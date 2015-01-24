using System;

//Write a program that reads the coefficients a, b and c
//of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

class Program
{
    static void Main()
    {
        //write numbers.
        Console.Write("Write a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Write b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Write c:");
        double c = double.Parse(Console.ReadLine());

        double D = Math.Pow(b,2) - (4 * a * c);
            
        if (D >= 0)
        {
            double discriminant = Math.Sqrt(D);

            if (discriminant == 0)
            {
                double root = (b / (2 * a)) * (-1);
                Console.WriteLine("The only root is:{0}", root);
            }
            else 
            {
                double root1 = (b*(-1) - discriminant) /( 2 * a);
                double root2 = (b*(-1) + discriminant) / (2 * a);
                Console.WriteLine("The root1 is:{0:0.0}\nThe root2 is:{1:0.0}", root1,root2);
            }
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}