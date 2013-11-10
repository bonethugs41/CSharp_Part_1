//A marketing firm wants to keep record of its employees.
//Each record would have the following characteristics –
//first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999).
//Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.



using System;

class Marketing
{
    static void Main()
    {
        Console.Title = "Employee information";
        string firstName = "Martin";
        string lastName = "Pavlov";
        byte age = 22;
        char gender = 'm';
        short iD = 3608;
        uint uEN = 27560001;

        Console.WriteLine("First name:{0} \nLast name:{1} \nAge:{2} \nGender:{3} \nID number:{4} \nUnique employee number:{5}", firstName, lastName, age, gender, iD, uEN);
    }
}
