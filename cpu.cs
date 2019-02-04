namespace Dvx.Internals.Processor
{

    using Dvx.Internals.Memory;

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
    }

    //Instruction set

    //The RegisterSet of the CPU defining all registers
    public class RegisterSet
    {
        //General purpose registers (1 byte)
        sbyte a=0,b=0,c=0,d=0,e=0,f=0,g=0,h = 0;

        //General purpose registers (2 bytes)
        short ae=0,be=0,ce=0,de=0,ee=0,fe=0,ge=0,he=0;

        //General purpose registers (4 bytes)
        int aex=0,bex=0,cex=0,dex=0,eex=0,fex=0,gex=0,hex=0;

        //General purpose registers (8 bytes)
        long raex=0,rbex=0,rcex=0,rdex=0,reex=0,rfex=0,rgex=0,rhex=0;


        //Status registers
        //
        //These are registers which either change the state of the machine or indicate the current state of it.

        //Instruction Pointer - holds the address of the start of the instruction to be executed
        long ip; //TODO: This value should be set to the place whereby the BIOS is mapped in (to be decided)

        //Initialize a new register set
        public RegisterSet()
        {
            //TODO: Initialize all registers here
        }



    }

}