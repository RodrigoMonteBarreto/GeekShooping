using GeekShooping.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeekShooping.Web.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> FindAllProduct();
        Task<ProductModel> FindProductById(long id);
        Task<ProductModel> CreateProduct(ProductModel productModel);
        Task<ProductModel> UpdateProduct(ProductModel productModel);
        Task<bool> DeleteProductById(long id);
    }
}
