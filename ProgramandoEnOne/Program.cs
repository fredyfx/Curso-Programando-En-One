using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramandoEnOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iniciamos con todo el power!
            
            //Definimos las variables:
            int numero;
            string nombres;
            decimal cantidadDinero;
            //Para leer las variables:
            //Variable = Lectura (se establece el valor)
            //se necesita un Console.ReadLine();
            //Para decirle al usuario
            //
            Console.WriteLine("Ingrese su nombre: ");
            nombres = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("Cuanto dinero tiene en el bolsillo?: ");
            cantidadDinero = decimal.Parse(Console.ReadLine());
            //Estructuras Secuenciales

            //Cabe mencionar que esto
            //Estructuras Condicionales
            //Decision
            //Dobles
            //Multiples
            //Estructuras Repetitivas
            //while
            //dowhile
            //for
            //Fin de la primera temporada
        }
    }
}
