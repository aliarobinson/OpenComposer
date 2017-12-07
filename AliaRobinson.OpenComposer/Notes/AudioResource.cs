namespace AliaRobinson.OpenComposer.Notes
{
    /// <summary>
    /// This abstract class handles metadata for an audio resource, such as pitch and audio clip duration.
    /// Extend this class to provide the appropriate audio capabilities for the framework being used
    /// </summary>
    public abstract class AudioResource
    {
        public IPitch Pitch { get; set; }
        public double Duration { get; set; }
    }
}