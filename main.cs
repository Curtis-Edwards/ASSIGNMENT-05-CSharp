using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int integer;
        int currentsymbol = "negative";
        int bottomnumber = 0 ;
        int answer = 0 ;


        Console.WriteLine("Please enter the number of iterations");
        Console.WriteLine("");

        Console.Write("Number of iterations: ");
        integer = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        if (integer > 1)
        {
            for (let counter = 1; counter < integer; counter++)
            {
                if (currentSymbol == "negative")
                {
                    bottomNumber = bottomNumber + 2;
                    answer = answer - (4 / bottomNumber);
                    currentSymbol = "positive";
                } else if (currentSymbol == "positive")
                {
                    bottomNumber = bottomNumber + 2;
                    answer = answer + (4 / bottomNumber);
                    currentSymbol = "negative";
                }
            }
        }

        Console.WriteLine(answer.ToString("0.0000000000"));

        Console.WriteLine("\nDone.");
    }
}