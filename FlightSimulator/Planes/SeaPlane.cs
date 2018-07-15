using FlightSimulator.Enum;

namespace FlightSimulator.Planes
{
    public class SeaPlane : Plane
    {
        public SeaPlane() : base("Seaplane", MotorType.OneEngine, WingType.RealWing, WheelType.Floats)
        {
        }
    }
}