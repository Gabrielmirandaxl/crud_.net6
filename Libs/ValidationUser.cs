
using test_crud.models;

namespace test_crud.libs
{
  public static class ValidationUser
  {

    public static void Validation(Usuario usuario)
    {
      if (usuario == null) throw new ArgumentException("Preencha todos os campos");
      if (string.IsNullOrWhiteSpace(usuario.Name)) throw new ArgumentException("Preencha o campo nome");
      if (string.IsNullOrWhiteSpace(usuario.Telefone)) throw new ArgumentException("Preencha o campo telefone");
      if (usuario.Telefone.Length != 14) throw new ArgumentException("Preencha corretamente o campo telefone");
      if (string.IsNullOrWhiteSpace(usuario.Cpf)) throw new ArgumentException("Preencha o campo cpf");
      if (usuario.Cpf.Length != 14) throw new ArgumentException("Preencha o campo cpf corretamente");
      if (string.IsNullOrWhiteSpace(usuario.Email)) throw new ArgumentException("Preencha o campo email");
      if (!ValidationEmail.validEmail(usuario.Email)) throw new ArgumentException("Email inválido");



    }

  }
}