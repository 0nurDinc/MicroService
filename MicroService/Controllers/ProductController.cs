using MicroService.Models;
using MicroService.Repository.Abstract;
using MicroService.Repository.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Transactions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }


       
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _repository.GetProductList();
        }

     
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _repository.GetProductByID(id);
        }

     
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            _repository.AddProduct(value);
        }


        public IActionResult Put([FromBody] Product value)
        {
            _repository.UpdateProduct(value);
            return new OkResult();
        }

       
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.RemoveProduct(id);
            return new OkResult();
        }
    }
}
