//Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.



using System;

class GenderCheck
{
    static void Main()
    {
        bool isFemale;
        Console.WriteLine("What is you gender (male/female):");
        string myGender = Console.ReadLine();
        if (myGender == "female")
        {
            isFemale = true;
        }
        else 
        {
            isFemale = false;
        }
        Console.WriteLine("Are you female:" + isFemale);
    }
}
