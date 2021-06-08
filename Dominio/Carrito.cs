using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carrito
    {
        public DateTime FechaCarrito { get; set; }
        public List<ItemCarrito> Items { get; set; }
        public decimal totalCarrito(Carrito carrito)
        {
            decimal total = 0;
            foreach (ItemCarrito item in carrito.Items)
            {
                
                total += item.Producto.Precio * item.Cantidad;
            }
            return total;
        }
    }
    
}
