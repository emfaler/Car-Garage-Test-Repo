using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int FuelLevel { get; set; }
        public bool AutoBrakeActive { get; set; }

        public string SetMake(string Honda)
        {
            Make = Honda;
            return Honda;
        }

        public string SetModel(string Accord)
        {
            Model = Accord;
            return Accord;
        }




    }














}
