// Statement of Authorship: I Ayodeji Eniabire, 000878946 certify that this material is my original work.
// No other person's work has been used without due acknowledgement.
// the arcithecture of ROT13 encryption and decryption algorithm used is refrenced to https://foxlearn.com/windows-forms/encryption-and-decryption-using-rot13-in-csharp-375.html

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3A
{
    /// <summary>
    /// This class extends Abstract class Media and Implements IEncryptable interface 
    /// Contain models to instanciate object of Book and implement functions related to its attribute 
    /// </summary>
    internal class Book :Media, IEncryptable
    {
        private string Author; // Book author
        private string summary; // Book Summary

        /// <summary>
        /// this constructor is to set values for this movie object attributes, parameter tittle ans year are inherited parameters from base class Media
        /// </summary>
        /// <param name="title"> Book title</param>
        /// <param name="year"> Book production year</param>
        /// <param name="director"> Book author </param>
        /// <param name="summary"> Book Summary</param>
        public Book(string title, int year, string Author, string summary) : base(title, year)
        {
            this.Author = Author;
            this.summary = summary;
        }

        /// <summary>
        /// ROT13 decryption algorithm 
        /// </summary>
        /// <returns>string of decrypted data</returns>
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

                this.summary = result.ToString();
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
            foreach (char c in getsummary())
            {
                if (regex.IsMatch(c.ToString()))
                {
                    int code = ((c & 223) - 52) % 26 + (c & 32) + 65;
                    result.Append((char)code);
                }
                else
                    result.Append(c);
                this.summary = (string)result.ToString();
            }
            return result.ToString();
          
        }

        /// <summary>
        /// get data for Book Author parameter 
        /// </summary>
        /// <returns> string data of author parameter</returns>
        public string getAuthor()
        {
            return this.Author;
        }

        /// <summary>
        /// get data for Book summary parameter 
        /// </summary>
        /// <returns> string data of summary parameter</returns>
        public string getsummary()
        {
            return this.summary;
        }

        /// <summary>
        /// format string value of selected parameters for printing
        /// </summary>
        /// <returns>string value of selected parameters </returns>
        public override string ToString()
        {
            return $" \nBook Title: {base.Title} \nYear: {base.Year } \nAuthor: {getAuthor()} ";
        }


    }
}
