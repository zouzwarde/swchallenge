using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace swlibrary.Utilities
{
    /// <summary>
    /// class related to calculations in the library 
    /// converting consumables to hours and calculating number of stops
    /// </summary>
    public class calculations : Icalculations
    {
        /// <summary>
        /// getting the consumables length in hours 
        /// if unknown or with a unit undefined then will return nothing 
        /// otherwise will get the length of the consumables in hours
        /// </summary>
        /// <param name="strcunsumables">it is the consumables length saved in the ship object</param>
        /// <returns>the number of hours equivalent to the consumable length</returns>
        public decimal getdurabilityofconsumableinhours(string strcunsumables)
        {
            string[] arrconsumables;
            decimal nbhours = 0;
            ///if unknown return 0
            if (strcunsumables == "unknown")
            {
                nbhours = 0;
            }
            else
            {
                ///if it is not unknown then we will split the string in 2 the unit and the value, delimiter ' ' empty space
                ///it will be an array of 2 dimensions the first for the value and the second for the unit
                arrconsumables = strcunsumables.Split(default(Char[]));
                ///getting the value as integer 
                int valueconsumables = Convert.ToInt32(arrconsumables[0]);
                string x;

                ///defining from the unit the number of hours
                switch (arrconsumables[1])
                {
                    case "year": case "years":
                        nbhours = valueconsumables * 8760;
                        break;
                    case "month": case "months":
                        nbhours = valueconsumables * 730;
                        break;
                    case "week": case "weeks":
                        nbhours = valueconsumables * 168;
                        break;
                    case "day": case "days":
                        nbhours = valueconsumables * 24;
                        break;
                    case "hour": case "hours":
                        nbhours = valueconsumables;
                        break;
                }
            }

            return nbhours;
        }

        /// <summary>
        /// this function calculate the number of stops that the consumables of the ship allows to travle
        /// </summary>
        /// <param name="dbldistance">the distance that the user has entered</param>
        /// <param name="strspeed">the speed of the ship</param>
        /// <param name="strconsumables">the consumables of the ship</param>
        /// <returns></returns>
        public int getnumberofstops(decimal dbldistance, string strspeed, string strconsumables)
        {
            int nbstops = 0;
            decimal consumablesduration = 0, speed = 0, duration = 0;

            ///if all parameters are defined then begin calculations else return 0
            if (strspeed != "unknown" && strconsumables != "unknown" && dbldistance > 0)
            {
                ///calculating the length in hours of the consumables
                consumablesduration = getdurabilityofconsumableinhours(strconsumables);
                ///converting speed saved in the object to number
                speed = Convert.ToDecimal(strspeed);
                ///checking that speed is not 0 because we are deviding by the speed
                ///calculating the duration of the travel by deviding the distance by the speed to get the duration in hours
                if (speed != 0)
                {
                    duration = dbldistance / speed;
                }

                ///checking that consumablesduration is not 0 because we are deviding by the consumablesduration
                ///calculating the number of stops by deviding the duration of the travel, in hours, by the length 
                ///in hours of the consumables
                if (consumablesduration != 0)
                {
                    nbstops = Convert.ToInt32(duration / consumablesduration);
                    if (nbstops != 0)
                    {
                        //if duration's division by the number of stops is not 0 means we need an extra stop
                        if (duration % nbstops != 0)
                        {
                            nbstops++;
                        }
                    }
                }

            }

            return nbstops;
        }
    }
}
