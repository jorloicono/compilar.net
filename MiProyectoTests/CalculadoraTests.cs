using NUnit.Framework;
using MiProyectoLib;
using System;
namespace MiProyectoTests
{
 public class CalculadoraTests
 {
 private Calculadora calc;
 [SetUp]
 public void Setup()
 {
 calc = new Calculadora();
 }
 [Test]
 public void Suma_Correcta()
 {
 Assert.AreEqual(8, calc.Sumar(5,3));
 }
 [Test]
 public void Resta_Correcta()
 {
 Assert.AreEqual(2, calc.Restar(5,3));
 }
 [Test]
 public void Multiplicacion_Correcta()
 {
 Assert.AreEqual(15, calc.Multiplicar(5,3));
 }
 [Test]
 public void Division_Correcta()
 {
 Assert.AreEqual(1.6666666666666667, calc.Dividir(5,3), 0.0001);
 }
 [Test]
 public void DivisionPorCero_LanzaExcepcion()
 {
 Assert.Throws<DivideByZeroException>(() => calc.Dividir(5,0));
 }
 }
}