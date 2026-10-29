using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LandingPizzeria.Core.Entidades;
using LandingPizzeria.Core.Estado;

namespace LandingPizzeria.Service.Interface;

public interface IPedidoService
{
    Task<int> CrearPedidoAsync(Pedido pedido);
    Task<Pedido?> ObtenerPedidoAsync(int id);
    Task CambiarEstadoPedidoAsync(int idPedido, EstadoPedido nuevoEstado);
}