

using Microsoft.EntityFrameworkCore;
using test_crud.Data;
using test_crud.models;

namespace test_crud.Repository
{
  public class UserRepository : IUserRepository
  {


    private readonly UserContext context;

    public UserRepository(UserContext context)
    {
      this.context = context;
    }

    public void AdicionandoUsuario(Usuario usuario)
    {
      this.context.Add(usuario);
    }

    public void AtualizarUsuario(Usuario usuario)
    {
      throw new NotImplementedException();
    }

    public async Task<IEnumerable<Usuario>> BuscarUsuarios()
    {
      return await this.context.Usuarios.ToListAsync();
    }

    public async Task<Usuario> BuscaUsuario(int id)
    {
      return await this.context.Usuarios.Where(x => x.Id == id).FirstOrDefaultAsync();
    }

    public void RemoverUsuario(Usuario usuario)
    {
      throw new NotImplementedException();
    }

    public async Task<bool> SavesChangesAsync()
    {
      return await this.context.SaveChangesAsync() > 0;
    }
  }
}