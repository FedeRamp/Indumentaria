using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Entidades
{
    public class IndumentariaDeportiva : TipoIndumentaria
    {
        public IndumentariaDeportiva()
        {
            this.origen = "EEUU";
            this.porcentajeAlgodon = 50;
        }
    }
}
