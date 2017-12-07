using AliaRobinson.OpenComposer.Tracks;

namespace AliaRobinson.OpenComposer.Notes
{
    public interface INote
    {

        IPitch GetPitch();

        double GetDuration();

    }
}