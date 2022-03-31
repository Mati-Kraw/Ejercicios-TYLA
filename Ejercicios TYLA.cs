// See https://aka.ms/new-console-template for more information

namespace EjerciciosTyla.ConsoleApp
{
    class Program
    {

        public static void Main(string[] args)
        {
            /*DivisionEntera();*/
            /*Multiplicacion_Positivos();*/
            /* Multiplicacion_no_negativos();*/
            /* Primo();*/
            /*Promedio();*/
            /*
          Asignar, Leer y Escribir

         1) Hacer un programa que solicite al usuario su nombre, apellido y número de registro, y guarde lo solicitado en variables.
         a.	Muestre en diferentes mensajes el nombre, apellido y número de registro del alumno/a.
         b.	Muestre en un mismo mensaje el nombre, apellido y número de registro del alumno/a. 
            */
            /*
            string Nombre;
            string Apellido;
            int Registro;

            Console.WriteLine("Ingrese su nombre:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su Apellido:");
            Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su Numero de Registro:");
            Registro = int.Parse(Console.ReadLine());

            *//*a)*//*
            Console.WriteLine("Tu Nombre es " + Nombre);
            Console.WriteLine("Tu Apellido es " + Apellido);
            Console.WriteLine("Tu Regsitro es " + Registro);

            *//*b)*//*
            Console.WriteLine("Bienvenido al Curso de TYLA {0} {1} {2}", Nombre, Apellido, Registro);*/
            /*2)Hacer un programa que solicite al usuario el ingreso de dos palabras. Luego, muestre en un mensaje si las palabras ingresadas son iguales.
                    */

            /* do
             {
                 Console.WriteLine("  ");
                 string palabra1;
                 string palabra2;

                 Console.WriteLine("Ingrese una palabra");
                 palabra1 = Console.ReadLine();
                 Console.WriteLine("Ingrese la segunda palabra");
                 palabra2 = Console.ReadLine();

                 if (palabra1 == palabra2)
                 {
                     Console.WriteLine("Las palabras son iguales");
                 }
                 else
                 {
                     Console.WriteLine("Las palabras son distintas");
                 }
             }while (true);
            */
            /*            DECISION


            1)Hacer un programa que solicite la edad del usuario y muestre si es mayor o menor de edad.
            Una persona es mayor de edad cuando ya tiene 18 años o más.*/

            /*
            int edad;
            Console.WriteLine("Ingrese su edad:");
            edad = int.Parse(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("No puede ingresar, es menor de edad");
            }
            else {
                Console.WriteLine("Bienvenido, usted es mayor de edad");
            }*/

            /*2) Hacer un programa que solicite al usuario un color y muestre si es primario o no.
            Los colores primarios son el Rojo, Azul o Amarillo.*/

            /*
            do
            {
                string Color;
                Console.WriteLine("Ingrese un color:");
                Color = Console.ReadLine().ToLower();

                if (Color == "amarillo")
                {
                    Console.WriteLine("Su color es primario");
                }
                else if (Color == "azul")
                {
                    Console.WriteLine("Su color es primario");
                }
                else if (Color == "rojo")
                {
                    Console.WriteLine("Su color es primario");
                }
                else { Console.WriteLine("Su color no es primario"); }
            }while (true);
            */

            /*3)Hacer un programa que solicite al usuario la cantidad de años de aportes realizados para la jubilación.Luego, muestre si ya aportó lo suficiente. Si no alcanza, que muestre cuantos años le faltan.
            Una persona que aporta 30 o más años es suficiente.
            */
            /*
            int años;

            Console.WriteLine("Ingrese la cantidad de años aportados: ");
            años = int.Parse(Console.ReadLine());

            if (años < 30) { 
                Console.WriteLine("No tiene la edad suficiente, le faltan {0} años", 30 - años); 
            } else {
                Console.WriteLine("Cumple con los requisitos para obtener su jubilacion");
            }*/

            /*    4)Hacer un programa que solicite al usuario un número y que escriba si es par o impar.*/

            /*
            do
            {
                try
                {
                    Console.WriteLine("");
                    int numero;
                    Console.WriteLine("Ingrese un numero:");
                    numero = int.Parse(Console.ReadLine());
                    if (numero % 2 == 0) { Console.WriteLine("Su numero es Par"); } else { Console.WriteLine("Su numero es Impar"); }
                } catch { Console.WriteLine("No es un numero, por favor ingreselo nuevamente"); }
            }while (true);

            */
            /*    REPETICION
                1)Hacer un programa que solicite al usuario el ingreso de un número positivo, no deberá finalizar hasta no tener un ingreso válido.*/

            /*
                int numero;
                do
            {

                    Console.WriteLine("");

                    Console.WriteLine("Ingrese un numero Positivo:");
                    numero = int.Parse(Console.ReadLine());
                    if (numero >= 0) { Console.WriteLine("Su numero es Positivo"); } else { Console.WriteLine("Su numero es Negativo, por favor ingrese uno positivo"); }


            } while (numero < 0);
            */
            /*
            2)Hacer un programa que solo nos permita introducir los valores “S” o “N” en una variable, no deberá finalizar hasta no tener un ingreso válido.*/
            /*
                        string sn;

                        do {
                            Console.WriteLine("Ingrese la letra S o N : ");
                            sn = Console.ReadLine();
                        }while ((sn != "S") && (sn != "N"));*/

            //3) Hacer un programa que solicite ingreso de un nombre y lo muestre 20 veces de la siguiente manera: “Mi nombre es < ingreso >”.
            /*    Console.WriteLine("Ingrese su Nombre : ");
                string Nombre = Console.ReadLine();

                for (int i = 0; i < 20; i++) {
                    Console.WriteLine(i+"."+" Mi nombre es " + Nombre);
                }*/
            //4)Hacer un programa que escriba la suma de los 100 primeros números.
            /*    int contador = 0;
                for (int i = 1; i < 100; i++) {
                    contador = contador + i;
                    Console.WriteLine(contador);

                }*/
            //5)Hacer un programa que escriba todos los números naturales que hay desde la unidad(1) hasta un número ingresado por el usuario.
            /*  Console.WriteLine("Ingrese un numero : ");
              int num = int.Parse(Console.ReadLine());
              for (int i = 1; i < num; i++)
              {
                  Console.WriteLine(i);
              }*/

            // 6) Hacer un programa que permita introducir un número por el usuario y, escriba y cuente los múltiplos de 3 desde la unidad(1) hasta el número ingresado. 
            /*            Console.WriteLine("Ingrese un numero : ");
                        int num = int.Parse(Console.ReadLine());
                        for (int i = 1; i < num; i++) {
                            if (i%3 == 0)
                            {
                            Console.WriteLine(i);
                            }
                        };*/
            // 7)Hacer un programa que solicite 20 ingresos al usuario de un número cada vez. Al finalizar, muestre cuántos números pares fueron ingresados.
            /*        int contador = 0;
                    for (int i = 0; i < 20; i++)
                    {Console.WriteLine("Ingrese un numero : ");
                        int numero = int.Parse(Console.ReadLine());
                        if (numero % 2 == 0) {
                            contador = contador + 1;
                        }
                    }Console.WriteLine("Usted ingreso "+contador+" numeros pares");*/
            //8)Hacer un programa que permita introducir dos números por el usuario, y escriba todos los números naturales que hay entre ambos números, incluyendolos, empezando por el menor. Además, se pide contar cuántos números hay entre ambos números, cuántos de ellos son pares y la suma de todos los impares. Mostrar los resultados calculados por pantalla. 
            /*      Console.WriteLine("Ingrese un numero : ");
                  int num = int.Parse(Console.ReadLine());
                  Console.WriteLine("Ingrese un segundo numero : ");
                  int num2 = int.Parse(Console.ReadLine());
                  int contador = 0;
                  int pares = 0;
                  int impar = 0;
                  for (int i = num; i < num2 + 1; i++)
                  {
                      Console.WriteLine(i);
                      contador = contador + 1;
                      if (i % 2 == 0)
                      {
                          pares = pares + 1;

                      }
                      if (i % 2 != 0) {
                          impar = impar + i;
                      }
                  }
                      Console.WriteLine("entre " + num + " y " + num2 + " hay " + contador + " numeros");
                      Console.WriteLine("entre " + num + " y " + num2 + " hay " + pares + " numeros pares");
                      Console.WriteLine("La suma de los numeros impares es : "+impar);*/
            //9)Hacer un programa que solicite el ingreso de 5 números y que muestre el mayor y el menor de los ingresados.
            /*            int mayor = 0;
                        int menor = 0;
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("Ingrese un numero : ");
                            int numero = int.Parse(Console.ReadLine());
                            if (i == 0) {
                                mayor = numero;
                                menor = numero;
                            }
                            if (numero > mayor)
                            {
                                mayor = numero;
                            }
                            if (numero < menor)
                            {
                                menor = numero;
                            }
                        }
                            Console.WriteLine("El mayor es : " + mayor + " y el menor es : " + menor);*/

            // 10) Hacer un programa que solicite el ingreso de un número y calcule el factorial.
            /*
                        Console.WriteLine("Ingrese un numero : ");
                        double numero = int.Parse(Console.ReadLine());
                        double factorial = 1;
                        for (double i = 1; i < numero+1; i++) {
                            factorial = factorial * i;
                        }Console.WriteLine(factorial);*/
            /*Arrays y Matrices
            1)Hacer un programa que solicite al usuario los días de la semana, los guarde en un array de 7 posiciones y los muestre de la siguiente manera: “Día<posición>: < Ingreso >”*/

            /*String[] Dias_de_Semana = new String[7];
            int contador = 0;

            for (int i = 0; i < 7; i++)

            { Console.WriteLine("Ingrese un dia de la semana");
                Dias_de_Semana[i] = Console.ReadLine();
            }
            foreach (var d in Dias_de_Semana) {
                Console.WriteLine("Dia {0}: {1}",contador,d);
                contador++;
            }*/

            /*2)Hacer un programa que solicite al usuario el largo del array.Luego, en cada posición del array, guardar la posición al cuadrado.*/


            /*Console.WriteLine("Ingrese el Largo del Array: ");
            int[] al_cuadrado =new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < al_cuadrado.Length; i++) {
                al_cuadrado[i] = i*i;
            }
            foreach (var a in al_cuadrado)
            {
                Console.Write("\n");
                Console.Write(a);
            }
            */

            //3)Hacer un programa que pida el tamaño de un array, y que luego lo complete pero solo permita ingresar números múltiplos de 4.
            /*
            Console.WriteLine("Ingrese el tamaño del array : ");
            int[] multiplos_de_cuatro = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < multiplos_de_cuatro.Length; i++)
            {
                Console.WriteLine("Ingrese un multiplo de 4 : ");
                multiplos_de_cuatro[i] = int.Parse(Console.ReadLine());
                if (multiplos_de_cuatro[i] % 4 != 0)
                {
                    do
                    {
                        Console.WriteLine("Por favor ingrese un multiplo de 4");
                        multiplos_de_cuatro[i] = int.Parse(Console.ReadLine());
                    } while (multiplos_de_cuatro[i] % 4 != 0);
                }
            } foreach (var a in multiplos_de_cuatro)
            {
                Console.Write(a+" ");
            }*/
            //4)Hacer un programa que permita ingresar 20 números enteros, calcule la suma de todos los elementos y la muestre por pantalla.
            /*int[] suma = new int[20];
            int contador = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un numero :");
                suma[i] = int.Parse(Console.ReadLine());
                contador+=suma[i];

            }Console.WriteLine("\n");
            Console.WriteLine(contador);*/
            //5)Hacer un programa que cree una matriz de 3 filas y 4 columnas, solicite números para llenar todas las posiciones y calcule y muestre la suma de todos los elementos guardados.
            /*
                        int[,] Matriz = new int[3, 4];
                        int contador = 0;
                        for (int i = 0; i < 3; i++)
                        {

                            for (int j = 0; j < 4; j++)
                            {
                                Console.WriteLine("Ingrese un numero : ");
                                Matriz[i, j] = int.Parse(Console.ReadLine());
                                contador += Matriz[i, j];
                            }

                        }
                        Console.WriteLine("\n");
                        Console.WriteLine(contador);*/

            //6)Hacer un programa que cree una matriz de n filas y m columnas(debe solicitar los valores de n y m al usuario), solicite valores al usuario para completarla y muestre los valores de la última fila y de la última columna.
            /*Console.WriteLine("Ingrese la cantidad de filas para la Matriz : ");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de columnas para la Matriz : ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] Matriz = new int[filas, columnas];
            for (int n = 0; n < filas; n++)
            {

                for (int m = 0; m < columnas; m++)
                {
                    Console.WriteLine("Ingrese un numero : ");
                    Matriz[n, m] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Los valores de la ultima Fila son : ");
            for (int i = 0; i < columnas; i++)
            {
                
                Console.Write(Matriz[filas - 1, i]+" ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Los valores de la ultima Columna son : ");
            for (int i = 0; i < filas; i++)
            {

                Console.WriteLine(Matriz[i, columnas - 1] + " ");
            }*/


            /*    Lectura de Algoritmos y Testeo
            A)Explicar qué hacen los siguientes algoritmos
            1)PC1*/
            /*
            int[,] Matriz = new int[10, 10];
            for (int i = 1; i < 10; i++)
            {

                for (int j = 1; j < 10; j++)
                {
                    if (i == j)
                    {
                        Matriz[i, j] = 1;
                    }
                    else
                    {
                        Matriz[i, j] = 0;
                    }
                    Console.Write(Matriz[i, j]+" ");

                }
                Console.Write("\n");
            }*/

        }
        /*
            Funciones
            1)Hacer una función que calcule el resto de una división entera entre dos números positivos..No se puede utilizar “MOD” en este ejercicio.*/
        /*public static void DivisionEntera()
        {

            do
            {
                Console.WriteLine("Ingrese el Dividendo");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Divisor");
                int numero2 = int.Parse(Console.ReadLine());

                int division = numero / numero2;
                int numero3 = numero2 * division;
                int numero4 = numero - numero3;

                Console.WriteLine("El resto es:" + numero4);
                Console.WriteLine("\n");
            } while (true);

            

            
        }*/

