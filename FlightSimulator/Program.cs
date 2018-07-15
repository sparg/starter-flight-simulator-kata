using System;
using System.Collections.Generic;
using FlightSimulator.Factory;

namespace FlightSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var planeList = new List<Planes.Plane>();
            var fact = new PlaneFactory();

            planeList.Add(fact.CreateOneEnginePlane());
            planeList.Add(fact.CreatePaperPlane());
            planeList.Add(fact.CreateToyPlane());
            planeList.Add(fact.CreateSeaPlane());

            foreach (var p in planeList)
            {
                Console.WriteLine(p.Printable());
            }

            Console.ReadLine();
        }
    }
}