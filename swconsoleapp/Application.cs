using swlibrary;
using swlibrary.Utilities;
using System;

namespace swconsoleapp
{
    /// <summary>
    /// the main class in the console app will call the business logic in the library 
    /// and in consequence call the interaction with the user, the appi calling, 
    /// the calculation and the enumeration of the results 
    /// </summary>
    public class Application : IApplication
    {
        Ibusinesslogic _businesslogic;
        Idisplay _disp;

        /// <summary>
        /// constructor of the class
        /// </summary>
        /// <param name="businesslogic">we need to initialise business logic class</param>
        /// <param name="disp">initialising the display class</param>
        public Application(Ibusinesslogic businesslogic, Idisplay disp)
        {
            _businesslogic = businesslogic;
            _disp = disp;
        }

        /// <summary>
        /// processing the data means checking if user has entered -1 
        /// if so then leave else check if number is negative then prompt the user again 
        /// if number is positive then check if the api is valid and returns data then make 
        /// the calculations and display the results, else give an error message and exit
        /// </summary>
        /// <param name="strdist">it is the user input for the distance to travle</param>
        /// <returns>true for success and false for failure</returns>
        public bool applyprocess(string strdist) {
            decimal dbldistance = 0;
            
            if (strdist.Trim() != "-1")
            {
                decimal.TryParse(strdist, out dbldistance);
                if (dbldistance > 0)
                {
                    if (!_businesslogic.ProcessData(dbldistance)) { 
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    _disp.displaymessage("Please enter a positive numeric number!", "info");
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// the function that will lunch the console app
        /// </summary>
        public void Run()
        {
            ///propmt the user to enter a distance that the ships should travel
            _disp.displaymessage("Please enter a positive numeric number! \nif you wish to quit press -1", "info");
            string strdist = "";

            ///repeat this process as long as the apply process returns true (as long the user is not entering -1)
            do {
                _disp.displaymessage("what is the distance you wish to travel?\npress -1 if you wish to quit", "message");
                strdist = _disp.getinputmessage();
            }
            while (this.applyprocess(strdist)); //condition to continue looping 

            //
            Console.ResetColor();
        }
    }
}
