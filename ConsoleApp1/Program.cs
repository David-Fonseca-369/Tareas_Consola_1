using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pida 2 numeros y calcule la suma de estos.
            //TAREA 1
            //Promedio de calificaciones
            //Pida 4 calificaciones de los parciales y me devuelva el promedio.

            //Programa de salario
            //Calcule e imprima el salario semanal de un empleado
            //a partir de las horas semanales trabajadas y del salario por hora

            //Agente de ventas
            /*Una compañia de venta de carros usados, paga a su personal de ventas un salario de $1,000 mensuales,
              mas una comisión de $150 por cada carro vendido, más el 5% del valor de las ventas totales.

              Cada mes el capturista de la empresa ingresa en la computadora los datos. Hacer un programa que calcule
              e imprima el salario mensual de un vendedor dado.
             */

            //PISTAS:
            //Pedir - Ingrese los carros vendidos
            //... - _ Ingrese el costo de los carros -> Imprimir el salario mensual del empleado 


            //Texto de pedir primer numero
            Console.WriteLine("Ingresa el primer número:");

            //Pedir numero por consola
            int primerNumero = Convert.ToInt32(Console.ReadLine());

            //Texto de pedir segundo numero
            Console.WriteLine("Ingresa el segundo número:");

            //Pide segundo numerom por consola
            int segundoNumero = Convert.ToInt32(Console.ReadLine());

            int suma = primerNumero + segundoNumero;

            Console.WriteLine($"La suma de los dos números es: {suma}");

        }


    }
}
