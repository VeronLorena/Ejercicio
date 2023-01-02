using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    internal class Persona
    {
        public string name { get; set; } 
        public string lastName { get; set; }

        public bool smartphone = false;
        public string fechaNac { get; set; }

        public int edad { get; set; }   

        public void CalEdad()
        {
            Console.WriteLine("agregar la fecha de nacimiento dd/MM/yyyy");
            fechaNac = Console.ReadLine();

            DateTime fechaNacDate = DateTime.ParseExact(fechaNac, "dd/MM/yyyy", null);
            DateTime fechaActual = DateTime.Now;
            int años = fechaActual.Year - fechaNacDate.Year;
            Console.WriteLine("Tu edad es " + años + "a");
            Console.Read();

        }


        public void Name()
        {
            Console.WriteLine($"Nombre completo{name + lastName}");


        }
        public void Phone()
        {
            if (smartphone == false)
            {
                Console.WriteLine("No tiene un Smartphone");

            }
            else
            {
                Console.WriteLine("Tiene un Smartphone");
            }
        }
    }

}
