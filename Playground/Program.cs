using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isrunning = true;
            
            while (isrunning)
            {
                Console.WriteLine("CALCULATOR");
                Console.WriteLine("Press Any Key To Start");
                Console.ReadLine();


                Console.Write("Enter your first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter your second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double addnums = num1 + num2;
                double subnums = num1 - num2;
                double mulnums = num1 * num2;

                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");


                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Answer: " + addnums);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Answer: " + subnums);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Answer: " + mulnums);
                }
                else if (choice == 4)
                {
                    if (num2 != 0)
                    {
                        double divnums = num1 / num2;

                        Console.WriteLine("Answer: " + divnums);

                    }
                    else
                    {
                        Console.WriteLine("Cannot Divide by 0");
                    }



                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }

                Console.WriteLine("Continue? y/n");

                string CountinueChoice = Console.ReadLine();

                if (CountinueChoice == "n")
                {
                    isrunning = false;
                }
            }




        }
    }
}
