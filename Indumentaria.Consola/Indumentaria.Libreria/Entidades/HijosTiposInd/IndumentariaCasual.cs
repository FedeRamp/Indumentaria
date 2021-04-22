using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Indumentaria.Libreria.Entidades;

namespace Indumentaria.Libreria.Entidades
{
    public class IndumentariaCasual : TipoIndumentaria
    {
        public IndumentariaCasual()
        {
            this.origen = "Tailandia";
            this.porcentajeAlgodon = 80.5;
        }
    }
}
