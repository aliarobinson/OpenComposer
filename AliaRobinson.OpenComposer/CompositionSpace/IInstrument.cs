using System;
using System.Collections.Generic;
using AliaRobinson.OpenComposer.Notes;
using AliaRobinson.OpenComposer.Utils;

namespace AliaRobinson.OpenComposer.Instruments
{
    public interface IInstrument : INamed
    {
        String GetName();

        IPitch GetLowerBound();

        IPitch GetUpperBound();

        List<IPitch> GetPitches();

    }
}