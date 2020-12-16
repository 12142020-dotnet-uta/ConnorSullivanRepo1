using System;
using System.Collections.Generic;

namespace RPS_Group_assn
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                Console.WriteLine("\nWelcome to the Rock-Paper-Scissors Game");
                Console.WriteLine("Type \"stop\" if you want to stop.");
                Console.WriteLine("Please choose an option by typing a number: \n\t1. Rock\n\t2. Paper\n\t3. Scissors");
                Console.WriteLine("Type your answer here: ");
                string userResponse = Console.ReadLine().ToLower();
                if(userResponse=="stop"){
                    break;
                }
                if(userResponse=="1"||userResponse=="2"||userResponse=="3"){
                    Dictionary<int,string> answers = new Dictionary<int,string>();
                    //rock beats scissors
                    answers.Add(1,"3");
                    //paper beats rock
                    answers.Add(2,"1");
                    //scissors beats paper
                    answers.Add(3,"2");
                    Random rand = new Random();
                    int computerChoice = rand.Next(3)+1;
                    string response = "The computer chose ";
                    if(userResponse==computerChoice.ToString()){
                        Console.WriteLine("\nResult: You tied!");
                    }
                    else if(answers[computerChoice]==userResponse){
                        switch (computerChoice){
                            case 1: response+="Rock and you picked Scissors, so you lost...";
                            break;
                            case 2: response+="Paper and you picked Rock, so you lost...";
                            break;
                            case 3: response+="Scissors and you picked Paper, so you lost...";
                            break;
                        }
                        Console.WriteLine(response);
                        Console.WriteLine("\nResult: You fool! The computer won!\n");
                    }
                    else{
                        switch (computerChoice){
                            case 1: response+="Rock and you picked Paper, so you won!";
                            break;
                            case 2: response+="Paper and you picked Scissors, so you won!";
                            break;
                            case 3: response+="Scissors and you picked Rock, so you won!";
                            break;
                        }
                        Console.WriteLine(response);
                        Console.WriteLine("\nResult: Good job! You won!\n");
                    }
                }
                else{
                    Console.WriteLine("Ummm, try again...\n\n");
                }
            }
        }

    }

}

