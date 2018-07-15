using FlightSimulator.Enum;

namespace FlightSimulator.Planes
{
    public class PaperPlane : Plane
    {
        public PaperPlane() : base("paper plane", MotorType.NoEngine, WingType.PaperWing, WheelType.None)
        {
        }
    }
}