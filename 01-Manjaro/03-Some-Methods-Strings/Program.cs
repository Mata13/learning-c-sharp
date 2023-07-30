// Some basic methods with Strings in C#

using System;

namespace MyProgram
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("............................");
			Console.WriteLine("STRINGS");
			Console.WriteLine("............................");

			// Length
			Console.WriteLine("Length");
			Console.WriteLine("............................");

			string str = "Hello, World!"; // definimos la variable
			int length = str.Length; // metodo lenght determina la cantidad de caracteres del string
			Console.WriteLine(length);

			Console.WriteLine("............................");

			// Substring
			Console.WriteLine("Substrings");
			Console.WriteLine("............................");

			string str2 = str.Substring(1, 4); // este metodo nos devuelve un substring (i inicial, length)
			Console.WriteLine(str2);

			string str3 = str.Substring(0, 5); // este metodo nos devuelve un substring (i inicial, length)
			Console.WriteLine(str3);

			string str4 = str.Substring(3, 8); // este metodo nos devuelve un substring (i inicial, length)
			Console.WriteLine(str4);

			string str5 = str.Substring(0, 4); // este metodo nos devuelve un substring (i inicial, length)
			Console.WriteLine(str5);

			string str6 = str.Substring(6, 3); // este metodo nos devuelve un substring (i inicial, length)
			Console.WriteLine(str6);

			Console.WriteLine("............................");

			// To lower and to upper
			Console.WriteLine("lowercase and uppercase");
			Console.WriteLine("............................");

			Console.WriteLine(str); // imprimimos el string original

			String lower1 = str.ToLower(); // transforma todo a minusculas
			Console.WriteLine(lower1);

			String upper1 = str.ToUpper(); // transforma todo a mayusculas
			Console.WriteLine(upper1);

			Console.WriteLine("............................");

			// otros ejemplos

			String str7 = "Perros y Gatos";
			String str10 = "Los Anillos de Poder";
			String str13 = "Mas alla del Universo";

			String str8 = str7.ToUpper(); // transforma todo a mayusculas
			String str9 = str7.ToLower(); // transforma todo a minusculas

			String str11 = str10.ToUpper(); // transforma todo a mayusculas
			String str12 = str11.ToLower(); // transforma todo a minusculas

			String str14 = str13.ToUpper(); // transforma todo a mayusculas
			String str15 = str13.ToLower(); // transforma todo a minusculas

			Console.WriteLine("String original = " + str7);
			Console.WriteLine("String UpperCase (ToUpper) = " + str8);
			Console.WriteLine("String LowerCase (ToLower) = " + str9);
			Console.WriteLine("............................");

			Console.WriteLine("String original = " + str10);
			Console.WriteLine("String UpperCase (ToUpper) = " + str11);
			Console.WriteLine("String LowerCase (ToLower) = " + str12);
			Console.WriteLine("............................");

			Console.WriteLine("String original = " + str13);
			Console.WriteLine("String UpperCase (ToUpper) = " + str14);
			Console.WriteLine("String LowerCase (ToLower) = " + str15);
			Console.WriteLine("............................");

			// Replace
			Console.WriteLine("Replace");
			Console.WriteLine("............................");

			String strReplaced1 = str13.Replace("Universo", "Cielo"); // elemento a reemplazar, nuevo elemento

			Console.WriteLine("String original = " + str13);
			Console.WriteLine("String replaced = " + strReplaced1);
			Console.WriteLine("............................");

			// Concatenate
			Console.WriteLine("Concatenate");
			Console.WriteLine("............................");

			Console.WriteLine("String 1 = " + str7);
			Console.WriteLine("String 2 = " + str10);

			String combined1 = String.Concat(str7, str10); // concatenar o combinar dos strings
			Console.WriteLine("String concatenated = " + combined1);
			Console.WriteLine("............................");

		}
	}
}