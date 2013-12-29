using System;

class GreatestOfFiveVars
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());
        int fourthNum = int.Parse(Console.ReadLine());
        int fifthNum = int.Parse(Console.ReadLine());
        int biggestNum = 0;

        if ((firstNum > secondNum) && (firstNum > thirdNum) && (firstNum > fourthNum) && (firstNum > fifthNum))
        {
            biggestNum = firstNum;
        }
        else if ((secondNum > firstNum) && (secondNum > thirdNum) && (secondNum > fourthNum) && (secondNum > fifthNum))
        {
            biggestNum = secondNum;
        }
        else if ((thirdNum > firstNum) && (thirdNum > secondNum) && (thirdNum > fourthNum) && (thirdNum > fifthNum))
        {
            biggestNum = thirdNum;
        }
        else if ((fourthNum > firstNum) && (fourthNum > secondNum) && (fourthNum > thirdNum) && (fourthNum > fifthNum))
        {
            biggestNum = fourthNum;
        }
        else if ((fifthNum > firstNum) && (fifthNum > secondNum) && (fifthNum > thirdNum) && (fifthNum > fourthNum))
        {
            biggestNum = fifthNum;
        }
        Console.WriteLine(biggestNum);
    }
}