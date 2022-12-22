using   System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    class Cuadrado
    {
        public double lado;

        public Cuadrado()
        {
            Console.WriteLine("Ingrese el lado");
            this.lado = int.Parse(Console.ReadLine());
        }   
        public double area()
        {
            return lado * lado;
        }
    }    
}
 


