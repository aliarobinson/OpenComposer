using System;

namespace AliaRobinson.OpenComposer.Notes
{
    public class Pitch : IPitch
    {
        private readonly PitchClass pitchClass;
        private readonly int octave;

        public Pitch(PitchClass pitchClass, int octave)
        {
            this.pitchClass = pitchClass;
            this.octave = octave;
        }
        
        public PitchClass GetPitchClass()
        {
            return pitchClass;
        }

        public int GetOctave()
        {
            return octave;
        }

        public double GetFrequency()
        {
            return Math.Pow(2, octave + 1) * pitchClass.GetBaseFrequency();
        }

        public IPitch GetPitchAbove(int numHalfSteps)
        {
            var newPitchId = pitchClass.GetId() + numHalfSteps;
            var newOctave = octave;
            while (newPitchId >= PitchClasses.NumPitchClasses)
            {
                newPitchId -= PitchClasses.NumPitchClasses;
                newOctave++;
            } 
            while (newPitchId < 0)
            {
                newPitchId += PitchClasses.NumPitchClasses;
                newOctave--;
            }
            return new Pitch(PitchClasses.GetPitchClass(newPitchId), newOctave);
        }

        public int CompareTo(IPitch other)
        {
            return GetHashCode() - other.GetHashCode();
        }

        public override bool Equals(object o)
        {
            if (o == null)
                return false;
            IPitch p = o as IPitch;
            if (p == null)
                return false;
            return p.GetOctave() == this.GetOctave() && p.GetPitchClass().Equals(this.pitchClass);
        }

        public override int GetHashCode()
        {
            return octave * PitchClasses.NumPitchClasses + pitchClass.GetId();
        }
    }
}