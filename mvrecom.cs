using System;
using System.Collections.Generic;

class MovieRecommendationSystem
{
    // Movie class to hold the movie details
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Mood { get; set; }
        public double Rating { get; set; }

        public Movie(string title, string genre, string mood, double rating)
        {
            Title = title;
            Genre = genre;
            Mood = mood;
            Rating = rating;
        }
    }

    static void Main(string[] args)
    {
        // Predefined movie list
        List<Movie> movieList = new List<Movie>
        {
            new Movie("Inception", "Sci-Fi", "Exciting", 8.8),
            new Movie("The Shawshank Redemption", "Drama", "Reflective", 9.3),
            new Movie("The Dark Knight", "Action", "Thrilling", 9.0),
            new Movie("Forrest Gump", "Drama", "Heartwarming", 8.8),
            new Movie("The Avengers", "Action", "Exciting", 8.1),
            new Movie("Toy Story", "Animation", "Lighthearted", 8.3)
        };

        // Asking user for their mood
        Console.WriteLine("Welcome to the Movie Recommendation System!");
        Console.WriteLine("Please enter your mood (e.g., Exciting, Reflective, Heartwarming, Thrilling, Lighthearted):");
        string userMood = Console.ReadLine();

        // Asking user for their preferred genre
        Console.WriteLine("Please enter your preferred genre (e.g., Action, Drama, Sci-Fi, Animation):");
        string userGenre = Console.ReadLine();

        // Finding matching movies based on user inputs
        List<Movie> recommendedMovies = new List<Movie>();

        foreach (var movie in movieList)
        {
            if (movie.Mood.Equals(userMood, StringComparison.OrdinalIgnoreCase) &&
                movie.Genre.Equals(userGenre, StringComparison.OrdinalIgnoreCase))
            {
                recommendedMovies.Add(movie);
            }
        }

        // Displaying the recommended movies
        if (recommendedMovies.Count > 0)
        {
            Console.WriteLine("\nRecommended Movies based on your mood and genre preference:");
            foreach (var movie in recommendedMovies)
            {
                Console.WriteLine($"- {movie.Title} (Genre: {movie.Genre}, Rating: {movie.Rating}/10)");
            }
        }
        else
        {
            Console.WriteLine("\nSorry, no movies found matching your mood and genre preferences.");
        }
    }
}
