using AutoMapper;
using BerthaStore.Application.Models.NewClient;
using BerthaStore.Application.Models.NewProduct;
using BerthaStore.Application.Models.NewOrder;
using BerthaStore.Core.Entities;

namespace BerthaStore.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NewProductRequest, Product>()
                .ForMember(dest => dest.Name, fonte => fonte.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, fonte => fonte.MapFrom(src => src.Description))
                .ForMember(dest => dest.Price, fonte => fonte.MapFrom(src => src.Price))
                .ForMember(dest => dest.Storage, fonte => fonte.MapFrom(src => src.Storage));

 //           CreateMap<NewClientRequest, Client>()
 //               .ForMember(dest => dest.Name, fonte => fonte.MapFrom(src => src.Name))
 //               .ForMember(dest => dest.Email, fonte => fonte.MapFrom(src => src.Email))
 //               .ForMember(dest => dest.Cpf, fonte => fonte.MapFrom(src => src.Cpf))
 //               .ForMember(dest => dest.Password, fonte => fonte.MapFrom(src => src.Password));

            CreateMap<NewOrderRequest, Order>()
                .ForMember(dest => dest.PaymentType, fonte => fonte.MapFrom(src => src.PaymentType));
        }


    }
}
