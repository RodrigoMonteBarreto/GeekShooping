using AutoMapper;
using GeekShopping.CartAPI.Data.ValueObjects;
using GeekShopping.CartAPI.Model;

namespace GeekShopping.CartAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                //1ª Uma maneira de fazer, utilizarei a primeira
                config.CreateMap<ProductVO, Product>().ReverseMap();
                config.CreateMap<CartHeaderVO, CartHeader>().ReverseMap();
                config.CreateMap<CartDetailVO, CartDetail>().ReverseMap();
                config.CreateMap<CartVO, Cart>().ReverseMap();

                //2ªª outra maneira de fazer
                //config.CreateMap<ProductVO, Product>();
                //config.CreateMap<Product, ProductVO>();
                //config.CreateMap<CartHeaderVO, CartHeader>();
                //config.CreateMap<CartHeader, CartHeaderVO>();
                //config.CreateMap<CartDetailVO, CartDetail>();
                //config.CreateMap<CartDetail, CartDetailVO>();
                //config.CreateMap<CartVO, Cart>();
                //config.CreateMap<Cart, CartVO>();
            });
            return mappingConfig;
        }
    }
}
