/*Bucle DO WHILE*/

/*Ejemplo 01: 50 primeros números pares usando DO WHILE */
int acumulador4 = 0;
do
{
    acumulador4++;
    int par = acumulador4 * 2;
    Console.WriteLine(par);

} while (acumulador4 < 50);

/*Ejemplo 02: Escribe un programa que vas ingresando números
 * y termina cuando ingresar un número par*/
/*
int numeroIngresado = 0;

do
{
    Console.WriteLine("Ingrese un número");
    numeroIngresado = Convert.ToInt32(Console.ReadLine());
}
while (numeroIngresado % 2 != 0);

*/

/*Ejemplo 03:*/
/*
int opcion = 0;
int lado = 0;
int area = 0;
int volumen = 0;
do
{
    Console.WriteLine("INGRESE UNA DE LAS OPCIONES");
    Console.WriteLine("===========================");

    Console.WriteLine("\n");//Salto de Línea
    Console.WriteLine("1.Calcular el área del cuadrado");
    Console.WriteLine("2.Calcular el volúmen del cubo");
    Console.WriteLine("3.Salir");
    Console.WriteLine("4.Nuevo Menu");


    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("AREA");
            Console.WriteLine("AREA2");
            Console.WriteLine("======");
            Console.WriteLine("Ingrese el lado del cuadrado");

            lado = Convert.ToInt32(Console.ReadLine());
            area = lado * lado;

            Console.WriteLine("El área del cuadrado es: ");
            Console.WriteLine(area);

            break;

        case 2:
            Console.WriteLine("VOLUMEN");
            Console.WriteLine("========");
            Console.WriteLine("Ingrese el lado del cuadrado");

            lado = Convert.ToInt32(Console.ReadLine());
            volumen = lado * lado * lado;

            Console.WriteLine("El volumen del cubo es: ");
            Console.WriteLine(volumen);
            break;

        case 3:
            Console.WriteLine("GRACIAS");
            break;

        default:
            Console.WriteLine("OPCIÓN INCORRECTA");
            break;
    }

}
while (opcion != 3);

*/

/*Ejemplo 04:*/
string usuario;
string password;
bool Acceso = false;
do
{
    Console.WriteLine("Ingrese Usuario");
    usuario = Console.ReadLine();

    Console.WriteLine("Ingrese Password");
    password = Console.ReadLine();

    if (usuario == "htorrico" && password == "123456")
    {
        Console.WriteLine("=============");
        Console.WriteLine("Bienvenido");
        Console.WriteLine("=============");
        Acceso = true;
    }
    else
    {
        Console.WriteLine("=============");
        Console.WriteLine("Usuario y Password Incorrecto");
        Console.WriteLine("=============");

    }
} while (!Acceso);

