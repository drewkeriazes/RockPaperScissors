using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    public class GameManager
    {
        public GameManager()
        {
            _random = new Random();
            _inputs = new List<string>();
            _inputs.Add("rock");
            _inputs.Add("paper");
            _inputs.Add("scissors");
            _inputs.Add("exit");
            _playerScore = new int();
            _computerScore = new int();

        }
        private List<string> _inputs;
        private Random _random;
        private int _playerScore = 0;
        private int _computerScore = 0;
        

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
                return rpsChoice.Exit;
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


    }
}

