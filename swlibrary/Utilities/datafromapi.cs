using Newtonsoft.Json;
using swlibrary.Models;
using System;
using System.Linq;
using System.Net;

namespace swlibrary.Utilities
{
    /// <summary>
    /// class to bring data from api
    /// </summary>
    public class datafromapi : Idatafromapi
    {
        Idisplay _disp;

        /// <summary>
        /// constructor of the class and creation of the instance whenever needed
        /// </summary>
        /// <param name="disp">display class</param>
        public datafromapi(Idisplay disp)
        {
            _disp = disp;
        }

        /// <summary>
        /// getting data from the api
        /// </summary>
        /// <param name="strurl">the url to call the api if empty take the default address else use the url sent</param>
        /// <returns>an object of type starships</returns>
        public starships getstarshipsfromapi(string strurl)
        {
            string strresult;
            starships ships = null;
            using (WebClient client = new WebClient())
            {
                ///using webclient in order to bring data from api, and need the data to be of type JSON 
                client.Headers.Add("Content-Type: application/json");
                client.Headers.Add("Accept: application/json");
                ///if url empty take the default url
                if (strurl == "")
                {
                    strurl = "https://swapi.co/api/starships";
                }
                try
                {
                    ///get data from the api
                    strresult = client.DownloadString(strurl);
                    ///convert JSON data into ojects of type starships
                    ships = JsonConvert.DeserializeObject<starships>(strresult);
                }
                catch (Exception ex)
                {
                    ///if an error or url not valid send back an error message
                    _disp.displaymessage($"Error in Getting data { ex.Message }", "error");
                }
            }
            return ships;
        }

        /// <summary>
        /// get all starships from the api 
        /// </summary>
        /// <returns>an object containing all the ships from api</returns>
        public starships getstarships()
        {
            starships ships, shipsresult;

            ///getting the first page from the api
            ships = getstarshipsfromapi("");

            shipsresult = ships;
            ///if there are any results continue to the other pages 
            if (ships != null)
            {
                ///while there is a url in the next property means there is a data
                while (ships.next != null)
                {
                    ///getting the next page from api
                    ships = getstarshipsfromapi(ships.next);
                    if (ships.results.Count() != 0)
                    {
                        ///adding the new results from the new page to the previously brought data
                        shipsresult.results = shipsresult.results.Concat(ships.results);
                    }
                }
            }

            return shipsresult;
            ;
        }
    }
}
