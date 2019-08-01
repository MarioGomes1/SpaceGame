using System;
using System.Security.Cryptography.X509Certificates;

namespace SpaceGame
{
    public class FirstChallenge
    {
        public void Method1stChallenge()
        {

            // need to add 100 player tokens
            while (true)
            {
                string num1, num2, num3;
                //string userValue = Console.ReadLine();
                Console.WriteLine("Space pirates are attacking your ship attempting to deplete\n" +
                                  "your resources, to stop them solve this math equation");
                Console.WriteLine("You have a set of numbers 3,9,27,81 ... \n" +
                                  "what will be the next 3 numbers?");

                try
                {
                    Console.WriteLine("Enter the first number");
                    num1 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    num2 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter third number");
                    num3 = Convert.ToString(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Try again");
                    return;
                }

                if (num1 == "247" && num2 == "729" && num3 == "2187")
                {
                    Console.WriteLine("Congrats you passed the challenge");
                    break;
                }

                else if (num1 != "247" || num2 != "729" || num3 != "2187")
                {
                    Console.WriteLine("Failed");

                    while (true)
                    {
                        Console.Write("Do you want to play again [Y/N]?");
                        string answer = Console.ReadLine().ToUpper();
                        if (answer == "Y")
                            break;
                        if (answer == "N")
                            return;
                    }
                }
            }

        }
        







    }
}