using GeekShooping.ProductAPI.Data.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekShooping.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductVO>> FindAll();
        Task<ProductVO> FindById(long id);
        Task<ProductVO> Create(ProductVO Vo);
        Task<ProductVO> Update(ProductVO Vo);
        Task<bool> Delete(long id);
    }
}
