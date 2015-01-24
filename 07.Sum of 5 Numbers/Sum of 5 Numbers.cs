using System;

//Write a program that enters 5 numbers (given in a single line, separated by a space),
//calculates and prints their sum


class Program
{
    static void Main()
    {
        Console.Write("a = ");
        string [] line = Console.ReadLine().Split(' '); ;
        double sum = 0;

        foreach (string s
            in line)
        {
            sum += Convert.ToDouble(s);
           
        }
       
        Console.WriteLine("Sum is = {0}", sum);  
    }
}   