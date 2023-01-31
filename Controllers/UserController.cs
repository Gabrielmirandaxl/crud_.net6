
using Microsoft.AspNetCore.Mvc;
using test_crud.models;

namespace test_crud.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class UserController : ControllerBase
  {

    private static List<Usuario> Users()
    {
      return new List<Usuario>{
         new Usuario{Id = 1, Name = "gabriel", Email = "gabriel@gmail.com", Telefone = "984021703", Cpf = "23234523412", RegistrationDate = new DateTime(2023, 01, 31)}
  };
    }

    [HttpGet]
    public IActionResult Get() => Ok(Users());




    [HttpPost]
    public IActionResult Post(Usuario usuario)
    {
      var usuarios = Users();
      usuarios.Add(usuario);
      return Ok(usuarios);
    }


  }
}