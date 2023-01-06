using System;

namespace Assignment_5_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Player[] India = new Player[5]
           {
                new Player("Sachin Tendulkar", 49, 100),
                new Player("Rohit Sharma", 35, 75),
                new Player("Kieron Pollard", 35, 35),
                new Player("Ishan Kishan", 24, 90),
                new Player("Hardik Pandya", 29, 60)
           };

            Team teamList = new Team(India);
            foreach (Player p in teamList)
                Console.WriteLine("Name: {0} Age: {1} Run Scored: {2} ", p.name, p.age, p.runsScored);
        }
    }
}
