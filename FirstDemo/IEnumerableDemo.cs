using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class Player
    {
        private string name;
        private int runs;

        public Player(string name, int runs)
        {
            this.name = name;
            this.runs = runs;
        }

        public override string? ToString()
        {
            return $"Player Name: {name} , Runs: {runs}";
        }
    }
    public class Team : IEnumerable
    {
        private Player[] players;

        public Team()
        {
            players = new Player[3];
            players[0] = new Player("Virat", 3000);
            players[1] = new Player("Rohit", 2300);
            players[2] = new Player("Dhoni", 3800);
        }

        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }
    public class IEnumerableDemo
    {
        public static void Main(string[] args)
        {
            Team ind = new Team();
            foreach(Player p in ind)
            {
                Console.WriteLine(p);
            }
        }
    }
}
