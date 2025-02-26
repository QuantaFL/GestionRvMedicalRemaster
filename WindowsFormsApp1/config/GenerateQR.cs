using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ZXing;
using System.Drawing;
using System.IO;


namespace WindowsFormsApp1.config
{
    public static class GenerateQR
    {
        public static byte[] GenerateQRCode(string data)
        {
            var barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Height = 200,
                    Width = 200
                }
            };

            using (Bitmap bitmap = barcodeWriter.Write(data))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
        }
    }
}
