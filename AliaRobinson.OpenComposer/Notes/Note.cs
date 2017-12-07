namespace AliaRobinson.OpenComposer.Notes
{
    public class Note : INote
    {

        private IPitch pitch;
        private double duration;

        public Note(IPitch pitch) : this(pitch, 1)
        {
        }
        
        public Note(IPitch pitch, double duration)
        {
            this.pitch = pitch;
            this.duration = duration;
        }
        
        public IPitch GetPitch()
        {
            return this.pitch;
        }

        public double GetDuration()
        {
            return this.duration;
        }
    }
}