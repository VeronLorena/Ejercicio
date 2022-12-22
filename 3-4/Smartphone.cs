using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    internal class Smartphone
    {
        public string marca { get; set; }
        public string modelo { get; set; }

        public int brillo = 50;

        public int volumen = 50;

        public bool estado = false;

        public void Encendido()
        {
            if (estado = false)
            {
                Console.WriteLine("Celular encendido ");

                estado = true;
            }

            else
            {
                Console.WriteLine("El celular se encuentra encendido");
            }
        }

        public void Apagado()
        {
            if (estado)
            {
                Console.WriteLine("El celular esta apagado");

                estado = false;
            }
            else { Console.WriteLine("El celular se encuentra apagado"); }
        }
        public void SubirVol()
        {
            if (volumen == 100)
            {
                Console.WriteLine("El volumen esta al maximo");

            }
            else
            {
                volumen += 10;
                Console.WriteLine($"Volumen actual{volumen}");
            }
        }
        public void BajarVol()
        {
            if (volumen == 0)
            {
                Console.WriteLine("El volumen esta al minimo");

            }
            else
            {
                volumen -= 10;
                Console.WriteLine($"Volumen actual{volumen}");
            }
        }
        public void SilencioVol()
        {
            volumen = 0;
            Console.WriteLine("El celular esta en silencio");
        }
        public void PantallaSu()
        {
            if (brillo == 100)
            {
                Console.WriteLine("El brillo esta al maximo");

            }
            else
            {
                brillo += 10;
                Console.WriteLine($"brillo actual{brillo}");
            }
        }
        public void PantallaBa()
        {
            if (brillo == 0)
            {
                Console.WriteLine("El brillo esta al minimo");

            }
            else
            {
                brillo -= 10;
                Console.WriteLine($"brillo actual{brillo}");
            }
        }
    }

}
       