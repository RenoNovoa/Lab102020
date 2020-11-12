using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace ChallengeObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application !");
            //
            //Console.ReadKey()
            //string strCategory = Console.ReadLine();
            do
            {

                //string Drama = "1";
                //string Scifi = "2"; 
                //string Horror ="3";
                //string Animate ="4";

                Console.Write(" Select a category of movies in the fallowing  list in \n 1 : Drama \n " + "2 : Scifi\n " + "3 : Animate\n" + " 4 : Horror\n Enter your choice:" );
                
                string strInput = Console.ReadLine();
                // private static List<Movie> MoviesoftheDay()
                {
                    List<Movie> theGener = new List<Movie>();
                    theGener.Add(new Movie("Drama", "freddie mercury"));
                    theGener.Add(new Movie("Drama", "freddie mercury"));
                    theGener.Add(new Movie("Scifi", "Back To The Future."));
                    theGener.Add(new Movie("Scifi", "Blade Runner."));
                    theGener.Add(new Movie("Horror", "A Quiet Place"));
                    theGener.Add(new Movie("Horror", "Paranormal Activity"));
                    theGener.Add(new Movie("Animated", "Nightmare Before Christmas"));
                    theGener.Add(new Movie("Animate", "Chicken Run"));
                    theGener.Add(new Movie("Horror", "chucky "));
                    theGener.Add(new Movie("Drama", "Black Panther"));
                    //return theGener;
                    foreach (Movie TheLoop in theGener)
                    {
                        if (TheLoop.GetGener() == strInput)
                        {
                      

                            Console.WriteLine(TheLoop.GetTitle());
                        }
                    }
                    Console.WriteLine("Do you want to coontinu(Y/N)");
                    string response = Console.ReadLine();
                    if (response == "Y" || response == "y")
                    {
                        Console.WriteLine("What Category are you interest in? "); ;
                    }
                    else
                    {
                        Console.WriteLine("Adios Amigoooo! ");
                        break;
                    }
                }
            } while (true);
            Console.ReadKey();
        }



        public class Movie
        {
            public Movie(string theGener, string theTitle )
            {
                _theGener = theGener;
                _theTitle = theTitle;
               
            }

            private string _theTitle;
         
            public string GetTitle()
            {
                return _theTitle;
            }

            private string _theGener;
            public string GetGener()
            {
                return _theGener;
            }
            

        }
    }
}