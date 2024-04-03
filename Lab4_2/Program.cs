using Lab4_2;
using Lab4_2.ElectricDevices;
using Lab4_2.ElectricDevices.FridgeDescendants;

Fridge fridge = new Fridge();
Freezer freezer = new Freezer();
Stove stove = new Stove();
MicrowaveOven microwaveoven = new MicrowaveOven();
Kettle kettle = new Kettle(400, 4, "DarkGray", "Kettle", 5);
HomeElectronics homeelectronics = new HomeElectronics();
homeelectronics.AddDevice(fridge);
homeelectronics.AddDevice(freezer);
homeelectronics.AddDevice(stove);
homeelectronics.AddDevice(microwaveoven);
homeelectronics.AddDevice(kettle);
while (true)
{
    Console.Clear();
    Console.WriteLine("Pick a task:\n1. Turn on device.\n2. Turn off device.\n3. Sum of electricity usage.\n4. Sort by electricity.\n5. Find device.\n6. Exit.");
    int choice;
    choice = int.Parse(Console.ReadLine());
    if (choice == 1)
        homeelectronics.Connect();
    else if (choice == 2)
        homeelectronics.Disconnect();
    else if (choice == 3)
        homeelectronics.ElectricitySum();
    else if (choice == 4)
        homeelectronics.Sort();
    else if (choice == 5)
        homeelectronics.Search();
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
