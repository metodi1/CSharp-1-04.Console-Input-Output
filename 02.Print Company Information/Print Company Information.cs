using System;

//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and 
//its manager and prints it back on the console.
//Example input:
//program       	user
//Company name:	    Telerik Academy
//Company address:	31 Al. Malinov, Sofia
//Phone number:	    +359 888 55 55 555
//Fax number:	    2
//Web site:	        http://telerikacademy.com/
//Manager first name:	Nikolay
//Manager last name:	Kostov
//Manager age:	    25
//Manager phone:	+359 2 981 981


class Program
{
    static void Main()
    {
        Console.Write("Company name:");
        string companyName = Console.ReadLine();
        Console.Write("Company address:");
        string companeAddress = Console.ReadLine();
        Console.Write("Phone number:");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number:");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site:");
        string webSite= Console.ReadLine();
        Console.Write("Manager first name:");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name:");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age:");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone:");
        string managerPhone = Console.ReadLine();

        Console.Write("{0}\n{1}\nTel.{2}\nFax:{3}\nWeb site:{4}",companyName,companeAddress,phoneNumber,faxNumber,webSite);
        Console.WriteLine("{0} {1}(age:{2}, tel.{3})",managerFirstName,managerLastName,managerAge,managerPhone);
    }
}