        /*    2)Hacer una función que multiplique dos números positivos.
        No se puede utilizar “ * ” en este ejercicio.*/
        /*public static void Multiplicacion_Positivos(){

        do
        {
            Console.WriteLine("Ingrese el Multiplicando");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Multiplicador");
            int numero2 = int.Parse(Console.ReadLine());

            int numero3 = 0;
            for (int i = 0; i < numero2; i++)
            {
                numero3 += numero;
            };
            Console.WriteLine("\n");
            Console.WriteLine("El resultado es:"+numero3);
            Console.WriteLine("\n");
        }
        while (true);}*/

        //3)Hacer una función que multiplique dos números no negativos. No se puede utilizar “ * ” en este ejercicio.
        /*public static void Multiplicacion_no_negativos()
        {

            do
            {
                Console.WriteLine("Ingrese el Multiplicando");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Multiplicador");
                int numero2 = int.Parse(Console.ReadLine());

                int numero3 = 0;
                for (int i = 0; i < numero2; i++)
                {
                    numero3 += numero;
                };
                Console.WriteLine("\n");
                Console.WriteLine("El resultado es:" + numero3);
                Console.WriteLine("\n");
            }
            while (true);
        }*/
        //Hacer una función que dado un número positivo, muestra si es primo o no. Un número es primo si los divisores son dos, el 1 y el mismo número.
        /*public static void Primo()
        {
            Console.WriteLine("Ingrese un numero : ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine("El numero " + numero + " no es Primo");
                    break;
                }
                else { Console.WriteLine("El numero " + numero + " es Primo");
                    break;
                }
            }
            
        }*/
        //5)Hacer una función que solicite números no negativos al usuario hasta que ingrese un cero.Luego, calcular el promedio de todos los números ingresados sin contabilizar cero.Si no es posible realizar este cálculo, devolver cero.
/*        public static void Promedio() {
            int cero = 0;
            int suma = 0;
            int contador = 0;
            int promedio;
            do
            {
                Console.WriteLine("Ingrese un numero no negativo");
                int numero = int.Parse(Console.ReadLine());
                cero = numero;
                suma += numero;
                contador = contador + 1;
            } while (cero != 0);
            promedio = suma / (contador-1);
            Console.WriteLine("\n");
            Console.WriteLine("el promedio es : "+promedio);
        }*/

}
}
