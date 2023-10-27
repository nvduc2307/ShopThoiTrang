using ShopThoiTrang.BackEnd.Entities;
using ShopThoiTrang.BackEnd.IRepositories;

namespace ShopThoiTrang.BackEnd.Repositories;

public class ProductRepository : IProductRepository
{
    public Task CreateProduct(ProductEntity productEntity)
    {
        throw new NotImplementedException();
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

    public Task<List<ProductEntity>> GetProducts()
    {
        throw new NotImplementedException();
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