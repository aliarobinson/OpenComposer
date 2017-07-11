using System;
using System.Collections.Generic;
using AliaRobinson.OpenComposer.Notes;

namespace AliaRobinson.OpenComposer.Instruments
{
    public class Instrument : IInstrument
    {
        //TODO Store a reference to an audio resource
        private String name;
        private IPitch lowerBound;
        private IPitch upperBound;
        private List<IPitch> pitches;
        
        public Instrument(String name)
        {
            this.name = name;
            pitches = new List<IPitch>();
        }
        
        public string GetName()
        {
            return name;
        }

        public IPitch GetLowerBound()
        {
            return lowerBound;
        }

        public IPitch GetUpperBound()
        {
            return upperBound;
        }

        public List<IPitch> GetPitches()
        {
            return pitches;
        }

        public void AddPitch(IPitch pitch)
        {
            pitches.Add(pitch);
        }

        public void SetLowerBound(IPitch lowerBound)
        {
            this.lowerBound = lowerBound;
        }

        public void SetUpperBound(IPitch upperBound)
        {
            this.upperBound = upperBound;
        }
    }
}