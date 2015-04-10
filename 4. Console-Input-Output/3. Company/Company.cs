using System;
using System.Text;
using System.Threading;
using System.Globalization;


class Company
{
    static void Main()
    {
        string company_Name, web_Site;
        string first_Name, last_Name;
        int age, phone_number, fax_Num;

        Console.Write("Company name: "); company_Name = Console.ReadLine();
        Console.Write("web site: "); web_Site = Console.ReadLine();
        Console.Write("Manager\n");
        Console.Write("First name: "); first_Name = Console.ReadLine();
        Console.Write("Last name: "); last_Name = Console.ReadLine();
        Console.Write("Age: "); age = int.Parse(Console.ReadLine());
        Console.Write("Phone number: "); phone_number = int.Parse(Console.ReadLine());
        Console.Write("Fax number: "); fax_Num = int.Parse(Console.ReadLine());

        Console.Write("\nCompany name: {0}\nweb site: http://{1}\nManager\nNames: {2} {3}\nAge: {4}\nPhone number: {5}\nFax Number: {6}\n", company_Name, web_Site, first_Name, last_Name, age, phone_number, fax_Num);

    }
}

//A company has name, address, 
//phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company 
//and its manager and prints them on the console.
