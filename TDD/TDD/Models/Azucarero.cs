using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Models
{
    public class Azucarero
    {
        public int CucharadasDisponibles { get; private set; }

        public Azucarero(int cantidadInicial)
        {
            CucharadasDisponibles = cantidadInicial;
        }

        public bool UsarAzucar(int cucharadas)
        {
            if (CucharadasDisponibles >= cucharadas)
            {
                CucharadasDisponibles -= cucharadas;
                return true;
            }
            return false;
        }
    }
}

