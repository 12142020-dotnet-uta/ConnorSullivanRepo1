using System;

namespace rps_multiple_users
{
    class Program
    {
        // public enum Choices {
        //     Rock,
        //     Paper,
        //     Scissors
        // }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Player p1 = new Player();
            Console.Write(p1.PlayerId);
        }
   
    }
}


