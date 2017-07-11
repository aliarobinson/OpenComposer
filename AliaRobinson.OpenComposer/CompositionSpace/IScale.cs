using System.Collections.Generic;
using AliaRobinson.OpenComposer.Notes;

namespace AliaRobinson.OpenComposer.CompositionSpace
{
    public interface IScale
    {
        List<IPitch> getPitches(IPitch tonic);

        List<IPitch> getPitches(IPitch tonic, int numPitches);
    }
}