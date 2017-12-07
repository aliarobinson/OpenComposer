namespace AliaRobinson.OpenComposer.Tracks
{
    public class TimeSignature
    {
        private int numBeatsPerMeasure;
        private int singleBeatNote;

        public TimeSignature(int numBeats, int singleBeat)
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