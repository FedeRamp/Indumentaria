using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Exceptions
{
    class CodigoExistenteException : Exception
    {
        public override string Message => "Ese codigo ya existe";
    }
}
