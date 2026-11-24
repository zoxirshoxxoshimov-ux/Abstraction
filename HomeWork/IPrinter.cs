using System;

namespace Homework
{
    public interface IPrinter
    {
        void Print(string documentName);
        void PrintPreview(string documentName);
        void Clean();
    }

    public class LaserPrinter : IPrinter
    {
        public void Print(string documentName)
        {
            Console.WriteLine($"Laser printer tez chop etdi: {documentName}");
        }

        public void PrintPreview(string documentName)
        {
            Console.WriteLine($"Laser printer ko'rib chiqdi: {documentName}");
        }

        public void Clean()
        {
            Console.WriteLine("Laser printer tozalandi");
        }
    }

    public class InkjetPrinter : IPrinter
    {
        public void Print(string documentName)
        {
            Console.WriteLine($"Inkjet printer sifatli chop etdi: {documentName}");
        }

        public void PrintPreview(string documentName)
        {
            Console.WriteLine($"Inkjet printer ko'rib chiqdi: {documentName}");
        }

        public void Clean()
        {
            Console.WriteLine("Inkjet printer tozalandi");
        }
    }

    public class ThermalPrinter : IPrinter
    {
        public void Print(string documentName)
        {
            Console.WriteLine($"Termoprinter chek chop etdi: {documentName}");
        }

        public void PrintPreview(string documentName)
        {
            Console.WriteLine($"Termoprinter oldindan ko'rdi: {documentName}");
        }

        public void Clean()
        {
            Console.WriteLine("Termoprinter tozalandi");
        }

        public void PrintReceipt(string receiptName)
        {
            Console.WriteLine($"Termoprinter chek chop etdi: {receiptName}");
        }
    }
}