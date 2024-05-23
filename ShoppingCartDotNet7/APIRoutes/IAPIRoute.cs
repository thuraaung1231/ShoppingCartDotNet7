using Refit;
using ShoppingCartDTO;
using ShoppingCartDTO.Product;
using ShoppingCartDTO.User;

namespace ShoppingCartDotNet7.APIRoutes
{
    public interface IAPIRoute
    {
        [Post("/User/CreateUser")]
        Task<ResponseModel> CreateUser(UserModel userModel);

        [Post("/User/GetUserByNameAndPassword")]
        Task<ResponseModel> GetUserByNameAndPassword(LoginModel loginModel);

        [Post("/Product/AddProduct")]
        Task<ResponseModel> AddProduct(ProductModel productModel);
        [Get("/Product/ListProduct")]
        Task<ResponseModel> ProductList();

        [Post("/Product/DeleteProduct/{id}")]
        Task<ResponseModel> DeleteProduct(int id);

        [Post("/Product/GetByProductId/{id}")]
        Task<ResponseModel> GetByProductId(int id);

        [Post("/Product/UpdateProduct")]
        Task<ResponseModel> UpdateProduct(ProductModel productModel);
    }
}
