using System;

namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc 
    {
        public CD(string name, int capacity, string discType) : base(name, capacity, discType)
        {}

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public void SpinDisc()
        {
           Console.WriteLine("The disc is spinning now...."); 
        }
        public void ReadDisc()
        {
            Console.WriteLine("Let's play some tunes.");
        }
    }
}

