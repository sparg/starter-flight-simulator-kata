using FlightSimulator.Enum;

namespace FlightSimulator.Planes
{
    public class ToyPlane : Plane
    {
        public ToyPlane() : base("toy plane", MotorType.NoEngine, WingType.NoWing, WheelType.None)
        {
        }
    }
}