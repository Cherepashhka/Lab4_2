using Lab4_2;
using Lab4_2.ElectricDevices;
using Lab4_2.ElectricDevices.FridgeDescendants;

Fridge fridge = new Fridge();
Freezer freezer = new Freezer();
Stove stove = new Stove();
MicrowaveOven microwaveoven =  new MicrowaveOven();
Kettle kettle = new Kettle();
List<BaseElectricDevice> listofdevices = new List<BaseElectricDevice>
{
    fridge,
    freezer,
    stove,
    microwaveoven,
    kettle
};
while (true)
{
    Console.Clear();
    Console.WriteLine("Pick a task:\n1. Turn on device.\n2. Turn off device.\n3. Sum of electricity usage.\n4. Sort by electricity.\n5. Find device.\n6. Exit.");
    int choice;
    choice = int.Parse(Console.ReadLine());
    if (choice == 1)
    {
        Console.WriteLine("Choose a device: ");
        foreach (var device in listofdevices)
        {
            Console.WriteLine($"{choice}. {device.Name}");
            choice++;
        }
        choice = int.Parse(Console.ReadLine());
        listofdevices[choice - 1].Connect();
    }
    else if (choice == 2)
    {
        choice = 1;
        Console.WriteLine("Choose a device: ");
        foreach (var device in listofdevices)
        {
            Console.WriteLine($"{choice}. {device.Name}");
            choice++;
        }
        choice = int.Parse(Console.ReadLine());
        listofdevices[choice - 1].Disconnect();
    }
    else if (choice == 3)
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
    else if (choice == 4)
    {
        Sort(listofdevices);
    }
    else if (choice == 5)
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
    else if (choice == 6)
    {
        Console.Clear();
        break;
    }
    else
    {
        Console.WriteLine("There is no such option!");
    }
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

void Sort(List<BaseElectricDevice> list)
{
    //for (int i = 0; i < list.Count; i++)
    //{
    //    for (int j = 0; j < list.Count - 1; j++)
    //    {
    //        if (list[j].ElectricityUsedInWatts > list[j + 1].ElectricityUsedInWatts)
    //        {

    //            BaseElectricDevice test = list[j + 1];
    //            list[j + 1] = list[j];
    //            list[j] = test;
    //        }
    //    }
    //}
    list = list.OrderBy(item => item.ElectricityUsedInWatts).ToList();
    foreach (var device in list)
    {
        Console.WriteLine(device.ToString());
    }
}