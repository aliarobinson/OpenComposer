using AliaRobinson.OpenComposer.Notes;
using NUnit.Framework;

namespace AliaRobinson.OpenComposerTest.Notes
{
    [TestFixture]
    public class PitchTest
    {

        [Test]
        public void TestPitchesEqual()
        {
            Pitch first = new Pitch(PitchClasses.ASharp, 3);
            Pitch second = new Pitch(PitchClasses.ASharp, 3);
            Assert.True(first.Equals(second));
        }
        
        [Test]
        public void TestPitchesNotEqual1()
        {
            Pitch first = new Pitch(PitchClasses.ASharp, 3);
            Pitch second = new Pitch(PitchClasses.GSharp, 3);
            Assert.False(first.Equals(second));
        }
        
        [Test]
        public void TestPitchesNotEqual2()
        {
            Pitch first = new Pitch(PitchClasses.ASharp, 3);
            Pitch second = new Pitch(PitchClasses.ASharp, 4);
            Assert.False(first.Equals(second));
        }
        
        [Test]
        public void TestGetPitchAbove1()
        {
            Pitch E = new Pitch(PitchClasses.E, 3);
            IPitch above = E.GetPitchAbove(3);
            Assert.AreEqual(new Pitch(PitchClasses.G, 3), above);
        }
        
        [Test]
        public void TestGetPitchAboveOctave()
        {
            Pitch ASharp = new Pitch(PitchClasses.ASharp, 4);
            IPitch sameoctave = ASharp.GetPitchAbove(1);
            IPitch octaveabove = ASharp.GetPitchAbove(2);
            Assert.AreEqual(new Pitch(PitchClasses.B, 4), sameoctave);
            Assert.AreEqual(new Pitch(PitchClasses.C, 5), octaveabove);
        }
        
        [Test]
        public void TestGetPitchBelow1()
        {
            Pitch E = new Pitch(PitchClasses.E, 3);
            IPitch below = E.GetPitchAbove(-2);
            Assert.AreEqual(new Pitch(PitchClasses.D, 3), below);
        }
        
        [Test]
        public void TestGetPitchBelowOctave()
        {
            Pitch CSharp = new Pitch(PitchClasses.CSharp, 4);
            IPitch sameoctave = CSharp.GetPitchAbove(-1);
            IPitch octaveabove = CSharp.GetPitchAbove(-2);
            Assert.AreEqual(new Pitch(PitchClasses.C, 4), sameoctave);
            Assert.AreEqual(new Pitch(PitchClasses.B, 3), octaveabove);
        }
    }
}