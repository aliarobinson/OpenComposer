using System.Collections;
using System.Collections.Generic;
using AliaRobinson.OpenComposer.Notes;

namespace AliaRobinson.OpenComposer.CompositionSpace
{
    public class CompositionSpace : ICompositionSpace
    {

        private List<PitchClass> availablePitches;

        public CompositionSpace()
        {
            availablePitches = new List<PitchClass>();
        }

        public void AddAvailablePitch(PitchClass pc)
        {
            availablePitches.Add(pc);
        }
        
        public List<PitchClass> GetAvailablePitches()
        {
            return availablePitches;
        }
        
    }
}