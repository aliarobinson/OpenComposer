using AliaRobinson.OpenComposer.Instruments;
using AliaRobinson.OpenComposer.Notes;

namespace AliaRobinson.OpenComposer.Tracks
{
    public class NoteRecorder : INoteRecorder
    {
        private Timeline timeline = new Timeline();
        private IInstrument defaultInstrument;

        public void Start()
        {
            timeline.Start();
        }

        public void Pause()
        {
            timeline.Pause();
        }

        public void Record(INote note)
        {
            timeline.Record(new NoteTimelineEvent(note, defaultInstrument));
        }

        public void Record(INote note, IInstrument instrument)
        {
            timeline.Record(new NoteTimelineEvent(note, instrument));
        }

        public void Record(Beat beat, IInstrument instrument)
        {
            timeline.Record(new BeatTimelineEvent(beat, instrument));
        }
    }
}