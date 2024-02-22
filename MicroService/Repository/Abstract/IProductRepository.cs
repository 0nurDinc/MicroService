using MicroService.Models;
using System.Collections.Generic;

namespace MicroService.Repository.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProductList();
        Product GetProductByID(int productID);
        void AddProduct(Product entity);
        void UpdateProduct(Product entity);
        void RemoveProduct(int productID);
    }
}
