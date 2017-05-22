namespace AliaRobinson.OpenComposer.Notes
{
    public interface IPitch
    {
        
        PitchClass GetPitchClass();

        int GetOctave();

        double GetFrequency();

    }
}