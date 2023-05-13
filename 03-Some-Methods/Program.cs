// Some basic methods in C#

// STRINGS

Console.WriteLine("............................");
Console.WriteLine("STRINGS");
Console.WriteLine("............................");

Console.WriteLine("Length");
Console.WriteLine("............................");

string str = "Hello, World!"; // definimos la variable
int length = str.Length; // metodo lenght determina la cantidad de caracteres del string
Console.WriteLine(length);

Console.WriteLine("............................");

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