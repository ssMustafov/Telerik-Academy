using System;

class Company
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Company phone number: ");
        int companyPhoneNumber = int.Parse(Console.ReadLine());

        Console.Write("Company fax number: ");
        int companyFaxNumber = int.Parse(Console.ReadLine());

        Console.Write("Company website: ");
        string companyWebsite = Console.ReadLine();

        Console.Write("Manager's first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Manager's last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Manager's age: ");
        int managerAge = int.Parse(Console.ReadLine());

        Console.Write("Manager's phone number: ");
        int managerPhoneNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The company name is {0}, with address - {1}, phone number - {2}, fax number - {3}, website - {4}", 
            companyName, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebsite);
        Console.WriteLine("Manager's name is {0}, manager's age is {1}, manager's phone number is {2}", 
            managerFirstName+ " " + managerLastName, managerAge, managerPhoneNumber);
    }
}