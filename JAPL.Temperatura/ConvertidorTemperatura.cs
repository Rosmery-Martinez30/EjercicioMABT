using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MABT.Temperatura
{
  
        public class ConvertidorTemperatura
        {
            // Método que se probará con MSTest
            public double CelsiusAFahrenheit(double celsius)
            {
                return (celsius * 9 / 5) + 32;
            }

            // Método que se probará con MSTest
            public double FahrenheitACelsius(double fahrenheit)
            {
                return (fahrenheit - 32) * 5 / 9;
            }
        }
    }

