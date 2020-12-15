using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine("Please Enter Your Selection:");
            string response = Console.ReadLine();
            string res_lower = response.ToLower();
            Console.WriteLine($"You selected: {res_lower}");
            string[] options = {"rock", "paper", "scissors"};
            Random rnd = new Random();
            int num = rnd.Next(3); 
            string cpuresponse = options[num];
            Console.WriteLine($"CPU selected: {cpuresponse}");
        }
    }
}
