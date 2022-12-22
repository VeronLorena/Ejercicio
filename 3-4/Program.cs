/*2. Crear una clase Cuadrado con método para calcular el área del mismo.*/

using _3_4;

namespace calculo
{
    internal class Program
    {
        static void Main(string[] args)
            //Ejercicio 2
        {
            /*          Cuadrado cuadrado = new Cuadrado();

                        Console.WriteLine($"El area del cuadrado es : {cuadrado.area()}");*/


            //Ejercicio 3

            /*  Persona persona = new Persona();

                persona.name = "laura";
                persona.lastName = "Rodrigues";

                persona.Name();*/
            //Ejercicio 4
            /*          Edad edad = new Edad();

                        edad.CalEdad();*/

            //Ejercicio 5

            /*          Auto auto = new Auto();

                        Console.WriteLine("Ingrese el modelo del auto");
                        auto.modelo = Console.ReadLine();
                        auto.Encedido();
                        auto.Apagado();*/

            //Ejercicio 6

            /*          Mascota mascota = new Mascota();
            */
            /*mascota.Alimento();
              mascota.Alimento();
              mascota.Alimento();
       */
            //Ejercicio 7


            /*          mascota.Correr();
            */

            //Ejercicio 8
            /*
                        Smartphone smartphone = new Smartphone();

                        smartphone.Encendido();
                        smartphone.Apagado();
                        smartphone.BajarVol();
                        smartphone.SubirVol();
                        smartphone.SilencioVol();
                        smartphone.PantallaSu();
                        smartphone.PantallaBa();
            */
            //Ejercicio 9

            /*          Auto auto = new Auto();
             *          
                        auto.Encedido();
                        auto.AcelerarVe();
                        auto.Apagado();
                        auto.FrenarVe();

                        //Ejercicio 10 


                        Persona persona = new Persona();

                        persona.Phone();*/

            //Ejercico 11

            /*          Persona persona = new Persona();   
                        Auto auto = new Auto();

                        Console.WriteLine("Ingrese su edad");
                        persona.edad = int.Parse(Console.ReadLine());

                        if (persona.edad > 18)
                        {
                            Console.WriteLine("Usted puede manejar");
                            auto.conductor = true;
                        }*/

            //Ejercicio 13

            /*            Auto auto = new Auto();
                        Mascota mascota = new Mascota();

                        auto.SubirPasj();
                        Console.WriteLine("Acepta una  mascota al auto?si/no");
                        var res = Console.ReadLine();
                        if (res == "si")
                        {
                            auto.mascota = true;
                        }
                        else
                        {
                            auto.mascota = false;
                        }
                        mascota.subirMas();
                        mascota.CambiarLugar();*/

            //Ejercicio 15
            Estudiante estudiante = new Estudiante();

            Libro Novela1 = new Libro();
            Novela1.nombre = "Orgullo y Pejuicio";
            Novela1.autor = "Grande";
            Novela1.cantidadP = 400;
            Novela1.wasread = false;

            Libro Novela2 = new Libro();
            Novela1.nombre = "cuentos que o son cuentos";
            Novela1.autor = "Grande";
            Novela1.cantidadP = 600;
            Novela1.wasread = false;

            Libro Novela3 = new Libro();
            Novela1.nombre = "Odisea";
            Novela1.autor = "Grande";
            Novela1.cantidadP = 400;
            Novela1.wasread = false;

            Libro Novela4 = new Libro();
            Novela1.nombre = "Señor de los anillos";
            Novela1.autor = "Grande";
            Novela1.cantidadP = 700;
            Novela1.wasread = false;

            // Lista de libros
            var novelas = new List<Libro>();
            novelas.Add(Novela1);
            novelas.Add(Novela2);
            novelas.Add(Novela3);
            
        
            Console.WriteLine("Seleccione una de las siguientes opciones:");
            Console.WriteLine("1-Agregar un Libro");
            Console.WriteLine("2-Quitar un Libro");
            Console.WriteLine("3-Ver el contenido de la lista");;
            Console.WriteLine("0-Salir");

            var res = Console.ReadLine();
            switch (res) 
            {
                case "1":

                    Console.WriteLine("Ingrese Libro: ");
                    var nuevoLibro = Console.ReadLine();
                    estudiante.Libros.Add(nuevoLibro);
                    break;
                case "2":
                    Console.WriteLine("Ingrese el libro que quiere quitar: ");
                    var LibroRemove = Console.ReadLine();
                    estudiante.Libros(LibroRemove);
                    break;
                case "3":
                    if (estudiante.Libros.Count == 0)
                    {
                        Console.WriteLine("La lista está vacía.");
                    }
                    else
                    {
                        foreach (var item in estudiante.Libros)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
            }



        }
    }
}
