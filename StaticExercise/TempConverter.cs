using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius (double temp)
        {
            
            //temp -= 32;
            //double celsius_Dec = 1.8;
            //double celsius = temp / celsius_Dec;
            return (temp - 32) / 1.8;
        }
        public static double CelsiusToFahrenheit(double temp)
        {
            
            //temp += 32;
            //double fahren_Dec = 1.8;
            //double fahrenheit = temp * fahren_Dec;
            return temp *1.8 + 32 ;
        }



    }
}
