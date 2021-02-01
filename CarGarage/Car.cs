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

        public string SetMake(string honda)
        {
            Make = honda;
            return honda;
        }

        public string SetModel(string accord)
        {
            Model = accord;
            return accord;
        }

         public int GetSpeed()
        {

            return 27;
            
          
        }

       

       

      
        }



            
           
           


        }



    















