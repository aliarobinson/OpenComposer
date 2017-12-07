namespace AliaRobinson.OpenComposer.CompositionSpace
{
    public class Defaults
    {
        public static readonly Scale MAJORSCALE;
        public static readonly Scale MINORSCALE;
        public static readonly Scale PENTATONICMAJORSCALE;
        public static readonly Scale PENTATONICMINORSCALE;
        public static readonly Scale CHROMATICSCALE;
        
        static Defaults()
        {
            PENTATONICMAJORSCALE = new Scale(new int[]{7, 4, 9, 2, 12, -5, -3, 14, 16, -8});
            PENTATONICMAJORSCALE.SetName("Major Pentatonic");
            PENTATONICMINORSCALE = new Scale(new int[]{7, 3, 5, 10, 12, -2, -5, 15, 17});
            PENTATONICMINORSCALE.SetName("Minor Pentatonic");
            MAJORSCALE = new Scale(new int[]{7, 4, 12, 2, 5, 9, 11, -5, -1, 14, 16, -3, 17});
            MAJORSCALE.SetName("Major");
            MINORSCALE = new Scale(new int[]{});
            MINORSCALE.SetName("Minor");
            CHROMATICSCALE = new Scale(new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 
                -1, -2, -3, -4, -5 });
            CHROMATICSCALE.SetName("Chromatic");
        }
    }
}