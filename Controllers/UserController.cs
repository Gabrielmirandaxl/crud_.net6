using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using test_crud.Dtos;
using test_crud.models;
using test_crud.Repository;


namespace test_crud.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class UserController : ControllerBase
  {

    private readonly IUserRepository repository;
    private readonly IMapper mapper;

    public UserController(IUserRepository repository, IMapper mapper)
    {
      this.repository = repository;
      this.mapper = mapper;
    }




    [HttpPost]
    public async Task<IActionResult> Post(Usuario usuario)
    {


      usuario.RegistrationDate = DateTime.Now;
      this.repository.AdicionandoUsuario(usuario);

      return await this.repository.SavesChangesAsync()
      ? Ok("Usuário criado")
      : BadRequest("Erro ao salvar o suário");
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {

      var usuarios = await this.repository.BuscarUsuarios();

      return Ok(usuarios);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {

      var user = await this.repository.BuscaUsuario(id);

      var userdetails = mapper.Map<UsuarioDetalhesDto>(user);

      return user != null ? Ok(userdetails) : NotFound("Nenhum usuário encontrado");

    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Usuario usuario)
    {

      var user = await this.repository.BuscaUsuario(id);

      if (user == null) return NotFound("usuário não encontrado");

      user.Name = usuario.Name ?? user.Name;
      user.Email = usuario.Email ?? user.Email;
      user.Telefone = usuario.Telefone ?? user.Telefone;
      user.Cpf = usuario.Cpf ?? user.Cpf;
      user.RegistrationDate = DateTime.Now;

      this.repository.AtualizarUsuario(user);

      return await this.repository.SavesChangesAsync()
             ? Ok("Usuário atualizado com sucesso")
             : BadRequest("Erro ao atualizar o usuário");

    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {

      var user = await this.repository.BuscaUsuario(id);

      if (user == null) return NotFound("Usuário não encontrado");

      this.repository.RemoverUsuario(user);

      return await this.repository.SavesChangesAsync()
      ? Ok("Usuário deletado com sucesso")
      : BadRequest("Erro ao deletar o usuário");


    }


  }
}