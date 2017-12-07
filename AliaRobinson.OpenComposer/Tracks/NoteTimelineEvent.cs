using AliaRobinson.OpenComposer.Instruments;
using AliaRobinson.OpenComposer.Notes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AliaRobinson.OpenComposer.Tracks
{
    class NoteTimelineEvent : ITimelineEvent
    {
        INote _note { get; set; }
        IInstrument _instrument { get; set; }

        public NoteTimelineEvent(INote note, IInstrument inst)
        {
            _note = note;
            _instrument = inst;
        }
    }
}
