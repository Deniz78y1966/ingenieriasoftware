using TDD.Models;
using Xunit;

namespace CafeteriaTest
{
    public class TestAzucarero
    {
        [Fact]
        public void UsarAzucar_DeberiaReducirCucharadasDisponibles()
        {
            var azucarero = new Azucarero(10);

            var resultado = azucarero.UsarAzucar(3);

            Assert.True(resultado);
            Assert.Equal(7, azucarero.CucharadasDisponibles);
        }

        [Fact]
        public void UsarAzucar_NoDeberiaPermitirSiNoHaySuficienteAzucar()
        {
            var azucarero = new Azucarero(2);

            var resultado = azucarero.UsarAzucar(5);

            Assert.False(resultado);
            Assert.Equal(2, azucarero.CucharadasDisponibles);
        }

        [Fact]
        public void UsarAzucar_ExactamenteLoDisponible_DeberiaSerExitoso()
        {
            var azucarero = new Azucarero(5);

            var resultado = azucarero.UsarAzucar(5);

            Assert.True(resultado);
            Assert.Equal(0, azucarero.CucharadasDisponibles);
        }

        [Fact]
        public void Azucarero_InicializaConCantidadCorrecta()
        {
            var azucarero = new Azucarero(12);

            Assert.Equal(12, azucarero.CucharadasDisponibles);
        }
    }
}

