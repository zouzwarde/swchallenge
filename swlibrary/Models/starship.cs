namespace swlibrary.Models
{
    /// <summary>
    /// the object of the starship
    /// </summary>
    public class starship: vehiculeship
    {
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
    }
}
