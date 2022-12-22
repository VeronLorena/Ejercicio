using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    internal class Estudiante: Persona
    {
        public string edad { get; set; }

        public List<int> Libros{ get; set; }
        public List<int> LibroNoLeidos { get; set; }
    }

}
