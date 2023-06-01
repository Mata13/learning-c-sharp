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

			int[] numArray = { 23, 45, 16, 37, 3, 99, 22 };

			Console.WriteLine("El elemento del array con indice [0] es" + " " + numArray[0]); // imprime el elemento con indice 0

			Console.WriteLine("El elemento del array con indice [4] es" + " " + numArray[4]); // imprime el elemento con indice 4

			Console.WriteLine("El elemento del array con indice [6] es" + " " + numArray[6]); // imprime el elemento con indice 6

			Console.WriteLine("The length of this array is" + " " + numArray.Length); // cantidad de elementos del array

			Console.WriteLine("...................");

			Console.WriteLine("Array de texto");
			Console.WriteLine("...................");

			string[] animales = { "perro", "gato", "tigre" }; // definimos un array de animales

			Console.WriteLine("El elemento con indice [0] del array de animales es:" + " " + animales[0]); // imprime el elemento con indice 0 del array

			Console.WriteLine("El elemento con indice [2] del array de animales es:" + " " + animales[2]); // imprime el elemento con indice 2 del array

			Console.WriteLine("The length of this array is" + " " + animales.Length); // obtenemos el tamano del array

			Console.WriteLine("...................");

			Console.WriteLine("Modifying Array Elements");
			Console.WriteLine("...................");

			numArray[6] = 121; // cambia el valor 22 por 121

			Console.WriteLine(numArray.Length);
			Console.WriteLine(numArray[6]); // ahora, numArray = {23, 45, 16, 37, 3, 99, 121}

			Console.WriteLine("...................");

			Console.WriteLine("Array con diferentes tipos de datos");
			Console.WriteLine("...................");

			dynamic[] datosMixtos = { "texto", "121", "true", false, 134, new string[] { "Lista dentro de otra lista" } }; // definimos un array con diferentes tipos de datos

			Console.WriteLine(datosMixtos.Length);
			Console.WriteLine(datosMixtos[1]);
			Console.WriteLine(datosMixtos[3]);
			Console.WriteLine(datosMixtos[4]);
			Console.WriteLine(datosMixtos[5][0]); // podemos obtener un elemeto de un array que esta dentro de otro array ["index of the firs array"]["index of the first inner array"]

			Console.WriteLine("...................");

			Console.WriteLine("Arrays Dinamicos");
			Console.WriteLine("...................");

			// declaramos una lista
			List<int> numbers = new List<int>();

			// agregando elementos al array dinamico using Add() method.
			numbers.Add(0);
			numbers.Add(1);

			Console.WriteLine(numbers.Count); // obtenemos el numero de elementos guardados del array dinamico

			Console.WriteLine(numbers[0]); // accediendo al elemento del array dinamico
			Console.WriteLine(numbers[1]); // accediendo al elemento del array dinamico

		}

	}

}