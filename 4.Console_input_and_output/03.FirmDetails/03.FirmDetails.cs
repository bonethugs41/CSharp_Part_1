//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company and its manager and prints them on the console.



using System;

class FirmDetails
{
    static void Main(string[] args)
    {
        Console.Title = "FIrm Details";
        //Company information
        Console.WriteLine("Please fill the company information.");

        Console.Write("Company name:");
        string companyName = Console.ReadLine();

        Console.Write("Company address:");
        string companyADdress = Console.ReadLine();

        Console.Write("Company phone number:");
        int companyPhone;
        while (true)
        {
            string check = Console.ReadLine();
            if (int.TryParse(check, out companyPhone))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid phone number, please try again:");
                continue;
            }
        }
                
        Console.Write("Company fax number:");
        int companyFaxNumber;
        while (true)
        {
            string check = Console.ReadLine();
            if (int.TryParse(check, out companyFaxNumber)) 
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid fax number, please try again:");
                continue;
            }
        }

        Console.Write("Company web site:");
        string companyWebSite = Console.ReadLine();

        Console.Write("Company manager:");
        string companyManager = Console.ReadLine();

        //Manager information
        Console.WriteLine("Please fill the manager details.");
        Console.Write("Manager first name:");
        string managerName = Console.ReadLine();

        Console.Write("Manager last name:");
        string managerLastName = Console.ReadLine();

        Console.Write("Manager age:");
        byte managerAge = byte.Parse(Console.ReadLine());

        //Don't know how to check if the entered number is byte

        Console.Write("Manager phone number:");
        int managerPhoneNumber;
        while (true)
        {
            string check = Console.ReadLine();
            if (int.TryParse(check, out managerPhoneNumber))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid phone number, please try again:");
                continue;
            }
        }

        Console.WriteLine("\n\n\n\n");
        Console.WriteLine("Company name: {0} \nCompany address: {1} \nPhone number: {2} \nFax number: {3} \nWeb site: {4} \n Manager: {5}", companyName, companyADdress, companyPhone, companyFaxNumber, companyWebSite, companyManager);
        Console.WriteLine("Manager's name: {0} {1} \nAge: {2} \nPhone number: {3}", managerName, managerLastName, managerAge, managerPhoneNumber);       
    }
}