using System;
using System.Collections.Generic;
using AliaRobinson.OpenComposer.Notes;

namespace AliaRobinson.OpenComposer.Instruments
{
    public interface IInstrument
    {
        String GetName();

        IPitch GetLowerBound();

        IPitch GetUpperBound();

        List<IPitch> GetPitches();

    }
}