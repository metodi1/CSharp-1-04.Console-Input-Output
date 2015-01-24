using System;
//Write a program that reads the radius r of a circle and prints its perimeter and 
//area formatted with 2 digits after the decimal point.
class Program
{
    static void Main()
    {
        //write the radius.
        Console.Write("Write the radius:");
        double radius = double.Parse(Console.ReadLine());

        //calculate the area and perimeter
        double perimeter =radius*radius * Math.PI;
        double area = radius * 2 * Math.PI;

        //print the result.
        Console.WriteLine("Perimeter formatted with 2 digits after the decimal point is:{0:0.00}",perimeter);
        Console.WriteLine("Area formatted with 2 digits after the decimal point is:{0:0.00}",area);
    }
}