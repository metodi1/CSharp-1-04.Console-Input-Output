using System;
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

class Program
{
    static void Main()
    {
        //write numbers.
        Console.Write("Write first number:");
        double firtsNumber = double.Parse(Console.ReadLine());
        Console.Write("Write second number:");
        double secondNumber = double.Parse(Console.ReadLine());

        //calculation.
        double max = Math.Max(firtsNumber, secondNumber);

        //print result.
        Console.WriteLine("The greater of them is:{0}",max);
    }
}