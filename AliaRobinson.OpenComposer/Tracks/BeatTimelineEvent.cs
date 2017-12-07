using AliaRobinson.OpenComposer.Instruments;
using System;
using System.Collections.Generic;
using System.Text;

namespace AliaRobinson.OpenComposer.Tracks
{
    class BeatTimelineEvent : ITimelineEvent
    {
        Beat _beat { get; set; }
        IInstrument _instrument { get; set; }

        public BeatTimelineEvent(Beat beat, IInstrument instrument)
        {
            _beat = beat;
            _instrument = instrument;
        }
    }
}
