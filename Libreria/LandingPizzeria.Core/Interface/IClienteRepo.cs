using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LandingPizzeria.Core.Entidades;

namespace LandingPizzeria.Core.Interface
{
    public interface IClienteRepo
    {
        Task<int> GuardarAsync(Cliente cliente);
        Task<Cliente?> ObtenerPorIdAsync(int idCliente);
        Task<IEnumerable<Cliente>> ObtenerTodosAsync();
    }
}