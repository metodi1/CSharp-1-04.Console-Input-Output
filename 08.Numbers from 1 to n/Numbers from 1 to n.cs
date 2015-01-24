using System;
//Write a program that reads an integer number n from the console
//and prints all the numbers in the interval [1..n], each on a single line.
class Program
{
    static void Main()
    {
        Console.Write("Write n(integer number):");
        int number = int.Parse(Console.ReadLine());

        for (int counter = 1; counter <= number; counter++)
        {
            Console.WriteLine(counter);
        }
    }
}