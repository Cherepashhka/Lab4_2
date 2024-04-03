using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2.ElectricDevices
{
    public class Stove: BaseElectricDevice
    {
        public int MaximumTemperature { get; set; }

        public Stove() 
        {
            ElectricityUsedInWatts = 5000;
            YearsOfWarranty = 6;
            Color = "Black";
            Name = "Stove";
            IsConnected = false;
            MaximumTemperature = 460;
        }
        public Stove(int Electricity, int Warranty, string Color, string Name, int MaxTemperature) :
            base(Electricity, Warranty, Color, Name)
        {
            MaximumTemperature = MaxTemperature;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Stove stove)
                return ElectricityUsedInWatts == stove.ElectricityUsedInWatts && YearsOfWarranty == stove.YearsOfWarranty && Color == stove.Color && Name == stove.Name && MaximumTemperature == stove.MaximumTemperature;
            return false;
        }
        public override string? ToString()
        {
            return $"Name = {Name}, Electricity used (in watts) = {ElectricityUsedInWatts}, Years of warranty = {YearsOfWarranty}, Color = {Color}, Connected? {IsConnected}, Maximum temperature = {MaximumTemperature}";
        }
    }
}