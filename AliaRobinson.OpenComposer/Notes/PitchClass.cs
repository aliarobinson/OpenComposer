
using AliaRobinson.OpenComposer.Utils;

namespace AliaRobinson.OpenComposer.Notes
{
    public class PitchClass : INamed
    {
        // For simplicity, consider equivalent pitch classes to be the same pitch class
        // i.e. one pitch class represents either C sharp or D flat
        
        private int id; // A unique identifier for this pitch class 
        private string name; // Defaults to sharp
        private string alias; // The equivalent flat, if it exists.
        private double baseFrequency; // The basic frequency of this pitch at octave 1

        public PitchClass(int id, double baseFrequency, string name) : this(id, baseFrequency, name, null) {}
        
        public PitchClass(int id, double baseFrequency, string name, string alias)
        {
            this.id = id;
            this.baseFrequency = baseFrequency;
            this.name = name;
            this.alias = alias;
        }

        public int GetId()
        {
            return id;
        }

        public double GetBaseFrequency()
        {
            return baseFrequency;
        }

        public string GetName()
        {
            return name;
        }

        public string GetAlias()
        {
            return alias;
        }

    }

    public static class PitchClasses
    {
        public const int NumPitchClasses = 12;

        public static readonly PitchClass C = new PitchClass(0, 16.35, "C");
        public static readonly PitchClass CSharp = new PitchClass(1, 17.32, "C Sharp", "D Flat");
        public static readonly PitchClass D = new PitchClass(2, 18.35, "D");
        public static readonly PitchClass DSharp = new PitchClass(3, 19.44, "D Sharp", "E Flat");
        public static readonly PitchClass E = new PitchClass(4, 20.6, "E");
        public static readonly PitchClass F = new PitchClass(5, 21.8, "F");
        public static readonly PitchClass FSharp = new PitchClass(6, 23.12, "F Sharp", "G Flat");
        public static readonly PitchClass G = new PitchClass(7, 24.5, "G");
        public static readonly PitchClass GSharp = new PitchClass(8, 25.95, "G Sharp", "A Flat");
        public static readonly PitchClass A = new PitchClass(9, 27.5, "A");
        public static readonly PitchClass ASharp = new PitchClass(10, 29.13, "A Sharp", "B Flat");
        public static readonly PitchClass B = new PitchClass(11, 30.86, "B");
        
        
        private static readonly PitchClass[] AllPitchClasses =
            { C, CSharp, D, DSharp, E, F, FSharp, G, GSharp, A, ASharp, B };

        public static PitchClass GetPitchClass(int id)
        {
            return id >= NumPitchClasses || id < 0 ? null : AllPitchClasses[id];
        }
    }
}