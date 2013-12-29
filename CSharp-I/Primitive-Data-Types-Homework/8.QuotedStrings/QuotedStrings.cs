using System;

class QuotedStrings
{
    static void Main(string[] args)
    {
        string withoutQuotes = "The \"use\" of quotations causes difficulties.";
        string withQuotes = "\"The \"use\" of quotations causes difficulties.\"";
        Console.WriteLine(withQuotes);
        Console.WriteLine(withoutQuotes);
    }
}