using System;
//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.


class Program
{
    static void Main()
    {
        //write numbers.
        Console.Write("Write first number(integer a (0 <= a <= 500):");
        int firtsNumber = int.Parse(Console.ReadLine());
        Console.Write("Write second number(floating-point):");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Write third number(floating-point):");
        double third = double.Parse(Console.ReadLine());

        //calculation 
        string binary = Convert.ToString(firtsNumber, 2).PadLeft(10, '0');
        

        //print result
        Console.Write("|{0,-10:X}|{1}|{2,10:0.00}|{3,-10:0.000}|", firtsNumber, binary, secondNumber, third);
       

    }
}