using AliaRobinson.OpenComposer.Notes;

namespace AliaRobinson.OpenComposer.Tracks
{
    public interface QueueableTrack : ITrack
    {
        void Enqueue(IPitch pitch);
        IPitch Dequeue();
    }
}