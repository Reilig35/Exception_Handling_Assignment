using System;

namespace Exception_Handling_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the year you were born in YYYY format:\n");
                int userBirthYear = Convert.ToInt32(Console.ReadLine());
                UserAge.Age(userBirthYear);
            }
            catch (NotOldEnoughException)
            {
                {
                    Console.WriteLine("According to your input you do not exist yet or a time traveller\n" +
                        "Please try again when you are created.");
                }
            }
            catch (TooOldException)
            {
                Console.WriteLine("Sorry the oldest person alive is Kane Tanaka and she was born in 1903\n" +
                    "If you were born before 1903 please contact Guinness World Records.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter only numbers.");
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry something went wrong please try again");
            }
        }
    }
}
        
            

                
