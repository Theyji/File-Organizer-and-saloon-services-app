using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab3A
{
    /// <summary>
    /// this class covers reading of text file and spliting data into arrays and strings 
    /// instantiation of Media objects from read splited data
    /// implementation of various media object functions 
    /// </summary>
    internal class Program
    {
        const string MEDIADATA = "Data.txt"; // assign text file to a variable 

        // create list for each media file type 
        static List<Book> books = new List<Book>(); 
        static List<Movie> movies = new List<Movie>();
        static List<Songs> songs = new List<Songs>();
       
        /// <summary>
        /// Main implementation method 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Theyji's Media Collection" + '\n'); // App introduction Tittle 

            readData(); 

            selectOption();

        }

        /// <summary>
        /// this function read text file
        /// split strings in the text file into arrays and strings 
        /// create media objects (Movies, Books, and Songs) using splited arrays and strings as parameters
        /// append each created object of media to its corresponding list type 
        /// </summary>
        public static void readData()
        {
            StreamReader mediaReader = new StreamReader(MEDIADATA); // instanciate file reader object 

            while (!mediaReader.EndOfStream) // condition to read file 
            {
                string[] firstSplit = mediaReader.ReadLine().Split('|'); // first split function (split first line into arrays 

                if (firstSplit[0] == "BOOK") // logic to select type of Book media
                {
                    string secondSplit = mediaReader.ReadLine(); // second split function (split the next line into string 

                    Book br = new Book(firstSplit[1], int.Parse(firstSplit[2]), firstSplit[3], secondSplit); // instanciate object of book with splited data 

                    books.Add(br); // add newly created object to a corresponding book list 

                }
                else if (firstSplit[0] == "SONG") // logic to select song media
                {
                    Songs sg = new Songs(firstSplit[1], int.Parse(firstSplit[2]), firstSplit[3], firstSplit[4]); // create song object 

                    songs.Add(sg); // add created song object to song list 
                }
                else if (firstSplit[0] == "MOVIE") // logic to select movie media
                {
                    string secondSplit = mediaReader.ReadLine(); // second split to get summary section

                    Movie mv = new Movie(firstSplit[1], int.Parse(firstSplit[2]), firstSplit[3], secondSplit); // create movie object 

                    movies.Add(mv); // add newly created object to movie list 
                }

            }
            mediaReader.Close();

        }
       
        /// <summary>
        /// this method interface with users
        /// prompt user to select options from media menu
        /// implement required method to implement user's choice 
        /// </summary>
        public static void selectOption()
        {
            while (true) // logic for user interaction 
            {
                // print menu 
                Console.WriteLine(" \n 1. List All Books \n\n " +
                    "2. List All Movies\n\n " +
                    "3. List All Songs\n\n " +
                    "4. List All Media\n\n " +
                    "5. Search All Media By Title\n\n " +
                    "6. Exit\n");

                try
                {

                    string pick = Console.ReadLine();  // prompt user to pick from the menu

                    // if statement logic to implement user's pick 
                    if (int.Parse(pick) == 1)
                    {
                        listBooks(); // list all books in media collection 
                    }
                    else if (int.Parse(pick) == 2)
                    {
                        listMovies(); // list all movies in media collection
                    }
                    else if (int.Parse(pick) == 3)
                    {
                        listSongs(); // list all songs in media collection 
                    }
                    else if (int.Parse(pick) == 4)
                    {
                        listMedias(); // list all items in media collection 
                    }
                    else if (int.Parse(pick) == 5)
                    {
                        Console.WriteLine("Enter your search word"); // prompt user to enter search word 
                        string searchWord = Console.ReadLine();
                        searchByTitle(searchWord); // browse through medial collections to match search word with tittles in media collection 
                    }
                    else if (int.Parse(pick) == 6)
                    {
                        break; // exit menu loop
                    }
                    else
                    {
                        Console.WriteLine("invalid input"); // check for invalid input 
                    }
                }
                catch (Exception ex) // check for incorrect input format 
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        /// <summary>
        /// this function print list of books in media collection
        /// </summary>
        public static void listBooks()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine(books[i].ToString());
            }
        }

        /// <summary>
        /// this function print list of movies in media collection 
        /// </summary>
        public static void listMovies()
        {
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine(movies[i].ToString());
            }
        }

        /// <summary>
        /// this function prints list of songs in media collection 
        /// </summary>
        public static void listSongs()
        {
            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine(songs[i].ToString());
            }
        }

        /// <summary>
        /// this function prints all items in media collection 
        /// </summary>
        public static void listMedias()
        {
            listBooks();
            listMovies();
            listSongs();
        }

        /// <summary>
        /// this function takes search word from users and print details of media with matchin tittle 
        /// it implements the decryption method to decrypt summary of books and movies
        /// </summary>
        /// <param name="v"></param>
        public static void searchByTitle(string v)
        {
            for (int i = 0; i < books.Count; i++)
            {
                
                if (books[i].Search(v) == true)
                {
                    books[i].Decrypt();
                    Console.WriteLine(books[i].ToString());
                    Console.WriteLine($"Summary: {books[i].getsummary()}\n");
                }

                if (movies[i].Search(v) == true)
                {
                    movies[i].Decrypt();
                    Console.WriteLine(movies[i].ToString());
                    Console.WriteLine($"Summary: {movies[i].getSummary()}\n");
                }

                if (songs[i].Search(v) == true)
                {
                    Console.WriteLine(songs[i].ToString());

                }
            }
           
          
        }


    }
}
