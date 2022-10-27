using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            StringBuilder result = new StringBuilder();
            Regex regex = new Regex("[A-Za-z]");
            foreach (char c in getsummary())
            {
                if (regex.IsMatch(c.ToString()))
                {
                    int code = ((c & 223) - 52) % 26 + (c & 32) + 65;
                    result.Append((char)code);
                }
                else
                    result.Append(c);
            }
            return result.ToString();
            
        }

        public string Encrypt()
        {
            StringBuilder result = new StringBuilder();
            Regex regex = new Regex("[A-Za-z]");
            foreach (char c in getsummary())
            {
                if (regex.IsMatch(c.ToString()))
                {
                    int code = ((c & 223) - 52) % 26 + (c & 32) + 65;
                    result.Append((char)code);
                }
                else
                    result.Append(c);
            }
            return result.ToString();
          
        }

       
        public string getAuthor()
        {
            return this.Author;
        }

        public string getsummary()
        {
            return this.summary;
        }

       

        public override string ToString()
        {
            return $"Book Title: {base.Title + '\n'}  Year: {base.Year + '\n'} Author: {getAuthor() +'\n'}";
        }


    }
}
