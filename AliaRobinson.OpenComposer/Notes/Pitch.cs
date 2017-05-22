using System;

namespace AliaRobinson.OpenComposer.Notes
{
    public class Pitch : IPitch
    {
        private PitchClass pitchClass;
        private int octave;

        public Pitch(PitchClass pc, int octave)
        {
            this.pitchClass = pc;
            this.octave = octave;
        }
        
        public PitchClass GetPitchClass()
        {
            return this.pitchClass;
        }

        public int GetOctave()
        {
            return this.octave;
        }

        public double GetFrequency()
        {
            int exponent = octave + 1;
            double baseFrequency = PitchClasses.BaseFrequency(pitchClass);
            return Math.Pow(2, exponent) * baseFrequency;
        }
    }
}