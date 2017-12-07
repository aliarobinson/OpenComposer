using System;
using System.Collections.Generic;

namespace AliaRobinson.OpenComposer.Tracks
{
    [Serializable]
    public class Timeline 
    {
        private long _startTime;
        private long _pauseTime;
        private long _totalTimeInactive;

        private bool _isRecording;

        private List<TimelineEntry> _recordedEvents;

        public void Start()
        {
            if (_startTime == 0)
            {
                _startTime = DateTime.Now.Millisecond;
            }
            if (_recordedEvents == null)
            {
                _recordedEvents = new List<TimelineEntry>();
            }
            _totalTimeInactive += GetCurrentAdjustedTime() - _pauseTime;
            _isRecording = true;

        }

        public void Pause()
        {
            _pauseTime = GetCurrentAdjustedTime();
            _isRecording = false;
        }

        public void Record(ITimelineEvent timelineEvent)
        {
            if (_isRecording)
            {
                var entry = new TimelineEntry
                {
                    RecordTime = GetCurrentAdjustedTime(),
                    TimelineEvent = timelineEvent
                };
                _recordedEvents.Add(entry);
            }
        }

        private long GetAdjustedTime(long absoluteMilliseconds)
        {
            return absoluteMilliseconds - _totalTimeInactive - _startTime;
        }

        private long GetCurrentAdjustedTime()
        {
            return GetAdjustedTime(DateTime.Now.Millisecond);
        }
    }
}