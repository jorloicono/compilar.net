using System;
using MiProyectoLib;
namespace MiProyectoApp
{
 class Program
 {
 static void Main(string[] args)
 {
 var calc = new Calculadora();
 Console.WriteLine($"Suma: {calc.Sumar(5,3)}");
 Console.WriteLine($"Resta: {calc.Restar(5,3)}");
 Console.WriteLine($"Multiplicación: {calc.Multiplicar(5,3)}");
 Console.WriteLine($"División: {calc.Dividir(5,3)}");
 }
 }
}