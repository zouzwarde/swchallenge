namespace swconsoleapp
{
    /// <summary>
    /// the application interface 
    /// </summary>
    public interface IApplication
    {
        /// <summary>
        /// the function that will lunch the console app
        /// </summary>
        void Run();

        /// <summary>
        /// this function will call the functionnality of the software
        /// calling the api, calculate and listing of data
        /// </summary>
        /// <param name="strdist"></param>
        /// <returns>returns true if everything went fine otherwise false</returns>
        bool applyprocess(string strdist);
    }
}