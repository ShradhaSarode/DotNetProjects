using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class Player1
    {
        private string name;
        private int runs;

        public int Runs
        {
            get { return runs; }
        }
        public Player1(string name, int runs)
        {
            this.name = name;
            this.runs = runs;
        }
        public override string ToString()
        {
            return $"name= {name}, runs ={runs}";
        }
    }



    public class PlayerCompare : IComparer<Player1>
    {
        // x-> virat , y-> rohit
        public int Compare(Player1? x, Player1? y)
        {
            if (x.Runs > y.Runs)
            {
                return 1;
            }
            else if (x.Runs < y.Runs)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    public class IComparerDemo
    {
        public static void Main(string[] args)
        {
            Player1 virat = new Player1("Virat", 3500);
            Player1 rohit = new Player1("Rohit", 4500);

            PlayerCompare obj = new PlayerCompare();

            int result = obj.Compare(virat, rohit);
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
