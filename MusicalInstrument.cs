using System;
namespace InheritanceDemos
{
    public class MusicalInstrument
    {
        public MusicalInstrument()
        {
        }

        public string Brand { get; set; }
        public bool PlaysNotes { get; set; }
        public bool PlaysRythem { get; set; }
        public bool IsElectric { get; set; }
        public bool HandHeld { get; set; }

        public void PrintStats()
        {
            Console.WriteLine("The brand is " + Brand);
            Console.WriteLine("Plays Notes: " + PlaysNotes);
            Console.WriteLine("Plays Rythem: " + PlaysRythem);
            Console.WriteLine("Is Electric: " + IsElectric);
            Console.WriteLine("Hand Held: " + HandHeld);
            
        }

    }
}
