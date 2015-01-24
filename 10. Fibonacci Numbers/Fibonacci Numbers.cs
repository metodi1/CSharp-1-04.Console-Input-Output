using System;
//Write a program that reads a number n and prints on the console the first n members
//of the Fibonacci sequence (at a single line, separated by comma and space - ,) 
//: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.
class Program
{
    static void Main()
    {
        Console.Write("Write n:");
        int number = int.Parse(Console.ReadLine());
        int fib1 = 0;
        int fib2 = 1;
        int var1 = 0;

        Console.WriteLine("Fibonacci sequence :");
        Console.WriteLine(fib1);
        Console.WriteLine(fib2);

       for (int counter = 1; counter <= number-2; counter++)
        {
           int fib3 = fib1+fib2;            
           Console.WriteLine(fib3);
           var1 = fib2;
           fib1 = fib2;
           fib2 = fib3;
        }
    }
}