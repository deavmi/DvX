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

            //TODO: check for an interrupt if any
            Console.WriteLine("Checking the interrupt status register...");

            //If there is an interrupt
            if(isInterrupted())
            {
                //The interrupt ID
                sbyte interruptID = registerSet.getInterruptRegister();

                //Passing it will extend it with sign extension from [11111111] (255) for example to [11111111 11111111 11111111 11111111]
                Console.WriteLine("Interrupt detected with ID: \"" + Utils.getUnsignedAddressFormatStringByte(interruptID)+"\"");

                //TODO: continue here
            }
            //If there is no interrupt
            else
            {
                Console.WriteLine("No interrupt");
            }

            //TODO: add if statement and interrupt check
            
            //TODO: add interrupt return and save before (nah done by user)
            //TODO: (This is how I think it should be done) The user should save the current IP and then do the interrupt, then `iret` (part of the interrupt handler's code) with arg of register
        }

        private bool isInterrupted()
        {
            bool isInterrupted = false;

            //Check if the value in the interrupt status register is `0`

            //Status will be sign extended, in this case [00000000 00000000 00000000 00000000] which does equal [00000000 00000000 00000000 00000000]
            if(registerSet.getInterruptRegister() == 0)
            {
                //Then there is no interrupt
                isInterrupted = false;
            }
            //If it is anything else then it is an interrupt
            //Status register would have been sign extended already to (for example 255) [11111111]
            //[11111111 11111111 11111111 11111111] which does not equal [00000000 00000000 00000000 00000000]
            else
            {
                //Else, then there is an interrupt
                isInterrupted = true;
            }

            return isInterrupted;
        }

        
    }

    

}