using ShopThoiTrang.BackEnd.Databases;
using ShopThoiTrang.BackEnd.Entities;
using ShopThoiTrang.BackEnd.IRepositories;

namespace ShopThoiTrang.BackEnd.Repositories;

public class ProductRepository : IProductRepository
{
    private MainDbContext _mainDbContext;
    public ProductRepository(MainDbContext mainDbContext)
    {
        _mainDbContext = mainDbContext;
    }
    public async Task<ProductEntity> CreateProduct(ProductEntity productEntity)
    {
        var products = _mainDbContext.products;
        var isExisted = products.Any(x => x.Name == productEntity.Name);
        if(!isExisted) {
            _mainDbContext.products.Add(productEntity);
            _mainDbContext.SaveChanges();
            return productEntity;
        } else
        {
            return null;
        }
    }

    public Task DeleteProduct(int productEntityId)
    {
        throw new NotImplementedException();
    }

    public Task<ProductEntity> GetProductById(int productEntityId)
    {
        throw new NotImplementedException();
    }

    public Task<ProductEntity> GetProductByName(string productEntityName)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ProductEntity>> GetProducts()
    {
        var products = _mainDbContext.products.ToList();
        return  products;
    }

    public Task RestoreProduct(int productEntityId)
    {
        throw new NotImplementedException();
    }

    public Task UpDateProduct(int productEntityId, ProductEntity productEntityUpdate)
    {
        throw new NotImplementedException();
    }
}