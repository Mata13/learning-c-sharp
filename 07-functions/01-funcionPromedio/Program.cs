// Funciones
using System;

namespace MyProgram
{

	class Program
	{

		static void Main()
		{
			// creamos la funcion promedio
			double GetPromedio(double num1, double num2, double num3)
			{
				double sum = num1 + num2 + num3;
				double prom = sum / 3;

				return prom;
			}

			// llamamos a la funcion
			double resultado = GetPromedio(5.0, 5.0, 5.0);
			Console.WriteLine($"El promedio final es: {resultado}");

			resultado = GetPromedio(10.0, 10.0, 10.0);
			Console.WriteLine($"El promedio final es: {resultado}");

			resultado = GetPromedio(3.3, 8.5, 6.5);
			Console.WriteLine($"El promedio final es: {resultado}");

			resultado = GetPromedio(1.3, 8.5, 9.8);
			Console.WriteLine($"El promedio final es: {resultado}");

		}
	}

}