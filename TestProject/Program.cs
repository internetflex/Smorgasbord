using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = "C 13.01 (CR SEC) (CR SEC) Credit risk: Securitisations";
            var result = x.Contains("(CR SEC) Credit Risk: Securitisations", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
