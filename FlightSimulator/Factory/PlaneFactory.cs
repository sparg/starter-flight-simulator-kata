using FlightSimulator.Planes;

namespace FlightSimulator.Factory
{
    public class PlaneFactory
    {
        public PaperPlane CreatePaperPlane()
        {
            return new PaperPlane();
        }

        public OneEnginePlane CreateOneEnginePlane()
        {
            return new OneEnginePlane();
        }

        public ToyPlane CreateToyPlane()
        {
            return new ToyPlane();
        }

        public SeaPlane CreateSeaPlane()
        {
            return new SeaPlane();
        }
    }
}