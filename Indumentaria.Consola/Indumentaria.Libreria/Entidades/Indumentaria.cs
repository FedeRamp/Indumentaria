using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Entidades
{
    public abstract class Indumentaria
    {
        protected TipoIndumentaria tipo;
        private int codigo;
        private int stock;
        protected string talle;
        private double precio;

        public double Precio { get => precio; }
        public int Codigo { get => codigo; }
        public int Stock { get => stock; set => stock = value; }

        public override string ToString()
        {
            return this.GetDetalle();
        }

        public override bool Equals(object obj)
        {
            Indumentaria indumentaria = (Indumentaria)obj;
            return this.codigo == indumentaria.codigo;
        }

        public virtual string GetDetalle()
        {
            return "";
        }
        
    }
}
