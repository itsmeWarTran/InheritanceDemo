using System;
namespace InheritanceDemos
{
    public class Guitar : MusicalInstrument
    {
        public Guitar()
        {
            PlaysNotes = true;
            PlaysRythem = true;
            IsElectric = false;
            HandHeld = true;
        }

        public int numStrings { get; set; } = 6;
        public string Color { get; set; }
    }
}
