// If

int entero = 100;

if (entero == 99)
{
	Console.WriteLine("Es 99!!!");
}
else if (entero == 100)
{
	Console.WriteLine("Es 100!!!");
}
else
{
	Console.WriteLine("No es ni 99 ni 100, :v");
}

bool autorizado = false;

if (autorizado)
{
	Console.WriteLine("Puede ingresar!");
}
else
{
	Console.WriteLine("No puede ingresar :(");
}


// Numeros impares

int number1 = 2;

if (number1 % 2 == 1)
{
	Console.WriteLine("El numero: " + number1 + " es IMPAR!!!");
}
else
{
	Console.WriteLine("El numero: " + number1 + " es PAR!!!");
}