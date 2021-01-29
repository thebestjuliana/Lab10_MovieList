using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab10_MovieList
{
    /// <summary>
    /// /Juliana Sheehan 
    /// Date 1/28/2021
    /// The Application stores a list of 10 movies and displays them by category
    /// the user can enter any of the following categories to display the films in the list that match the category: animated, drama, horror, scifi
    /// after the list is displayed, the user is asked if he or she wants to continue. If no, the program ends
    /// 
    /// each Movie should be represented by an opbject type of Movie
    /// The Movie class must provide 2 private fields; title and category and the properties that go with them
    /// the class should also provide a constructor that accepts a title and category as parameters and uses the values passes to initialize its fields
    /// when the user enters a category, the program should read through all of the movies in the List and display a line for any movies whose category matches the catefory entered by the user. 
    /// validate input, don't accept blanks for any of the questions. 
    /// 
    /// Standardize the category codes by displaying a menu of categories and having the user select by number rather than entering the name
    /// Display the movies for the selected catefory in alphabetical order
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> Movie = new List<Movie>();
            Movie.Add(new Movie("Toy Story", "Animated"));
            Movie.Add(new Movie("Lion King", "Animated"));
            Movie.Add(new Movie("Cinderella", "Animated"));
            Movie.Add(new Movie("Dunkirk", "Drama"));
            Movie.Add(new Movie("The Irishman", "Drama"));
            Movie.Add(new Movie("Selma", "Drama"));
            Movie.Add(new Movie("American Psycho", "Horror"));
            Movie.Add(new Movie("The Ring", "Horror"));
            Movie.Add(new Movie("A Nightmare on Elm Street", "Horror"));
            Movie.Add(new Movie("The Fifth Element", "SciFi"));
            Movie.Add(new Movie("Planet of the Apes", "SciFi"));
            Movie.Add(new Movie("Men in Black", "SciFi"));
            Movie.Add(new Movie("Godzilla", "SciFi"));

            Movie.Sort((x, y) => x.title.CompareTo(y.title));
            

            Console.WriteLine("Welcome to the Movie List Application");
            bool running = true;
            while (running == true)
            {
               
                Console.WriteLine("Which category are you interested in? (1-4)");
                Console.WriteLine("1) Animated");
                Console.WriteLine("2) Drama");
                Console.WriteLine("3) Horror");
                Console.WriteLine("4) SciFi");

                

                int userChoice = WhichCategoryValidation();
                Console.WriteLine("Here are some movies you might be interested in:");
                if (userChoice == 1)
                {

                    foreach (Movie m in Movie)
                    {
                        
                        if (m.category == "Animated")
                        {
                            Console.WriteLine(m.title);
                        }
                    }
                }
                else if (userChoice == 2)
                {
                    foreach (Movie m in Movie)
                    {
                        if (m.category == "Drama")
                        {
                            Console.WriteLine(m.title);
                        }
                    }
                }
                else if (userChoice == 3)
                {
                    foreach (Movie m in Movie)
                    {
                        if (m.category == "Horror")
                        {
                            Console.WriteLine(m.title);
                        }
                    }
                }
                else if (userChoice == 4)
                {
                    foreach (Movie m in Movie)
                    {
                        if (m.category == "SciFi")
                        {
                            Console.WriteLine(m.title);
                        }
                    }
                }
                bool validAnswer = false;
                //ask if they want to know about another student
                while (validAnswer == false)
                {
                    Console.WriteLine("Are you interested in another category? (y/n)");

                    try
                    {
                        string answer = Console.ReadLine();
                        if (answer == "y")
                        {
                            validAnswer = true;
                        }
                        else if (answer == "n")
                        {
                            Console.WriteLine("goodbye!");
                            running = false;
                            break;
                        }
                        else
                        {
                            throw new Exception("Invalid response.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Would you like to know about another student? y/n");
                        continue;
                    }
                }

            }

        }
        public static int WhichCategoryValidation()
        {
            while (true)
            {
                string userInput = Console.ReadLine();
                int categoryNumber;
                bool inputIsNumber = int.TryParse(userInput, out categoryNumber);
                bool inputGreaterThanCategories = categoryNumber > 4 || categoryNumber < 1;

                try
                {
                    if (inputIsNumber && inputGreaterThanCategories)
                    {
                        throw new Exception("Index Out of Range");

                    }
                    if (inputIsNumber)

                    {
                        return categoryNumber;
                    }
                    else
                    {
                        throw new Exception("Invalid input");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine($"Lets's try again");
                    Console.WriteLine("Which category are you interested in? (1-4)");
                    Console.WriteLine("1) Animated");
                    Console.WriteLine("2) Drama");
                    Console.WriteLine("3) Horror");
                    Console.WriteLine("4) SciFi");
                    continue;
                }

            }

        }
    }
}
