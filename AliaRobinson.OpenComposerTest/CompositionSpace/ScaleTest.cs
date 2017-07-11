using System.Collections.Generic;
using AliaRobinson.OpenComposer.CompositionSpace;
using AliaRobinson.OpenComposer.Notes;
using NUnit.Framework;

namespace AliaRobinson.OpenComposerTest.CompositionSpace
{
    [TestFixture]
    public class ScaleTest
    {
        [Test]
        public void TestMajorPentatonicC()
        {
            List<IPitch> pentatonic = Defaults.PENTATONICMAJORSCALE.getPitches(new Pitch(PitchClasses.C, 4), 6);
            Assert.AreEqual(6, pentatonic.Count);
            Assert.AreEqual(pentatonic[0], new Pitch(PitchClasses.C, 4));
            Assert.AreEqual(pentatonic[1], new Pitch(PitchClasses.D, 4));
            Assert.AreEqual(pentatonic[2], new Pitch(PitchClasses.E, 4));
            Assert.AreEqual(pentatonic[3], new Pitch(PitchClasses.G, 4));
            Assert.AreEqual(pentatonic[4], new Pitch(PitchClasses.A, 4));
            Assert.AreEqual(pentatonic[5], new Pitch(PitchClasses.C, 5));
        }

    }
}