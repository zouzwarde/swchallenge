using System;
using System.Collections.Generic;
using System.Text;

namespace swlibrary.Models
{
    /// <summary>
    /// this class in common between vehicule and ship
    /// </summary>
    public class vehiculeship : swsinglename
    {
        /// <summary>
        /// the model of the ship or vehicule
        /// </summary>
        public string model { get; set; }

        /// <summary>
        /// the manufacturer of the ship or the vehicule
        /// </summary>
        public string manufacturer { get; set; }

        /// <summary>
        /// the length of the ship or the vehicule
        /// </summary>
        public string length { get; set; }

        /// <summary>
        /// the cost in credits of the ship or the vehicule
        /// </summary>
        public string cost_in_credits { get; set; }

        /// <summary>
        /// the number of the crew of the ship or the vehicule
        /// </summary>
        public string crew { get; set; }

        /// <summary>
        /// the number of passengers of the ship or the vehicule
        /// </summary>
        public string passengers { get; set; }

        /// <summary>
        /// the max atmosphering speed of the ship or the vehicule
        /// </summary>
        public string max_atmosphering_speed { get; set; }

        /// <summary>
        /// the cargo capacity of the ship or the vehicule
        /// </summary>
        public string cargo_capacity { get; set; }

        /// <summary>
        /// the consumables of the ship or the vehicule
        /// </summary>
        public string consumables { get; set; }

    }
}
