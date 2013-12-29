using System;

class Program
{
    static void Main()
    {
        int tomatoSeeds = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        int cucumberSeeds = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
        int potatoSeeds = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
        int carrotSeeds = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        int cabbageSeeds = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());
        int beanSeeds = int.Parse(Console.ReadLine());

        decimal tomatoCost = 0.5M;
        decimal cucumberCost = 0.4M;
        decimal potatoCost = 0.25M;
        decimal carrotCost = 0.6M;
        decimal cabbageCost = 0.3M;
        decimal beanCost = 0.4M;

        decimal totalCosts = tomatoSeeds * tomatoCost + cucumberSeeds * cucumberCost + potatoSeeds * potatoCost + carrotSeeds * carrotCost + cabbageSeeds * cabbageCost + beanSeeds * beanCost;
        Console.WriteLine("Total costs: {0:F2}", totalCosts);

        int beansArea = 250 - tomatoArea - cucumberArea - potatoArea - carrotArea - cabbageArea;
        if (beansArea > 0)
        {
            Console.WriteLine("Beans area: {0}", beansArea);
        }
        else if (beansArea == 0)
        {
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Insufficient area");
        }
    }
}