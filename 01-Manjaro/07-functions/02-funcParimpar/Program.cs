// Funcion par-impar

/*

Console.WriteLine("Ingresa un numero: "); // ingresamos un numero por consola
;
int num = int.Parse(Console.ReadLine()); // convertimos el string a entero

// Console.WriteLine($"El numero que ingresaste es: {num}"); // comprobamos el numero ingresado

// comprobamos si el numero es par o impar

if (num % 2 == 0) {
	Console.WriteLine($"El numero {num} es par.");
} else
{
	Console.WriteLine($"El numero {num} es impar");
}

*/

using System;
namespace MyProgram
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Ingresa un numero entero positivo:");
		}

		static void CheckEvenOdd(int num)
		{
			if (num % 2 == 0)
			{
				Console.WriteLine("El numero {num} es par");
			}
			else
			{
				Console.WriteLine("El numero {num} es impar");
			}
		}

	}
}
