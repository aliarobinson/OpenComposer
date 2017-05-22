using System;

namespace AliaRobinson.OpenComposer.Notes
{
    public enum PitchClass
    {
        AFlat,
        A,
        ASharp,
        BFlat,
        B,
        C,
        CSharp,
        DFlat,
        D,
        DSharp,
        EFlat,
        E,
        F,
        FSharp,
        GFlat,
        G,
        GSharp
    }

    public static class PitchClasses
    {

        public static double BaseFrequency(this PitchClass pc)
        {
            switch (pc)
            {
                    case PitchClass.C:
                        return 16.35;
                    case PitchClass.CSharp:
                        return 17.32;
                    case PitchClass.DFlat:
                        return 17.32;
                    case PitchClass.D:
                        return 18.35;
                    case PitchClass.DSharp:
                        return 19.44;
                    case PitchClass.EFlat:
                        return 19.44;
                    case PitchClass.E:
                        return 20.6;
                    case PitchClass.F:
                        return 21.8;
                    case PitchClass.FSharp:
                        return 23.12;
                    case PitchClass.GFlat:
                        return 23.12;
                    case PitchClass.G:
                        return 24.5;
                    case PitchClass.GSharp:
                        return 25.95;
                    case PitchClass.AFlat:
                        return 25.95;
                    case PitchClass.A:
                        return 27.5;
                    case PitchClass.ASharp:
                        return 29.13;
                    case PitchClass.BFlat:
                        return 29.13;
                    case PitchClass.B:
                        return 30.86;
                    default:
                        return 0;
            }
        }
    }

}