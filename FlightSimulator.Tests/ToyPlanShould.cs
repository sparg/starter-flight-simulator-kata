using FlightSimulator.Planes;
using NUnit.Framework;

namespace FlightSimulator.Tests
{
    [TestFixture]
    public class ToyPlanShould
    {        
        [Test]
        public void Print_Im_a_toy_plane_On_Display()
        {
            var p = new ToyPlane();
            Assert.AreEqual(p.Display(), "I'm a toy plane!");
        }

        [Test]
        public void Print_This_plane_is_unable_to_fly_On_Fly()
        {
            var p = new ToyPlane();
            Assert.AreEqual(p.Fly(), "This plane is unable to fly");
        }

        [Test]
        public void Print_Crash_On_Land()
        {
            var p = new ToyPlane();
            Assert.AreEqual(p.Land(), "Crash!");
        }

        [Test]
        public void Print_No_engine_to_start_On_StartEngine()
        {
            var p = new ToyPlane();
            Assert.AreEqual(p.SingleEnginePlane(), "No engine to start!");
        }
    }
}
