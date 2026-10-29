using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using LandingPizzeria.Core.Entidades;

namespace LandingPizzeria.Services.Interface;

public interface IPizzaService
{
    Task<IEnumerable<Pizza>> VerDisponiblesAsync();
    Task<Pizza?> ObtenerPizzaAsync(int id);
    Task<int> RegistrarPizzaAsync(Pizza pisha);
}