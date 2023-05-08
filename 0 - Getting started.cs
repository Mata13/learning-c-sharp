// Learning C#


// Primer Hola Mundo en C#
Console.WriteLine("Hola Mundo!");



// agregando un espacio en lo que se imprime
string CONST_SPACE = "---------------------------------"; // solo para separar lo que voy haciendo
Console.WriteLine(CONST_SPACE);


// Variables

Console.WriteLine("Variables");
Console.WriteLine(CONST_SPACE);

// C# is case sensitive




// Strings
Console.WriteLine("strings");

// se coloca el tipo de variable cuando se crean por primera vez

string libro = "Los Anillos del Poder";
string telef = "406-235 2352";
string color = "negro";
string animal = "perro "; // agreggo un espacio para la concatenacion


Console.WriteLine(libro);
Console.WriteLine(telef);
Console.WriteLine(color);
Console.WriteLine(animal);


// Se usa camelCase para declarar variables, ejemplo de formato
string fechaDeNacimiento = "12031994";
Console.WriteLine(fechaDeNacimiento);

// Se usa SCREAMING_SNAKE_CASE se usa para las constantes, ejemplo de formato
string FECHA_DE_NACIMIENTO = "21032015";
Console.WriteLine(FECHA_DE_NACIMIENTO);

// Se usa snake_case para bases de datos y un ejemplo del formato seria
string fecha_de_nacimiento = "24091990";
Console.WriteLine(fecha_de_nacimiento);

// Se usa kebab-case para el nombre de las carpetas y urls, ejemplo de formato
// fecha-de-nacimiento


//  Para concatenar textos se hace lo siguiente
string colorDeanimal = animal + color;
Console.WriteLine(colorDeanimal);

// Podemos reasignar el valor a una variable reescribiendo su nuevo valor
libro = "Metro 2033";
Console.WriteLine(libro);


Console.WriteLine(CONST_SPACE);



// Numeros
Console.WriteLine("numeros");

// Enteros
Console.WriteLine("enteros");

int number1 = 9;
Console.WriteLine(number1);

// Decimales
Console.WriteLine("decimales");

double num1 = 3.1415;
Console.WriteLine(num1);

Console.WriteLine(CONST_SPACE);


// Concatenando texto con numeros
Console.WriteLine("concatenando numeros y strings");

string numeroDelperro = "El numero del " + animal + "es " + number1;
Console.WriteLine(numeroDelperro);

Console.WriteLine(CONST_SPACE);

// Operaciones
Console.WriteLine("operaciones");

// Modulo %

// Veamos si un numero x es par usando x % 2 == 0

int number2 = 18; // definimos un numero
int isPar = number2 % 2; // creamos una variable que se llame isPar -- va ser par si isPar = 0.
Console.WriteLine(isPar); // imprimimos el valor de isPar para verficar si es cero


Console.WriteLine(CONST_SPACE);


// pueden ocurrir ciertas situaciones como en los siguiendes 2 ejemplos

// no es lo mismo esto
string prueba1 = color + number1 + number2; // primero toma el string y concatena todas las variables
// que esto
string prueba2 = number1 + number2 + color; // primero realiza la operacion de adicion y luego concatena el resultado al color

// veamos el resultado
Console.WriteLine("ESTAS SON LAS VARIABLES: ");
Console.WriteLine(color);
Console.WriteLine(number1);
Console.WriteLine(number2);

Console.WriteLine("RESULTADO 1: ");
Console.WriteLine(prueba1);
Console.WriteLine("RESULTADO 2: ");
Console.WriteLine(prueba2);




string CONST_SPACE2 = "................";


Console.WriteLine(CONST_SPACE);
Console.WriteLine("PRACTICANDO CON VARIABLES");
Console.WriteLine(CONST_SPACE);

// Exercises
Console.WriteLine("1. Write a program that calculates the area of a rectangle given its lenght and width.");
Console.WriteLine(CONST_SPACE2);

int lenght = 5;
int width = 10;

int areaRectangle = lenght * width;
Console.WriteLine("The area of the rectangle is: " + areaRectangle);

Console.WriteLine(CONST_SPACE2);

Console.WriteLine("2. Write a program that calculates the area of a triangle given its base and height.");
Console.WriteLine(CONST_SPACE2);

