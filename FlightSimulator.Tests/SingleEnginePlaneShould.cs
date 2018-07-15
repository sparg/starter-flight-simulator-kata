using FlightSimulator.Planes;
using NUnit.Framework;

namespace FlightSimulator.Tests
{
    [TestFixture]
    public class SingleEnginePlaneShould
    {
        [Test]
        public void Print_Im_a_one_engine_plane_On_Display()
        {
            var p = new OneEnginePlane();
            Assert.AreEqual(p.Display(), "I'm a one engine plane!");
        }

        [Test]
        public void Print_Flying_with_real_wings_On_Fly()
        {
            var p = new OneEnginePlane();
            Assert.AreEqual(p.Fly(), "Flying with real wings");
        }

        [Test]
        public void Print_Landing_with_wheels_On_Land()
        {
            var p = new OneEnginePlane();
            Assert.AreEqual(p.Land(), "Landing with wheels");
        }

        [Test]
        public void Print_Single_engine_started_On_StartEngine()
        {
            var p = new OneEnginePlane();
            Assert.AreEqual(p.SingleEnginePlane(), "Single engine started!");
        }
    }
}
