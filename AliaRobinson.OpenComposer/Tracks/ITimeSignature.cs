namespace AliaRobinson.OpenComposer.Tracks
{
    public class ITimeSignature
    {
        private int numBeatsPerMeasure;
        private int singleBeatNote;

        public ITimeSignature(int numBeats, int singleBeat)
        {
            numBeatsPerMeasure = numBeats;
            singleBeatNote = singleBeat;
        }

        public int GetNumBeatsPerMeasure()
        {
            return numBeatsPerMeasure;
        }

        public int GetSingleBeatNote()
        {
            return singleBeatNote;
        }
    }
}