using System.Collections.Generic;
using AliaRobinson.OpenComposer.Notes;

namespace AliaRobinson.OpenComposer.CompositionSpace
{
    public interface ICompositionSpace
    {
        List<PitchClass> GetAvailablePitches();
    }
}