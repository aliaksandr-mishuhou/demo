using Demo.Entities;

namespace Demo.BusinessServices
{
    public interface IAdminShop
    {
        void AddProduct(Product item);
        void DeleteProduct(int id);
        void UpdateProduct(Product item);

        void AddCategory(Category item);
        void DeleteCategory(int id);
        void UpdateCategory(Category item);

    }
}
