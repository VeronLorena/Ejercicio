using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml.Schema;

namespace Ejercicio_5_6
{
    class program
    {
        static void Main(string[] args)
        {



            /*1.Dado que se tiene almacenado en una lista, los resultados de los últimos 10
            exámenes de un alumno, calcular su promedio y mostrar por pantalla las 10
            notas de los exámenes y el promedio resultante.*/


            /*List<int>nota = new List<int>();
            nota.Add(10);
            nota.Add(5);
            nota.Add(7);
            nota.Add(9);
            nota.Add(6);
            nota.Add(10);
            nota.Add(6);
            nota.Add(8);
            nota.Add(9);
            nota.Add(5);

            int suma = 0;
            for (int i = 0; i < nota.Count; i++)
            {
                Console.WriteLine(nota[i]);
                suma = suma + nota[i];
            }
            Console.WriteLine($"Muestra el promedio:{suma / 10}");


            2. Dada las edades de 20 personas guardadas en una lista, imprimir por pantalla cuántos son mayores de edad y cuántos no.


            List<int>edad=new List<int>();
            edad.Add(1);
            edad.Add(2);
            edad.Add(3);
            edad.Add(4);
            edad.Add(5);
            edad.Add(6);
            edad.Add(7);
            edad.Add(8);
            edad.Add(9);
            edad.Add(10);
            edad.Add(11);
            edad.Add(12);


            var mayor = 0;
            var menor = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese la edad:{i}");
                edad[i] = int.Parse(Console.ReadLine());

                if (edad[i] > 18)
                {
                    Console.WriteLine($"Es mayor de edad");
                    mayor = mayor + 1;
                }
                else
                {
                Console.WriteLine($"Es menor de edad");
                    menor = menor + 1;
                }
            }
            Console.WriteLine($"Son mayores: {mayor}");
            Console.WriteLine($"Son mayores: {menor}");*/

            /*3.Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y
            el que tenga menos letras de todos.*/

            /*List<string>Nombre = new List<string>();

            Nombre.Add("lore");
            Nombre.Add("mati");
            Nombre.Add("leandro");

            var pala_men = Nombre[0].Length;
            var pala_may = Nombre[0].Length;

            for (int i = 0; i < Nombre.Count; i++)
            {
            if (Nombre[i].Length < pala_men)
                {
                    pala_men = Nombre[i].Length;
                }
            else if (Nombre[i].Length > pala_may)
                {
                    pala_may = Nombre[i].Length;
                }
            }
            Console.WriteLine($"Los nombres menores son: {pala_men}");
            Console.WriteLine($"Los nombres menores son: {pala_may}");*/





            /*4.Crear una variable para guardar los nombres de elementos para una “lista de  supermercado”.
            Solicitar al usuario que ingrese el nombre de un elemento que va a comprar en el super y verificar que el elemento esté en la lista.
            Si no está, agregarlo e indicar que no estaba. Si está, quitarlo de la lista, y avisar que sí estaba.
            Al finalizar mostrar por pantalla los elementos que no compró  los que compró, pero no estaban en la lista. Si se quiere, mostrar también
            todos los elementos que el usuario compró. Para salir el usuario debe ingresar “fin”*/


            /*List<string> Producto2 = new List<string>();
            List<string> PrRemovidos = new List<string>();
            List<string>NoComprados = new List<string>();


            Producto2.Add("leche");
            Producto2.Add("pan");
            Producto2.Add("banana");

            foreach(string s in Producto2) 
            {
                Console.WriteLine(s); 
            }
            Console.WriteLine("Desea comprar un producto: Presionar s ");
            var comprar = Console.ReadLine();

            while (comprar.ToLower() == "s")
            {
                Console.WriteLine("Ingrese el producto: ");
                var prod = Console.ReadLine();
                var existe = Producto2.Contains(prod);


                if(existe == false)
                {
                    Console.WriteLine("Este producto no se encuentra en la lista");
                    Producto2.Add(prod);
                    NoComprados.Add(prod);

                }
                else if (existe == true)
                {
                    var indice = Producto2.IndexOf(prod);
                    Console.WriteLine("Este producto esta en la lista");
                    Producto2.RemoveAt(indice);
                    PrRemovidos.Add(prod);
                }
                Console.WriteLine("Desea seguir comprando? s para si f para Finalizar");
                comprar = Console.ReadLine();
            }

            foreach(string prod in NoComprados)
            {
                Console.WriteLine("Lista de no comprados");
                Console.WriteLine(prod);

            }
            Console.WriteLine();

            foreach(string prod in PrRemovidos)
            {
                Console.WriteLine("Lista de tachados");
                Console.WriteLine(prod);

            }*/



            /*5.Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en
            lugares pares. Imprimir la matriz por pantalla*/
            /*
            string[,] miVector = new string[5, 5];


            for (int y= 0; y < 5; y++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i %2 == 0)
                    {
                        miVector[y, i] = "I";

                    }
                    else
                    {
                        miVector[y, i] = "P";
                    }
                    Console.Write(miVector[y , i]+" ");

                }
                Console.Write("\n\n");
            }*/

            /*6.Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los
            días de la semana. La estructura es para registrar la temperatura diaria de
            una cabina de pago, estos oscilan entre los 7 y 38 grados. Deberá llenar la
            matriz de forma aleatoria para el mes de mayo donde el primer día inicia en
            lunes y el último (31) se ubica en el miércoles (la matriz puede ser inicializada
            con valores aleatorios desde el principio del programa, no es necesario pedir
            los valores al usuario para cada posición). Se nos pide hacer lo siguiente:
            a.Obtener la temperatura más alta y baja de la semana y que día se
            produjo (lunes, martes, etc.)
            b.Promedio de temperatura de la semana.
            c. Temperatura más alta del mes y su día.*/

            /*int[,] mes = new int[5, 7];
            Random temp = new Random();

            //relleno de matrices
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    mes[i, j] = temp.Next(1,40);
                    Console.Write(mes[i, j] + "");
                }
            }
            Console.Write("\n\n");
            for (int i = 4; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mes[i, j] = temp.Next(1, 40);
                    Console.Write(mes[i, j] + "");
                }
            }
            Console.Write("\n\n");

            var tempAlta = 0;
            var tempBaja = 0;
            var tempAltames = mes[0, 0];
            var tempBajames = mes [0,0];
            int diaMes = 0;
            int semanaMes = 0;
            int posBajai = 0;
            int posBajaj = 0;
            int posAltai = 0;
            int posAltaj = 0;

            var sumaTemp = 0;
            var promTemp = 0;
            for(int i = 0; i < 5; i++)
            {
                tempAlta = mes[i, 0];
                tempBaja = mes[i, 0];
                sumaTemp = 0;
                for(int j = 0; j < 7; j++)
                {
                    if (mes[i,j] < tempBaja && mes[i, j] > 0)
                    {
                        tempBaja = mes[i, j];
                        posBajai = i;
                        posBajaj = j;
                    }
                    if(mes[i,j] > tempAlta)
                    {
                        tempAlta = mes[i, j];
                        posAltai = i;
                        posAltaj = j;
                    }
                    sumaTemp += mes[i, j];
                }
                if (tempAlta > tempAltames)
                {
                    tempAltames = tempAlta;
                    semanaMes = posAltai;
                    diaMes =posAltaj;
                }
                promTemp = sumaTemp / 7;
                Console.WriteLine($"Promedio de la temperatura de la semana: {promTemp}");
                Console.WriteLine($"Temperatura mas alta de la semana: {tempAlta}");
                Console.WriteLine($"Se dio el dia {posAltaj}  de la demana {posAltai}");
                Console.WriteLine($"Temperatura mas baja de la semana {tempBaja}");
                Console.WriteLine($"se dio el dia {posBajaj} de la semana {posBajai}");
            }
            Console.WriteLine($"Temperatura mas alta del mes fue: {tempAlta} grados");
            Console.WriteLine($"Se dio en la semana:{semanaMes} y el dia {diaMes}");*/




            /*7.Almacenar en una matriz las tablas del 1 al 9, teniendo en cuenta que en la
            primera fila y la primera columna se debe guardar los números (de 0 a 9),
            estando el cero en la primera posición (fila 0, columna 0). El resto de los
            lugares debe ser calculado usando los números que se dispone, por ejemplo,
            en la fila 1, calcular 1*1, 1*2, 1*3, etc. usando las posiciones del array o
            arreglo. Al finalizar el cálculo, mostrar la matriz por pantalla*/

            /*int[,] miVector = new int[10,10];

            for (int i = 0; i < 10; i++)
            {
                var total = i;
                for (int j = 0; j < 10; j++)
                {
                    miVector[i,j] = i*j;

                    Console.Write(miVector[i,j] + " ");
                }
                Console.Write("\n\n");

            }*/

        }
    }


}