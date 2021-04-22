using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Entidades
{
    public class Camisa : Indumentaria
    {
        private bool tieneEstampado;
        private string tipoManga;

        public Camisa(int codigo, string talle, double precio, bool estampado, string manga, int stock = 3)
        {
            this.codigo = codigo;
            this.talle = talle;
            this.precio = precio;
            this.stock = stock;
            this.tipo = new IndumentariaCasual();
            this.tieneEstampado = estampado;
            this.tipoManga = manga;
        }

        public override string GetDetalle()
        {
            string conSin = tieneEstampado ? "con" : "sin";
            return $"{this.codigo}) talle: {this.talle}, precio: {this.precio}" +
                $"manga: {this.tipoManga}, {conSin} estampado";
        }

    }
}
