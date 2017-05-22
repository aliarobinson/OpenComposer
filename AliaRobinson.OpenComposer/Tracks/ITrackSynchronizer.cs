namespace AliaRobinson.OpenComposer.Tracks
{
    public interface ITrackSynchronizer
    {
        void Start();
        void Stop();
        void AddTrack(ITrack track);
        void RemoveTrack(ITrack track);
        void SetBpm(int bpm);
    }
}