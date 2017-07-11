using System.Collections.Generic;
using AliaRobinson.OpenComposer.Instruments;
using AliaRobinson.OpenComposer.Notes;

namespace AliaRobinson.OpenComposer.CompositionSpace
{
    public interface ICompositionSpace
    {

        int GetMaxPitches();

        Scale GetMasterScale();

        List<IInstrument> GetAvailableInstruments();
    }
}