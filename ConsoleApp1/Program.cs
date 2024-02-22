using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Operadores aritmeticos
             + - * / %
            */

            /*Operadores condicionales*/

            //If
            //Switch
            //Operador ternario

            /*
             *Operadores de comparación
             
            == comparación
            != diferencia
            > mayor
            < menor
            >= mayor o igual
            <= menor o igual           
             */

            // = asignación*

            //Console.WriteLine("Ingresa tu edad:");
            //int edad = Convert.ToInt32(Console.ReadLine());


            //if (edad >= 0 && edad <= 12)
            //{
            //    Console.WriteLine("Eres niño");
            //}
            //else if (edad > 12 && edad <=18)
            //{
            //    Console.WriteLine("Eres adolescente");
            //}
            //else if (edad > 18 && edad <=60)
            //{
            //    Console.WriteLine("Eres un adulto");
            //}
            //else if (edad > 60)
            //{
            //    Console.WriteLine("Eres mayor de edad");
            //}
            //else
            //{
            //    Console.WriteLine("Edad no valida");
            //}

            //Console.WriteLine("Ingresa un número:");
            //int numero = Convert.ToInt32(Console.ReadLine());

            //switch (numero)
            //{
            //    case "s":                   
            //        Console.WriteLine("tu número uno");
            //        break;
            //    case 2: //si es igual a este numero entra al caso
            //        Console.WriteLine("tu número dos");
            //        break;
            //    case 3:
            //        Console.WriteLine("tu numero es tres");
            //        break;
            //    default:
            //        Console.WriteLine("No coincide");
            //        break;
            //}

            //Operador ternario

            //Console.WriteLine("Ingresa un número:");
            //int numero = Convert.ToInt32(Console.ReadLine());

            //                 // condicion ? 'si cumple' : 'si no cumple'
            //string mensaje = numero % 2 == 0 ? "Es par" : "Es inpar";
            //Console.WriteLine(mensaje);

            //EJERCICIO 1
            //Pedir un numero entre 0 y 99 999 y decir cuantas cifras tiene
            //1 = 1 cifra
            //100 = 3 crifras 
            //9000 = 4 crifras

            //Ejercicio 2:
            /*Pedir que digite un dos números y despues de pedirlos que nos indique que operacion desea hacer
             1.- Suma ingresa (s)  etc... (+,-,/,*)
             2.- res (r)
             ..... 
             */
            Console.WriteLine("Opciones: \n" +
                "1.- Suma (s)\n" +
                "2.- Resta (r)" +
                "3.- Multi (m)");


            //Ejercicio 3
            /*
             CAJERO AUTOMATICO
            Hacer un programa quen simule un cajero automático con un saldo inicial de $1000 pesos
            con el siguiente menu de opciones:
            1.- Ingresar dinero a la cuenta   => Solicitar la cantidad a ingresar y después imprimir la cantidad total de la cuenta
            2.- Retirar dinero de la cuenta   => Solicitar la cantidad a retirar (Si tiene el dinero que impra lo que resta y si no imprimir que su saldo es insuficiente)
            3.- Salir => imprimir que ha salido del sistema

             * => opcion no valida
             */
        }


    }
}
