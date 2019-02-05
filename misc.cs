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


    
        public static string getUnsignedAddressFormatStringByte(long address)
        {
            //Get the lowest 8 bits
            sbyte theByte = (sbyte)address;

            //Retur a string that treats the byte as unsigned and hence formats the number as an unsigned number in the returned string
            return ""+(byte)theByte;
        }
    }
}