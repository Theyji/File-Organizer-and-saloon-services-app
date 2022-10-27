using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Program
    {
        const string MEDIADATA = "Data.txt";

        static List<Media> medias = new List<Media>();
        static List<Book> books = new List<Book>();
        static List<Movie> movies = new List<Movie>();
        static List<Songs> songs = new List<Songs>();
       


        static void Main(string[] args)
        {
            Console.WriteLine("Theyji's Media Collection" + '\n');

            readData();

           listSongs();

         
        }

        public static void readData()
        {
            StreamReader mediaReader = new StreamReader(MEDIADATA);

            while (!mediaReader.EndOfStream)
            {
                string[] firstSplit = mediaReader.ReadLine().Split('|');
                if (firstSplit[0] == "BOOK")
                {

                    string secondSplit = mediaReader.ReadLine();


                    Book br = new Book(firstSplit[1], int.Parse(firstSplit[2]), firstSplit[3], secondSplit);

                    books.Add(br);

                }
                
                else if (firstSplit[0] == "SONG")
                {
                    Songs sg = new Songs(firstSplit[1], int.Parse(firstSplit[2]), firstSplit[3], firstSplit[4]);

                    songs.Add(sg);
                }
                else if (firstSplit[0] == "MOVIE")
                {
                    string secondSplit = mediaReader.ReadLine();
                    Movie mv = new Movie(firstSplit[1], int.Parse(firstSplit[2]), firstSplit[3], secondSplit);

                    movies.Add(mv);
                }

            }
            mediaReader.Close();

        }
       


        public static void selectOption()
        {
            while (true)
            {
                // print sort menu 
                Console.WriteLine(" 1. List All Books \n\n " +
                    " 2. List All Movies\n\n " +
                    " 3. List All Songs\n\n " +
                    " 4. List All Media\n\n " +
                    " 5. Search All Media By Title\n\n " +
                    " 6. Exit\n");

                string pick = Console.ReadLine();  // prompt user to pick from the menu

                // if statement logic to call required sort method 
                if (int.Parse(pick) == 1)
                {
                    listBooks();
                }
                else if (int.Parse(pick) == 2)
                {
                   listMovies();
                }
                else if (int.Parse(pick) == 3)
                {
                    listSongs();
                }
                else if (int.Parse(pick) == 4)
                {
                    listMedias();
                }
                else if (int.Parse(pick) == 5)
                {
                    
                }
                else if (int.Parse(pick) == 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Sort Option Input\n");
                }
            }
        }

        public static void listBooks()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine(books[i].ToString());
            }
        }

        public static void listMovies()
        {
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine(movies[i].ToString());
            }
        }

        public static void listSongs()
        {
            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine(songs[i].ToString());
            }
        }

        public static void listMedias()
        {
            listBooks();
            listMovies();
            listSongs();
        }


        public static void searchByTitle(string v)
        {

            for (int i = 0; i < books.Count; i++)
            {

                if (books[i].Search(v) == true)
                {
                    books[i].Decrypt();
                    medias.Add(books[i]);
                }

                if (songs[i].Search(v) == true)
                {
                    medias.Add(songs[i]);
                }

                if (movies[i].Search(v) == true)
                {
                    movies[i].Decrypt();
                    medias.Add(movies[i]);
                }
            }
        }


    }
}
