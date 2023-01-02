using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    internal class Auto
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }

        public bool estado = false;

        public bool conductor = false;

        //ejercicio 12
        public int capacidad;

        public bool mascota;


        public int asientosOcup = 0;
          

        //ejercicio 9
        public int velocidad = 30;

        public void Encedido()
        {
            if (conductor = true && estado == false)
            {
               
            if (estado = false)
            {
                Console.WriteLine("Auto encendido ");

                estado = true;
            }

            else
            {
                Console.WriteLine("El auto se encuentra encendido");
            }
            }
        }
        public void AcelerarVe()
        {
            if (estado)
            {

                Console.WriteLine($"Ingrementa la velocidad{velocidad}");
                velocidad += 10;

            }
        }
        public void Apagado()
        {
            if (estado)
            {
                Console.WriteLine("El Auto esta apagado");

                estado = false;
            }
            else { Console.WriteLine("El auto se encuentra apagado"); }
        }
        public void FrenarVe()
        {
            if (velocidad > 20)
            {
                Console.WriteLine($"Esta frenando{velocidad}");
                velocidad -= 20;
            }
        }
        public void SubirPasj()
        {
            Console.WriteLine("Cuantos pasajeros van a subir:");
            int pasajeros = int.Parse(Console.ReadLine());  

            if(pasajeros > capacidad)
            {
                Console.WriteLine("Son muchos pasajeros");
            }
            else if(pasajeros < capacidad)
            {
                capacidad -=pasajeros;
                Console.WriteLine($"Cantidad de asientos disponibles:{capacidad} ");
            }
        }
        //ejercicio 14
        public void BajarPasj()
        {
        if (velocidad == 0)
            {
                Console.WriteLine("Pueden bajar pasajeros");
                asientosOcup = 0;
            }
        }
        public void BajarCond()
        {
            if (velocidad ==0 && estado ==false )
            {
                Console.WriteLine("El auto se encuentra apagado");
                Console.WriteLine("El conductor puede bajarse");
            }
        }
  
    }
}







