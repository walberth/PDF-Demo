using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args)
        {
            var renderer = new IronPdf.HtmlToPdf();
            renderer.RenderHtmlAsPdf("<h1>Html with CSS and Images</h1>").SaveAs("example.pdf");

            var pdf = renderer.RenderHtmlAsPdf("<img src='test.jpg'>", @"C:\Users\walbe\Desktop\ConsoleApp1\");
            pdf.SaveAs("html-with-assets.pdf");
            Console.WriteLine("Hello World!");
        }
    }
}
