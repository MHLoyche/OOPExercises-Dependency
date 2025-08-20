using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises_Dependency.Exercise05
{
    internal class GuessNumberGame : IGameEngine
    {
        public void Play()
        {
            Console.WriteLine("Welcome to the Guess Number Game!");
            Random random = new Random();
            int numberToGuess = random.Next(1, 11);
            int userGuess = 0;
            while (userGuess != numberToGuess)
            {
                Console.Write("Enter your guess (1-10): ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You've guessed the number!");
                }
            }
        }
    }
}
