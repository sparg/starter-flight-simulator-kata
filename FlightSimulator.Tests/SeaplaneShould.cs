using FlightSimulator.Planes;
using NUnit.Framework;

namespace FlightSimulator.Tests
{
    [TestFixture]
    public class SeaplaneShould
    {
        [Test]
        public void Print_Im_a_Seaplane_On_Display()
        {
            var p = new SeaPlane();
            Assert.AreEqual(p.Display(), "I'm a Seaplane!");
        }

        [Test]
        public void Print_This_plane_is_unable_to_fly_On_Fly()
        {
            var p = new SeaPlane();
            Assert.AreEqual(p.Fly(), "Flying with real wings");
        }

        [Test]
        public void Print_Crash_On_Land()
        {
            var p = new SeaPlane();
            Assert.AreEqual(p.Land(), "Landing with floats");
        }

        [Test]
        public void Print_No_engine_to_start_On_StartEngine()
        {
            var p = new SeaPlane();
            Assert.AreEqual(p.SingleEnginePlane(), "Single engine started!");
        }
    }
}
