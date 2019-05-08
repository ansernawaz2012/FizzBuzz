using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Game
    {
        public Boolean gameWon = false;
        public Boolean wrongAnswer = false;

        public Game()
        {
            playGame();
        }

        public void playGame()
        {
            Console.WriteLine("Choose F for Fizz, B for Buzz, A for Both and N for none.");
            //while(!gameWon && !wrongAnswer)
            for(int i = 1; i<=30; i++)
            {
                string rightChoice = "";
                Console.WriteLine($"The number is {i} : Make your choice");
                string userInput = Console.ReadLine();

                if (i % 3 == 0 && i % 5 == 0)
                {
                    rightChoice = "a";
                } else if (i % 3 == 0)
                {
                    rightChoice = "f";
                } else if (i % 5 == 0)
                {
                    rightChoice = "b";
                } else
                {
                    rightChoice = "n";
                }

                if(userInput == rightChoice)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Wrong!!! Game over.");
                    wrongAnswer = true;
                    break;
                }
                
            }

            if (!wrongAnswer)
            {
                Console.WriteLine("You have won. Well done!!!");
            }
        }
    }
}
