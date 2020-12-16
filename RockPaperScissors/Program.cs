using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome user and initiate counter variables to track rounds and scores
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            int counter = 0;
            int userWins = 0;
            int cpuWins = 0;
            // Set up game loop to continually run until the user exits the program
            while (true) {
                // get user response
                Console.WriteLine("Please Enter Your Selection (Rock, Paper, or Scissors):");
                string userresponse = Console.ReadLine();
                // normalize user response and validate
                string res_lower = userresponse.ToLower();
                if ((res_lower == "rock" || res_lower == "paper" || res_lower == "scissors"))
                {
                    counter += 1;
                    Console.WriteLine($"You selected: {res_lower}");
                    string[] options = {"rock", "paper", "scissors"};
                    // get random selection from program
                    Random rnd = new Random();
                    int num = rnd.Next(3); 
                    string cpuresponse = options[num];
                    Console.WriteLine($"CPU selected: {cpuresponse}");
                    // check win conditions and show how many rounds have been played and current score
                    if (res_lower == cpuresponse) // tie game
                    {
                        Console.WriteLine($"Round {counter}: Tie Game!!\n################");
                        Console.WriteLine($"Score: \nYou: {userWins}\nCPU: {cpuWins}");
                    }
                    else if ((res_lower == "rock" & cpuresponse == "scissors") || (res_lower == "paper" & cpuresponse == "rock") || (res_lower == "scissors" & cpuresponse == "paper")) // user wins
                    {
                        userWins += 1;
                        Console.WriteLine($"Round {counter}: You Win!!\n################"); // user wins
                        Console.WriteLine($"Score: \nYou: {userWins}\nCPU: {cpuWins}");
                    }
                    else {
                        cpuWins += 1;
                        Console.WriteLine($"Round {counter}: You Lose!!\n################"); // program wins
                        Console.WriteLine($"Score: \nYou: {userWins}\nCPU: {cpuWins}");
                    }
                }
                else {
                    Console.WriteLine($"Please Enter a valid response");
                }
            }
        }
    }
}
