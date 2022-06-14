using System;

namespace InheritanceDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            var acostic = new Guitar();
            acostic.Brand = "acostic";
            acostic.numStrings = 12;
            acostic.PrintStats();

            Console.WriteLine("");

            var electric = new Guitar();
            electric.Brand = "electric";
            electric.IsElectric = true;
            electric.Color = "Blue";
            electric.PrintStats();

        }
    }
}
