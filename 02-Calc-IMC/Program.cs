// CALCULADORA DE IMC
Console.WriteLine(".......");
Console.WriteLine("Calculadora de IMC in C#");
Console.WriteLine(".......");

// Creamos las variables

Console.WriteLine("Ingresa tu peso en kg:"); // pedimos que se ingrese el peso por consola
double masa = double.Parse(Console.ReadLine()); // convertimos a float los datos de entrada del usuario por consola

Console.WriteLine("Ingresa tu estatura en metros:"); // pedimos que se ingrese la estatura por consola
double estatura = double.Parse(Console.ReadLine());

// Calculamos el resultado

double imc = masa / Math.Pow(estatura, 2);

// Se muestra el valor de IMC obtenido

Console.WriteLine("Tu IMC es: " + imc);

Console.WriteLine(".......");
Console.WriteLine(".......");