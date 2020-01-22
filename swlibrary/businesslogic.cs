using swlibrary.Models;
using swlibrary.Utilities;
using System.Linq;

namespace swlibrary
{
    /// <summary>
    /// this is the main class of the library 
    /// where data will be brought from api, calculations will be done and results will be displayed
    /// </summary>
    public class businesslogic : Ibusinesslogic
    {
        Icalculations _calc;
        Idisplay _disp;
        Idatafromapi _dataapi;

        /// <summary>
        /// this the constructor of this object, it will create instance of the other classes 
        /// whenever needed (_disp is the display class whenever we need to write anything in the console 
        /// _calc for calculation whenever we need to make caluclation (consumable duration or number of stops) 
        /// and _dataapi for bringing data from api)
        /// </summary>
        /// <param name="calc">it is the class calculation which is related to calculation</param>
        /// <param name="disp">the class specialized in displaying info</param>
        /// <param name="dataapi">class related to manipulating data from api</param>
        public businesslogic(Icalculations calc, Idisplay disp, Idatafromapi dataapi)
        {
            _calc = calc;
            _disp = disp;
            _dataapi = dataapi;
        }

        /// <summary>
        /// this function will get data from api and then in case there are no results then will return
        /// to the main project that there are nothing to show
        /// </summary>
        /// <param name="distance">the distance the user wishes to travel by starship</param>
        /// <returns>it will return true if all calculations done and displayed or false in case of failure</returns>
        public bool ProcessData(decimal distance)
        {
            ///bringing data from the api
            starships ships = _dataapi.getstarships();
            int nbstops = 0;
            if (ships == null)
            {
                return false;
            }

            ///checking if api has returned results
            if (ships.results.Count() != 0)
            {
                ///looping the startships, calculating the number of stops and displaying the results
                foreach (starship ship in ships.results)
                {
                    ///calculating the number of stops
                    nbstops = _calc.getnumberofstops(distance, ship.MGLT, ship.consumables);
                    if (nbstops != 0)
                    {
                        ///displaying the results
                        _disp.displaylistshipandstop(ship, nbstops);
                    }
                }
            }
            return true;
        }
    }
}
