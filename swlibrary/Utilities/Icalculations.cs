namespace swlibrary.Utilities
{
    /// <summary>
    /// this interface is the base for the calculations in the library 
    /// it will convert the ship consumables length to hours and calculate the number of stops
    /// </summary>
    public interface Icalculations
    {
        decimal getdurabilityofconsumableinhours(string strcunsumables);
        int getnumberofstops(decimal dbldistance, string strspeed, string strconsumables);
    }
}