using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    internal class Ejercicio
    {
        public void ejecicio1()
        {
            Console.WriteLine("Este programa calcula el valor");
            Console.WriteLine();

            Console.WriteLine("Ingrese un valor");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro valor");
            double v = double.Parse(Console.ReadLine());

            double allarElValor =
                valor + v;

            Console.WriteLine("El valor exacto es: ");
            Console.WriteLine(allarElValor);

            bool esMayorACien = allarElValor > 100;

            if (esMayorACien)
            {
                Console.WriteLine("El valor es mayor que 100");
            }
        }
        public void Ejercicio2() 
        {
            Console.WriteLine("ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese un segundo numero: ");
            string segundoN = Console.ReadLine();

            Console.WriteLine("El numero ingresado es: " + segundoN);
            Console.WriteLine();

            if (numero % 2 == 0)
            {
                Console.WriteLine("El resultado es par");
            }
            else
            {
                Console.WriteLine("El resultado es impar");
            }
        }
        public void Ejercio3()
        {

            Console.WriteLine("Ingrase un numero: ");
            int num = int.Parse(Console.ReadLine());

            var div = num / 2;


            if (div % 2 == 1)
            {
                Console.WriteLine("Cumple con la condicion");
            }
            else
            {
                Console.WriteLine("No cumple con la condicion");
            }
        }
        public void Ejercicio4()
        {
            Console.WriteLine("Ingrese un numero: ");
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (num)
            {
                case 1:
                    Console.WriteLine("I");
                    break;
                case 2:
                    Console.WriteLine("II");
                    break;
                case 3:
                    Console.WriteLine("III");
                    break;
                case 4:
                    Console.WriteLine("IV");
                    break;
                case 5:
                    Console.WriteLine("V");
                    break;
                case 6:
                    Console.WriteLine("VI");
                    break;
                case 7:
                    Console.WriteLine("VII");
                    break;
                case 8:
                    Console.WriteLine("VIII");
                    break;
                case 9:
                    Console.WriteLine("IX");
                    break;
                case 10:
                    Console.WriteLine("X");
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }

        public void Ejercicio5()
        {
            string[] personas = new string[2];
            int[] edad = new int[2];
            int resta = 0;
            for (int a = 0; a < personas.Length; a++)
            {
                Console.WriteLine("Ingrese el nombre del {0}ª persona", a + 1);
                personas[a] = Console.ReadLine();
                Console.WriteLine();
            }
            for (int a = 0; a < edad.Length; a++)
            {
                Console.WriteLine("Ingrese la edad {0}ª persona", a + 1);
                edad[a] = int.Parse(Console.ReadLine());
            }

            if (edad[0] < edad[1])
            {
                Console.WriteLine("El menor es:", personas[0]);
            }
            else if (edad[1] < edad[0])
            {
                Console.WriteLine("El nombre es", personas[1]);
            }
            else
            {
                Console.WriteLine("Tienen la misma edad");
            }
        }
        public void Ejercicio6()
        {

            Console.WriteLine("Ingrese la long1 del triangulo");
            double l1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la long2 del triangulo");
            double l2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la long3 del triangulo");
            double l3 = double.Parse(Console.ReadLine());

            if (l1 == l2 && l1 == l3)
            {
                Console.WriteLine("El triangulo es equilatero");

            }
            else if ((l1 != l2) && (l1 != l3) && (l2 != l3))
            {
                Console.WriteLine("Es escaleno");
            }
            else
            {
                Console.WriteLine("Es iscoceles");

            }


            Console.WriteLine("Ingrese la base del triangulo");
            double basetriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triangulo");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            double areaTriangulo =
                basetriangulo * alturaTriangulo;
            Console.WriteLine("La area del rectangulo es");
            Console.WriteLine(areaTriangulo);

            double perimetroTriangulo =
                basetriangulo + alturaTriangulo + basetriangulo + alturaTriangulo;
            Console.WriteLine("La perimetro del rectangulo es");
            Console.WriteLine(perimetroTriangulo);
        }
       
        public void Ejercicio7()
        {
            Console.WriteLine("Ingrese un monto");
            int num = int.Parse(Console.ReadLine());
            int cociente = 0;
            int resul = 0;
            int[] denominacion = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };

            for (int i = 0; i < denominacion.Length; i++)
            {
                cociente = num / denominacion[i];
                num = num % denominacion[i];
                if (i < 6)
                {
                    Console.WriteLine("{0} billetes de {1}", cociente, denominacion[i]);
                }
                else
                {
                    Console.WriteLine("{0} monedas de {1}", cociente, denominacion[i]);

                }
            }
        }

        public void Ejercicio8()
        {

            Console.WriteLine("Ingrese un valor");
            int valor = int.Parse(Console.ReadLine());

            for (int a = 0; a < valor; a++)
            {
                Console.WriteLine(a);
            }
        }
        public void Ejercicio9()
        {
            int total = 0;
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Ingrese un numero");
                int num = int.Parse(Console.ReadLine());
                total = total + num;
            }
            Console.WriteLine(total);
        }
        public void Ejercicio10()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (numero % 3 == 0)
                {
                    Console.WriteLine("Es multiplo de 3");
                }
                else
                {
                    Console.WriteLine("No es multipo");
                }

            }
        }


    }
}
