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

        [Get("/User/GetUserList")]
        Task<ResponseModel> GetUserList();

        [Post("/User/DeleteUser/{id}")]
        Task<ResponseModel> DeleteUser(int id);

        [Post("/User/GetUserById/{id}")]
        Task<ResponseModel> GetUserById(int id);

        [Post("/User/UpdateUser")]
        Task<ResponseModel> UpdateUser(UserModel userModel);
        [Get("/User/GetAdminList")]
        Task<ResponseModel> GetAdminList();


        //product API
        [Post("/Product/AddProduct")]
        Task<ResponseModel> CreateProduct(ProductModel productModel);

        [Get("/Product/ListProduct")]
        Task<ResponseModel> GetProductList();

        [Post("/Product/DeleteProduct/{id}")]
        Task<ResponseModel> DeleteProduct(int id);
        [Post("/Product/GetByProductId")]
        Task<ResponseModel> GetByProductId(int id);
        [Post("/Product/UpdateProduct")]
        Task<ResponseModel> UpdateProduct(ProductModel productModel);
    }
}
