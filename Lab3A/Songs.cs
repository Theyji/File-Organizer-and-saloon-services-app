// Statement of Authorship: I Ayodeji Eniabire, 000878946 certify that this material is my original work.
// No other person's work has been used without due acknowledgement.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    /// <summary>
    /// This class extends abstract class Media 
    /// contains models to instantiate objects of songs and implement fuctions related to its attributes 
    /// </summary>
    internal class Songs : Media
    {
        private string Album; // song album name 
        private string Artist; // song artist 

        /// <summary>
        /// this constructor is to set values for this movie object attributes, parameter tittle ans year are inherited parameters from base class Media
        /// </summary>
        /// <param name="title">song's title</param>
        /// <param name="year">song's year of production</param>
        /// <param name="Album">album name</param>
        /// <param name="Artist">Artist name</param>
        public Songs(string title, int year, string Album, string Artist) : base(title, year)
        {
            this.Album = Album;
            this.Artist = Artist;

        }

        /// <summary>
        ///  Get data for song album parameter 
        /// </summary>
        /// <returns>string data of album parameter</returns>
        public string getAlbum()
        {
            return this.Album;
        }

        /// <summary>
        /// get data for song's artist 
        /// </summary>
        /// <returns>string data of artist parameter</returns>
        public string getArtist()
        {
            return this.Artist;
        }

        /// <summary>
        /// format string value of selected parameters for printing
        /// </summary>
        /// <returns>string value of selected parameters </returns>
        public override string ToString()
        {
            return $" \nSong Title: {base.Title} \nYear: {base.Year} \nAlbum: {getAlbum()} \nArtist: {getArtist()}";
        }

    }


}
