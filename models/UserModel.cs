namespace test_crud.models
{
  public class UserModel
    {

      public int id { get; set; }
      public string? name { get; set; }
      public string? email { get; set; }
      public string? telefone { get; set; }
      public string? cpf { get; set; }
      public DateTime registrationDate { get; set; }
        
    }
}