using System;
using System.Collections.Generic;
using System.Text;

namespace swlibrary.Models
{
    /// <summary>
    /// the class of the set of starships
    /// </summary>
    public class starships
    {
        /// <summary>
        /// number of objects in the set
        /// </summary>
        public int count { get; set; }

        /// <summary>
        /// the next page of the set
        /// </summary>
        public string next { get; set; }

        /// <summary>
        /// the previous page of the set
        /// </summary>
        public string previous { get; set; }
        /// <summary>
        /// a list of starships
        /// </summary>
        public IEnumerable<starship> results { get; set; }
    }
}
