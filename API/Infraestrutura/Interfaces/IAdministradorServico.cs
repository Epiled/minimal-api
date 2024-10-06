using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;

namespace MinimalApi.Dominio.Interfacer;

public interface IAdministradorServico
{
  Administrador? Login(LoginDTO loginDTO);

  Administrador Incluir(Administrador administrador);

  Administrador? BuscaPorId(int id);

  List<Administrador> Todos(int? pagina);

}
