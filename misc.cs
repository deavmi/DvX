namespace Dvx.Misc
{
    public sealed class Utils
    {
        public static string getUnsignedAddressFormatString(long address)
        {
            //Treat it as an unsigned long so that the data gets interpreted as an unsigned long and hence will be formatted as 0 to 2^64-1
            //in the returned string
            return ""+(ulong)address;
        }
    }
}