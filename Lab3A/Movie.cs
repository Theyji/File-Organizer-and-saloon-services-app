// Statement of Authorship: I Ayodeji Eniabire, 000878946 certify that this material is my original work.
// No other person's work has been used without due acknowledgement.
// the arcithecture of ROT13 encryption and decryption algorithm used is refrenced to https://foxlearn.com/windows-forms/encryption-and-decryption-using-rot13-in-csharp-375.html

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab3A
{
    /// <summary>
    /// This class extends Abstract class Media and Implements IEncryptable interface 
    /// Contain models to instanciate object of Movie and implement functions related to its attribute 
    /// </summary>
    internal class Movie : Media, IEncryptable
    {

        private string Director; // Director of the movie

        private string Summary; // movie Summary


        /// <summary>
        /// this constructor is to set values for this movie object attributes, parameter tittle ans year are inherited parameters from base class Media
        /// </summary>
        /// <param name="title"> Movie title</param>
        /// <param name="year"> Movie production year</param>
        /// <param name="director"> Movie director </param>
        /// <param name="summary"> Movie Summary</param>
        public Movie(string title, int year, string director, string summary) : base(title, year)
        {
            Director = director;
            Summary = summary;
        }

        /// <summary>
        /// Get data for movie director parameter 
        /// </summary>
        /// <returns> string data of director parameter </returns>
        public string getDirector()
        {
            return Director;
        }

        /// <summary>
        /// get data for movie summary parameter 
        /// </summary>
        /// <returns> string data of summary parameter</returns>
        public string getSummary()
        {
            return Summary;
        }

        /// <summary>
        /// ROT13 decryption algorithm 
        /// </summary>
        /// <returns>string of decrypted data</returns>
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
                this.Summary = result.ToString();
            }
            return result.ToString();
            
        }

        /// <summary>
        /// ROT13 Encryption algorithm 
        /// </summary>
        /// <returns>string of decrypted data</returns>
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
                this.Summary = result.ToString();
            }
            return result.ToString();
            
        }
        /// <summary>
        /// format string value of selected parameters for printing
        /// </summary>
        /// <returns>string value of selected parameters </returns>
        public override string ToString()
        {
            return $" \nMovie Title: {base.Title} \nYear: {base.Year} \nDirector: {getDirector()}";
        }

    }
}
