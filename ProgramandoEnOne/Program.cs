using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Este es el espacio de nombres empleado
namespace ProgramandoEnOne
{
    //El nombre de la clase que estamos usando
    class Program
    {
        //Este es el metodo principal de la clase "Program"        
        static void Main(string[] args)
        {
            //Iniciamos con todo el power!            
            //Definimos las variables:
            int numero;
            string nombres;
            decimal cantidadDinero;
            //=================================
            //Estructuras Secuenciales
            //=================================
            //Para escribir en pantalla:
            Console.WriteLine("Ingrese su nombre: ");
            //Para leer las variables:
            //Variable = Lectura (se establece el valor)
            //se necesita un Console.ReadLine();          
            nombres = Console.ReadLine();
            //OJO un Console.Write -> Escribe el mensaje
            //y la variable se asigna en la misma linea
            Console.Write("Ingrese su edad: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("Cuanto dinero tiene en el bolsillo?: ");
            cantidadDinero = decimal.Parse(Console.ReadLine());
            

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
