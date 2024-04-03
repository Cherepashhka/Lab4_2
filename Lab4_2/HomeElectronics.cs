using Lab4_2.ElectricDevices.FridgeDescendants;
using Lab4_2.ElectricDevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Linq;
using System.Reflection.Metadata;

namespace Lab4_2
{
    public class HomeElectronics
    {
        private List<BaseElectricDevice> listofdevices = new List<BaseElectricDevice>();
        
        public void AddDevice(BaseElectricDevice device)
        {
            listofdevices.Add(device);  
        }

        public void Connect()
        {
                int index = 1;
                Console.WriteLine("Choose a device: ");
                foreach (var device in listofdevices)
                {
                    Console.WriteLine($"{index}. {device.Name}");
                    index++;
                }
                index = int.Parse(Console.ReadLine());
                listofdevices[index - 1].Connect();
        }
        public void Disconnect()
        {
                int index = 1;
                Console.WriteLine("Choose a device: ");
                foreach (var device in listofdevices)
                {
                    Console.WriteLine($"{index}. {device.Name}");
                    index++;
                }
                index = int.Parse(Console.ReadLine());
                listofdevices[index - 1].Disconnect();
        }
        public void ElectricitySum()
        {
            int sum = 0;
            foreach (var device in listofdevices)
            {
                if (device.IsConnected)
                {
                    sum += device.ElectricityUsedInWatts;
                }
            }
            Console.WriteLine("Electricity usage: " + sum);
        }
        public void Sort()
        {
            //for (int i = 0; i < listofdevices.Count; i++)
            //{
            //    for (int j = 0; j < listofdevices.Count - 1; j++)
            //    {
            //        if (listofdevices[j].ElectricityUsedInWatts > listofdevices[j + 1].ElectricityUsedInWatts)
            //        {

            //            BaseElectricDevice test = listofdevices[j + 1];
            //            listofdevices[j + 1] = listofdevices[j];
            //            listofdevices[j] = test;
            //        }
            //    }
            //}
            listofdevices = listofdevices.OrderBy(item => item.ElectricityUsedInWatts).ToList();
            foreach (var device in listofdevices)
            {
                Console.WriteLine(device.ToString());
            }
        }
        public void Search()
        {
            Console.WriteLine("Which parameter to set?\n1. Electricity usage.\n2. Years of warranty.\n3. Color\n4. Name");
            int search;
            search = int.Parse(Console.ReadLine());
            if (search == 1)
            {
                search = 0;
                int start, end;
                do
                {
                    Console.WriteLine("Start: ");
                    start = int.Parse(Console.ReadLine());
                    Console.WriteLine("End: ");
                    end = int.Parse(Console.ReadLine());
                }
                while (start < 0 || end <= start);
                foreach (var device in listofdevices)
                {
                    if (device.ElectricityUsedInWatts > start && device.ElectricityUsedInWatts < end)
                    {
                        search++;
                        Console.WriteLine(device.ToString());
                    }
                }
            }
            else if (search == 2)
            {
                search = 0;
                int start, end;
                do
                {
                    Console.WriteLine("Start: ");
                    start = int.Parse(Console.ReadLine());
                    Console.WriteLine("End: ");
                    end = int.Parse(Console.ReadLine());
                }
                while (start < 0 || end <= start);
                foreach (var device in listofdevices)
                {
                    if (device.YearsOfWarranty > start && device.YearsOfWarranty < end)
                    {
                        search++;
                        Console.WriteLine(device.ToString());
                    }
                }
            }
            else if (search == 3)
            {
                search = 0;
                string parameter;
                Console.WriteLine("Enter color of device: ");
                parameter = Console.ReadLine();
                foreach (var device in listofdevices)
                {
                    if (device.Color == parameter)
                    {
                        search++;
                        Console.WriteLine(device.ToString());
                    }
                }
            }
            else if (search == 4)
            {
                search = 0;
                string parameter;
                Console.WriteLine("Enter name of device: ");
                parameter = Console.ReadLine();
                foreach (var device in listofdevices)
                {
                    if (device.Name == parameter)
                    {
                        search++;
                        Console.WriteLine(device.ToString());
                    }
                }
            }
            if (search == 0)
                Console.WriteLine("Nothing has been found by these parameters!");
        }
        public override bool Equals(object? obj)
        {
            if (obj is HomeElectronics homeelectronics)
                return listofdevices == homeelectronics.listofdevices;
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string? ToString()
        {
            string result = "";
            foreach (var device in listofdevices)
            {
                result += device.ToString() + "\n";
            }
            return result;
        }
    }
}
