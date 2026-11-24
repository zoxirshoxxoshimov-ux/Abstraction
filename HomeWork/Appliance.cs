using System;

namespace Homework
{
    public abstract class Appliance
    {
        public abstract string Name { get; }

        public abstract double CalculatePowerConsumption(int hours);

        public void ShowName()
        {
            Console.WriteLine($"Qurilma: {Name}");
        }

        public double CalculateWeeklyConsumption(int hoursPerDay)
        {
            double powerForOneDay =
                CalculatePowerConsumption(hoursPerDay);

            double powerForThreeDays = powerForOneDay * 3;

            return powerForThreeDays;
        }
    }

    public class WashingMachine : Appliance
    {
        public override string Name
        {
            get
            {
                return "Kir yuvish mashinasi";
            }
        }

        public override double CalculatePowerConsumption(int hours)
        {
            double powerUsed = hours * 1.0;
            return powerUsed;
        }
    }

    public class AirHeater : Appliance
    {
        public override string Name
        {
            get
            {
                return "Isitgich";
            }
        }

        public override double CalculatePowerConsumption(int hours)
        {
            double powerUsed = hours * 2.0;
            return powerUsed;
        }
    }

    public class ElectricKettle : Appliance
    {
        public override string Name
        {
            get
            {
                return "Choynak";
            }
        }

        public override double CalculatePowerConsumption(int hours)
        {
            double powerUsed = hours * 1.5;
            return powerUsed;
        }
    }
}