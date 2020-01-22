using swlibrary.Models;

namespace swlibrary.Utilities
{
    /// <summary>
    /// it is the interface on which the class datafromapi is based 
    /// get data from the api
    /// </summary>
    public interface Idatafromapi
    {
        starships getstarships();
        starships getstarshipsfromapi(string strurl);
    }
}