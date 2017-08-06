using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Bogoraz.Utils;
using Bogoraz.Models;

namespace Bogoraz.Tests.Utils
{
    [TestClass]
    public class PdfprocessorTest
    {
        [TestMethod]
        public void TestUpdatePDF()
        {
            Application application = new Application();
            application.FirstName = "John";
            application.LastName = "Johnson";

            String inputPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Docs\\BLGLegal Intake Form AcroForm.pdf";
            String outputPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Docs\\BLGLegal Intake Form_new.pdf";

            PdfProcessor pdfproc = new PdfProcessor();
            pdfproc.UpdatePDF(outputPath, inputPath, application);

        }
    }
}
