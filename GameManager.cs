using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    public class GameManager
    {

        private List<string> _inputs;
        private Random _random;
        private int _playerScore;
        private int _computerScore;

        public GameManager()
        {
            _random = new Random();
            _inputs = new List<string>() { "rock", "paper", "scissors", "exit" };
            _playerScore = 0;
            _computerScore = 0;
        }
        public bool QuitGame { get; private set; }

        public rpsChoice GetUserChoice()
        {
            Console.WriteLine("Make a Selection. Enter 'Rock', 'Paper', 'Scissors', or 'Exit'");

            string userChoice = Console.ReadLine().ToLower();

            while (!_inputs.Contains(userChoice))
            {
                Console.WriteLine("Invalid input! Enter a valid input");
                Console.WriteLine("Please enter 'Rock', 'Paper', 'Scissors', or 'Exit'");
                userChoice = Console.ReadLine().ToLower();
            }

            if (userChoice == "rock")
            {
                return rpsChoice.Rock;
            }
            else if (userChoice == "paper")
            {
                return rpsChoice.Paper;
            }
            else if (userChoice == "scissors")
            {
                return rpsChoice.Scissors;
            }
            else if (userChoice == "exit")
            {
                Console.WriteLine("Goodbye");
                Console.ReadKey();
                QuitGame = true;
                
            }

            throw new Exception("Invalid Entry");

        }


        public rpsChoice GetComputerChoice()
        {
            return (rpsChoice)_random.Next(1, 4);

        }

        public string CompareChoices(rpsChoice userChoice, rpsChoice computerChoice)
        {
            Console.WriteLine($"User Selection: {userChoice}");
            Console.WriteLine();
            Console.WriteLine($"Computer Selection: {computerChoice}");

            if (userChoice == computerChoice)
            {
                return "You Tied! Play again? Press 'Escape' key to Exit";
            }
            if (victory(userChoice, computerChoice))
            {
                _playerScore++;
                return "You Win! Play again? Press 'Escape' key to Exit";
            }

            else
                _computerScore++;
            return "You Lose! Play again? Press 'Escape' key to Exit";

        }
        public string ScoreBoard(rpsChoice userChoice, rpsChoice computerChoice)
        {
            return $"Player: {_playerScore} | Computer: {_computerScore}";
        }
        private bool victory(rpsChoice userChoice, rpsChoice computerChoice)
        {
            return (userChoice == rpsChoice.Rock && computerChoice == rpsChoice.Scissors ||
                userChoice == rpsChoice.Scissors && computerChoice == rpsChoice.Paper ||
                userChoice == rpsChoice.Paper && computerChoice == rpsChoice.Rock);
        }

        public void displayOutcome(string score ,string message)
        {
            Console.WriteLine(score);

            Console.WriteLine(message);

            var key = Console.ReadKey();

            QuitGame = key.Key == ConsoleKey.Escape;
        }
    }
}

