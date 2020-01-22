using System;
using System.Collections.Generic;
using System.Text;

namespace swlibrary.Models
{
    /// <summary>
    /// a class used by most of the objects
    /// </summary>
    public class swsingle
    {
        /// <summary>
        /// date of creation of the object
        /// </summary>
        public DateTime created { get; set; }

        /// <summary>
        /// date last edited of the object
        /// </summary>
        public DateTime edited { get; set; }

        /// <summary>
        /// the url to get this object
        /// </summary>
        public string url { get; set; }
}
}
