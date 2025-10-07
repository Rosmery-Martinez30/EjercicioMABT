using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MABT.Cadenas
{
   
    public class ManipuladorCadenas
    {
        // Método que se probará con xUnit
        public string InvertirCadena(string texto)
        {
            char[] arr = texto.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        
        // Método que se probará con xUnit
        public int ContarVocales(string texto)
        {
            return texto.Count(c => "aeiouAEIOU".Contains(c));
        }
    }
}
