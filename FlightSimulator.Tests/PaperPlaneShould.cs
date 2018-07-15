using FlightSimulator.Planes;
using NUnit.Framework;

namespace FlightSimulator.Tests
{
    [TestFixture]
    public class PaperPlaneShould
    {
        [Test]
        public void Print_Im_a_paper_plane_On_Display()
        {
            var p = new PaperPlane();
            Assert.AreEqual(p.Display(), "I'm a paper plane!");
        }

        [Test]
        public void Print_Flying_with_paper_wings_On_Fly()
        {
            var p = new PaperPlane();
            Assert.AreEqual(p.Fly(), "Flying with paper wings");
        }

        [Test]
        public void Print_Crash_On_Land()
        {
            var p = new PaperPlane();
            Assert.AreEqual(p.Land(), "Crash!");
        }

        [Test]
        public void Print_No_engine_to_start_On_StartEngine()
        {
            var p = new PaperPlane();
            Assert.AreEqual(p.SingleEnginePlane(), "No engine to start!");
        }
    }
}
