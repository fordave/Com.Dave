using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ConsoleMain
{
    class Program
    {

        private static void AppendOneEmptyPageToDocument(string sourcePdfPath, string outputPdfPath)
        {
            var sourceDocumentStream = new FileStream(sourcePdfPath, FileMode.Open);
            var destinationDocumentStream = new FileStream(outputPdfPath, FileMode.Create);

            var pdfReader = new PdfReader(sourceDocumentStream);
            var pdfConcat = new PdfConcatenate(destinationDocumentStream);

            var pages = Enumerable.Range(1, pdfReader.NumberOfPages + 2).ToList();

            pdfReader.SelectPages(pages);
            pdfConcat.AddPages(pdfReader);

            pdfReader.Close();
            pdfConcat.Close();
        }
        private static void AppendToDocument(string sourcePdfPath1, string sourcePdfPath2, string outputPdfPath)
        {
            using (var sourceDocumentStream1 = new FileStream(sourcePdfPath1, FileMode.Open))
            {
                using (var sourceDocumentStream2 = new FileStream(sourcePdfPath2, FileMode.Open))
                {
                    using (var destinationDocumentStream = new FileStream(outputPdfPath, FileMode.Create))
                    {
                        var pdfConcat = new PdfConcatenate(destinationDocumentStream);
                        var pdfReader = new PdfReader(sourceDocumentStream1);

                        var pages = new List<int>();
                        for (int i = 0; i < pdfReader.NumberOfPages; i++)
                        {
                            pages.Add(i);
                        }

                        pdfReader.SelectPages(pages);
                        pdfConcat.AddPages(pdfReader);

                        pdfReader = new PdfReader(sourceDocumentStream2);

                        pages = new List<int>();
                        for (int i = 0; i < pdfReader.NumberOfPages; i++)
                        {
                            pages.Add(i);
                        }

                        pdfReader.SelectPages(pages);
                        pdfConcat.AddPages(pdfReader);

                        pdfReader.Close();
                        pdfConcat.Close();
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            synth.Speak("This example demonstrates a basic use of Speech Synthesizer");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            //SoundPlayer soundPlayer = new SoundPlayer();
            //var tt = Encoding.UTF8.GetBytes("hhhhhhhh");
            //MemoryStream memoryStream = new MemoryStream();
            //memoryStream.Write(tt, 0, tt.Length);
            //soundPlayer.Stream = memoryStream;
            //soundPlayer.Load();
            //soundPlayer.Play();
            var srcPath1 = "MyFirstPDF.pdf";
            var srcPath2 = "result.pdf";
            //File.Delete(srcPath2);
            //AppendOneEmptyPageToDocument(srcPath1, srcPath2);

           // AddImageToPdf(srcPath1, srcPath2);
            //using (Document document = new Document(PageSize.A4))
            //using (Stream outputPdfStream = new FileStream(srcPath2, FileMode.Create, FileAccess.Write, FileShare.None))
            //{
            //    PdfWriter pdfWriter = PdfWriter.GetInstance(document, outputPdfStream);

            //}


            //string originalFile = srcPath1;
            //string copyOfOriginal = srcPath2;
            //using (FileStream fs = new FileStream(originalFile, FileMode.Create, FileAccess.Write, FileShare.None))
            //using (Document doc = new Document(PageSize.A4))
            //using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
            //{
            //    doc.Open();
            //    doc.Add(new Paragraph("Hi! I'm Original"));
            //    doc.Close();
            //}
            //var reader = new PdfReader(originalFile);
            //using (FileStream fs = new FileStream(copyOfOriginal, FileMode.Create, FileAccess.Write, FileShare.None))
            //// Creating iTextSharp.text.pdf.PdfStamper object to write
            //// Data from iTextSharp.text.pdf.PdfReader object to FileStream object
            //using (PdfStamper stamper = new PdfStamper(reader, fs)) { }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pdfPath"></param>
        /// <param name="imagePath"></param>
        /// <param name="info"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private static void AddImageToPdf(string pdfPath, string imagePath,float x,float y)
        {
            if (string.IsNullOrWhiteSpace(pdfPath) || string.IsNullOrWhiteSpace(imagePath))
            {
                throw new ArgumentException();
            }
            if (!File.Exists(pdfPath) || !File.Exists(imagePath))
            {
                throw new FileNotFoundException();
            }
            var srcPath2 = "result.pdf";
            using (Stream inputPdfStream = new FileStream(pdfPath, FileMode.Open, FileAccess.ReadWrite))
            using (Stream inputImageStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            using (Stream outputPdfStream = new FileStream(srcPath2, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                var reader = new PdfReader(inputPdfStream);
                var stamper = new PdfStamper(reader, outputPdfStream);
                stamper.InsertPage(reader.NumberOfPages, PageSize.A4);
                var pdfConcat = new PdfConcatenate(outputPdfStream);
                var pdfContentByte = stamper.GetOverContent(reader.NumberOfPages);

                Image image = Image.GetInstance(inputImageStream);
                image.SetAbsolutePosition(x, y);
                image.ScaleToFit(new Rectangle(100, 100));
                pdfContentByte.AddImage(image);
               
                Paragraph elements = new Paragraph();
                //pdfContentByte.AddOutline()
                stamper.Close();
            }
            //允许抛出异常
            File.Copy(srcPath2, pdfPath, true);          
        }
    }
}
