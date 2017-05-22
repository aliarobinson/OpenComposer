using System;
using System.Collections.Generic;

namespace AliaRobinson.OpenComposer.Tracks
{
    public class TrackSet : ITrack
    {

        private List<ITrack> tracks;

        public TrackSet()
        {
            tracks = new List<ITrack>();
        }

        public void AddTrack(ITrack track)
        {
            tracks.Add(track);
        }

        public void RemoveTrack(ITrack track)
        {
            tracks.Remove(track);
        }
        
        public void EighthBeat()
        {
            tracks.ForEach(tr=>tr.EighthBeat());
        }

        public void QuarterBeat()
        {
            tracks.ForEach(tr=>tr.QuarterBeat());
        }

        public void HalfBeat()
        {
            tracks.ForEach(tr=>tr.HalfBeat());
        }

        public void Beat()
        {
            tracks.ForEach(tr=>tr.Beat());
        }

    }
}