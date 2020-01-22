namespace swlibrary
{
    /// <summary>
    /// this interface is the main element in this library, it will be the backbone of the class business class 
    /// where data will be brought from api, calculations will be done and results will be displayed
    /// </summary>
    public interface Ibusinesslogic
    {
        /// <summary>
        /// this function gets the distance to be travelled and then make the necessary proccessing for the data
        /// from api, calculate the number of stops and display them
        /// </summary>
        /// <param name="distance">the distance to be travelled entered by the user</param>
        /// <returns>return boolean value indicating that all process has passed successfully or no</returns>
        bool ProcessData(decimal distance);
    }
}