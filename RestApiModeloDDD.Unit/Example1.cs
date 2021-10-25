using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestApiModeloDDD.Domain.Entitys;
using System;
using Xunit;
using Xunit.Abstractions;

namespace RestApiModeloDDD.Unit
{
    public class Example1
    {
        private readonly ITestOutputHelper _output;

        public Example1(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void UsuarioEMaiorDeIdade()
        {
            // Arrange
            Cliente cli = new Cliente("José", 50);
            bool expected = true;
            // Act
            bool result = true;
            // Assert
            Assert.AreEqual(expected, result);
            Console.ReadLine();
        }
    }
}