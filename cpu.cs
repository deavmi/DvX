namespace Dvx.Internals.Processor
{

    using System;

    using Dvx.Internals.Memory;
    using Dvx.Misc;

    //The processor of the machine
    public class CPU
    {

        //The register set for this CPU
        private RegisterSet registerSet;

        //The CPU's MMU
        private MMU mmu;

        //Initialize a new CPU
        public CPU()
        {
            //Create a new MMU
            mmu = new MMU(MMU.standardMap);

            //TODO: add other initialization
        }

        //Start the processor
        public void start()
        {
            Console.WriteLine("Starting CPU cycle...");

            //Do CPU cycles (TODO: ending condition)
            while(true)
            {
                //Do a cycle
                Console.WriteLine("Cycle begin");
                cycle();
                Console.WriteLine("Cycle end");
            }
        }

        //A CPU cycle
        private void cycle()
        {
            //TODO: add cycle code here

            //Fetch the instruction at the current `ip`
            long instructionPointer = (long)(ulong)registerSet.getIP();
            Console.WriteLine("Fetching instruction at address \"" +Utils.getUnsignedAddressFormatString(instructionPointer)+"\"");

            //TODO: Get first byte as op code and then get instruction back
            //TODO: then determine the correct instruction oibject and make one of that type
            //TODO: then get length to read, pass array of bytes to instruction for it to execute whatever it wants then on the CPU

            

            //TODO: add more
        }

        //TODO: check for an interrupt if any
    }

    

}