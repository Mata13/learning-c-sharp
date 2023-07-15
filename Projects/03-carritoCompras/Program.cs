using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		List<string> carrito = new List<string>(); // definimos la lista vacia

		bool compra = true;

		while (compra)
		{
			Console.WriteLine("...................");
			Console.WriteLine("Bienvenid@ al CHIKERO PRO");
			Console.WriteLine("...................");

			Console.WriteLine("Presiona enter para continuar: ");
			Console.ReadKey();

			Console.WriteLine("...................");
			Console.WriteLine("Menu de opciones");

			Console.WriteLine("1. Agregar un producto al carrito");
			Console.WriteLine("2. Ver carrito");
			Console.WriteLine("3. Pagar");
			Console.WriteLine("4. Cancelar");
			Console.WriteLine("...................");

			Console.WriteLine("Elige una opcion para continuar");
			string opcionUsuario = Console.ReadLine();

			// Console.WriteLine(opcionUsuario);

			// break;

			switch (opcionUsuario)
			{
				case "1":
					Console.WriteLine("Ingresa el nombre del producto");
					string producto = Console.ReadLine();
					carrito.Add(producto);
					Console.WriteLine($"'{producto}' agregado al carrito.");
					break;

				case "2":
					Console.WriteLine("Ver el carrito");
					foreach (string elementoCarrito in carrito)
					{
						Console.WriteLine(elementoCarrito);
					}
					break;
				case "3":
					Console.WriteLine("Pagando...");
					Console.WriteLine("Gracias por tu compra!!!");
					compra = false;
					break;
				case "4":
					Console.WriteLine("Cancelando...");
					compra = false;
					break;
				default:
				Console.WriteLine("Opcion incorrecta. Intenta de nuevo");
				break;
			}

		}
	}
}