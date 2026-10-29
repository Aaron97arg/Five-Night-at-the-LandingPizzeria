using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LandingPizzeria.Core.Entidades;
using LandingPizzeria.Core.Interface;
using LandingPizzeria.Services.IService;

namespace LandingPizzeria.Services.Service;

public class PizzaService : IPizzaService
{
    private readonly IPizzaRepository _pizzaRepository;

    public PizzaService(IPizzaRepository pizzaRepository)
    {
        _pizzaRepository = pizzaRepository;
    }

    public async Task<IEnumerable<Pizza>> VerDisponiblesAsync()
    {
        return await _pizzaRepository.ObtenerDisponiblesAsync();
    }

    public async Task<Pizza?> ObtenerPizzaAsync(int id)
    {
        return await _pizzaRepository.ObtenerPorIdAsync(id);
    }

    public async Task<int> RegistrarPizzaAsync(Pizza pisha)
    {
        if (string.IsNullOrWhiteSpace(pisha.Nombre))
            throw new ArgumentException("El nombre de la pizza es obligatorio.");

        if (pisha.Precio <= 0)
            throw new ArgumentException("El precio debe ser mayor a cero.");

        return await _pizzaRepository.CrearPizzaAsync(pisha);
    }
}