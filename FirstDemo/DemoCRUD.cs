using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double TicketCost { get; set; }
        public string ProducerName { get; set; }

        public Movie(int id, string name, double ticketCost, string producerName)
        {
            Id = id;
            Name = name;
            TicketCost = ticketCost;
            ProducerName = producerName;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Ticket Cost: {TicketCost:C}, Producer Name: {ProducerName}";
        }
    }
    public class OperationCRUD
    {
       public void addMovie()
        {

        }
    }
    public class DemoCRUD
    {
        public static void Main(string[] args)
        {
            // Create an array to store movies
            const int maxMovies = 10;
            Movie[] movies = new Movie[maxMovies];
            int movieCount = 0;

            // Insert movies
            InsertMovie(movies, ref movieCount, new Movie(1, "Inception", 10.99, "Christopher Nolan"));
            InsertMovie(movies, ref movieCount, new Movie(2, "The Shawshank Redemption", 9.99, "Frank Darabont"));
            InsertMovie(movies, ref movieCount, new Movie(3, "Inception", 10.99, "Christopher Nolan"));
            InsertMovie(movies, ref movieCount, new Movie(4, "The Shawshank Redemption", 9.99, "Frank Darabont"));
            InsertMovie(movies, ref movieCount, new Movie(5, "Inception", 10.99, "Christopher Nolan"));
            InsertMovie(movies, ref movieCount, new Movie(6, "The Shawshank Redemption", 9.99, "Frank Darabont"));
            InsertMovie(movies, ref movieCount, new Movie(7, "Inception", 10.99, "Christopher Nolan"));
            InsertMovie(movies, ref movieCount, new Movie(8, "The Shawshank Redemption", 9.99, "Frank Darabont"));

            // Display all movies
            Console.WriteLine("All Movies:");
            DisplayAllMovies(movies, movieCount);

            // Update a movie
            UpdateMovie(movies, movieCount, 1, new Movie(1, "Inception (Director's Cut)", 14.99, "Christopher Nolan"));

            // Display a movie by ID
            Console.WriteLine("\nMovie with ID 1:");
            DisplayMovieById(movies, movieCount, 1);

            // Delete a movie
            DeleteMovie(movies, ref movieCount, 2);

            // Display all movies after deletion
            Console.WriteLine("\nAll Movies after deletion:");
            DisplayAllMovies(movies, movieCount);
        }

        static void InsertMovie(Movie[] movies, ref int movieCount, Movie newMovie)
        {
            if (movieCount < movies.Length)
            {
                movies[movieCount++] = newMovie;
                Console.WriteLine($"Movie inserted successfully: {newMovie}");
            }
            else
            {
                Console.WriteLine("Movie database is full. Unable to insert.");
            }
        }

        static void UpdateMovie(Movie[] movies, int movieCount, int id, Movie updatedMovie)
        {
            for (int i = 0; i < movieCount; i++)
            {
                if (movies[i].Id == id)
                {
                    movies[i] = updatedMovie;
                    Console.WriteLine($"Movie updated successfully: {updatedMovie}");
                    return;
                }
            }
            Console.WriteLine("Movie not found.");
        }

        static void DeleteMovie(Movie[] movies, ref int movieCount, int id)
        {
            for (int i = 0; i < movieCount; i++)
            {
                if (movies[i].Id == id)
                {
                    // Shift elements to the left to remove the movie
                    for (int j = i; j < movieCount - 1; j++)
                    {
                        movies[j] = movies[j + 1];
                    }
                    movieCount--;
                    Console.WriteLine($"Movie with ID {id} deleted successfully.");
                    return;
                }
            }
            Console.WriteLine("Movie not found.");
        }

        static void DisplayMovieById(Movie[] movies, int movieCount, int id)
        {
            for (int i = 0; i < movieCount; i++)
            {
                if (movies[i].Id == id)
                {
                    Console.WriteLine(movies[i]);
                    return;
                }
            }
            Console.WriteLine("Movie not found.");
        }

        static void DisplayAllMovies(Movie[] movies, int movieCount)
        {
            if (movieCount == 0)
            {
                Console.WriteLine("No movies in the database.");
                return;
            }
            for (int i = 0; i < movieCount; i++)
            {
                Console.WriteLine(movies[i]);
            }
        }

    }
}

