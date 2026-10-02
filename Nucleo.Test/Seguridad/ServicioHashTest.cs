namespace Nucleo.Test;
using Nucleo.Seguridad;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class ServicioHashTest
{/*
    [TestClass]
    public class ServicioHashTests
    {
        private const string TextoValido = "P@ssw0rd";

        // ED-03 / ED-04

        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow(" ")]
        [DataRow("     ")]
        public void Generar_TextoNoValido_LanzaInvalidOperationException(
            string? texto)
        {
            Assert.ThrowsException<InvalidOperationException>(
                () => ServicioHash.Generar(texto!)
            );
        }

        // ED-05 / ED-09 / ED-20

        [TestMethod]
        public void Generar_TextoValido_DevuelveResultadoConHashYSal()
        {
            ResultadoHash resultado = ServicioHash.Generar(TextoValido);

            Assert.IsNotNull(resultado);

            Assert.IsFalse(
                string.IsNullOrWhiteSpace(resultado.Hash)
            );

            Assert.IsFalse(
                string.IsNullOrWhiteSpace(resultado.Sal)
            );
        }

        // ED-06 / ED-07

        [TestMethod]
        public void Generar_MismoTextoDosVeces_GeneraSalesDiferentes()
        {
            ResultadoHash resultado1 =
                ServicioHash.Generar(TextoValido);

            ResultadoHash resultado2 =
                ServicioHash.Generar(TextoValido);

            Assert.AreNotEqual(
                resultado1.Sal,
                resultado2.Sal
            );
        }

        // ED-08

        [TestMethod]
        public void Generar_MismoTextoDosVeces_GeneraHashesDiferentes()
        {
            ResultadoHash resultado1 =
                ServicioHash.Generar(TextoValido);

            ResultadoHash resultado2 =
                ServicioHash.Generar(TextoValido);

            Assert.AreNotEqual(
                resultado1.Hash,
                resultado2.Hash
            );
        }

        // ED-12

        [TestMethod]
        public void Verificar_DatosCorrectos_DevuelveTrue()
        {
            ResultadoHash generado =
                ServicioHash.Generar(TextoValido);

            bool resultado = ServicioHash.Verificar(
                TextoValido,
                generado.Hash,
                generado.Sal
            );

            Assert.IsTrue(resultado);
        }

        // ED-13 - Texto incorrecto

        [TestMethod]
        public void Verificar_TextoIncorrecto_DevuelveFalse()
        {
            ResultadoHash generado =
                ServicioHash.Generar(TextoValido);

            bool resultado = ServicioHash.Verificar(
                "Texto incorrecto",
                generado.Hash,
                generado.Sal
            );

            Assert.IsFalse(resultado);
        }

        // ED-13 - Hash incorrecto

        [TestMethod]
        public void Verificar_HashIncorrecto_DevuelveFalse()
        {
            ResultadoHash generado =
                ServicioHash.Generar(TextoValido);

            ResultadoHash otro =
                ServicioHash.Generar("Otro texto");

            bool resultado = ServicioHash.Verificar(
                TextoValido,
                otro.Hash,
                generado.Sal
            );

            Assert.IsFalse(resultado);
        }

        // ED-13 - Sal incorrecta

        [TestMethod]
        public void Verificar_SalIncorrecta_DevuelveFalse()
        {
            ResultadoHash generado =
                ServicioHash.Generar(TextoValido);

            ResultadoHash otro =
                ServicioHash.Generar("Otro texto");

            bool resultado = ServicioHash.Verificar(
                TextoValido,
                generado.Hash,
                otro.Sal
            );

            Assert.IsFalse(resultado);
        }

        // ED-14

        [DataTestMethod]

        [DataRow("texto", null)]
        [DataRow("texto", "")]
        [DataRow("texto", "   ")]

        [DataRow("hash", null)]
        [DataRow("hash", "")]
        [DataRow("hash", "   ")]

        [DataRow("sal", null)]
        [DataRow("sal", "")]
        [DataRow("sal", "   ")]
        public void Verificar_ParametroNoValido_DevuelveFalse(
            string parametro,
            string? valorInvalido)
        {
            ResultadoHash generado =
                ServicioHash.Generar(TextoValido);

            string? texto = TextoValido;
            string? hash = generado.Hash;
            string? sal = generado.Sal;

            switch (parametro)
            {
                case "texto":
                    texto = valorInvalido;
                    break;

                case "hash":
                    hash = valorInvalido;
                    break;

                case "sal":
                    sal = valorInvalido;
                    break;
            }

            bool resultado = ServicioHash.Verificar(
                texto!,
                hash!,
                sal!
            );

            Assert.IsFalse(resultado);
        }

        // ED-15 / ED-16 / ED-17

        [TestMethod]
        public void Verificar_HashConFormatoIncorrecto_DevuelveFalse()
        {
            ResultadoHash generado =
                ServicioHash.Generar(TextoValido);

            bool resultado = ServicioHash.Verificar(
                TextoValido,
                "%%%HASH_INVALIDO%%%",
                generado.Sal
            );

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Verificar_SalConFormatoIncorrecto_DevuelveFalse()
        {
            ResultadoHash generado =
                ServicioHash.Generar(TextoValido);

            bool resultado = ServicioHash.Verificar(
                TextoValido,
                generado.Hash,
                "%%%SAL_INVALIDA%%%"
            );

            Assert.IsFalse(resultado);
        }
    }*/
}
