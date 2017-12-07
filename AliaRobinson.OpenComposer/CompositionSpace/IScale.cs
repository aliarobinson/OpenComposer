using System.Collections.Generic;
using AliaRobinson.OpenComposer.Notes;
using AliaRobinson.OpenComposer.Utils;

namespace AliaRobinson.OpenComposer.CompositionSpace
{
    public interface IScale : INamed
    {
        List<IPitch> getPitches(IPitch tonic);

        List<IPitch> getPitches(IPitch tonic, int numPitches);
    }
}