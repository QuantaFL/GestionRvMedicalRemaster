using System;
using System.Net.Http;
using System.Configuration;
using WindowsFormsApp1.ApiConsumer.Services;
using Serilog;

namespace WindowsFormsApp1.ApiConsumer
{
    public static class ApiClientContainer
    {
        private static readonly HttpClient httpClient;
        private static string apiBaseUrl;

         public static IAuthService AuthService { get; private set; }
        public static IUserService UserService { get; private set; }
        public static IRoleService RoleService { get; private set; }
        public static ISpecialiteService SpecialiteService { get; private set; }
        public static IMedecinService MedecinService { get; private set; }
        public static ISecretaireService SecretaireService { get; private set; }
        public static IPatientService PatientService { get; private set; }
        public static IAgendaService AgendaService { get; private set; }
        public static ISoinService SoinService { get; private set; }
        public static IRendezVousService RendezVousService { get; private set; }
        public static IGroupeSanguinService GroupeSanguinService { get; private set; }
        public static IMoyenDePaiementService MoyenDePaiementService { get; private set; }
        public static ILogErrorService LogErrorService { get; private set; }
        public static IApplicationDataService ApplicationDataService { get; private set; }

        public static Models.User CurrentUser { get; private set; }
        private static string currentAuthToken;

        static ApiClientContainer()
        {
            try
            {
                apiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
                if (string.IsNullOrEmpty(apiBaseUrl))
                {
                    apiBaseUrl = "http://localhost:8000/api/v1";
                    Log.Warning("ApiBaseUrl not found in App.config or is empty. Using default: {DefaultApiBaseUrl}", apiBaseUrl);
                }
                else
                {
                    Log.Information("API Base URL loaded from App.config: {ApiBaseUrl}", apiBaseUrl);
                }
            }
            catch (ConfigurationErrorsException configEx)
            {
                apiBaseUrl = "http://localhost:8000/api/v1";
                Log.Error(configEx, "Error reading ApiBaseUrl from App.config. Using default: {DefaultApiBaseUrl}", apiBaseUrl);
            }

            apiBaseUrl = apiBaseUrl.TrimEnd('/');
            httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(60);

            InitializeServices();
        }

        private static void InitializeServices()
        {
            SerializerType serializer = SerializerType.NewtonsoftJson;

            AuthService = new AuthService(httpClient, apiBaseUrl, serializer);
            UserService = new UserService(httpClient, apiBaseUrl, serializer);
            RoleService = new RoleService(httpClient, apiBaseUrl, serializer);
            SpecialiteService = new SpecialiteService(httpClient, apiBaseUrl, serializer);
            MedecinService = new MedecinService(httpClient, apiBaseUrl, serializer);
            SecretaireService = new SecretaireService(httpClient, apiBaseUrl, serializer);
            PatientService = new PatientService(httpClient, apiBaseUrl, serializer);
            AgendaService = new AgendaService(httpClient, apiBaseUrl, serializer);
            SoinService = new SoinService(httpClient, apiBaseUrl, serializer);
            RendezVousService = new RendezVousService(httpClient, apiBaseUrl, serializer);
            GroupeSanguinService = new GroupeSanguinService(httpClient, apiBaseUrl, serializer);
            MoyenDePaiementService = new MoyenDePaiementService(httpClient, apiBaseUrl, serializer);
            LogErrorService = new LogErrorService(httpClient, apiBaseUrl, serializer);
            ApplicationDataService = new ApplicationDataService(httpClient, apiBaseUrl, serializer);
        }

        public static void SetApiBaseUrl(string baseUrl)
        {
            apiBaseUrl = baseUrl.TrimEnd('/');
            InitializeServices();
            if (!string.IsNullOrEmpty(currentAuthToken))
            {
                SetUserAuthentication(CurrentUser);
            }
        }

        public static string GetApiBaseUrl()
        {
            return apiBaseUrl;
        }

        public static void SetUserAuthentication(Models.User user)
        {
            CurrentUser = user;
        }

        public static void ClearUserAuthentication()
        {
            CurrentUser = null;
            InitializeServices();
        }

        public static bool IsUserAuthenticated()
        {
            return !string.IsNullOrEmpty(currentAuthToken) && CurrentUser != null;
        }
    }
}
