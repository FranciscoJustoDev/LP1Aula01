using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double xx = 0.12345;
            int ii = 18;
            
            string xstr = $"{xx:f2}";
            string xperc = $"{xx:p1}";
            string ihex = $"{ii:x}";
            string icurr = $"{ii:c}";
            
            Console.WriteLine(xstr);
            Console.WriteLine(xperc);
            Console.WriteLine(ihex);
            Console.WriteLine(icurr);
        }
    }
}