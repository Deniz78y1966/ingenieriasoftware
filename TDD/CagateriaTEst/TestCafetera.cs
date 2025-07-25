using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Models;
using Xunit;

namespace CafeteriaTest
{
    public class TestCafetera
    {
        [Fact]
        public void ServirCafe_DeberiaReducirCantidadCafe()
        {
            var cafetera = new Cafetera(10);
            int cantidadAServir = 3;

            bool resultado = cafetera.ServirCafe(cantidadAServir);

            Assert.True(resultado);
            Assert.Equal(7, cafetera.CantidadCafeOz);
        }

        [Fact]
        public void ServirCafe_NoDeberiaServirSiNoHaySuficienteCafe()
        {
            var cafetera = new Cafetera(5);
            int cantidadAServir = 6;
            bool resultado = cafetera.ServirCafe(cantidadAServir);
            Assert.False(resultado);
            Assert.Equal(5, cafetera.CantidadCafeOz);
        }

        [Fact]
        public void ServirCafe_DeberiaServirExactamenteLoDisponible()
        {
            var cafetera = new Cafetera(10);
            int cantidadAServir = 10;
            bool resultado = cafetera.ServirCafe(cantidadAServir);
            Assert.True(resultado);
            Assert.Equal(0, cafetera.CantidadCafeOz);
        }

        [Fact]
        public void Cafetera_InicializaConCantidadCorrectaDeCafe()
        {
            var cafetera = new Cafetera(10);
            Assert.Equal(10, cafetera.CantidadCafeOz);
        }
    }
}
