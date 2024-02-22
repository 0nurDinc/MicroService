using MicroService.Context;
using MicroService.Models;
using MicroService.Repository.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace MicroService.Repository.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDBContext context;

        public ProductRepository(AppDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product> GetProductList()
        {
            return context.Products.ToList();
        }

        public Product GetProductByID(int productID)
        {
            return context.Products.FirstOrDefault(x=>x.ProductID == productID);
        }

        public void AddProduct(Product entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }
         
        public void RemoveProduct(int productID)
        {
            var selectedProduct = context.Products.FirstOrDefault(x=>x.ProductID==productID);
            if (selectedProduct is null)
                return;

            context.Products.Remove(selectedProduct);
            context.SaveChanges();
        }

        public void UpdateProduct(Product entity)
        {
            if (entity is null)
                return;

            context.Entry<Product>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
