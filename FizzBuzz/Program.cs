using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Name: Kirtan Khare");
        Console.WriteLine($"Date: {DateTime.Today:24-07-2026}");
        Console.WriteLine();

        FizzBuzz();
    }

    static void FizzBuzz()
    {
        for (int i = 1; i <= 20; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
    }
}