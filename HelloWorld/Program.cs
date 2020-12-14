using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This Batch will be Revature A-Team.");
            Console.WriteLine("###########################\n###########################\n###########################\n###########################\n###########################");
            Console.WriteLine("Please Enter a Word");
            string response = Console.ReadLine();
            int len = response.Length;
            Console.WriteLine($"Your response was '{response}'");
            Console.WriteLine($"Your response was '{len}' characters long");
            // Print every character line by line
            for (int i = 0; i < len; i++) 
                if (Char.ToString(response[i]) == " ")
                {
                    Console.WriteLine($"{i + 1}: Empty Space Entered");
                }
                else
                {
                    Console.WriteLine($"{i + 1}: {response[i]}");
                };
            
        }
    }
}
