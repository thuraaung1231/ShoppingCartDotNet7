using Refit;
using ShoppingCartDTO;
using ShoppingCartDTO.User;

namespace ShoppingCartDotNet7.APIRoutes
{
    public interface IAPIRoute
    {
        [Post("/User/CreateUser")]
        Task<ResponseModel> CreateUser(UserModel userModel);

        [Post("/User/GetUserByNameAndPassword")]
        Task<ResponseModel> GetUserByNameAndPassword(LoginModel loginModel);
    }
}
