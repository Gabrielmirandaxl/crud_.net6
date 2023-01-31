
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

      var usuario = modelBuilder.Entity<Usuario>();

      usuario.ToTable("tb_users");
      usuario.HasKey(x => x.Id);
      usuario.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
      usuario.Property(x => x.Name).HasColumnName("name").IsRequired();
      usuario.Property(x => x.Email).HasColumnName("email").IsRequired();
      usuario.Property(x => x.Telefone).HasColumnName("telefone").IsRequired();
      usuario.Property(x => x.Cpf).HasColumnName("cpf").IsRequired();
      usuario.Property(x => x.RegistrationDate).HasColumnName("registrationDate");

    }

  }
}