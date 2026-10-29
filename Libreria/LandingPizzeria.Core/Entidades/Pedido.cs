using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LandingPizzeria.Core.Entidades
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaHora { get; set; } = DateTime.Now;
        public int Estado { get; set; }
        public string DireccionEntrega { get; set; } = string.Empty;
        public decimal Total { get; set; }

        // Propiedad opcional para navegar los detalles del pedido si los consultas con Dapper
        public List<DetallePedido> Detalles { get; set; } = new();
    }
}