using FlightSimulator.Enum;

namespace FlightSimulator.Planes
{
    public class OneEnginePlane : Plane
    {
        public OneEnginePlane() : base("one engine plane", MotorType.OneEngine, WingType.RealWing, WheelType.Wheels)
        {
        }
    }
}