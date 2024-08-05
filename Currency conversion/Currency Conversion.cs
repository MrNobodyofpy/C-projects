using System;

namespace Check_your_personal_information
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will use your personal information, be careful: )");

            // Tell me your name
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            // Tell me your gender
            string gender;
            do
            {
                Console.WriteLine("What is your gender?");
                Console.WriteLine("Enter 'male', 'female', or 'others'");
                gender = Console.ReadLine();

                if (gender != "male" && gender != "female" && gender != "others")
                {
                    Console.WriteLine("Invalid gender, please try again!");
                }
            } while (gender != "male" && gender != "female" && gender != "others");

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            // So young
            if (age < 18)
            {
                Console.WriteLine("You are really young");
                // So old
            }
            else if (age > 18)
            {
                Console.WriteLine("You are really old");
            }

            Console.WriteLine("Ok, now I will repeat this information. Please check and answer the last question:");
            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"Your gender is {gender}");
            Console.WriteLine($"Your age is {age}");

            string program_is_true;
            do
            {
                Console.WriteLine("Is this information correct? (Enter 'yes' or 'no'): ");
                program_is_true = Console.ReadLine().ToLower();

                switch (program_is_true)
                {
                    case "yes":
                        Console.WriteLine("Thank you for your cooperation!");
                        break;
                    case "no":
                        Console.WriteLine("Sorry, the program will be fixed. This simple program can't be wrong, liar!");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
                    Console.WriteLine("Thank you for your cooperation!");

            } while (program_is_true != "yes" && program_is_true != "no");
        }
    }
}