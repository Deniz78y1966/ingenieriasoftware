using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Models;

namespace CafeteriaTest
{
    public class TetstMaquinaCafe
    {
        [Fact]
        public void ServirCafe_DeberiaServirCafePequeno() {            
            var cafetera = new Cafetera(50);
            var azucarero = new Azucarero(20);
            var vasoPequeno = new Vaso("pequeño",15);
            var vasoMediano = new Vaso("mediano");
            var vasoGrande = new Vaso("grande");

            var maquina = new MaquinaCafe(cafetera, azucarero,vasoPequeno,vasoMediano,vasoGrande);
                
            var resultado = maquina.GetVasoDeCafe("pequeño",2, 15);

            Assert.Equal("Se han servido 2 vasos pequeño 3oz con 15 cucharadas de azúcar.", resultado);
        }

        [Fact]
        public void ServirCafe_DeberiaServirCafeMediano()
        {
            var cafetera = new Cafetera(50);
            var azucarero = new Azucarero(20);
            var vasoPequeno = new Vaso("pequeño");
            var vasoMediano = new Vaso("mediano",15);
            var vasoGrande = new Vaso("grande");

            var maquina = new MaquinaCafe(cafetera, azucarero, vasoPequeno, vasoMediano, vasoGrande);

            var resultado = maquina.GetVasoDeCafe("mediano", 2, 15);

            Assert.Equal("Se han servido 2 vasos mediano 5oz con 15 cucharadas de azúcar.", resultado);
        }

        [Fact]
        public void ServirCafe_DeberiaServirCafeGrande()
        {
            var cafetera = new Cafetera(50);
            var azucarero = new Azucarero(20);
            var vasoPequeno = new Vaso("pequeño");
            var vasoMediano = new Vaso("mediano");
            var vasoGrande = new Vaso("grande", 15);

            var maquina = new MaquinaCafe(cafetera, azucarero, vasoPequeno, vasoMediano, vasoGrande);

            var resultado = maquina.GetVasoDeCafe("grande", 2, 15);

            Assert.Equal("Se han servido 2 vasos grande 7oz con 15 cucharadas de azúcar.", resultado);
        }

        [Fact]
        public void ServirCafe_DeberiaMostrarErrorSiNoHayVasosDisponibles()
        {
            var cafetera = new Cafetera(50);
            var azucarero = new Azucarero(20);
            var vasoPequeno = new Vaso("pequeño", 1);
            var vasoMediano = new Vaso("mediano");
            var vasoGrande = new Vaso("grande");

            var maquina = new MaquinaCafe(cafetera, azucarero, vasoPequeno, vasoMediano, vasoGrande);

            var resultado = maquina.GetVasoDeCafe("pequeño", 2, 5);

            
            Assert.Equal("No hay suficientes vasos pequeño. Solo hay 1 disponibles.", resultado);
        }


    }
}
