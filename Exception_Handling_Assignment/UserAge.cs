using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling_Assignment
{
    public class UserAge
    {
        
        
        public static void Age(int userBirthYear)
        {
            double userAge = DateTime.Now.Year - userBirthYear;
            if (userAge >= 1 && userBirthYear >= 1903)
            {
                Console.WriteLine($"You are {userAge} years old.");
            }
            else if (userAge <= 0)
            {
                throw new NotOldEnoughException();
            }
            else if (userBirthYear <= 1902)
            {
                throw new TooOldException();
            }
            else 
            { 
                throw new Exception(); 
            };
           
        }
    }
}
