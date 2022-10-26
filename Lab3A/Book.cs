using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Book :Media, IEncryptable
    {
        private string Author;
        private string summary;

        public Book(string title, int year, string Author, string summary) : base(title, year)
        {
            this.Author = Author;
            this.summary = summary;
        }

        public string Decrypt()
        {
            throw new NotImplementedException();
        }

        public string Encrypt()
        {
            throw new NotImplementedException();
        }

        public string getAuthor()
        {
            return this.Author;
        }

        public string getsummary()
        {
            return this.summary;
        }


    }
}
