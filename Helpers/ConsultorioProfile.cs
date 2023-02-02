using AutoMapper;
using test_crud.Dtos;
using test_crud.models;

namespace test_crud.Helpers
{
  public class ConsultorioProfile : Profile
  {

    public ConsultorioProfile()
    {
      CreateMap<Usuario, UsuarioDetalhesDto>();
    }

  }
}