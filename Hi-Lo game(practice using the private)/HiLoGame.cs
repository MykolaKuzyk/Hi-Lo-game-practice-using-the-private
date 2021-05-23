using System;
using System.Collections.Generic;
using System.Text;

namespace Hi_Lo_game_practice_using_the_private_
{
    static class HiLoGame
    {



        public const int MAXIMUM = 10;
        private static Random random = new Random();
        private static int currentNumber = random.Next(0, MAXIMUM + 1);
        private static int pot = 1;
        public static int GetPot() { return pot; }

        static HiLoGame()
        {
            int MyPot = pot;
            int CurrentNumber = currentNumber;
        }

        public static void Guess(bool higher)
        {
            int nextCurrentNumber = random.Next(1, MAXIMUM + 1);


            if ((higher && nextCurrentNumber >= currentNumber) || (!higher && nextCurrentNumber <= currentNumber)) 
            {
                Console.WriteLine("You guessed right");
                pot++;
            }
            else
            {
                Console.WriteLine("Bad luck you guessed wrong ");
                pot --;
                
            }

            currentNumber = nextCurrentNumber;
            Console.WriteLine($"The current number is {currentNumber}");
           

        }
        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (currentNumber >= half)
            {
                Console.WriteLine($"the number is at least {half}");

            }
            else Console.WriteLine($"The number is at most {half}");

        }

    }
}
