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
    /// class service
    /// </summary>
    internal class Service
    {
        private string type;

        private int serviceRate;

        public Service(string type, int serviceRate)
        {
            this.type = type;
            this.serviceRate = serviceRate;
        }

        /// <summary>
        /// return type of services
        /// </summary>
        /// <returns>type</returns>
        public string getType()
        {
            return type;
        }

        /// <summary>
        /// return service rate 
        /// </summary>
        /// <returns>servicerate</returns>
        public int getServiceRate()
        {
            return serviceRate;
        }

       
    }
}
