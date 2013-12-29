using System;

class ConvertNumberToWord
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 0 && n < 999)
        {
            string[] Ones = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Ninteen" };
            string[] Tens = { "Ten", "Twenty", "Thirty", "Fourty", "Fifth", "Sixty", "Seventy", "Eighty", "Ninty" };
            string words = "";

            if (n == 0)
            {
                words = "Zero";
            }

            if (n > 99 & n < 1000)
            {
                int i = n / 100;

                if (n % 100 == 0)
                {
                    words = words + Ones[i - 1] + " Hundred";
                }
                else
                {
                    words = words + Ones[i - 1] + " Hundred and ";
                }
                
                n = n % 100;
            }

            if (n > 19 && n < 100)
            {
                int i = n / 10;
                words = words + Tens[i - 1] + " ";
                n = n % 10;
            }

            if (n > 0 && n < 20)
            {
                words = words + Ones[n - 1];
            }

            Console.WriteLine(words);
        }
    }
}