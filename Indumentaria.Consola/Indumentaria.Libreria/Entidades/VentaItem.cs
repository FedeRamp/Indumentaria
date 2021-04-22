using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Entidades
{
    public class VentaItem
    {
        private Indumentaria prenda;
        private int cantidad;

        public VentaItem(Indumentaria prenda, int cantidad)
        {
            this.prenda = prenda;
            this.cantidad = cantidad;
        }

        public int Cantidad { get => cantidad; }
        public Indumentaria Prenda { get => prenda; }

        public double GetTotal()
        {
            return this.cantidad * prenda.Precio;
        }
    }
}
