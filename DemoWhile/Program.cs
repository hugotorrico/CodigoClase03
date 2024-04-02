/*Bucle WHILE*/

/*Ejemplo 01:  */
int contador = 0;
Console.WriteLine("MENSAJE HOLA MUNDO");
Console.WriteLine("=====================");
while (contador < 5)
{
    Console.WriteLine("Hola Mundo");
    //contador=contador+ 1;
    contador++;
}



/*Ejemplo 02:  */
Console.WriteLine("TABLA DE MULTIPLICAR");
Console.WriteLine("=====================");
int acumulador2 = 1;
while (acumulador2 <= 12)
{
    int producto = acumulador2 * 8;
    Console.WriteLine("8 X " + acumulador2 + " = " + producto);
    acumulador2++;
}


/*Ejemplo 03: 50 primeros números pares usando WHILE */
Console.WriteLine("NÚMEROS PARES");
Console.WriteLine("=====================");
int acumulador3 = 0;

while (acumulador3 < 50)
{
    int par = acumulador3 * 2;
    Console.WriteLine(par);
    acumulador3++;
}

/*Ejemplo 04: Ingresa un número y dime de cuántos dígitos es
 *input=121     resultado=3
 *input=11      resultado=2
 *input=45524  resultado=6
 */
int numero3 = 123;
int contadorDivisiones = 0;


while (numero3 > 10)
{
    numero3 = numero3 / 10;
    contadorDivisiones++;
}
Console.WriteLine("El número de dígitos es:");
Console.WriteLine(contadorDivisiones + 1);

Console.Read();