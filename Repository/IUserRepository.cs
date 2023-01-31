
using test_crud.models;

namespace test_crud.Repository
{
  public interface IUserRepository
  {

    Task<IEnumerable<Usuario>> BuscarUsuarios();
    Task<Usuario> BuscaUsuario(int id);
    void AdicionandoUsuario(Usuario usuario);
    void AtualizarUsuario(Usuario usuario);
    void RemoverUsuario(Usuario usuario);

    Task<bool> SavesChangesAsync();

  }
}