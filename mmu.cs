namespace Dvx.Internals.Memory
{

    using System;

    //The memory management unit of the machine.
    //
    //All memory accesses are done through here.
    public class MMU
    {
        
        //TODO: Decide on a memory map (change these values too)
        public static MemoryMap standardMap = new MemoryMap(0,0,0,0,0);//TODO: change these values (as stated above)

        //The MMU's memory map which is used during memory accesses (read or write)
        private MemoryMap memoryMap;

        //The Phyiscal memory chip
        private MemoryChip memoryChip;

        //Initialize the MMU with the given MemoryMap
        public MMU(MemoryMap memoryMap)
        {
            //Set the MMU's memory map
            this.memoryMap = memoryMap;

            //Now initialize the memory system
            initialize();
        }

        //Initialize the memory
        private void initialize()
        {
            //Setup the physical memory
            setupPhysicalMemory();
        }

        private void setupPhysicalMemory()
        {
            //The size of the physical memory is determined by `realTo-realFrom+1` (+1 because it is inclusive of the `realTo` address)
            long realFrom = memoryMap.getRealFrom();
            long realTo = memoryMap.getRealTo();

            //TODO: Make sure I do the right finding the difference here



            //Create a new physical memory chip
            MemoryChip memoryChip = new MemoryChip();
        }

    }  



    
}