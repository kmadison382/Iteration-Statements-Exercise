using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.XPath;
using Microsoft.VisualBasic;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Thousands()
        {
            Console.WriteLine("Let's count backwards from 1000 to -1000. Press enter.");
            Console.Read();
            for (var i = 1000; i > -1001; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Threes()
        {
            Console.WriteLine("Let's count by threes! Press enter.");
            Console.Read();
            var i = 3;
            do
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i <= 999);
        }
        //Write a method to accept two integers as parameters and check whether they are equal or not
        public static void Equal(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine($"{x} and {y} are equal!");
            }
            else
            {
                Console.WriteLine($"{x} and {y} are not equal :(");
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOdd(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is even!");
            }
            else
            {
                Console.WriteLine($"{x} is odd!");
            }
        }
        
        //Write a method to check whether a given number is positive or negative
        public static void PosNeg(int x)
        {
            if (x == 0)
            {
                Console.WriteLine("This is zero!");
                return;
            }
            var result = (x >= 0) ? $"{x} is positive" : $"{x} is negative";
            Console.WriteLine(result);
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void VoteAge()
        {
            Console.WriteLine("Can you legally vote? Enter your age.");
            bool goodAge = int.TryParse(Console.ReadLine(), out int age);
            while (goodAge == false)
            {
                Console.WriteLine("Please enter a number.");
                goodAge = int.TryParse(Console.ReadLine(), out age);
            }
            // Not sure if there is a better way to loop if user doesn't input a number
            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote, get going!");
            }
            else
            {
                Console.WriteLine("Sorry, you are not old enough to vote.");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void InTens()
        {
            Console.WriteLine("Please enter a number.");
            int number = int.Parse(Console.ReadLine());
            if (number >= -10 && number <= 10)
            {
                Console.WriteLine($"{number} is between -10 and 10.");
            }
            else if (number < -10 || number > 10)
            {
                Console.WriteLine($"{number} is not between -10 and 10");
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultTable()
        {
            Console.WriteLine("Finally, let's practice multiplication. Enter a number.");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1 ; i <= 12 ; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Thousands();
            Threes();
            Equal(6, 5);
            EvenOdd(145);
            PosNeg(-655);
            VoteAge();
            InTens();
            MultTable();
        }
    }
}
