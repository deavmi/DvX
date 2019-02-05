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

    //Instruction set

    //The RegisterSet of the CPU defining all registers
    public class RegisterSet
    {
        //General purpose registers (1 byte)
        sbyte a = 0,b = 0,c = 0,d = 0,e = 0,f = 0,g = 0,h = 0;

        //General purpose registers (2 bytes)
        short ae = 0,be = 0,ce = 0,de = 0,ee = 0,fe = 0,ge = 0,he = 0;

        //General purpose registers (4 bytes)
        int aex = 0,bex = 0,cex = 0,dex = 0,eex = 0,fex = 0,gex = 0,hex = 0;

        //General purpose registers (8 bytes)
        long raex = 0,rbex = 0,rcex = 0,rdex = 0,reex = 0,rfex = 0,rgex = 0,rhex = 0;


        //Status registers
        //
        //These are registers which either change the state of the machine or indicate the current state of it.

        //Instruction Pointer - holds the address of the start of the instruction to be executed
        long ip; //TODO: This value should be set to the place whereby the BIOS is mapped in (to be decided)

        //Interrupt register - if `0` then there is no interrupt, else [1,255] indiccate an interrupt with a given interrupt-ID
        sbyte interrupt;

        //Interrupt handler register - address of the beginning of the interrupt handler table
        long interruptHandler;

        //Initialize a new register set with the initial starting address for the instruction pointer
        public RegisterSet(long initInstructionAddress)
        {
            //TODO: Initialize all registers here
        }


        //Return the value in the interrupt register
        public sbyte getInterruptRegister()
        {
            return interrupt;
        }


        //Return the address of the current instruction to be executed (ulong for fun) //Ex: Undo maybe for cleanliness
        public ulong getIP()
        {
            return (ulong)ip;
        }


    }

}