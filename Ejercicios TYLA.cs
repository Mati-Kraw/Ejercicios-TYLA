// See https://aka.ms/new-console-template for more information
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

Console.WriteLine("Tu Nombre es " + Nombre);
Console.WriteLine("Tu Apellido es " + Apellido);
Console.WriteLine("Tu Regsitro es " + Registro);

Console.WriteLine("Bienvenido al Curso de TYLA {0} {1} {2}",Nombre,Apellido,Registro);
*/
/*
do
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
/*
int años;

Console.WriteLine("Ingrese la cantidad de años aportados: ");
años = int.Parse(Console.ReadLine());

if (años < 30) { 
    Console.WriteLine("No tiene la edad suficiente, le faltan {0} años", 30 - años); 
} else {
    Console.WriteLine("Cumple con los requisitos para obtener su jubilacion");
}*/
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

/*do
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
}while(true);*/
/*do
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
while (true);
*/
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

Console.WriteLine("Ingrese el Largo del Array: ");
int[] al_cuadrado =new int[int.Parse(Console.ReadLine())];
for (int i = 0; i < al_cuadrado.Length; i++) {
    al_cuadrado[i] = i*i;
}
foreach (var a in al_cuadrado)
{
    Console.WriteLine(a);
}