using AutoMapper;
using NerdStore.Catalogo.Application.ViewModels;
using NerdStore.Catalogo.Domain;

namespace NerdStore.Catalogo.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Produto, ProdutoViewModel>()
                .ForMember(d => d.Largura, o => o.MapFrom(p => p.Dimensoes.Largura))
                .ForMember(d => d.Altura, o => o.MapFrom(p => p.Dimensoes.Altura))
                .ForMember(d => d.Profundidade, o => o.MapFrom(p => p.Dimensoes.Profundidade));

            CreateMap<Categoria, CategoriaViewModel>();
        }
    }
}
