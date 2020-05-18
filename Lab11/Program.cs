using System;

namespace lab11
{
    class Program
    {
        public static void Main(string[] args)
        {
            var appName = "Movie app";
            var MovieList = List<Movie>();

            {

                MovieList.Add(new Movie("Toy story", Category.animated));
                MovieList.Add(new Movie("Incredibles", Category.animated));
                MovieList.Add(new Movie("The invisible man", Category.horror));
                MovieList.Add(new Movie("Fantacy island", Category.horror));
                MovieList.Add(new Movie("Little women", Category.drama));
                MovieList.Add(new Movie("Spotlight", Category.drama));
                MovieList.Add(new Movie("Joker", Category.drama));
                MovieList.Add(new Movie("Star wars", Category.scifi));
                MovieList.Add(new Movie("Avengers", Category.scifi));
                MovieList.Add(new Movie("venom", Category.scifi));

                Console.WriteLine($"Thank you for joining {appName}, there are 10 movies in this list");

                do
                {
                    Category movieType;

                    bool valid;
                    do
                    {
                        Console.WriteLine($"What category are you interested in? \nPlease pick from: \n(1) {Category.animated}, \n(2) {Category.horror}, \n(3) {Category.drama}, \n(4) {Category.scifi}");
                        valid = Category.TryParse(Console.ReadLine(), out movieType);
                    } while (!valid);
                    Console.WriteLine($"\nHere are the {movieType} of movies we have");
                    foreach (var movie in MovieList)
                    {
                        if (movie.GetCategory() == movieType)
                            Console.WriteLine(movie.GetTitle());
                    }
                    Console.WriteLine("Would you like to continue? y/n");
                } while (Console.ReadLine() == "y");


            }
        }
    }
}
