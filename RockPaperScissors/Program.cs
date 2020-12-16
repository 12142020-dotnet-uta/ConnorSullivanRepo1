using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");

            int counter = 0;

            while (true) {
                // show how many rounds have been played
                counter += 1;
                Console.WriteLine($"Round {counter}!");
                // get user response
                Console.WriteLine("Please Enter Your Selection:");
                string userresponse = Console.ReadLine();
                // normalize user response
                string res_lower = userresponse.ToLower();
                Console.WriteLine($"You selected: {res_lower}");
                string[] options = {"rock", "paper", "scissors"};
                // get random selection from program
                Random rnd = new Random();
                int num = rnd.Next(3); 
                string cpuresponse = options[num];
                string[] gameStatus = {res_lower, cpuresponse};
                Console.WriteLine($"CPU selected: {cpuresponse}");
                // check win conditions
                if (res_lower == cpuresponse)
                {
                    Console.WriteLine("Tie Game!!");
                }
                else if ((res_lower == "rock" & cpuresponse == "scissors") || (res_lower == "paper" & cpuresponse == "rock") || (res_lower == "scissors" & cpuresponse == "paper"))
                {
                    Console.WriteLine("You Win!!");
                }
                else {
                    Console.WriteLine("You Lose!!");
                }
            }
        }
    }
}
