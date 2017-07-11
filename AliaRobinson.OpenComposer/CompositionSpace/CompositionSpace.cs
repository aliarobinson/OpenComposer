using System.Collections;
using System.Collections.Generic;
using AliaRobinson.OpenComposer.Instruments;
using AliaRobinson.OpenComposer.Notes;

namespace AliaRobinson.OpenComposer.CompositionSpace
{
    public class CompositionSpace : ICompositionSpace
    {

        private int maxPitches;
        private Scale masterScale;
        private List<IInstrument> availableInstruments;
        
        public CompositionSpace()
        {
            availableInstruments = new List<IInstrument>();
        }

        public void AddAvailableInstrument(IInstrument instrument)
        {
            availableInstruments.Add(instrument);
        }

        public int GetMaxPitches()
        {
            return maxPitches;
        }

        public Scale GetMasterScale()
        {
            return masterScale;
        }

        public List<IInstrument> GetAvailableInstruments()
        {
            return availableInstruments;
        }
        
    }
}