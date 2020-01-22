using swlibrary.Models;

namespace swlibrary.Utilities
{
    /// <summary>
    /// it is the skeletton of the display class 
    /// we have three functions: display a message, display list of ships and get user input
    /// </summary>
    public interface Idisplay
    {
        void displaymessage(string strmessage, string strColor);

        void displaylistshipandstop(starship ship, int nbstops);

        string getinputmessage();
    }
}