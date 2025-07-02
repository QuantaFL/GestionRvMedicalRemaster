using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models; // For ApiResponse<T>
using Newtonsoft.Json; // For Newtonsoft
using System.Text.Json; // For System.Text.Json
using System.IO;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public abstract class BaseApiService
    {
        protected readonly HttpClient HttpClient;
        protected readonly string BaseUrl;
        protected string AuthToken { get; private set; }
        protected readonly SerializerType DefaultSerializer;

        protected BaseApiService(HttpClient httpClient, string baseUrl, SerializerType defaultSerializer = SerializerType.NewtonsoftJson)
        {
            HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            BaseUrl = baseUrl?.TrimEnd('/') ?? throw new ArgumentNullException(nameof(baseUrl));
            DefaultSerializer = defaultSerializer;
        }

        protected async Task<T> GetAsync<T>(string endpoint, Dictionary<string, string> queryParams = null, SerializerType? serializerType = null)
        {
            var finalSerializer = serializerType ?? DefaultSerializer;
            var requestUri = BuildRequestUri(endpoint, queryParams);

            var response = await HttpClient.GetAsync(requestUri);
            return await HandleResponse<T>(response, finalSerializer);
        }

        protected async Task<TResponse> PostAsync<TRequest, TResponse>(string endpoint, TRequest data, SerializerType? serializerType = null)
        {
            var finalSerializer = serializerType ?? DefaultSerializer;
            var requestUri = BuildRequestUri(endpoint);
            HttpContent content = SerializeRequest(data, finalSerializer);

            var response = await HttpClient.PostAsync(requestUri, content);
            return await HandleResponse<TResponse>(response, finalSerializer);
        }

        protected async Task PostAsync<TRequest>(string endpoint, TRequest data, SerializerType? serializerType = null)
        {
            var finalSerializer = serializerType ?? DefaultSerializer;
            var requestUri = BuildRequestUri(endpoint);
            HttpContent content = SerializeRequest(data, finalSerializer);

            var response = await HttpClient.PostAsync(requestUri, content);
            await HandleResponse(response); // No TResponse expected, just check for success
        }


        protected async Task<TResponse> PutAsync<TRequest, TResponse>(string endpoint, TRequest data, SerializerType? serializerType = null)
        {
            var finalSerializer = serializerType ?? DefaultSerializer;
            var requestUri = BuildRequestUri(endpoint);
            HttpContent content = SerializeRequest(data, finalSerializer);

            var response = await HttpClient.PutAsync(requestUri, content);
            return await HandleResponse<TResponse>(response, finalSerializer);
        }

        protected async Task PutAsync<TRequest>(string endpoint, TRequest data, SerializerType? serializerType = null)
        {
            var finalSerializer = serializerType ?? DefaultSerializer;
            var requestUri = BuildRequestUri(endpoint);
            HttpContent content = SerializeRequest(data, finalSerializer);

            var response = await HttpClient.PutAsync(requestUri, content);
            await HandleResponse(response);
        }


        protected async Task DeleteAsync(string endpoint, SerializerType? serializerType = null)
        {
            // Note: DeleteAsync might return TResponse in some APIs, adjust if needed
            var finalSerializer = serializerType ?? DefaultSerializer;
            var requestUri = BuildRequestUri(endpoint);

            var response = await HttpClient.DeleteAsync(requestUri);
            // Typically, DELETE returns 204 No Content or an ApiResponse for success/failure message
            // We'll use HandleResponse which can parse ApiResponse<object> or just check status
            await HandleResponse<object>(response, finalSerializer, true);
        }

        protected async Task<TResponse> DeleteAsync<TResponse>(string endpoint, SerializerType? serializerType = null)
        {
            var finalSerializer = serializerType ?? DefaultSerializer;
            var requestUri = BuildRequestUri(endpoint);

            var response = await HttpClient.DeleteAsync(requestUri);
            return await HandleResponse<TResponse>(response, finalSerializer);
        }


        private HttpContent SerializeRequest<TRequest>(TRequest data, SerializerType serializerType)
        {
            if (data == null) return new StringContent("", Encoding.UTF8, "application/json");

            string jsonPayload;
            if (serializerType == SerializerType.SystemTextJson)
            {
                jsonPayload = System.Text.Json.JsonSerializer.Serialize(data, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            else // Default to Newtonsoft
            {
                jsonPayload = JsonConvert.SerializeObject(data, new JsonSerializerSettings { ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver() });
            }
            return new StringContent(jsonPayload, Encoding.UTF8, "application/json");
        }

        private async Task<T> DeserializeResponse<T>(HttpContent content, SerializerType serializerType)
        {
            using (var stream = await content.ReadAsStreamAsync())
            {
                if (stream == null || stream.Length == 0)
                {
                    if (typeof(T) == typeof(string) || typeof(T) == typeof(object)) // Allow empty for string/object
                        return default(T);
                    throw new ApiException("Empty response content received where data was expected.", (int)System.Net.HttpStatusCode.NoContent, null);
                }

                if (serializerType == SerializerType.SystemTextJson)
                {
                    return await System.Text.Json.JsonSerializer.DeserializeAsync<T>(stream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }
                else // Default to Newtonsoft
                {
                    using (var streamReader = new StreamReader(stream))
                    using (var jsonTextReader = new JsonTextReader(streamReader))
                    {
                        var serializer = new Newtonsoft.Json.JsonSerializer();
                        // Configure Newtonsoft.Json settings if needed, e.g., for date parsing, missing members handling
                        // serializer.DateFormatHandling = DateFormatHandling.IsoDateFormat;
                        // serializer.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
                        return serializer.Deserialize<T>(jsonTextReader);
                    }
                }
            }
        }

        private async Task<T> HandleResponse<T>(HttpResponseMessage response, SerializerType serializerType, bool allowEmptyContentForObjectType = false)
        {
            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    if (typeof(T) == typeof(object) || typeof(T) == typeof(string) || allowEmptyContentForObjectType)
                        return default(T); // Or throw if T is not expected to be empty

                    // If T is ApiResponse<SomeData>, NoContent is an issue unless specifically handled
                    // For now, if T is not object/string and status is 204, it's potentially an issue.
                    throw new ApiException($"Received HTTP 204 No Content, but expected a response body of type {typeof(T).Name}.", (int)response.StatusCode, null);
                }

                var apiResponse = await DeserializeResponse<ApiResponse<T>>(response.Content, serializerType);
                if (apiResponse != null)
                {
                    if ("success".Equals(apiResponse.Status, StringComparison.OrdinalIgnoreCase))
                    {
                        return apiResponse.Data;
                    }
                    // If status is not "success" but HTTP code was 2xx, it might be a custom success response without 'data'
                    // E.g. a simple { "status": "success", "message": "Operation done" }
                    // If T is a simple type like string for a message, this needs adjustment.
                    // For now, we assume if HTTP is success, and we expect T, apiResponse.Data is our T.
                    // If apiResponse.Data is null but T is not nullable, this will be an issue.
                    // The general structure of this API per api.md seems to always have a 'data' field on success.
                    if (apiResponse.Data != null || typeof(T).IsClass || Nullable.GetUnderlyingType(typeof(T)) != null)
                    {
                         // If apiResponse.Data is null but T is a reference type or nullable, return it (it's null)
                        return apiResponse.Data;
                    }
                    // If status is not "success" and Data is null for a non-nullable value type T
                    throw new ApiException(apiResponse.Message ?? "API call succeeded but response format was unexpected (missing data or success status).", (int)response.StatusCode, apiResponse.Errors);
                }
                // This case should ideally not be hit if the API always returns the ApiResponse wrapper.
                // If it can return raw T data on success:
                // return await DeserializeResponse<T>(response.Content, serializerType);
                throw new ApiException("API call succeeded but response format was unexpected (null ApiResponse).", (int)response.StatusCode, null);
            }
            else
            {
                string errorContent = await response.Content.ReadAsStringAsync();
                ApiResponse<object> errorResponse = null;
                try
                {
                    errorResponse = await DeserializeResponse<ApiResponse<object>>(response.Content, serializerType);
                }
                catch { /* Ignore if error content is not in ApiResponse format */ }

                var errorMessage = errorResponse?.Message ?? $"API call failed with status code {response.StatusCode}";
                var errors = errorResponse?.Errors;
                throw new ApiException(errorMessage, (int)response.StatusCode, errorContent, errors);
            }
        }

        // Overload for responses where no specific T is expected from ApiResponse.Data (e.g. simple success/failure messages)
        private async Task HandleResponse(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return; // Successfully processed, no content to parse
                }

                // Attempt to parse as ApiResponse<object> to get status and message
                var apiResponse = await DeserializeResponse<ApiResponse<object>>(response.Content, DefaultSerializer); // Use default for this
                if (apiResponse != null && "success".Equals(apiResponse.Status, StringComparison.OrdinalIgnoreCase))
                {
                    return; // Success
                }
                // If not "success" or parsing failed but HTTP was 2xx
                throw new ApiException(apiResponse?.Message ?? "API call succeeded but response status was not 'success'.", (int)response.StatusCode, apiResponse?.Errors);
            }
            else
            {
                string errorContent = await response.Content.ReadAsStringAsync();
                ApiResponse<object> errorResponse = null;
                try
                {
                     // Try to deserialize with default serializer as error structure should be consistent
                    errorResponse = await DeserializeResponse<ApiResponse<object>>(response.Content, DefaultSerializer);
                }
                catch { /* Ignore */ }

                var errorMessage = errorResponse?.Message ?? $"API call failed with status code {response.StatusCode}";
                var errors = errorResponse?.Errors;
                throw new ApiException(errorMessage, (int)response.StatusCode, errorContent, errors);
            }
        }


        private string BuildRequestUri(string endpoint, Dictionary<string, string> queryParams = null)
        {
            var uriBuilder = new UriBuilder(BaseUrl.TrimEnd('/') + "/" + endpoint.TrimStart('/'));
            if (queryParams != null)
            {
                var query = System.Web.HttpUtility.ParseQueryString(uriBuilder.Query);
                foreach (var param in queryParams)
                {
                    if (!string.IsNullOrEmpty(param.Value))
                    {
                        query[param.Key] = param.Value;
                    }
                }
                uriBuilder.Query = query.ToString();
            }
            return uriBuilder.ToString();
        }
    }

    public class ApiException : Exception
    {
        public int StatusCode { get; }
        public string Content { get; }
        public object Errors { get; }
        public ApiException(string message, int statusCode, string content, object errors = null) : base(message)
        {
            StatusCode = statusCode;
            Content = content;
            Errors = errors;
        }
         public ApiException(string message, int statusCode, object errors = null) : base(message)
        {
            StatusCode = statusCode;
            Errors = errors;
            Content = null; // Or serialize errors if it's the primary content
        }
    }
}
