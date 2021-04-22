using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Entidades
{
    public class IndumentariaFormal : TipoIndumentaria
    {
        public IndumentariaFormal()
        {
            this.origen = "Francia";
            this.porcentajeAlgodon = 43;
        }
    }
}
