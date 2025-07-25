using System.Collections.Generic; // Add this using directive for Dictionary

namespace TDD.Models
{
    public class MaquinaCafe
    {
        private Cafetera _cafetera;
        private Azucarero _azucarero;
        private Dictionary<string, Vaso> _vasosDisponibles;

        public MaquinaCafe(Cafetera cafetera, Azucarero azucarero, Vaso vasoPequeno, Vaso vasoMediano, Vaso vasoGrande)
        {
            _cafetera = cafetera;
            _azucarero = azucarero;
            _vasosDisponibles = new Dictionary<string, Vaso>
            {
                { vasoPequeno.Tamaño, vasoPequeno },
                { vasoMediano.Tamaño, vasoMediano },
                { vasoGrande.Tamaño, vasoGrande }
            };
        }

        public string GetVasoDeCafe(string tamañoVaso, int cantidadVasos, int cucharadasAzucar)
        {
            if (!_vasosDisponibles.TryGetValue(tamañoVaso.ToLower(), out Vaso vasoSeleccionado))
            {
                return "Error: Tamaño de vaso no válido.";
            }

            int cafeNecesario = vasoSeleccionado.CantidadOz * cantidadVasos;

            if (vasoSeleccionado.CantidadDisponible < cantidadVasos)
            {
                return $"No hay suficientes vasos {tamañoVaso}. Solo hay {vasoSeleccionado.CantidadDisponible} disponibles.";
            }

            if (_cafetera.CantidadCafeOz < cafeNecesario)
            {
                return $"No hay suficiente café para {cantidadVasos} vasos {tamañoVaso}. Necesitas {cafeNecesario} oz y solo hay {_cafetera.CantidadCafeOz} oz.";
            }

            if (_azucarero.CucharadasDisponibles < cucharadasAzucar)
            {
                return $"No hay suficiente azúcar. Necesitas {cucharadasAzucar} cucharadas y solo hay {_azucarero.CucharadasDisponibles} cucharada(s).";
            }

            for (int i = 0; i < cantidadVasos; i++)
            {
                vasoSeleccionado.usarVaso();
            }

            _cafetera.ServirCafe(cafeNecesario);
            _azucarero.UsarAzucar(cucharadasAzucar);

            return $"Se han servido {cantidadVasos} vasos {vasoSeleccionado.Tamaño} {vasoSeleccionado.CantidadOz}oz con {cucharadasAzucar} cucharadas de azúcar.";
        }

    }
}