using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace SpaceGame
{
    class SecondChallenge
    {
        public void Method2ndChallenge()
        {
            while (true)
            {
                Console.WriteLine("Space pirates are attacking your ship again, to stop them,\n" +
                                  "answer this trivia question.");
                Console.WriteLine("**********************************************************");
                Console.WriteLine("On the Tv Shark Tank, out of these four people,\n" +
                                  "who is one of the investors");
                Console.ReadLine();
                Console.WriteLine("a) Steve Jobs\n" +
                                  "b) Mark Cuban\n" +
                                  "c) Bill Gates\n" +
                                  "D) Elon Musk");
                string userValue = Console.ReadLine();

                if (userValue == "b")
                {
                    Console.WriteLine("Congrats, you are correct");
                    break;
                }
                else
                {
                    Console.WriteLine("You've failed");

                    while (true)
                    {
                        Console.Write("Do you want to try again [Y/N]?");
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