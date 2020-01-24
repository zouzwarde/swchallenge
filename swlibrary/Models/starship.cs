using System;

namespace swlibrary.Models
{
    /// <summary>
    /// the object of the starship
    /// </summary>
    public class starship
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

        /// <summary>
        /// the class of the starship
        /// </summary>
        public string starship_class { get; set; }

        /// <summary>
        /// the hyperdrive rating
        /// </summary>
        public string hyperdrive_rating { get; set; }

        /// <summary>
        /// the speed of the starship in MGLT
        /// </summary>
        public string MGLT { get; set; }

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

        /// <summary>
        /// the property name
        /// </summary>
        public string name { get; set; }
    }
}
