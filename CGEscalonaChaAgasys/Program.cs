using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGEscalonaChaAgasys
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Persona per = new Persona();
            //int i = 0;
            //int a = 0;
            //int b = 0, c = 0;

            //Console.WriteLine("Ingrese su edad: ");
            //i = Convert.ToInt16(Console.ReadLine());
            //bool condi = per.ComprobarEdad(i);
            //Console.WriteLine("Nombre: {0}", per.nombre);
            //Console.WriteLine("Edad: " + per.edad);

            //if (condi == true)
            //{
            //    Console.WriteLine("Es mayor de edad");
            //}
            //else
            //{
            ////    Console.WriteLine("Es menor de edad");
            //}

            //Console.ReadKey();

            int i = 0;
            int max = 0, min = 0;


            int suma = 0;

            Console.WriteLine("Ingrese Numero de personas");
            int n = int.Parse(Console.ReadLine());

            for (i = 0; i <= n; i++)
            {
                Console.WriteLine("Escribe la edad");
                int edad = int.Parse(Console.ReadLine());
                if (edad >= 18)
                {
                    max += 1;
                }
                else
                {
                    min += 1;
                }

            }
            Console.WriteLine("Total de  Menores de Edad : " + min);

            Console.WriteLine("Total de Mayor de edad : " + max);
           
            Console.ReadKey();


        }
    }
}
