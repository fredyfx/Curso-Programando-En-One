﻿using System;
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

            Console.WriteLine("=================================");
            Console.WriteLine("Estructuras Condicionales Simples");
            Console.WriteLine("=================================");
            //Consideremos que necesitamos 100$ para viajar
            if (cantidadDinero > 100)
            {
                Console.WriteLine("Vas a viajar!");
            }
            Console.WriteLine("\n=================================");
            Console.WriteLine("Estructuras Condicionales Dobles");
            Console.WriteLine("=================================");
            //Si estás con acceso a internet, juega online, sino, juega local.            
            Console.WriteLine("Tienes acceso a internet? [s/n]");
            //Como solo necesitamos una letrita, empleamos el tipo "char"
            char AccesoInternet = Console.ReadLine()[0];
            if (AccesoInternet.Equals('s'))
            {
                Console.WriteLine("Juega Online");
            }
            else
            {
                Console.WriteLine("Juega Offline");
            }

            Console.WriteLine("\n==========================================");
            Console.WriteLine("Estructuras Condicionales Multiples con if");
            Console.WriteLine("==========================================");

            int nota;
            Console.WriteLine("Ingrese la nota que ha obtenido [00-100]: ");
            nota = int.Parse(Console.ReadLine());
            if (nota >= 90)
            {
                Console.WriteLine("Has obtenido una A");
            }
            else if (nota < 90 && nota >= 80)
            {
                Console.WriteLine("Has obtenido una B");
            }
            else if (nota < 80 && nota >= 70)
            {
                Console.WriteLine("Has obtenido una C");
            }

            Console.WriteLine("\n===================================================");
            Console.WriteLine("Estructuras Condicionales Multiples con Switch Case");
            Console.WriteLine("===================================================");

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

            Console.WriteLine("\n=================================");
            Console.WriteLine("Estructuras Repetitivas Do While");
            Console.WriteLine("=================================");

            //Prestarás atención con todos tus sentidos mientras que estés aprendiendo.
            //La condición es: "estar aprendiendo", por lo tanto: "prestarás atención".
            //Ahora estas aprendiendo:
            char respuesta = 's';
            do
            {
                Console.WriteLine("Prestando atencion");
                Console.Write("Estas aprendiendo? [S/N]: ");
                respuesta = Console.ReadLine()[0];
            } while (respuesta.Equals('s'));
            Console.WriteLine("Has dejado de prestar atencion");

            Console.WriteLine("\n=================================");
            Console.WriteLine("Estructuras Repetitivas While");
            Console.WriteLine("=================================");
            //De la cantidad de dinero que tienes, has decidido retirar del ATM
            //todo el dinero que puedas en billetes de 20            
            decimal dineroRetirado = 0;
            int cantidadBilletes = 0;
            while (20 <= cantidadDinero)
            {
                dineroRetirado = dineroRetirado + 20;
                cantidadDinero = cantidadDinero - 20;
                //Aumentamos nuestro contador:
                cantidadBilletes++;
                //la linea anterior equivale a cantidadBilletes = cantidadBilletes + 1;
            }
            //Para que sea sencillo redactar los mensajes con variables, se emplea {} y dentro el indice
            Console.WriteLine("Has retirado: {0} en {1} billetes de $20 ", dineroRetirado, cantidadBilletes);

            Console.WriteLine("\n=================================");
            Console.WriteLine("Estructuras Repetitivas For");
            Console.WriteLine("=================================");
            //Comprarás productos en una tienda cerca de casa,
            //ten presente que por cada producto que compres, 
            //se agrega un detalle de venta en tu boleta.
            int cantidadProductos;
            Console.Write("Ingrese la cantidad de productos: ");
            cantidadProductos = int.Parse(Console.ReadLine());
            for (int i = 1; i <= cantidadProductos; i++)
            {
                Console.WriteLine("Se ha registrado el {0} producto", i);
            }
            //Ahora bien, para ver el foreach primero veremos: Arreglos
            //Para definir un arreglo se usa la siguiente sintaxis:
            //tipodato[] <nombre del arreglo> = new tipodato[cantidad de datos]
            //Sin el uso del sufijo de una 'm' o una 'M', el compilador lo usa como double.
            decimal[] precios = new decimal[] { 5.23m, 4.5m, 1.2m };
            Console.WriteLine("\n=================================");
            Console.WriteLine("Estructuras Repetitivas Foreach");
            Console.WriteLine("=================================");
            decimal sumatoria = 0;
            foreach (decimal precio in precios)
            {
                Console.WriteLine("El precio es {0}", precio);
            }
            foreach (decimal precio in precios)
            {
                sumatoria = sumatoria + precio;
            }
            Console.WriteLine("El subtotal a pagar es: {0}", sumatoria);
            Console.WriteLine("\n=================================");
            Console.WriteLine("Arreglos Simples/Unidimensionales");
            Console.WriteLine("=================================");
            //Declaración de un array
            string[] nombreCompleto;
            //Instanciación del arreglo
            nombreCompleto = new string[3];
            // Declaración de un arreglo simple
            int[] array1 = new int[5];
            // Declaración y definición de elementos del arreglo
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };
            // Sintaxis alternativa
            int[] array3 = { 1, 2, 3, 4, 5, 6 };
            //Para insertar elementos en el array1, emplearemos un for:
            //en la condicion del for, se emplea la propiedad .Length para 
            //conocer la longitud de elementos que tiene el arreglo.
            for (int j = 0; j < array1.Length; j++)
            {
                Console.Write("El valor en el indice {0}, es: ", j);
                //Necesitamos conocer cual es el indice, para ello:
                //arreglo[indice] = Valor
                array1[j] = int.Parse(Console.ReadLine());
            }
            //Para mostrar los elementos, haremos uso de un foreach:
            Console.WriteLine("Reportamos los valores del array2");
            foreach (int number in array2)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Reportamos los valores del array1");
            foreach (int number in array1)
            {
                Console.WriteLine(number);
            }
           
            Console.WriteLine("\n=================================");
            Console.WriteLine("Arreglos Multiples/Bidimensionales");
            Console.WriteLine("=================================");
            // Arreglo de 2 dimensiones
            int[,] multiDimensionalArray1 = new int[2, 3];
            // Declaramos y definimos los elementos
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //Para mostrar los datos de un arreglo multidimensional:
            //Podemos hacer uso de 2 Fors -> con esto tenemos mayor control
            for (int k = 0; k < multiDimensionalArray2.GetLength(0); k++)
            {
                Console.WriteLine("Valores de la fila: {0}", k);
                for (int p = 0; p < multiDimensionalArray2.GetLength(1);p++)
                {
                    Console.Write(multiDimensionalArray2[k,p].ToString() + ", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Haciendo uso de un foreach \t");
            //Tambien podemos hacer uso de un foreach:
            foreach (int valor in multiDimensionalArray2)
            {
                Console.Write("{0},",valor);
            }
            Console.WriteLine("Insertando elementos en el primero arreglo multidimensional");
            //Ahora para insertar elementos en el arreglo multidimensional,
            //es la misma situacion que en arreglos unidimensionales: 
            //Necesitamos conocer los indices y listo.
            //El arreglo "multiDimensionalArray1" tiene 2 filas y 3 columnas
            for (int m = 0; m < multiDimensionalArray1.GetLength(0); m++)
            {
                for (int n = 0; n < multiDimensionalArray1.GetLength(1); n++)
                {
                    Console.Write("Ingrese el valor a registrar en {0},{1}: ",m,n);
                    multiDimensionalArray1[m, n] = int.Parse(Console.ReadLine()); 
                }
            }

            Console.WriteLine("\n=================================");
            Console.WriteLine("Arreglos de Arreglos / JaggedArray");
            Console.WriteLine("=================================");
            //declaramos el arreglo de arreglos
            int[][] jaggedArray = new int[2][];

            jaggedArray[0] = new int[3];
            jaggedArray[1] = new int[5];

            jaggedArray[0] = new int[] { 3, 5, 7, };
            jaggedArray[1] = new int[] { 1, 0, 2, 4, 6 };
            //Una segunda manera de declarar un arreglo de arreglos:
            //OJO donde va el punto y coma
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 3, 5, 7, },
                new int[] { 1, 0, 2, 4, 6 }
            };
            //Y hasta una tercera manera:
            int[][] jaggedArray3 =
            {
                new int[] { 3, 5, 7, },
                new int[] { 1, 0, 2, 4, 6 }
            };
            //El detalle está que siempre debemos usar el "new"
            //Porque no existe una inicialización por default para los elementos.
            //Y bueno, para mostrar los elementos hacemos lo siguiente:

            // Display the array elements:
            for (int a = 0; a < jaggedArray.Length; a++)
            {
                Console.Write("Element[{0}]: ", a);

                for (int b = 0; b < jaggedArray[a].Length; b++)
                {
                    Console.Write("{0}{1}", jaggedArray[a][b], b == (jaggedArray[a].Length - 1) ? "" : " ");
                    //Esta ultima parte es un if corto:
                    //<Condicion a Evaluar> ? <Si es verdadero> : <Si es falso>;
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
            
        }
    }
}
