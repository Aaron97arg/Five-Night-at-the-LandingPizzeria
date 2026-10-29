using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LandingPizzeria.Core.Entidades;

namespace LandingPizzeria.Core.Interface
{
    public interface IPedidoRepo
    {
        Task<int> CrearPedidoAsync(Pedido pedido, List<DetallePedido> detalles);
        Task<Pedido?> ObtenerPorIdAsync(int idPedido);
        Task<IEnumerable<Pedido>> ObtenerPorClienteAsync(int idCliente);
        Task<bool> CambiarEstadoAsync(int idPedido, int nuevoEstado);
    }
}