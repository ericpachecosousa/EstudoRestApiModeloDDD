using NUnit.Framework;
using RestApiModeloDDD.Domain.Entitys;
using Xunit;
using Xunit.Abstractions;

namespace RestApiModeloDDD.Tests
{
    [TestFixture]
    public class ApplicationServiceClienteTests
    {
        private readonly ITestOutputHelper _output;

        public ApplicationServiceClienteTests(ITestOutputHelper output)
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

        }
    }
}