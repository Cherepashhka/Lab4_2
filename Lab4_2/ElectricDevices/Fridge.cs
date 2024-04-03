using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2.ElectricDevices
{
    public class Fridge: BaseElectricDevice
    {
        public int MinimalTemperature { get; set; }

        public Fridge() 
        {
            ElectricityUsedInWatts = 2000;
            YearsOfWarranty = 10;
            Color = "White";
            Name = "Fridge";
            IsConnected = false;
            MinimalTemperature = -5;
        }
        public Fridge(int Electricity, int Warranty, string Color, string Name, int MinTemperature) :
            base (Electricity, Warranty, Color, Name)
        {
            MinimalTemperature = MinTemperature;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Fridge fridge)
                return ElectricityUsedInWatts == fridge.ElectricityUsedInWatts && YearsOfWarranty == fridge.YearsOfWarranty && Color == fridge.Color && Name == fridge.Name && MinimalTemperature == fridge.MinimalTemperature;
            return false;
        }
        public override string? ToString()
        {
            return $"Name = {Name}, Electricity used (in watts) = {ElectricityUsedInWatts}, Years of warranty = {YearsOfWarranty}, Color = {Color}, Connected? {IsConnected}, Minimal temperature = {MinimalTemperature}";
        }
    }
}