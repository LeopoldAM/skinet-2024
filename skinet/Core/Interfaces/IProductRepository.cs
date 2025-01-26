using System;
using Core.Entities;

namespace Core.Interfaces;

public interface IProductRepository
{
    /// <summary>
    /// return list of Products, filter by brand and type and price
    /// </summary>
    /// <param name="brand"></param>
    /// <param name="type"></param>
    /// <param name="sort"></param>
    /// <returns></returns>
    Task<IReadOnlyList<Product>> GetProductsAsync(string? brand, string? type, string? sort);
    Task<Product?> GetProductsByIdAsync(int id);
    Task<IReadOnlyList<string>> GetBrandsAsync();
    Task<IReadOnlyList<string>> GetTypesAsync();
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(Product product);
    bool ProductExists(int id);
    Task<bool> SaveChangesAsync();

}
