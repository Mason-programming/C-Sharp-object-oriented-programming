using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6_ch12
{
    class weightConvertor
    {
        double weight;
        int converoter;
        double kilo;
        double grams;
        double pounds;
        double ounces; 
        public weightConvertor(float w)
        {
            weight = w; 

        }
        public double kilograms(){

            kilo = weight * 2.2; 

            return kilo; 
        }
        public double Grams()
        {
            grams = weight * 453.59237; 

            return grams; 
        }
        public double Pounds
        {
            get
            {
                return weight;
            }

        }
        public double Ounces()
        {
            ounces = weight * 16; 

            return ounces; 
        }
    }
}
