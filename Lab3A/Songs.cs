﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Songs : Media
    {
        private string Album;
        private string Artist;

        public Songs(string title, int year, string Album, string Artist) : base(title, year)
        {
            this.Album = Album;
            this.Artist = Artist;

        }


        public string getAlbum()
        {
            return this.Album;
        }

        public string getArtist()
        {
            return this.Artist;
        }

    }


}