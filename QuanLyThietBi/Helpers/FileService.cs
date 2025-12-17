using DinkToPdf;
using DinkToPdf.Contracts;
using System.IO;

namespace QuanLyThietBi.Helpers
{
    public static class PdfService
    {
        private static readonly IConverter _converter =
            new SynchronizedConverter(new PdfTools());

        public static void Export(string html, string filePath)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);

            var doc = new HtmlToPdfDocument
            {
                GlobalSettings =
                {
                    PaperSize = PaperKind.A4,
                    Orientation = DinkToPdf.Orientation.Portrait
                },
                Objects =
                {
                    new ObjectSettings
                    {
                        HtmlContent = html,
                        WebSettings = { DefaultEncoding = "utf-8" }
                    }
                }
            };

            var pdf = _converter.Convert(doc);
            File.WriteAllBytes(filePath, pdf);
        }
    }
}
