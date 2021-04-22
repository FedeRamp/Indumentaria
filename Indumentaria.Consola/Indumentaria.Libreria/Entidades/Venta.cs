using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Indumentaria.Libreria.Exceptions;

namespace Indumentaria.Libreria.Entidades
{
    public class Venta
    {
        private List<VentaItem> items;
        private Cliente cliente;
        private string estado;
        private int codigo;

        public List<VentaItem> Items { get => items; }

        public Venta(int codigo, Cliente cliente)
        {
            items = new List<VentaItem>();
            this.codigo = codigo;
            this.cliente = cliente;
            this.estado = "Iniciada";
        }

        public void AddItem(Indumentaria indumentaria, int cantidad)
        {
            VentaItem item = new VentaItem(indumentaria, cantidad);
            if (indumentaria.Stock - cantidad > 0)
            {
                item.Prenda.Stock -= cantidad;
                items.Add(item);
            } else
            {
                throw new SinStockException();
            }
        }

        public double GetTotalPedido()
        {
            double resultado = 0;
            foreach(VentaItem item in items)
            {
                resultado += item.GetTotal();
            }
            return resultado;
        }

        public void Procesar()
        {
            this.estado = "Procesada";
        }
        public void Devolver()
        {
            this.estado = "Devuelta";

        }

        public override string ToString()
        {
            int cantidad = 0;
            foreach(VentaItem item in items)
            {
                cantidad += item.Cantidad;
            }
            return $"{this.codigo} - {this.estado}) {this.cliente.ToString()}, compra {cantidad} prendas, por ${GetTotalPedido()}";
        }
    }
}
