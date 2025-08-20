using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises_Dependency.Exercise05
{
    internal class RockPaperScissorsGame : IGameEngine
    {
        public void Play()
        {
            Console.WriteLine("Welcome to the Rock, Paper, Scissors Game!");
            string[] choices = { "Rock", "Paper", "Scissors" };
            Random random = new Random();
            string computerChoice = choices[random.Next(choices.Length)];

            Console.Write("Enter your choice (Rock, Paper, Scissors): ");
            string userChoice = Console.ReadLine();

            if (userChoice.Equals(computerChoice, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"It's a tie! Both chose {computerChoice}.");
            }
            else if ((userChoice.Equals("Rock", StringComparison.OrdinalIgnoreCase) && computerChoice == "Scissors") ||
                     (userChoice.Equals("Paper", StringComparison.OrdinalIgnoreCase) && computerChoice == "Rock") ||
                     (userChoice.Equals("Scissors", StringComparison.OrdinalIgnoreCase) && computerChoice == "Paper"))
            {
                Console.WriteLine($"You win! You chose {userChoice} and the computer chose {computerChoice}.");
            }
            else
            {
                Console.WriteLine($"You lose! You chose {userChoice} and the computer chose {computerChoice}.");
            }
        }
    }
}
