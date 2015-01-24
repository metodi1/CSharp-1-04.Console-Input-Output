using System;
//Write a program that reads two positive integer numbers and prints how many numbers p 
//exist between them such that the reminder of the division by 5 is 0.
class Program
{
    static void Main()
    {
        Console.Write("Write number1:");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Write number2:");
        int number2 = int.Parse(Console.ReadLine());

        int p = 0;

        for (int counter = number1; counter <= number2; counter++)
        {
            if (counter % 5 == 0)
            {
                Console.WriteLine(counter);
                p++;
            }
        }
        Console.WriteLine("numbers p exist between them such that the reminder \nof the division by 5 is 0 are:{0}",p);
    }
}