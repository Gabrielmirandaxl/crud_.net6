namespace test_crud.Dtos
{
  public class UsuarioDetalhesDto
  {

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public string? Cpf { get; set; }
    public DateTime RegistrationDate { get; set; }
  }
}