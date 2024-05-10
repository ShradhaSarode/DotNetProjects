using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class Movie1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double TicketCost { get; set; }
        public string ProducerName { get; set; }
    }

    public class MovieCRUD
    {
       
        static Movie1[] movies = new Movie1[10];
        static int movieCount = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Insert Movie");
                Console.WriteLine("2. Update Movie");
                Console.WriteLine("3. Delete Movie");
                Console.WriteLine("4. Display All Movies");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        InsertMovie();
                        break;
                    case 2:
                        UpdateMovie();
                        break;
                    case 3:
                        DeleteMovie();
                        break;
                    case 4:
                        DisplayMovies();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        static void InsertMovie()
        {
            if (movieCount < movies.Length)
            {
                Movie1 movie = new Movie1();
                Console.Write("Enter Movie Id: ");
                movie.Id = int.Parse(Console.ReadLine());
                Console.Write("Enter Movie Name: ");
                movie.Name = Console.ReadLine();
                Console.Write("Enter Ticket Cost: ");
                movie.TicketCost = double.Parse(Console.ReadLine());
                Console.Write("Enter Producer Name: ");
                movie.ProducerName = Console.ReadLine();

                movies[movieCount++] = movie;
                Console.WriteLine("Movie inserted successfully!");
            }
            else
            {
                Console.WriteLine("Cannot insert. Movie array is full.");
            }
        }

        static void UpdateMovie()
        {
            Console.Write("Enter Movie Id to update: ");
            int id = int.Parse(Console.ReadLine());
            int index = Array.FindIndex(movies, m => m != null && m.Id == id);
            if (index != -1)
            {
                Console.Write("Enter Updated Movie Name: ");
                movies[index].Name = Console.ReadLine();
                Console.Write("Enter Updated Ticket Cost: ");
                movies[index].TicketCost = double.Parse(Console.ReadLine());
                Console.Write("Enter Updated Producer Name: ");
                movies[index].ProducerName = Console.ReadLine();
                Console.WriteLine("Movie updated successfully!");
            }
            else
            {
                Console.WriteLine("Movie not found!");
            }
        }

        static void DeleteMovie()
        {
            Console.Write("Enter Movie Id to delete: ");
            int id = int.Parse(Console.ReadLine());
            int index = Array.FindIndex(movies, m => m != null && m.Id == id);
            if (index != -1)
            {
                for (int i = index; i < movieCount - 1; i++)
                {
                    movies[i] = movies[i + 1];
                }
                movies[movieCount - 1] = null;
                movieCount--;
                Console.WriteLine("Movie deleted successfully!");
            }
            else
            {
                Console.WriteLine("Movie not found!");
            }
        }

        static void DisplayMovies()
        {
            Console.WriteLine("Movie Details:");
            Console.WriteLine("ID\tName\tTicket Cost\tProducer Name");
            foreach (var movie in movies)
            {
                if (movie != null)
                {
                    Console.WriteLine($"{movie.Id}\t{movie.Name}\t{movie.TicketCost}\t{movie.ProducerName}");
                }
            }
        }
    }
}
