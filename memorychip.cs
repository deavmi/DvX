namespace Dvx.Internals.Memory
{

    using System;

    //Physical Memory
    //
    //The physical memory of the machine.
    public class MemoryChip
    {

        //The actual memory
        private sbyte[] memory;

        //Initialize a new memory chip with the requested memory size as specified by `memorySize`.
        //The argument `memorySize` goes from 0 to 2^64-1.

        //TODO: Array access DotNet
        public MemoryChip(long memorySize)
        {
            Console.WriteLine("Initializing memory chip with ...");
            memory = new sbyte[memorySize]; //Initialize a new array of bytes with the size of `memorySize`.
                                            //Array size is interpreted as unsigned as it only makes sense for a size of an array to be interpreted as such
            Console.WriteLine("Memory chip initialized");
        }

        //Read a byte at a given address
        public sbyte getByte(long address)
        {
            //(ulong) type cast is just so that DotNet will format the number as an unsigned interpretation and not a signed interpretation
            Console.WriteLine("Accessing byte at address \""+(ulong)address+"\"...");

            //(byte) so that DotNet interprets the byte as an unsigned byte when doing string concatenation and number representation as a string
            Console.WriteLine("Byte at that address is \""+(byte)memory[address]+"\"");

            //Return the byte at the given address (Array index is interpreted as unsigned as it only makes sense to access into an array as such)
            return memory[address];
        }

        //Write a byte at a certain address
        public void writeByte(sbyte writeByte, long address)
        {
            //Write the byte `writeByte` at address `address`
            memory[address] = writeByte;
        }
    }
}