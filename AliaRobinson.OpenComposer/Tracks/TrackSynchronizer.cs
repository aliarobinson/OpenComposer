using System;
using System.Collections.Generic;
using System.Timers;

namespace AliaRobinson.OpenComposer.Tracks
{
    public class TrackSynchronizer : ITrackSynchronizer
    {

        private TrackSet trackSet;
        private int bpm;
        private bool isPlaying;
        private Timer timer;

        private double smallestBeatInterval;
        private int beatCounter;
        
        private const int SmallestBeatDivision = 8;

        public TrackSynchronizer()
        {
            trackSet = new TrackSet();
            isPlaying = false;
            SetBpm(60);
        }
        
        public void Start()
        {
            beatCounter = 0;
            isPlaying = true;
            timer = new Timer();
            timer.Elapsed += new ElapsedEventHandler(ShortestBeat);
            timer.Interval = smallestBeatInterval;
            timer.Start();
        }

        public void Stop()
        {
            isPlaying = false;
            timer.Stop();
        }

        public void AddTrack(ITrack track)
        {
            if (isPlaying)
            {
                throw new InvalidOperationException("Cannot add tracks during play.");
            }
            else
            {
                trackSet.AddTrack(track);
            }
        }
        
        public void RemoveTrack(ITrack track)
        {
            if (isPlaying)
            {
                throw new InvalidOperationException("Cannot remove tracks during play.");
            }
            else
            {
                trackSet.RemoveTrack(track);
            }
        }

        public void SetBpm(int bpm)
        {
            this.bpm = bpm;

            var beatsPerMillisecond = bpm / 60000d;
            smallestBeatInterval = (1.0 / beatsPerMillisecond) / SmallestBeatDivision;
        }

        void ShortestBeat(object obj, ElapsedEventArgs args)
        {
                       
            if (++beatCounter >= SmallestBeatDivision)
            {
                beatCounter = 0;
                trackSet.Beat();
                return;
            }

            int fractionBeat = SmallestBeatDivision / 2;
            if (beatCounter == fractionBeat)
            {
                trackSet.HalfBeat();
                return;
            }

            fractionBeat /= 2;
            
            if (beatCounter % 4 == fractionBeat)
            {
                trackSet.QuarterBeat();
                return;
            }

            trackSet.EighthBeat();

        }
        
        
    }
}