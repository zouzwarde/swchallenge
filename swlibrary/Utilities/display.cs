using swlibrary.Models;
using System;

namespace swlibrary.Utilities
{
    /// <summary>
    /// this is the class display which is the interaction with the user
    /// we can display a message, listing of the ships and getting input from user
    /// </summary>
    public class display : Idisplay
    {
        /// <summary>
        /// function that displays messages on the console, and will color it according to the type of message
        /// </summary>
        /// <param name="strmessage">string that is the message or text to be printed in the console</param>
        /// <param name="strColor">the type of the message(string), red if error, green if success</param>
        public void displaymessage(string strmessage, string strColor)
        {
            switch (strColor)
            {
                case "message":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "error":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "success":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "info":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ResetColor();
                    break;
            }
            Console.WriteLine(strmessage);
        }

        /// <summary>
        /// getting input from the user, whatever the user needs to enter
        /// </summary>
        /// <returns>the return is a string that the user has written on the screen</returns>
        public string getinputmessage()
        {
            string strmessage = Console.ReadLine();
            return strmessage;
        }

        /// <summary>
        /// this function will display, in case calculation has brought any data, 
        /// the ship name and number of stops 
        /// </summary>
        /// <param name="ship">an object of starship that contain all data about the starship</param>
        /// <param name="nbstops">the number of stops as integer</param>
        public void displaylistshipandstop(starship ship, int nbstops)
        {
            displaymessage($"ship \"{ ship.name }\" needs { nbstops } stops to complete its journey;", "success");
        }
    }
}
