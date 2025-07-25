using Xunit; 
using System;
using TDD.Models;

namespace CagateriaFact
{
    public class FactVaso
    {
        [Fact] 
        public void DeberiaAsignarCantidadOzCorrectaParaVasoPequeno()
        {
            Vaso vasoPequeno = new Vaso("pequeño");
            Assert.Equal(3, vasoPequeno.CantidadOz);
        }

        [Fact]
        public void DeberiaAsignarCantidadOzCorrectaParaVasoMediano()
        {
            Vaso vasoMediano = new Vaso("mediano");
            Assert.Equal(5, vasoMediano.CantidadOz);
        }

        [Fact]
        public void DeberiaAsignarCantidadOzCorrectaParaVasoGrande()
        {
            Vaso vasoGrande = new Vaso("grande");
            Assert.Equal(7, vasoGrande.CantidadOz);
        }

        [Fact]
        public void DeberiaLanzarExcepcionParaTamañoDeVasoNoValido()
        {
            Assert.Throws<ArgumentException>(() => new Vaso("extra-grande"));
        }

        [Fact]
        public void DeberiaDevolverFalsoSiNoExistenVasos() { 
            Vaso vaso = new Vaso("pequeño" , 0);
            var resultado = vaso.usarVaso();
            Assert.False(resultado);
            Assert.Equal(0, vaso.CantidadDisponible);
        }
    }
}