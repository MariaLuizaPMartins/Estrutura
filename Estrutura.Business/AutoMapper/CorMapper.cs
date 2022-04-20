using AutoMapper;
using Estrutura.Data.Models;
using Estrutura.Shared.ViewModels.Cor;

namespace Estrutura.Business.AutoMapper
{
    public class CorMapper : Profile
    {
        public CorMapper()
        {
            CreateMap<Cor, CorViewModel>().ReverseMap();

            CreateMap<Cor, CorCadastroViewModel>().ReverseMap();

            CreateMap<Cor, CorAlteracaoViewModel>().ReverseMap();
        }
    }
}
