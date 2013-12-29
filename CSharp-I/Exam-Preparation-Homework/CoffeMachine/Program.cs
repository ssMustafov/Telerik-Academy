using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            decimal A = decimal.Parse(Console.ReadLine());
            decimal P = decimal.Parse(Console.ReadLine());

            decimal moneyInMachine = n1 * 0.05M + n2 * 0.10M + n3 * 0.20M + n4 * 0.50M + n5 * 1.00M;

            if (A > P && ((A - P) > moneyInMachine))
            {
                Console.WriteLine("No {0:0.00}", (A - P) - moneyInMachine);
            }
            else if (A >= P)
            {
                decimal money = A - P;
                decimal moneyLeft = moneyInMachine - money;
                Console.WriteLine("Yes {0:0.00}", moneyLeft);
            }
            else if (P > A)
            {
                decimal moneyNeeded = P - A;
                Console.WriteLine("More {0:0.00}", moneyNeeded); 
            }
        }
    }
}
