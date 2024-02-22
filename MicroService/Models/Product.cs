using System.ComponentModel.DataAnnotations;

namespace MicroService.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductCategoryID { get; set; }
    }
}
