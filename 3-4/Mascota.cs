using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    internal class Mascota
    {
        public string nombre { get; set; }
        public string tipo { get; set; }

        public int energia = 0;

        public int posicionM;
        public string tamaño { get; set; }

        public int asientoNec { get; set; }
        public void Alimento()
        {
            energia += 30;
            Console.WriteLine($"Energia actual: {energia}");
        }
        public void Correr()
        {
            if (energia > 20)
            {
                energia -= 10 ;
                Console.WriteLine($"Energia actual: {energia}");
            }
            else if (energia < 20)
            {
                Console.WriteLine($"Energia es : {energia} no puede correr");
            }
        }
        public void CambiarLugar()
        {
            if (tamaño == "pequeño")
            {
                Random random = new Random();
                posicionM = random.Next(1, 4);
                Console.WriteLine($"La posicion de la mascota es:{posicionM} ");
            }

        }
        public void subirMas()
        {
            Console.WriteLine("Ingrese tamaño de la mascota: ");
            tamaño = Console.ReadLine();
            if (tamaño == "pequeño")
            {
                posicionM = 1;
                asientoNec = 0;
                Console.WriteLine($"La posicion de la mascota es:{posicionM} ");
            }
            else if (tamaño == "mediana")
            {
                asientoNec = 1;
                Console.WriteLine("Un asiento ocupado");
            }
            else if(tamaño == "grande")
            {
                asientoNec = 2;
                Console.WriteLine("Dos asiento ocupado");
            }
        }
        
    }
}
