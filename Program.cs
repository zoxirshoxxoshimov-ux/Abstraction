using System;
using Homework;

MediaAsset audio = new AudioAsset("Podcast");
MediaAsset video = new VideoAsset("Videodars");
MediaAsset podcast = new PodcastAsset("C# yangiliklari");

MediaAsset[] mediaAssets = { audio, video, podcast };

foreach (MediaAsset media in mediaAssets)
{
    media.ShowTitle();
    Console.WriteLine(media.GetFormat());
    Console.WriteLine(media.Play());
    Console.WriteLine();
}

Console.WriteLine("=========================");

Appliance washingMachine = new WashingMachine();
Appliance airHeater = new AirHeater();
Appliance electricKettle = new ElectricKettle();

Appliance[] appliances = { washingMachine, airHeater, electricKettle };

foreach (Appliance appliance in appliances)
{
    appliance.ShowName();

    double powerForThreeHours =
        appliance.CalculatePowerConsumption(3);

    Console.WriteLine($"3 soat: {powerForThreeHours} kVt");

    double powerForThreeDays =
        appliance.CalculateWeeklyConsumption(3);

    Console.WriteLine($"3 kunlik hisob: {powerForThreeDays} kVt");
    Console.WriteLine();
}

Console.WriteLine("=========================");

IStorage cloud = new CloudStorage();
IStorage usb = new UsbStorage();
IStorage memoryCard = new MemoryCardStorage();

IStorage[] storageDevices = { cloud, usb, memoryCard };

foreach (IStorage storage in storageDevices)
{
    storage.Upload("course.zip");
    storage.Download("course.zip");

    long freeSpace = storage.GetAvailableSpace();
    Console.WriteLine($"Bo'sh joy: {freeSpace} MB");
    Console.WriteLine();
}

Console.WriteLine("=========================");

IPrinter laserPrinter = new LaserPrinter();
IPrinter inkjetPrinter = new InkjetPrinter();
IPrinter thermalPrinter = new ThermalPrinter();

IPrinter[] printers = { laserPrinter, inkjetPrinter, thermalPrinter };

foreach (IPrinter printer in printers)
{
    printer.PrintPreview("Dars-jadvali");
    printer.Clean();
    printer.Print("Dars-jadvali");
    Console.WriteLine();
}

ThermalPrinter receiptPrinter = new ThermalPrinter();
receiptPrinter.PrintReceipt("Chek");

Console.WriteLine("=========================");

Animal lion = new Lion("Sulton");
Animal parrot = new Parrot("Kesha");
Animal elephant = new Elephant("Barno");

Animal[] animals = { lion, parrot, elephant };

foreach (Animal animal in animals)
{
    animal.DisplayName();
    Console.WriteLine(animal.MakeSound());
    Console.WriteLine(animal.Move());
    Console.WriteLine();
}