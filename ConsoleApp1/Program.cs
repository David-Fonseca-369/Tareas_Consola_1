using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //BUCLES
            //- FOR, - WHILE, -- DO WHILE, FOREACH

            //List<int> facturas = new() { 2, 6, 8, 9, 5, 7, 8 };
            // [2, 6, 8, 9]
            //  0  1  2  3

            //inicializas variable | condicion | actualización

            //Incremento
            //++ === i = i + 1;

            //Decremento
            //-- === i = i - 1;
            //Imprime

            //for(int i = 0; i < facturas.Count; i+=2)
            //{
            //    Console.WriteLine($"Indice = {i}");
            //    Console.WriteLine($"Elemento = {facturas[i]}");

            //    Console.WriteLine("----");
            //}

            //for (int i = 0; i <= 1000; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //WHILE
            //int numero = 0;

            //while (numero <= 1000)
            //{
            //    //Logica
            //    Console.WriteLine(numero);
            //    numero++;
            //}


            //Console.WriteLine("" +
            //    "Elige una opcion:\n" +
            //    "1.- Dar edad\n" +
            //    "2.- Salir"
            //    );

            //int edad = Convert.ToInt32(Console.ReadLine());

            ////se escapa hasta que cumpla la condición
            //while (edad != 2)
            //{
            //    Console.WriteLine($"Tu edad es: {edad}");

            //    Console.WriteLine("" +
            //   "Elige una opcion:\n" +
            //   "1.- Dar edad\n" +
            //   "2.- Salir"
            //   );

            //    edad = Convert.ToInt32(Console.ReadLine());

            //}

            //Calcular promedio de alumnos
            Console.WriteLine("Ingresa la cantidad de alumnos:");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            int sumaCalificaciones = 0;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine($"Ingresa la calificacion número: {i}");
                sumaCalificaciones += Convert.ToInt32(Console.ReadLine());
            }

            decimal promedio = sumaCalificaciones / cantidad;
            Console.WriteLine($"El promedio es: {promedio}");

            //EJERCICIO 1
            //Leer un número y mostrar su cuadrado, repetir el proceso hasta que se introduzca un numero negativo

            //Ejercicio 2
            //Leer numeros hasta  que se introduzca 0, para cada uno indicar si es par o inpar

            //Ejercicio 3
            // Pedir un  número N de sueldos, introducir los N sueldos y mostrar el sueldo máximo

            //ejecicio 4
            //Pedir 5 notas y decir si hay algun reprobado
        
            //ejercicio 5
            //Mostrar los numeros del 100 al cero de 7 en 7 

            //ejercicio 6
            //Pedir un número N y mostrar todos los numeros del 1 al N
        }


    }
}
