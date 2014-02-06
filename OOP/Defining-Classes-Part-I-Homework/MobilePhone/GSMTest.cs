using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone
{
    class GSMTest
    {
        static void Main(string[] args)
        {
            // Test device
            Battery battery = new Battery("Samsung", 3.5, 1, BatteryType.LiIon);
            Display display = new Display(4.7, 16000000);
            GSM[] devices = new GSM[3];

            for (int i = 0; i < devices.Length; i++)
            {
                devices[i] = new GSM("Galaxy S" + (i + 1), "Samsung", 1499 - 200 * i, "Pesho", battery, display);
            }

            for (int i = 0; i < devices.Length; i++)
            {
                Console.WriteLine(devices[i]);
                Console.WriteLine();
            }
            
            Console.WriteLine(GSM.IPhone4S);

            // Test calls
            GSM testCall = new GSM("Lumia 625", "Nokia");
            testCall.AddNewCall("0899999999", 120);
            testCall.AddNewCall("0888888888", 453);
            testCall.AddNewCall("0877777777", 887);

            Console.WriteLine();
            Console.WriteLine("Call History:");
            for (int i = 0; i < testCall.CallHistory.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Call {0}", i);
                Console.WriteLine(testCall.CallHistory[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Total price of calls: {0}", testCall.CalculateTotalPrice(0.37m));

            // Remove longest call
            int index = 0;
            int duration = testCall.CallHistory[0].Duration;

            for (int i = 1; i < testCall.CallHistory.Count; i++)
            {
                if (testCall.CallHistory[i].Duration > duration)
                {
                    duration = testCall.CallHistory[i].Duration;
                    index = i;
                }
            }

            testCall.CallHistory.RemoveAt(index);

            Console.WriteLine("Total price of calls: {0}", testCall.CalculateTotalPrice(0.37m));

            // Clear the call history
            testCall.CallHistory.Clear();
            for (int i = 0; i < testCall.CallHistory.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Call {0}", i);
                Console.WriteLine(testCall.CallHistory[i]);
            }
        }
    }
}