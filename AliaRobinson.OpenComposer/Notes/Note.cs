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
            throw new System.NotImplementedException();
        }

        public double GetDuration()
        {
            throw new System.NotImplementedException();
        }
    }
}