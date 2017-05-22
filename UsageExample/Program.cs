using System;
using System.Collections.Generic;
using System.Threading;
using AliaRobinson.OpenComposer.Tracks;

namespace UsageExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            var gui = new SimpleGUI();
            Track track1 = new Track();
            var trackSynchronizer = new TrackSynchronizer();
            trackSynchronizer.AddTrack(track1);
            trackSynchronizer.SetBpm(20);
            gui.SetTrackSynchronizer(trackSynchronizer);
            gui.ShowDialog();
        }
    }
}