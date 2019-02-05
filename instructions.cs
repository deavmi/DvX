namespace Dvx.Internals.Processor.Instructions
{
    //TODO: make abstract
    public class Instruction
    {
        //The OP code of the instruction
        private sbyte opCode;

        //The arguments to the instruction
        private sbyte[] arguments;

        //The length of the instruction excluding the op code (so argument length)
        private sbyte argumentLength;

        public Instruction(sbyte opCode, sbyte[] arguments, sbyte argumentLength)
        {
            //Setup the instruction's information
            this.opCode = opCode;
            this.arguments = arguments;
            this.argumentLength = argumentLength;
        }
    }


    /*
     * Halt (OP Code: 0)
     *
     * Halts the machine.
     */
    public sealed class Int_Halt : Instruction
    {
        public Int_Halt() //: Instruction(0,null,0)
        {
            //this(0,null,0);//calling this I can';t remember
        }
    }

}