using System.Collections.Generic;
using System.Threading;
using AliaRobinson.OpenComposer.Notes;

namespace AliaRobinson.OpenComposer.CompositionSpace
{
    public class Scale : IScale
    {
        private int[] prioritizedIntervals;
        
        public Scale(int[] prioritizedIntervals)
        {
            this.prioritizedIntervals = prioritizedIntervals;
        }

        public List<IPitch> getPitches(IPitch tonic)
        {
            return getPitches(tonic, prioritizedIntervals.Length);
        }

        public List<IPitch> getPitches(IPitch tonic, int numPitches)
        {
            List<IPitch> pitches = new List<IPitch>();
            if (numPitches == 0)
                return pitches;
            pitches.Add(tonic);
            for (int i = 0; i < prioritizedIntervals.Length && i + 1 < numPitches; i++)
            {
                pitches.Add(tonic.GetPitchAbove(prioritizedIntervals[i]));
            }
            pitches.Sort();
            return pitches;
        }
    }

}