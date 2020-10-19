using System;

namespace YearValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When were you born?");
            string usersYearOfBirth = Console.ReadLine();
            if (Validate(usersYearOfBirth))
            {
                Console.WriteLine("Welcome");
                Calculation(usersYearOfBirth);
            }
        }

        public static bool Validate(string usersYear)
        {
            if (usersYear.Length == 4)
            {
                try
                {
                    Int32.Parse(usersYear);
                        return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong format: {e}");
                    return false;
                }
            }else
            {
                return false;
            }
        }

        public static void Calculation(string yearOfBirth)
        {
            int userInput = Int32.Parse(yearOfBirth);
            DateTime now = DateTime.Now;
            string currentYear = now.Year.ToString();
            int yearNow = Int32.Parse(currentYear);
            int age = yearNow - userInput;

            Console.WriteLine($"You are {age} years old.");
        }
    }
}
