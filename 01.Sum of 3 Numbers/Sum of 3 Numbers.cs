using System;
//Write a program that reads 3 real numbers from the console and prints their sum.
//Examples:
//a 	b	    c   	sum
//3	    4	    11	    18
//-2	0	    3	    1
//5.5	4.5	    20.1	30.1


class Program
{
    static void Main()
    {
        //Write 3 real numbers
        Console.Write("Write A:");
        double A = double.Parse(Console.ReadLine());
        Console.Write("Write B:");
        double B = double.Parse(Console.ReadLine());
        Console.Write("Write C:");
        double C = double.Parse(Console.ReadLine());

        //calculation.
        double sum = A + B + C;

        //print the result.
        Console.WriteLine("Their sum is:{0}", sum);

    }
}