using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int integer;
        string currentsymbol = "negative";
        decimal bottomnumber = 1;
        decimal answer = (4 / bottomnumber);

        Console.WriteLine("Please enter the number of iterations");
        Console.WriteLine("");

        Console.Write("Number of iterations: ");
        integer = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        if (integer > 1)
        {
            for (int counter = 1; counter < integer; counter++)
            {
                if (currentsymbol == "negative")
                {
                    bottomnumber = bottomnumber + 2;
                    answer = answer - (4 / bottomnumber);
                    currentsymbol = "positive";
                }
                else if (currentsymbol == "positive")
                {
                    bottomnumber = bottomnumber + 2;
                    answer = answer + (4 / bottomnumber);
                    currentsymbol = "negative";
                }
            }
        }

        Console.WriteLine(answer.ToString("0.0000000000"));

        Console.WriteLine("\nDone.");
    }
}