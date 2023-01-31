
using Microsoft.EntityFrameworkCore;
using test_crud.models;

namespace test_crud.Data
{
  public class UserContext : DbContext
  {
    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }

  }
}