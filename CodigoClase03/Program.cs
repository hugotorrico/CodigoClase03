// See https://aka.ms/new-console-template for more information


//i=contador
//i<5

using static System.Runtime.InteropServices.JavaScript.JSType;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Hello, World!");
}

/*
 * i=0 entonces 0<5 =>true
 * i=1 entonces 1<5 =>true
 * i=2 entonces 2<5 =>true
 * i=3 entonces 3<5 =>true
 * i=4 entonces 4<5 =>true
 * i=5 entonces 5<5 =>FALSE
 */

/*Ejemplo 01: Tabla de Multiplicar del 8 */
Console.WriteLine("TABLA DE MULTIPLICAR");
Console.WriteLine("=====================");
for (int i = 0; i < 12; i++)
{
    int numero2 = i + 1;
    int producto = numero2 * 8;
    Console.WriteLine("8 X " + numero2 + " = " + producto);
}


/*Ejemplo 02: 50 primeros números pares */
Console.WriteLine("NÚMEROS PARES");
Console.WriteLine("=====================");
for (int i = 0; i < 50; i++)
{   
    int par = i * 2;
    Console.WriteLine(par);
}

/*Ejemplo 03 A: 50 primeros números IMPARES */
Console.WriteLine("NÚMEROS IMPARES A");
Console.WriteLine("=====================");
for (int i = 1; i <= 50; i++)
{
    Console.WriteLine((i * 2) -1);
}

/*Ejemplo 03 B: 50 primeros números IMPARES */
Console.WriteLine("NÚMEROS IMPARES B");
Console.WriteLine("=====================");
for (int i = 1; i <= 100; i++)
{
    if (i%2!=0) //Si el residuo es diferente de 0
    {
        Console.WriteLine(i);
    }    
}

/*Ejemplo 03 C: 50 primeros números IMPARES */
Console.WriteLine("NÚMEROS IMPARES B");
Console.WriteLine("=====================");
// C++   i++ => i=i+1
for (int i = 1; i <= 99; i=i+2)
{    
 Console.WriteLine(i);
}

/*Ejemplo 04 C: SUMES 10 Primeros números naturales */
int Suma = 0;//Acumulador
for (int i = 1; i <= 10; i++)//i=contador
{
    //Suma = Suma + i;
    Suma += i;

}
Console.WriteLine("El resultado de la suma es:");
Console.WriteLine(Suma);

/*Ejemplo 05  A: 
 *SUMES 50 Primeros números pares
 *SUMES 50 Primeros números impares
 */

int sumaPares = 0;
int sumaImpares = 0;

for (int i = 1; i <= 99; i = i + 2)
{
    sumaImpares = sumaImpares + i;
}

for (int i = 2; i <= 100; i = i + 2)
{
    sumaPares = sumaPares + i;
}
Console.WriteLine("El resultado de la suma PAR es:");
Console.WriteLine(sumaPares);
Console.WriteLine("El resultado de la suma IMPAR es:");
Console.WriteLine(sumaImpares);



/*Ejemplo 05  A: 
 *SUMES 50 Primeros números pares
 *SUMES 50 Primeros números impares
 */

int sumaPares2 = 0;
int sumaImpares2 = 0;
int numeroPar = 0;
int numeroImpar = 0;

for (int i = 1; i <= 50 ; i++ )
{
    numeroPar = i * 2;
    numeroImpar = numeroPar - 1;

    sumaPares2 = sumaPares2 + numeroPar;
    sumaImpares2=sumaImpares2 + numeroImpar;
}

Console.WriteLine("El resultado de la suma PAR2 es:");
Console.WriteLine(sumaPares2);
Console.WriteLine("El resultado de la suma IMPAR2 es:");
Console.WriteLine(sumaImpares2);


/*Ejemplo 06  : 
 *Escribe en pantalla el número y obten su factorial
 *Input=>5
 *Resultado=1*2*3*4*5=120
 *
 *Input=>6
 *Resultado=1*2*3*4*5*6=720
 *
 *Input=>4
 *Resultad=1*2*3*4=24
 */

int numero = 6;
int factorial = 1;

for (int i = 1; i <= numero; i++)
{
    //1*2*3*4*5
    factorial = factorial * i;
}

Console.WriteLine("El resultado del factorial es:");
Console.WriteLine(factorial);















Console.Read();
