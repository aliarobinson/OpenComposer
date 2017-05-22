using System;
using System.Media;

namespace AliaRobinson.OpenComposer.Tracks
{
    public class Track : ITrack
    {
        
        public void EighthBeat()
        {
            Console.WriteLine("EIGHTH");
        }

        public void QuarterBeat()
        {
            Console.WriteLine("QUARTER");
        }

        public void HalfBeat()
        {
            Console.WriteLine("HALF");
        }

        public void Beat()
        {
            Console.WriteLine("BEAT");
        }
    }
}