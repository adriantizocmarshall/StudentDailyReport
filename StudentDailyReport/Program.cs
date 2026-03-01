using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The name of the institution is written to the console followed by a blank line.
            Console.WriteLine("The Tech Academy");

            //Space for user input.
            Console.ReadLine();

            // The title of the application displays to the console and waits for user input before proceeding.
            Console.WriteLine("Student Daily Report");

            Console.ReadLine();

            // The application asks a series of questions and waits for the user to provide answers before proceeding to each one.
            Console.WriteLine("What is your name?");

            Console.ReadLine();

            Console.WriteLine("What course are you on?");

            Console.ReadLine();

            Console.WriteLine("What page number?");

            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");

            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");

            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");

            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");

            Console.ReadLine();

            // After the user has answered all of the questions, a final message displays to the console.
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            // This final message displays to the console and the application waits for the user to press enter before closing.
            Console.ReadLine();
        }
    }
}
