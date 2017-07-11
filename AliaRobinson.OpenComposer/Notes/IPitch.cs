using System;

namespace AliaRobinson.OpenComposer.Notes
{
    public interface IPitch : IComparable<IPitch>
    {
        
        PitchClass GetPitchClass();

        int GetOctave();

        double GetFrequency();

        IPitch GetPitchAbove(int numHalfSteps);

    }
}