using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2.ElectricDevices.FridgeDescendants
{
    public class Freezer: Fridge
    {
        public int NumberOfShelves { get; set; }

        public Freezer()
        {
            ElectricityUsedInWatts = 1800;
            YearsOfWarranty = 10;
            Color = "White";
            Name = "Freezer";
            IsConnected = false;
            MinimalTemperature = -30;
            NumberOfShelves = 4;
        }
        public Freezer(int Electricity, int Warranty, string Color, string Name, int MinTemperature, int ShelvesNumber) :
            base(Electricity, Warranty, Color, Name, MinTemperature)
        {
            NumberOfShelves = ShelvesNumber;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Freezer freezer)
                return ElectricityUsedInWatts == freezer.ElectricityUsedInWatts && YearsOfWarranty == freezer.YearsOfWarranty && Color == freezer.Color && Name == freezer.Name && MinimalTemperature == freezer.MinimalTemperature && NumberOfShelves == freezer.NumberOfShelves;
            return false;
        }
        public override string? ToString()
        {
            return $"Name = {Name}, Electricity used (in watts) = {ElectricityUsedInWatts}, Years of warranty = {YearsOfWarranty}, Color = {Color}, Connected? {IsConnected}, Minimal temperature = {MinimalTemperature}, Number of shelves = {NumberOfShelves}";
        }
    }
}