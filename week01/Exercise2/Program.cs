using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();

        int grade;
        bool isNumber = int.TryParse(input, out grade);

        if (!isNumber)
        {
            Console.WriteLine("Please enter a valid number.");
            return; // Salir si no es un número válido
        }

        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = grade % 10;

        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit <= 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A")
        {
            if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Your letter grade is {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Don't worry — keep trying and you'll do better next time!");
        }
    }
}
