using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    public class BaseElectricDevice
    {
        public int ElectricityUsedInWatts { get; set; }
        public int YearsOfWarranty { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public bool IsConnected { get; set; }
        public BaseElectricDevice()
        {
            ElectricityUsedInWatts = 0;
            YearsOfWarranty = 0;
            Color = "None";
            Name = "None";
            IsConnected = false;
        }
        public BaseElectricDevice(int Electricity, int Warranty, string Color, string Name)
        {
            ElectricityUsedInWatts = Electricity;
            YearsOfWarranty = Warranty;
            this.Color = Color;
            this.Name = Name;
            IsConnected = false;
        }
        public void Connect()
        {
            IsConnected = true;
        }
        public void Disconnect()
        {
            IsConnected = false;
        }
        public override bool Equals(object? obj)
        {
            if (obj is BaseElectricDevice BED)
                return ElectricityUsedInWatts == BED.ElectricityUsedInWatts && YearsOfWarranty == BED.YearsOfWarranty && Color == BED.Color && Name == BED.Name;
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string? ToString()
        {
            return $"Name = {Name}, Electricity used (in watts) = {ElectricityUsedInWatts}, Years of warranty = {YearsOfWarranty}, Color = {Color}, Connected? {IsConnected}";
        }
    }
}