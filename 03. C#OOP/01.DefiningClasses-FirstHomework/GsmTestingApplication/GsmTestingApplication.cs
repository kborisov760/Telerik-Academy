namespace MobileDevice
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class GsmTestingApplication
    {
        static void Main()
        {
            //Creating an instance of IPhone Class

            IphoneClass iPhone4s = new IphoneClass();
            Console.WriteLine(iPhone4s.ToString());

            //Creating list of cell phones

            List<Gsm> cellPhones = new List<Gsm>();
            cellPhones.Add(new Gsm("One", "HTC", BatteryType.LiIon, 4.7f, "16m"));
            cellPhones.Add(new Gsm("Desire", "HTC", BatteryType.NiCd, 4.0f, "16m"));
            cellPhones.Add(new Gsm("Galaxy S4", "Samsung", BatteryType.NiMH, 5.0f, "16m"));
            cellPhones.Add(new Gsm("Galaxy S5", "Samsung", BatteryType.LiIon, 5.7f, "16m"));
            cellPhones.Add(new Gsm("iPhone5S", "Apple", BatteryType.LiIon, 4.0f, "16m"));

            //Adding phone calls for first phone
            
            cellPhones[0].AddCall(DateTime.Parse("15:30"), "+359888454558", 120, true);
            cellPhones[0].AddCall(DateTime.Parse("18:10"), "+359888984558", 35, true);
            cellPhones[0].AddCall(DateTime.Parse("10:30"), "+359888454318", 185, true);
            cellPhones[0].AddCall(DateTime.Parse("12:20"), "+359888454008", 67, true);

            //Using methods for adding, removing, and printing calls

            CallHistory.PrintCallHistory(cellPhones[0]);
            CallHistory.CalculateAndPrintCallAmount(cellPhones[0], 0.37m);
            CallHistory.RemoveLongestCall(cellPhones[0]);
            CallHistory.PrintCallHistory(cellPhones[0]);
            CallHistory.ClearCallHistory(cellPhones[0]);
            CallHistory.PrintCallHistory(cellPhones[0]);
        }
    }
}
