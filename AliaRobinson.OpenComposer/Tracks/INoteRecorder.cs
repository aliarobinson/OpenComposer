using AliaRobinson.OpenComposer.Instruments;
using AliaRobinson.OpenComposer.Notes;

namespace AliaRobinson.OpenComposer.Tracks
{
    public interface INoteRecorder
    {
        void Start();
        void Pause();
        
        void Record(INote note);
        void Record(INote note, IInstrument instrument);
        void Record(Beat beat, IInstrument instrument);
    }

}