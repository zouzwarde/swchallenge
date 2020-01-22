using System;
using System.Collections.Generic;
using System.Text;

namespace swlibrary.Models
{
    /// <summary>
    /// a class with the property name that is used by many objects
    /// </summary>
    public class swsinglename: swsingle
    {
        /// <summary>
        /// the property name
        /// </summary>
        public string name { get; set; }
    }
}
