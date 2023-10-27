using ShopThoiTrang.BackEnd.Entities;

namespace ShopThoiTrang.BackEnd.IRepositories;

public interface IProductRepository {
    Task<List<ProductEntity>> GetProducts();
    Task CreateProduct(ProductEntity productEntity);
    Task DeleteProduct(int productEntityId);
    Task UpDateProduct(int productEntityId, ProductEntity productEntityUpdate);
    Task RestoreProduct(int productEntityId);
    Task<ProductEntity> GetProductById(int productEntityId);
    Task<ProductEntity> GetProductByName(string productEntityName);
}