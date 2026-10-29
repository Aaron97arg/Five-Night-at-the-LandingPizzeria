using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using LandingPizzeria.Core.Entidades;

namespace LandingPizzeria.Services.Interface;

public interface IUsuarioService
{
    Task<int> RegistrarUsuarioAsync(Usuario user);

    Task<Usuario?> ObtenerUsuarioAsync(int id);

    Task<Usuario?> AutenticarAsync(
        string login,
        string password);
}