using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents on person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The first name of the person.
        /// </summary>
        public string FirstName { get; set; }

        // The last name of the person.
        public string LastName { get; set; }

        /// <summary>
        /// The primary email address of the person.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The primary cell phone number of the person.
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
