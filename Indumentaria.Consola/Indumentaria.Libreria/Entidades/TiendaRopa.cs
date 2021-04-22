using Indumentaria.Libreria.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Entidades
{
    public class TiendaRopa
    {
        private List<Indumentaria> inventario;
        private List<Venta> ventas;
        private int ultimoCodigo;

        public TiendaRopa(List<Indumentaria> inventario, List<Venta> ventas)
        {
            this.inventario = inventario;
            this.ventas = ventas;
            this.ultimoCodigo = inventario.Count;
        }

        public TiendaRopa()
        {
            inventario = new List<Indumentaria>();
            ventas = new List<Venta>();
        }

        public void AddIndumentaria(Indumentaria indumentaria)
        {
            inventario.Add(indumentaria);
        }

        public void ModificarIndumentaria(Indumentaria indumentaria)
        {
            throw new NotImplementedException();
        }


        public void QuitarIndumentaria(Indumentaria indumentaria)
        {
            inventario.Remove(indumentaria);
        }


        public void IngresarOrden(Venta venta)
        {
            if (venta.GetTotalPedido() < 1)
            {
                throw new Exception("Venta con total invalido");
            }
            else
            {
                venta.Procesar();
                ventas.Add(venta);
                
            }
        }

        public void DevolverOrden(Venta venta)
        {
            foreach(VentaItem item in venta.Items)
            {
                foreach(Indumentaria indumentaria in inventario)
                {
                    if (indumentaria.Equals(item.Prenda))
                    {
                        indumentaria.Stock += item.Cantidad;
                    }
                }
            }
        }

        public int GetNextCodigo()
        {
            ultimoCodigo++;
            return ultimoCodigo;
        }



    }
}
