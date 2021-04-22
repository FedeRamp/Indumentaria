using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Entidades
{
    public class Pantalon : Indumentaria
    {
        private string material;
        private bool tieneBolsillos;

        public Pantalon(int codigo, string talle, double precio, string material, bool bolsillos, int stock = 3)
        {
            this.codigo = codigo;
            this.talle = talle;
            this.precio = precio;
            this.stock = stock;
            this.tipo = new IndumentariaFormal();
            this.material = material;
            this.tieneBolsillos = bolsillos;
        }

        public override string GetDetalle()
        {
            string conSin = tieneBolsillos ? "con" : "sin";
            return $"{this.codigo}) talle: {this.talle}, precio: {this.precio}" +
                $"material: material, {conSin} bolsillos";
        }
    }
}
