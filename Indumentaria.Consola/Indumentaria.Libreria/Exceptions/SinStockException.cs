using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Exceptions
{
    class SinStockException : Exception
    {
        public override string Message => "No hay suficiente stock";
    }
}
