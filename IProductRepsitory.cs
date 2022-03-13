using NathansCRUDWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models;

namespace NathansCRUDWebsite
{
    public interface IProductRepsitory
    {
        public IEnumerable<Models.Product1> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product1 product);
        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
        public void DeleteProduct(Product product);



    }
}
