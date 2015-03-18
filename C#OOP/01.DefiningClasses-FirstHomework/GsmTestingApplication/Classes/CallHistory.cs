namespace MobileDevice
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class CallHistory
    {
        public static void PrintGsmInfo(Gsm inputGsm)
        {
            if (inputGsm != null)
            {
                Console.WriteLine(inputGsm);
            }
            else
            {
                Console.WriteLine("No Gsm defined ...");
            }
        }
        public static void AddCalls(Gsm inputGsm, List<Call> inputCallList)
        {
            for (int i = 0; i < inputCallList.Count; i++)
            {
                inputGsm.AddCall(inputCallList[i].TimeOfCall, inputCallList[i].DialedPhone, inputCallList[i].CallDuration, false);
            }

        }
        public static void PrintCallHistory(Gsm inputGsm)
        {
            Console.WriteLine("     Printing Call History: ");
            inputGsm.PrintCallHistory();
        }

        public static void CalculateAndPrintCallAmount(Gsm inputGsm, decimal pricePerMinute)
        {
            Console.WriteLine("Total amount is: {0:f2}", inputGsm.CalculateTotalPrice(pricePerMinute));
        }

        public static void RemoveLongestCall(Gsm inputGsm)
        {
            if (inputGsm.HistoryList.Count > 0)
            {
                uint callDuration = 0;
                for (int i = 0; i < inputGsm.HistoryList.Count; i++)
                {
                    if (inputGsm.HistoryList[i].CallDuration > callDuration)
                    {
                        callDuration = inputGsm.HistoryList[i].CallDuration;
                    }
                }
                inputGsm.ClearHistory(callDuration, true);
            }
        }

        public static void ClearCallHistory(Gsm inputGsm)
        {
            inputGsm.HistoryList.Clear();
        }
    }
}
