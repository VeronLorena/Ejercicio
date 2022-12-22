using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    internal class Edad
    {
        public string fechaNac { get; set; }

        public void CalEdad()
        {
            Console.WriteLine("agregar la fecha de nacimiento dd/MM/yyyy");
            fechaNac = Console.ReadLine();

            DateTime fechaNacDate = DateTime.ParseExact(fechaNac, "dd/MM/yyyy", null);
            DateTime fechaActual = DateTime.Now;
            int años = fechaActual.Year - fechaNacDate.Year;
            Console.WriteLine("Tu edad es "+años+"a");
            Console.Read();

        }
    }
}
