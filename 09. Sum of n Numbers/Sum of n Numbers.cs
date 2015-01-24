using System;

//Write a program that enters a number n and after that enters more n numbers 
//and calculates and prints their sum. Note: You may need to use a for-loop.

class Program
{
    static void Main()
    {
        Console.Write("Write n:");
        double number = double.Parse(Console.ReadLine());
        double sum = 0;

        for (int counter = 1; counter <= number; counter++)
        {
            Console.Write("Write number {0}:", counter);
            double moreNumber = double.Parse(Console.ReadLine());
            sum =sum+moreNumber;
        }

         Console.WriteLine("Sum is {0}", sum);
    }
}