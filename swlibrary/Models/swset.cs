using System;

namespace swlibrary
{
    /// <summary>
    /// a set of objects class
    /// </summary>
    public class swset
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
    }
}
