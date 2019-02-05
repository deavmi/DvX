namespace Dvx.Internals.Memory
{

    using System;

    //A memory map to be passed to the MMU during initialization
    //
    //Please note that this is a fixed memory map and not one to be changed but the standard of the architecture.
    //TODO: decide on these values
    public class MemoryMap
    {

        //Physical memory regions
        private long realFrom, realTo;

        //Memory-mapped I/O regions
        private long mappedFrom, mappedTo;

        //Total size of memory
        private long size;


        //Initialize the memory map
        //
        //Where `realFrom` it the starting address of physical memory and `realTo` is the ending address of physical memory.
        //Where `mappedFrom` is  the starting address of memory-mapped I/O and `mappedTo` is the ending address of memory-mapped I/O
        //Where `size` of the total size of memory.
        public MemoryMap(long realFrom, long realTo, long mappedFrom, long mappedTo, long size)
        {
            //Setup the regions
            this.realFrom = realFrom;
            this.realTo = realTo;
            this.mappedFrom = mappedFrom;
            this.mappedTo = mappedTo;

            //TODO: CHeck that they full within and including `size`
            this.size = size;

            //Output mapping information (ulong cast for String concatenation to interpret the number as unsigned and hence format it as so in the String)
            Console.WriteLine("Real from: \"" +(ulong)realFrom+"\" to \""+(ulong)realTo+"\"");
            Console.WriteLine("Memory-mapped I/O from: \"" +(ulong)mappedFrom+"\" to \""+(ulong)mappedTo+"\"");
            Console.WriteLine("Size: \""+(ulong)size+"\"");
        }

        //TODO: comment
        public long getRealFrom()
        {
            return realFrom;
        }
        
        //TODO: comment
        public long getRealTo()
        {
            return realTo;
        }

        //TODO: comment
        public long getMemoryMappedFrom()
        {
            return mappedFrom;
        }
        
        //TODO: comment
        public long getMemoryMappedTo()
        {
            return mappedTo;
        }

    } 
}