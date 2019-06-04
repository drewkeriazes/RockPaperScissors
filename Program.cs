using System;
using System.Collections.Generic;
using System.Threading;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> inputs = new List<string>();
            inputs.Add("rock");
            inputs.Add("paper");
            inputs.Add("scissors");
            inputs.Add("exit");

            string rock = "Rock";
            string paper = "Paper";
            string scissors = "Scissors";
            string closeStatement = "Press any key to close the program...";

            Random random = new Random();

            int randomChoice = random.Next(1, 4);
            string computerChoice = "Woah, thats not supposed to happen.";

            if (randomChoice == 1)
            {
                computerChoice = rock;
            }
            if (randomChoice == 2)
            {
                computerChoice = paper;
            }
            if (randomChoice == 3)
            {
                computerChoice = scissors;
            }


            string title = @"______           _       ______                       _____      _                        
| ___ \         | |      | ___ \                     /  ___|    (_)                       
| |_/ /___   ___| | __   | |_/ /_ _ _ __   ___ _ __  \ `--.  ___ _ ___ ___  ___  _ __ ___ 
|    // _ \ / __| |/ /   |  __/ _` | '_ \ / _ \ '__|  `--. \/ __| / __/ __|/ _ \| '__/ __|
| |\ \ (_) | (__|   < _  | | | (_| | |_) |  __/ |_   /\__/ / (__| \__ \__ \ (_) | |  \__ \
\_| \_\___/ \___|_|\_( ) \_|  \__,_| .__/ \___|_( )  \____/ \___|_|___/___/\___/|_|  |___/
                     |/            | |          |/                                        
                                   |_|                                                    ";
            string battle = @"███████╗██╗ ██████╗ ██╗  ██╗████████╗██╗
██╔════╝██║██╔════╝ ██║  ██║╚══██╔══╝██║
█████╗  ██║██║  ███╗███████║   ██║   ██║
██╔══╝  ██║██║   ██║██╔══██║   ██║   ╚═╝
██║     ██║╚██████╔╝██║  ██║   ██║   ██╗
╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═╝   ╚═╝   ╚═╝
                                        ";


            Console.WriteLine(title);
            Console.WriteLine();
            Console.WriteLine(@"Welcome to Rock, Paper, Scissors, the game!! type 'Exit' to quit the program...");
            Console.WriteLine();
            Console.WriteLine("Choose your warrior!");
            Console.WriteLine("Type 'Rock' for the Stone Wall Warrior");
            Console.WriteLine("Type 'Paper' for the Light and Nimble Knight");
            Console.WriteLine("Type 'Scissors' for the Champion of the Blade");
            Console.WriteLine();
            Console.WriteLine("Hit the 'Enter' key to continue after you have made your selection...");

            var playerChoice = Console.ReadLine().ToLower();

            while (string.IsNullOrEmpty(playerChoice))
            {
                Console.WriteLine("The input cannot be empty!! Choose a valid input.");
                playerChoice = Console.ReadLine().ToLower();
            }

            while(!inputs.Contains(playerChoice))
            {
                Console.WriteLine("Invalid input! Choose a valid input");
                playerChoice = Console.ReadLine().ToLower();
            }

           //Need to figure out how to validate the user input being rock, paper, scissors, or exit only.

            if (playerChoice == "exit")
            {
                Console.Clear();
                Console.WriteLine("You chose 'exit', What are you, scared??");
                Console.WriteLine();
                Console.WriteLine(closeStatement);
                Console.ReadKey();

                Environment.Exit(0);
            }

            if (playerChoice == "rock")
            {
                playerChoice = rock;
            }
            if (playerChoice == "paper")
            {
                playerChoice = paper;
            }
            if (playerChoice == "scissors")
            {
                playerChoice = scissors;
            }


            Console.Clear();

            for (int i = 0; i < 3; i++)
            {
                Console.Beep();
                Thread.Sleep(1000);
                Console.WriteLine("Thinking...");
            }

            Console.Clear();

            string winMessage = $"Congratulations!! You won! Everyone knows {playerChoice} destroys {computerChoice}.";
            string loseMessage = $"Aww too bad, you lose!! Looks like {playerChoice} was the wrong choice.";
            string tieMessage = $"Drats a tie?? You both chose {playerChoice}! Exit and play again!!";
            string victory = $"{playerChoice} beats {computerChoice}!";
            string loss = $"{computerChoice} beats {playerChoice}!";

            Console.WriteLine(battle);

            Console.WriteLine();

            Console.WriteLine("You chose " + playerChoice);

            Thread.Sleep(1000);

            Console.WriteLine();

            Console.WriteLine("The computer chose " + computerChoice);

            Console.WriteLine();

            //Player Choice Rock
            if (playerChoice == rock && computerChoice == paper)
            {
                Console.WriteLine(loss);
                Console.WriteLine(loseMessage);
                Console.WriteLine();
                Console.WriteLine(closeStatement);
                Console.ReadKey();
            }
            if (playerChoice == rock && computerChoice == scissors)
            {
                Console.WriteLine(victory);
                Console.WriteLine(winMessage);
                Console.WriteLine();
                Console.WriteLine(closeStatement);
                Console.ReadKey();
            }
            if (playerChoice == rock && computerChoice == rock)
            {
                Console.WriteLine(tieMessage);
                Console.WriteLine();
                Console.WriteLine(closeStatement);
                Console.ReadKey();
            }
            //Player Choice Scissors
            if (playerChoice == scissors && computerChoice == paper)
            {
                Console.WriteLine(victory);
                Console.WriteLine(winMessage);
                Console.WriteLine();
                Console.WriteLine(closeStatement);
                Console.ReadKey();
            }
            if (playerChoice == scissors && computerChoice == scissors)
            {
                Console.WriteLine(tieMessage);
                Console.WriteLine();
                Console.WriteLine(closeStatement);
                Console.ReadKey();
            }
            if (playerChoice == scissors && computerChoice == rock)
            {
                Console.WriteLine(loss);
                Console.WriteLine(loseMessage);
                Console.WriteLine();
                Console.WriteLine(closeStatement);
                Console.ReadKey();
            }
            //Player Choise Paper
            if (playerChoice == paper && computerChoice == paper)
            {
                Console.WriteLine(tieMessage);
                Console.WriteLine();
                Console.WriteLine(closeStatement);
                Console.ReadKey();
            }
            if (playerChoice == paper && computerChoice == scissors)
            {
                Console.WriteLine(loss);
                Console.WriteLine(loseMessage);
                Console.WriteLine();
                Console.WriteLine(closeStatement);
                Console.ReadKey();
            }
            if (playerChoice == paper && computerChoice == rock)
            {
                Console.WriteLine(victory);
                Console.WriteLine(winMessage);
                Console.WriteLine();
                Console.WriteLine(closeStatement);
                Console.ReadKey();
            }



        }

    }
}
