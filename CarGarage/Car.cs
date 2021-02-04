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

       
        public void SetMake (string make)
        {
            Make = make;
        }

        public void SetModel( string model)
        {
            Model = model;
        }
       
        public int GetSpeed()
        {
            return Speed;
            
        }

        public bool IsSpeeding()
        {
            if (Speed > 70)
            {
                return true;
            }
            else
            return false;
        }

        public int Accelerate()
        {
            if (Make == "Ferrari")
            {
                Speed += 20;
            }
            else Speed += 10;



            if (Speed <= 100)
            {
                return Speed;
            }
            else if (Make == "Ferrari")
            {
                Speed -= 20;
            }
            else
            {
                Speed -= 10;
            }
            return Speed;
        }

            public int Brake()
        {
            bool autoBrake = Speed < 50;


            if (autoBrake)
            {
                Speed -= 7;
                if (Speed >= 0)
                {
                    return Speed;
                }
                else
                {
                    Speed += 6;
                    return Speed;
                }
            }
            else
            {
                Speed = Speed / 2;
                return Speed;
            }


            }

         








        }







    }




     
    
    
    
    
    
    
    
    

       

      




            
           
           





    















