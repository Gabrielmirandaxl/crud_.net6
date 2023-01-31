
using Microsoft.AspNetCore.Mvc;
using test_crud.models;
using test_crud.Repository;

namespace test_crud.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class UserController : ControllerBase
  {

    private readonly IUserRepository repository;

    public UserController(IUserRepository repository)
    {
      this.repository = repository;
    }


    [HttpPost]
    public async Task<IActionResult> Post(Usuario usuario)
    {
      usuario.RegistrationDate = DateTime.Now;
      this.repository.AdicionandoUsuario(usuario);
      Console.WriteLine(usuario.Cpf);
      return await this.repository.SavesChangesAsync()
      ? Ok("Usuário criado")
      : BadRequest("Erro ao salvar o suário");
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      return Ok(await this.repository.BuscarUsuarios());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {

      var user = await this.repository.BuscaUsuario(id);

      return user != null ? Ok(user) : NotFound("Nenhum usuário encontrado");

    }


  }
}