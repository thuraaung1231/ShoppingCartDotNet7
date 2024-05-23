using Microsoft.AspNetCore.Mvc;
using ShoppingCartApi.Services.StudentServices;
using ShoppingCartDTO;
using ShoppingCartDTO.User;

namespace ShoppingCartApi.Controllers
{
    [ApiController]
    [Route("WebAPI/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("CreateUser")]
        public Task<ResponseModel> CreateUser(UserModel userModel)
        {
            ResponseModel responseModel = new ResponseModel();
           responseModel=_userService.CreateUser(userModel);
            return Task.FromResult(responseModel);
        }

        [HttpPost]
        [Route("GetUserById/{id}")]
        public Task<ResponseModel> GetUserById(int id)
        {
            ResponseModel responseModel = new ResponseModel();
            responseModel=_userService.GetUser(id);
            return Task.FromResult(responseModel);
        }

        [HttpGet]
        [Route("GetUserList")]
        public Task<ResponseModel> GetUserList()
        {
            ResponseModel responseModel = new ResponseModel();
            responseModel=_userService.GetUserList();
            return Task.FromResult(responseModel);
        }

        [HttpGet]
        [Route("GetAdminList")]
        public Task<ResponseModel> GetAdminList()
        {
            ResponseModel responseModel = new ResponseModel();
            responseModel = _userService.GetAdminList();
            return Task.FromResult(responseModel);
        }

        [HttpPost]
        [Route("UpdateUser")]
        public Task<ResponseModel> UpdateUser(UserModel userModel)
        {
            ResponseModel responseModel = new ResponseModel();
            responseModel=_userService.UpdateUser(userModel);
            return Task.FromResult(responseModel);
        }

        [HttpPost]
        [Route("DeleteUser/{id}")]
        public Task<ResponseModel>DeleteUser(int id) {
            ResponseModel responseModel = new ResponseModel();
            responseModel= _userService.DeleteUser(id);
            return Task.FromResult(responseModel);
        }
        [HttpPost]
        [Route("GetUserByNameAndPassword")]
        public Task<ResponseModel> GetUserByNameAndPassword(LoginModel loginModel)
        {
            ResponseModel responseModel = new ResponseModel();
            responseModel = _userService.GetUserByNameAndPassword(loginModel);
            return Task.FromResult(responseModel);
        }
    }
}
