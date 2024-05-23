using ShoppingCartDTO;
using ShoppingCartDTO.User;

namespace ShoppingCartApi.Services.StudentServices
{
    public interface IUserService
    {
        ResponseModel CreateUser(UserModel userModel);
        ResponseModel UpdateUser(UserModel userModel);
        ResponseModel DeleteUser(int id);
        ResponseModel GetUser(int id);
        ResponseModel GetUserList();
        ResponseModel GetAdminList();
        ResponseModel GetUserByNameAndPassword(LoginModel loginModel);
    }
}
