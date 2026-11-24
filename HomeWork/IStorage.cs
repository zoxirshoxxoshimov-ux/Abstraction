using System;

namespace Homework
{
    public interface IStorage
    {
        void Upload(string fileName);
        void Download(string fileName);
        long GetAvailableSpace();
    }

    public class CloudStorage : IStorage
    {
        public void Upload(string fileName)
        {
            Console.WriteLine($"Cloudga {fileName} yuklandi");
        }

        public void Download(string fileName)
        {
            Console.WriteLine($"Clouddan {fileName} olindi");
        }

        public long GetAvailableSpace()
        {
            return 100000;
        }
    }

    public class UsbStorage : IStorage
    {
        public void Upload(string fileName)
        {
            Console.WriteLine($"USBga {fileName} yuklandi");
        }

        public void Download(string fileName)
        {
            Console.WriteLine($"USBdan {fileName} olindi");
        }

        public long GetAvailableSpace()
        {
            return 32000;
        }
    }

    public class MemoryCardStorage : IStorage
    {
        public void Upload(string fileName)
        {
            Console.WriteLine($"Xotira kartasiga {fileName} yuklandi");
        }

        public void Download(string fileName)
        {
            Console.WriteLine($"Xotira kartasidan {fileName} olindi");
        }

        public long GetAvailableSpace()
        {
            return 16000;
        }
    }
}