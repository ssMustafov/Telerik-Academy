using System;

class UsersChoice
{
    static void Main()
    {
        Console.WriteLine("Enter 1 for int, 2 for double, 3 for string:");
        int userChoice = int.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                int userInput = int.Parse(Console.ReadLine());
                userInput++;
                Console.WriteLine(userInput);
                break;
            case 2:
                double userInputD = double.Parse(Console.ReadLine());
                userInputD++;
                Console.WriteLine(userInputD);
                break;
            case 3:
                string userInputS = Console.ReadLine();
                userInputS = userInputS + "*";
                Console.WriteLine(userInputS);
                break;
            default: Console.WriteLine("Error"); break;
        }
    }
}