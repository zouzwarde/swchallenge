using System;
using System.Collections.Generic;
using System.Text;

namespace swlibrary.Models
{
    /// <summary>
    /// the class of the set of starships
    /// </summary>
    public class starships: swset
    {
        /// <summary>
        /// a list of starships
        /// </summary>
        public IEnumerable<starship> results { get; set; }
    }
}
