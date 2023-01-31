namespace test_crud.models
{
  public class Usuario
  {

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public string? Cpf { get; set; }
    public DateTime RegistrationDate { get; set; }

  }
}