using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Movie : Media, IEncryptable
    {

        private string Director;

        private string Summary;
        public Movie(string title, int year, string director, string summary) : base(title, year)
        {
            Director = director;
            Summary = summary;
        }

        public string getDirector()
        {
            return Director;
        }

        public string getSummary()
        {
            return Summary;
        }

        public string getTitle()
        {
            return getTitle();
        }

        public string getYear()
        {
            return getYear();
        }

      

        public string Decrypt()
        {
            StringBuilder result = new StringBuilder();
            Regex regex = new Regex("[A-Za-z]");
            foreach (char c in getSummary())
            {
                if (regex.IsMatch(c.ToString()))
                {
                    int code = ((c & 223) - 52) % 26 + (c & 32) + 65;
                    result.Append((char)code);
                }
                else
                    result.Append(c);
            }
            this.Summary = result.ToString();
            return Summary;
        }

        public string Encrypt()
        {
            StringBuilder result = new StringBuilder();
            Regex regex = new Regex("[A-Za-z]");
            foreach (char c in getSummary())
            {
                if (regex.IsMatch(c.ToString()))
                {
                    int code = ((c & 223) - 52) % 26 + (c & 32) + 65;
                    result.Append((char)code);
                }
                else
                    result.Append(c);
            }
            this.Summary = result.ToString();
            return Summary;
        }

        public override string ToString()
        {
            return $"Book Title: {getTitle() + '\n'}  Year: {getYear() + '\n'} Director: {getDirector() + '\n'}";
        }



    }
}
