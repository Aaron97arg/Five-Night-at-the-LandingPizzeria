using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LandingPizzeria.Core.Entidades;

namespace LandingPizzeria.Core.Interface
{
    public interface IPizzaRepo
    {
        Task<IEnumerable<Pizza>> ObtenerDisponiblesAsync();
        Task<Pizza?> ObtenerPorIdAsync(int idPizza);
        Task<IEnumerable<Pizza>> ObtenerTodasAsync();
    }
}