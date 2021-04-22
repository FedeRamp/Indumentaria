using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Entidades
{
    public class Cliente
    {
        private int codigo;
        private string apellido;
        private string nombre;

        public Cliente(int codigo, string apellido, string nombre)
        {
            this.codigo = codigo;
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return $"{this.apellido}, {this.nombre}";
        }
    }
}
