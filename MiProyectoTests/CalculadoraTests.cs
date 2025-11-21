using NUnit.Framework;
using MiProyectoLib;
using System;

namespace MiProyectoTests
{
    public class CalculadoraTests
    {
        private Calculadora calc;

        [SetUp]
        public void Setup() => calc = new Calculadora();

        [Test]
        public void Suma_Correcta() => Assert.That(calc.Sumar(5, 3), Is.EqualTo(8));

        [Test]
        public void Resta_Correcta() => Assert.That(calc.Restar(5, 3), Is.EqualTo(2));

        [Test]
        public void Multiplicacion_Correcta() => Assert.That(calc.Multiplicar(5, 3), Is.EqualTo(15));

        [Test]
        public void Division_Correcta() => Assert.That(calc.Dividir(5, 3), Is.EqualTo(5.0 / 3.0).Within(0.0001));

        [Test]
        public void DivisionPorCero_LanzaExcepcion() => Assert.Throws<DivideByZeroException>(() => calc.Dividir(5, 0));
    }
}
