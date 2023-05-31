// Arrays

using System;

namespace MyProgram
{

	class Program
	{

		static void Main()
		{

			Console.WriteLine("...................");
			Console.WriteLine("Arrays");
			Console.WriteLine("...................");

			Console.WriteLine("podemos guardar muchos datos en un mismo lugar");
			Console.WriteLine("...................");

			Console.WriteLine("...................");

			Console.WriteLine("Matriz o array de numeros enteros");
			Console.WriteLine("...................");

			int[] numArray = {23, 45, 16, 37, 3, 99, 22};

			Console.WriteLine("El elemento del array con indice [0] es" + " " + numArray[0]); // imprime el elemento con indice 0

			Console.WriteLine("El elemento del array con indice [4] es" + " " + numArray[4]); // imprime el elemento con indice 4

			Console.WriteLine("El elemento del array con indice [6] es" + " " + numArray[6]); // imprime el elemento con indice 6

			Console.WriteLine("The length of this array is" + " " + numArray.Length); // cantidad de elementos del array

			Console.WriteLine("...................");

			Console.WriteLine("Array de texto");
			Console.WriteLine("...................");

			string[] animales = {"perro", "gato", "tigre"};

			Console.WriteLine("El elemento con indice [0] del array de animales es:" + " " + animales[0]); // imprime el elemento con indice 0 del array

			Console.WriteLine("El elemento con indice [2] del array de animales es:" + " " + animales[2]); // imprime el elemento con indice 2 del array

			Console.WriteLine("The length of this array is" + " " + animales.Length);

		}

	}

}