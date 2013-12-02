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
            //=================================
            //Estructuras Condicionales Simples
            //=================================
            //Consideremos que necesitamos 100$ para viajar
            if (cantidadDinero > 100)
            {
                Console.WriteLine("Vas a viajar!");
            }
            //=================================
            //Estructuras Condicionales Dobles
            //=================================
            //Si estás con acceso a internet, juega online, sino, juega local.            
            Console.WriteLine("Tienes acceso a internet? [S/N]");
            //Como solo necesitamos una letrita, empleamos el tipo "char"
            char AccesoInternet = Console.ReadLine()[0];
            if (AccesoInternet.Equals("S"))
            {
                Console.WriteLine("Juega Online");
            }
            else
            {
                Console.WriteLine("Juega Offline");
            }
            //=================================
            //Estructuras Condicionales Multiples con IFS
            //=================================
            int nota;
            Console.WriteLine("Ingrese la nota que ha obtenido: ");
            nota = int.Parse(Console.ReadLine());
            if (nota >= 90)
            {
                Console.WriteLine("Has obtenido una A"); 
            }else if(nota<90 && nota >=80)
            {
                Console.WriteLine("Has obtenido una B"); 
            }else if(nota<80 && nota >=70)
            {
                Console.WriteLine("Has obtenido una C"); 
            }
            //=================================
            //Estructuras Condicionales Multiples con Switch Case
            //=================================
            int numeroMes;
            Console.Write("Ingrese el numero de mes: ");
            numeroMes = int.Parse(Console.ReadLine());
            switch (numeroMes)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Setiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("Has escrito algun numero diferente del 1 al 12");
                    break;
            }         
            //while
            //dowhile
            //for
            //Fin de la primera temporada
        }
    }
}
