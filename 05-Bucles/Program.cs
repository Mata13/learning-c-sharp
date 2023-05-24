// Bucle while

using System;

namespace Exercise1
{
    class Program
    {
        static void Main()
        {
						Console.WriteLine("...................");

						Console.WriteLine("while");
						Console.WriteLine("...................");

            Console.WriteLine("Exercise 1: Write a program that prints the numbers from 1 to 10 using a while loop.");

            int number = 1;

            while (number <= 10)
            {
                Console.WriteLine(number); // hasta aqui solo se imprime el numero 1 sin sumar nada
                number++; // con esto el contador aumenta una unidad por cada elemento
            }
        }
    }
}


