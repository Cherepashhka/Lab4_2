using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab4_2.ElectricDevices
{
    public class Kettle: BaseElectricDevice
    {
        public int MinutesToBoil { get; set; }

        public Kettle()
        {
            ElectricityUsedInWatts = 300;
            YearsOfWarranty = 4;
            Color = "DarkGray";
            Name = "Kettle";
            IsConnected = false;
            MinutesToBoil = 6;
        }
        public Kettle(int Electricity, int Warranty, string Color, string Name, int BoilMinutes) :
            base(Electricity, Warranty, Color, Name)
        {
            MinutesToBoil = BoilMinutes;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Kettle kettle)
                return ElectricityUsedInWatts == kettle.ElectricityUsedInWatts && YearsOfWarranty == kettle.YearsOfWarranty && Color == kettle.Color && Name == kettle.Name && MinutesToBoil == kettle.MinutesToBoil;
            return false;
        }
        public override string? ToString()
        {
            return $"Name = {Name}, Electricity used (in watts) = {ElectricityUsedInWatts}, Years of warranty = {YearsOfWarranty}, Color = {Color}, Connected? {IsConnected}, Minutes to boil water = {MinutesToBoil}";
        }
    }
}
