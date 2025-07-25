namespace TDD.Models
{
    public class Cafetera
    {
        public int CantidadCafeOz { get; private set; }

        public Cafetera(int cantidadInicial) => CantidadCafeOz = cantidadInicial;

        public bool ServirCafe(int cantidad)
        {
            if (CantidadCafeOz >= cantidad)
            {
                CantidadCafeOz -= cantidad;
                return true;
            }
            return false;
        }
    }
}
