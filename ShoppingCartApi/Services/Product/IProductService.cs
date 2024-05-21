using ShoppingCartDTO.User;
using ShoppingCartDTO;
using ShoppingCartDTO.Product;

namespace ShoppingCartApi.Services.Product
{
    public interface IProductService
    {
        ResponseModel CreateProduct(ProductModel productModel);
        ResponseModel UpdateProduct(ProductModel productModel);
        ResponseModel DeleteProduct(int id);
        ResponseModel GetProduct(int id);
        ResponseModel GetProductList();
    }
}
