using System.ComponentModel;
using FlightSimulator.Enum;
using FlightSimulator.Interfaces;

namespace FlightSimulator.Planes
{
    public abstract class Plane : IDisplay, ISingleEnginePlane, IFly, ILand, IPrintable
    {
        private readonly string _name;
        private readonly MotorType _motor;
        private readonly WingType _wing;
        private readonly WheelType _wheel;

        protected Plane(string name, MotorType motor, WingType wing, WheelType wheel)
        {
            this._name = name;
            this._motor = motor;
            this._wheel = wheel;
            this._wing = wing;
        }

        public string Display()
        {
            return $"I'm a {_name}!";
        }

        public string SingleEnginePlane()
        {
            var singleEnginePlane = "";

            switch (_motor)
            {
                case MotorType.NoEngine:
                    singleEnginePlane = "No engine to start!";
                    break;
                case MotorType.OneEngine:
                    singleEnginePlane = "Single engine started!";
                    break;
                default:
                    throw new InvalidEnumArgumentException();
            }

            return singleEnginePlane;
        }

        public string Fly()
        {
            var fly = "";

            switch (_wing)
            {
                case WingType.PaperWing:
                    fly = "Flying with paper wings";
                    break;
                case WingType.NoWing:
                    fly = "This plane is unable to fly";
                    break;
                case WingType.RealWing:
                    fly = "Flying with real wings";
                    break;
                default:
                    throw new InvalidEnumArgumentException();
            }

            return fly;
        }

        public string Land()
        {
            var land = "";

            switch (_wheel)
            {
                case WheelType.Floats:
                    land = "Landing with floats";
                    break;
                case WheelType.None:
                    land = "Crash!";
                    break;
                case WheelType.Wheels:
                    land = "Landing with wheels";
                    break;
                default:
                    throw new InvalidEnumArgumentException();
            }

            return land;
        }

        public string Printable()
        {
            return (
                this.Display() + "\r\n" +
                this.SingleEnginePlane() + "\r\n" +
                this.Fly() + "\r\n" +
                this.Land() + "\r\n"
            );
        }
    }
}