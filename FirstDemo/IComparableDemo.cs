using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class Players : IComparable<Players>
    {
        private string name;
        private int runs;
        public Players(string name, int runs)
        {
            this.name = name;
            this.runs = runs;
        }

        public int CompareTo(Players? other) // other = rohit
        {
            // this.runs --> virat >rohit
            if (this.runs > other.runs)
            {
                return 1;
            }
            else if (this.runs < other.runs)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"name= {name}, runs ={runs}";
        }
    }

    public class Team1 : IEnumerable
    {
        private Players[] players;
        public Team1()
        {
            players = new Players[3];
            players[0] = new Players("Virat", 3000);
            players[1] = new Players("Rohit", 2500);
            players[2] = new Players("Dhoni", 2800);
        }
        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();// GetEnumerator() for typecasting
        }
    }

    public class IComparableDemo
    {
        public static void Main(string[] args)
        {
            Team1 ind = new Team1();

            foreach (Players p in ind)
            {
                Console.WriteLine(p);
            }

            Players virat = new Players("Virat", 3500);
            Players rohit = new Players("Rohit", 3500);

            int result = virat.CompareTo(rohit);
            if (result == 1)
            {
                Console.WriteLine("Virat has more runs than rohit");
            }
            else if (result == -1)
            {
                Console.WriteLine("virat has less runs than rohit");
            }
            else
            {
                Console.WriteLine("both have equal runs");
            }

        }
    }
}
