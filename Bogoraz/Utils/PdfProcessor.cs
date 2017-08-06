using Bogoraz.Models;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Bogoraz.Utils
{
    public class PdfProcessor
    {
        public void UpdatePDF(string outputPath, string inputPath, Application application)
        {
            using (FileStream outFile = new FileStream(outputPath, FileMode.Create))
            {
                PdfReader pdfReader = new PdfReader(inputPath);
                PdfStamper pdfStamper = new PdfStamper(pdfReader, outFile);
                AcroFields fields = pdfStamper.AcroFields;
                fields.SetField("Client Name", application.FirstName + " " + application.LastName);
                pdfStamper.Close();
                pdfReader.Close();
            }
        }
        
    }
}