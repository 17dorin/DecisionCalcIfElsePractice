using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            int input = 0;
            bool validInput = false;
            bool goAgain = true;
            char yesOrNo;

            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();

            while (goAgain == true)
            {
                Console.WriteLine("Hello {0}!", name);
                while(validInput == false)
                {
                    Console.WriteLine("Please enter a number from 1 to 100");
                    int.TryParse(Console.ReadLine(), out input);
                    if (input >= 1 && input <= 100)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                    }
                }
                //"if" checks for even, "else" defaults to odd
                if(input % 2 == 0)
                {
                    if(input > 60)
                    {
                        Console.WriteLine("{0}, Even", input);
                    }
                    else if(input >= 26)
                    {
                        Console.WriteLine("Even");
                    }
                    else
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                }
                else
                {
                    Console.WriteLine("{0}, Odd", input);
                }
                Console.WriteLine("{0}, continue? (Y/N)", name);
                char.TryParse(Console.ReadLine(), out yesOrNo);
                if(char.ToLower(yesOrNo) == 'y')
                {
                    Console.Clear();
                    goAgain = true;
                    validInput = false;
                }
                else
                {
                    goAgain = false;
                }
            }

        }
    }
}
