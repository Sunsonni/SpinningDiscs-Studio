using System;

namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public DVD(string name, int capacity, string discType) : base(name, capacity, discType)
        {
        }
        public void SpinDisc()
        {
           Console.WriteLine("The disc is spinning now...."); 
        }
        public void ReadDisc()
        {
            Console.WriteLine("Let's watch a movie");
        }
    }
}

