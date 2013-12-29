/*
 Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
 The cards should be printed with their English names. Use nested for loops and switch-case.
 */

using System;

class Cards
{
    static void Main()
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] type = { "CLUB", "DIAMOND", "HEART", "SPADE" };

        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 0; j < type.Length; j++)
            {
                Console.WriteLine("{0} {1}", cards[i], type[j]);
            }
        }
    }
}