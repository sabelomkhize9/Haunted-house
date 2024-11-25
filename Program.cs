using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace consoleproject
{
    internal class Program
    {
        static void Main(string[] args)
        

            


        {
            {
                
                {
                    bool playAgain = true;

                    while (playAgain)
                    {
                        bool gameWon = PlayGame();

                        if (gameWon)
                        {
                            Console.WriteLine("Congratulations, you survived the haunted house!");
                        }
                        else
                        {
                            Console.WriteLine("You have met a terrible fate...");
                        }

                        Console.WriteLine("Do you want to play again? (yes/no)");
                        string replayInput = Console.ReadLine()?.ToLower();
                        playAgain = replayInput == "yes";
                    }
                }

                  bool PlayGame()
                {
                    Console.WriteLine("You enter the haunted house. It's dark and eerie...");

                    if (!MakeChoice("1. Open the door", "2. Run away", "1"))
                        return false;

                    if (!MakeChoice("1. Light the candle", "2. Hide in the dark", "1"))
                        return false;

                    if (!MakeChoice("1. Take the hidden key", "2. Ignore the key", "1"))
                        return false;

                    if (!MakeChoice("1. Read the ancient book", "2. Ignore the book", "1"))
                        return false;

                    if (!MakeChoice("1. Use the key on the final door", "2. Run back", "1"))
                        return false;

                    return true;
                }

                  bool MakeChoice(string option1, string option2, string correctChoice)
                {
                    Console.WriteLine(option1);
                    Console.WriteLine(option2);
                    string playerChoice = Console.ReadLine();

                    if (playerChoice == correctChoice)
                    {
                        Console.WriteLine("You made the right choice!");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("You made the wrong choice!");
                        return false;
                    }
                }
            }




        }














    }
}

