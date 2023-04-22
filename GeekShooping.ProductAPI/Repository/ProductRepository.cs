using AutoMapper;
using GeekShooping.ProductAPI.Data.ValueObjects;
using GeekShooping.ProductAPI.Model;
using GeekShooping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShooping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySqlContext _context;
        private IMapper _mapper;


        public ProductRepository(MySqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<IEnumerable<ProductVO>> FindAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductVO>>(products);
        }

        public async Task<ProductVO> FindById(long id)
        {
            //Caso não encontre o produto, irá retornar uma instância de Produto.
            Product product = await _context
                                        .Products
                                        .Where(p => p.Id == id)
                                        .FirstOrDefaultAsync() ?? new Product();

            return _mapper.Map<ProductVO>(product);
        }

        public async Task<ProductVO> Create(ProductVO Vo)
        {
            Product product = _mapper.Map<Product>(Vo);
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductVO>(product);
        }

        public async Task<ProductVO> Update(ProductVO Vo)
        {
            Product product = _mapper.Map<Product>(Vo);
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductVO>(product);
        }

        public async Task<bool> Delete(long id)
        {
            //Caso não encontre o produto, irá retornar uma instância de Produto.
            try
            {
                Product product = await _context
                                            .Products
                                            .Where(p => p.Id == id)
                                            .FirstOrDefaultAsync() ?? new Product();
                if (product.Id <= 0)
                {
                    return false;
                }

                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
