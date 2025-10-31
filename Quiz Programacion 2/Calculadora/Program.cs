using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora ");


            // primer número
            Console.Write("Ingresa el primer número: ");
            // Usamos double para números con decimales
            double num1 = Convert.ToDouble(Console.ReadLine());

            // la operación
            Console.Write("Ingresa el operador (+, -, *, /): ");
            string operador = Console.ReadLine();

            // segundo número
            Console.Write("Ingresa el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    { resultado = num1 / num2; }
                    else
                    {
                        Console.WriteLine(" No se puede dividir por cero.");
                        Console.WriteLine("\nPresiona cualquier tecla para salir...");
                        Console.ReadKey();
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("operacion no valido");
                    Console.WriteLine("\nPresiona cualquier tecla para salir...");
                    Console.ReadKey();
                    return;
            }

            Console.WriteLine($"Resultado: {num1} {operador} {num2} = {resultado}");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();


        }
    }
}
