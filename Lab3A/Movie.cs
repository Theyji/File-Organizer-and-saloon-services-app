using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Movie : Media ,IEncryptable
    {
        private string Director;
        private string Summary;

        public Movie(string title, int year, string Director, string Summary) : base(title, year)
        {
            this.Director = Director;
            this.Summary = Summary; 
        }

        public string getDirector()
        {
            return this.Director;
        }

        public string getSummary()
        {
            return this.Summary;
        }

        public string Decrypt()
        {
            throw new NotImplementedException();
        }


        public string Encrypt()
        {
            throw new NotImplementedException();
        }
    }
}
