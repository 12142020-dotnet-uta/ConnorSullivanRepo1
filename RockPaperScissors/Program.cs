using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine("Please Enter Your Selection:");
            string userresponse = Console.ReadLine();
            string res_lower = userresponse.ToLower();
            Console.WriteLine($"You selected: {res_lower}");
            string[] options = {"rock", "paper", "scissors"};
            Random rnd = new Random();
            int num = rnd.Next(3); 
            string cpuresponse = options[num];
            string[] gameStatus = {res_lower, cpuresponse};
            Console.WriteLine($"{gameStatus[0]}, {gameStatus[1]}");
            string[,] winConditions = new string[,] {{"paper", "rock"}, {"scissors", "paper"}, {"rock", "{scissors}"},};
            Console.WriteLine($"{winConditions}");
            Console.WriteLine($"CPU selected: {cpuresponse}");
            // if (Array.Exists(winConditions, element => element == "paper"))
            // {
            //     Console.WriteLine("You Win!!");
            // }
            // if (gameStatus[0] == gameStatus[1])
            // {
            //     Console.WriteLine("Tie Game!!");
            // }
            // else {
            //     Console.WriteLine("You Lose!!");
            // }
        }
    }
}
