using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2.ElectricDevices
{
    public class MicrowaveOven: BaseElectricDevice
    {
        public int MicrowaveMhzFrequency { get; set; }

        public MicrowaveOven()
        {
            ElectricityUsedInWatts = 1200;
            YearsOfWarranty = 12;
            Color = "Gray";
            Name = "Microwave Oven";
            IsConnected = false;
            MicrowaveMhzFrequency = 2450;
        }
        public MicrowaveOven(int Electricity, int Warranty, string Color, string Name, int Frequency) :
            base(Electricity, Warranty, Color, Name)
        {
            MicrowaveMhzFrequency = Frequency;
        }
        public override bool Equals(object? obj)
        {
            if (obj is MicrowaveOven microwaveoven)
                return ElectricityUsedInWatts == microwaveoven.ElectricityUsedInWatts && YearsOfWarranty == microwaveoven.YearsOfWarranty && Color == microwaveoven.Color && Name == microwaveoven.Name && MicrowaveMhzFrequency == microwaveoven.MicrowaveMhzFrequency;
            return false;
        }
        public override string? ToString()
        {
            return $"Name = {Name}, Electricity used (in watts) = {ElectricityUsedInWatts}, Years of warranty = {YearsOfWarranty}, Color = {Color}, Connected? {IsConnected}, Microwave frequency (in Mhz) = {MicrowaveMhzFrequency}";
        }
    }
}
