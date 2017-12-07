using AliaRobinson.OpenComposer.Notes;

namespace AliaRobinson.OpenComposer.Tracks
{
    public class TimelineEntry
    {
        public long RecordTime { get; set; }
        public ITimelineEvent TimelineEvent { get; set; }
       
    }
}