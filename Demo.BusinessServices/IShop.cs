using System.Collections.Generic;
using Demo.Entities;

namespace Demo.BusinessServices
{
    public interface IShop
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Product> GetProducts(int categoryId);
        Product GetProduct(int productId);

    }
}
