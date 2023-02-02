

using Microsoft.EntityFrameworkCore;
using test_crud.Data;
using test_crud.Dtos;
using test_crud.libs;
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
      ValidationUser.Validation(usuario);
      this.context.Add(usuario);
    }

    public void AtualizarUsuario(Usuario usuario)
    {
      this.context.Update(usuario);
    }

    public async Task<IEnumerable<UsuarioDto>> BuscarUsuarios()
    {
      return await this.context.Usuarios
      .Select(x => new UsuarioDto { Id = x.Id, Name = x.Name, Email = x.Email, Telefone = x.Telefone })
      .ToListAsync();
    }

    public async Task<Usuario> BuscaUsuario(int id)
    {
      return await this.context.Usuarios.Where(x => x.Id == id).FirstOrDefaultAsync();
    }

    public void RemoverUsuario(Usuario usuario)
    {
      this.context.Remove(usuario);
    }

    public async Task<bool> SavesChangesAsync()
    {
      return await this.context.SaveChangesAsync() > 0;
    }
  }
}