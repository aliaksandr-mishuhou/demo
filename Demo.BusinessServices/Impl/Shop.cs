using System.Collections.Generic;
using System.Linq;
using Demo.Entities;

namespace Demo.BusinessServices.Impl
{
    public class Shop : IShop
    {


        #region data

        private readonly List<Category> _categories = new List<Category>
        {
            new Category {Id = 1, Name = "Category #1"},
            new Category {Id = 2, Name = "Category #2", Children = new List<Category>
            {
                new Category {Id = 21, Name = "Category #2.1"},
                new Category {Id = 22, Name = "Category #2.2"}
            }},
            new Category {Id = 3, Name = "Category #3", Children = new List<Category>
            {
                new Category {Id = 31, Name = "Category #3.1"},
                new Category {Id = 32, Name = "Category #3.2"},
                new Category {Id = 33, Name = "Category #3.3"}
            }}
        };

        private readonly List<Product> _products = new List<Product>
        {
            new Product {Id = 1, Name = "Product #1", Price = 1100, CategoryId = 1},
            new Product {Id = 2, Name = "Product #2", Price = 8100, CategoryId = 1},
            new Product {Id = 3, Name = "Product #3", Price = 300, CategoryId = 1},
            new Product {Id = 4, Name = "Product #4", Price = 2200, CategoryId = 1},
            new Product {Id = 5, Name = "Product #5", Price = 110, CategoryId = 1},
            new Product {Id = 6, Name = "Product #6", Price = 100, CategoryId = 1},
            new Product {Id = 7, Name = "Product #7", Price = 10, CategoryId = 21},
            new Product {Id = 8, Name = "Product #8", Price = 50, CategoryId = 21},
            new Product {Id = 9, Name = "Product #9", Price = 400, CategoryId = 22},
            new Product {Id = 10, Name = "Product #10", Price = 200, CategoryId = 3},
            new Product {Id = 11, Name = "Product #11", Price = 100, CategoryId = 3},
            new Product {Id = 12, Name = "Product #12", Price = 110, CategoryId = 33},
            new Product {Id = 13, Name = "Product #13", Price = 1101, CategoryId = 33}
        };

        #endregion

        public IEnumerable<Category> GetCategories()
        {
            return _categories.ToList();
        }

        public IEnumerable<Product> GetProducts(int categoryId)
        {
            return _products.Where(i => i.CategoryId == categoryId).ToList();
        }

        public Product GetProduct(int productId)
        {
            return _products.SingleOrDefault(i => i.Id == productId);
        }
    }
}
