// Statement of Authorship: I Ayodeji Eniabire, 000878946 certify that this material is my original work.
// No other person's work has been used without due acknowledgement.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3B
{
    /// <summary>
    /// Hairdresser class defines models to instatiate hairdressers 
    /// </summary>
    internal class Hairdresser
    {
        private string FirstName;

        private string LastName;

        private int BaseRate;

        public Hairdresser(string firstName, string lastName, int baseRate)
        {
            FirstName = firstName;
            LastName = lastName;
            BaseRate = baseRate;
        }

        /// <summary>
        /// return base price of hairdresser
        /// </summary>
        /// <returns>baserate</returns>
        public int GetBase()
        {
            return BaseRate;
        }

        /// <summary>
        /// return hairdresser first name
        /// </summary>
        /// <returns>firstname</returns>
        public string GetFirstname()
        {
            return FirstName;
        }

        /// <summary>
        /// returns hairdresser lastname
        /// </summary>
        /// <returns>lastname</returns>
        public string GetLasname()
        {
            return LastName;
        }

       
    }


}