double baseTriangle = 5.0;
double heightTriangle = 15.0;

double areaTriangle = baseTriangle * heightTriangle * 1/2;
Console.WriteLine("The area of the triangle is: " + areaTriangle);

Console.WriteLine(CONST_SPACE2);

Console.WriteLine("3. Write a program that converts a temperature from Celsius to Farenheit.");
Console.WriteLine(CONST_SPACE2);

double celsius = 25.0;
double farenheit = (celsius * 9/5) + 32;

Console.WriteLine(celsius + " Celsius = " + farenheit + " Farenheit");

Console.WriteLine(CONST_SPACE2);

Console.WriteLine("4. Write a program that calculates the sum of two integers.");
Console.WriteLine(CONST_SPACE2);

int addition = number1 + number2;
Console.WriteLine("La suma de " + number1 + " y " + number2 + " es " + addition);

Console.WriteLine(CONST_SPACE2);

Console.WriteLine("5. Write a program that calculates the difference of two integers.");
Console.WriteLine(CONST_SPACE2);

int difference = number2 - number1; // sup that number1 and number2 are integer+, and number2 > number1
Console.WriteLine("La diferencia entre " + number2 + " y " + number1 + " es " + difference);

Console.WriteLine(CONST_SPACE2);

Console.WriteLine("6. Write a program that calculates the product of two integers.");
Console.WriteLine(CONST_SPACE2);

int product = number1 * number2;
Console.WriteLine("El producto de " + number1 + " y " + number2 + " es " + product);

Console.WriteLine(CONST_SPACE2);

Console.WriteLine("7. Write a program that calculates the quotient and remainder of two integers.");
Console.WriteLine(CONST_SPACE2);

int divisor = 7;
int dividend = 25;

int quotient = dividend / divisor;
Console.WriteLine("El quotient de " + dividend + " dividido por " + divisor + " es " + quotient );

int residuo = dividend % divisor;
Console.WriteLine("El resudio de " + dividend + " dividido por " + divisor + " es " + residuo);

Console.WriteLine(CONST_SPACE2);

Console.WriteLine("8. Write a program that calculates the result of raising a number to a power");
Console.WriteLine(CONST_SPACE2);

double number3 = 2.0;
int exponent = 5;

double resultPower = Math.Pow(number3, exponent);
Console.WriteLine("El resultado de elevar " + number3 + " a la " + exponent + " es " + resultPower);

Console.WriteLine(CONST_SPACE2);
Console.WriteLine(CONST_SPACE2);

Console.WriteLine("Booleanos");
Console.WriteLine(CONST_SPACE2);

int edad = 27;
bool esMayorDeEdad = edad >= 18;
string mensaje = "El usuario es menor de edad";

if (esMayorDeEdad)
{
	mensaje = "El usuario es mayor de edad";
}

Console.WriteLine(mensaje);

Console.WriteLine(CONST_SPACE2);
Console.WriteLine(CONST_SPACE2);

Console.WriteLine("Otra forma:");


if (esMayorDeEdad)
{
	mensaje = "El usuario es mayor de edad";
} else {
	mensaje = "El usuario es menor de edad";
}

Console.WriteLine(mensaje);

Console.WriteLine(CONST_SPACE2);

Console.WriteLine("Convirtiendo de strings a numeros:");
Console.WriteLine(CONST_SPACE2);

Console.WriteLine("Cual es tu edad?: "); // recibimos por consola un texto
string edadTexto = Console.ReadLine(); // lo guardamos en una variable
// Console.WriteLine("Tu edad es: " + edadTexto); // solo para ver si se esta guardando

// Transformamos a numero usando
int edad2 = Int32.Parse(edadTexto);
// Console.WriteLine(edad2); // verificamos si va bien el codigo

bool esMayorDeEdad2 = edad2 >= 18; // si se cumple que sea mayor o igual entonces es True
string mensaje2 = "Eres menor de edad"; // por defecto es este mensaje

if (esMayorDeEdad2)
{
	mensaje2 = "Eres mayor de edad"; // si es mayor de edad entonces es TRue y por lo tanto se muestra este mensaje
}

Console.WriteLine(mensaje2); // se muestra el mensaje por consola

Console.WriteLine(CONST_SPACE2);
Console.WriteLine(CONST_SPACE2);