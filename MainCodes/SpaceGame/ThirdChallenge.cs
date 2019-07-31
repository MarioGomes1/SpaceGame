using System;

namespace SpaceGame
{
    class ThirdChallenge
    {
        public void MethodThirdChallenge()
        {
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Space pirates are attacking your ship...\n" +
                                      "again.. To stop them, answer this question correctly ");
                    Console.WriteLine("*********************************************************");
                    Console.WriteLine("What state is Area 51 located?");
                    Console.WriteLine("a) Nevada\n" +
                                      "b) Utah\n" +
                                      "c) Colorado\n" +
                                      "d) New Mexico");

                    string userValue = Console.ReadLine();

                    if (userValue == "a")
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
}