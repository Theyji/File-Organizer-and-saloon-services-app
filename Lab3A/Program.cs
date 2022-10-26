using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Program
    {
        const string MEDIADATA = "Data.txt";

       static List<Media> medias = new List<Media>();
        static List<Book> books = new List<Book>();
        static List<Media> movies = new List<Media>();
        static List<Songs> songs = new List<Songs>();
        static List<string> summary = new List<string>();

       


        static void Main(string[] args)
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

            Console.WriteLine(songs.Count);
            Console.WriteLine(books.Count);
            Console.WriteLine(movies.Count);
            Console.WriteLine(books[7].getsummary());
           

        }
    }
}
