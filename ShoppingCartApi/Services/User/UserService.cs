﻿using ShoppingCartApi.DAO;
using ShoppingCartDTO;
using ShoppingCartDTO.User;

namespace ShoppingCartApi.Services.StudentServices
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public ResponseModel CreateUser(UserModel userModel)
        {
            ResponseModel responseModel = new ResponseModel();
            _applicationDbContext.User.Add(userModel);
            int count=_applicationDbContext.SaveChanges();
            if(count> 0)
            {
                responseModel.ResCode = "I001";
            }
            else
            {
                responseModel.ResCode = "I002";
            }
            return responseModel;
           
        }

        public ResponseModel DeleteUser(int id)
        {
            ResponseModel responseModel = new ResponseModel();
            var User= _applicationDbContext.User.Where(u=>u.Id==id && u.Is_delete==false).FirstOrDefault();
            if(User!= null)
            {
              User.Is_delete = true;
                _applicationDbContext.User.Update(User);
               int count= _applicationDbContext.SaveChanges();
                if(count>0)
                {
                    responseModel.ResCode = "I001";
                }
                else
                {
                    responseModel.ResCode = "I002";
                }
            }
            else
            {
                responseModel.ResCode = "I003";
            }
            return responseModel;
        }

        public ResponseModel GetUser(int id)
        {
            ResponseModel responseModel= new ResponseModel();
            var User=_applicationDbContext.User.Where(u=>u.Is_delete==false && u.Id==id).FirstOrDefault();
            if (User != null)
            {
                responseModel.ResData = User;
                responseModel.ResCode = "I001";
            }
            else
            {
                responseModel.ResCode = "I003";
            }
            return responseModel;
        }

        public ResponseModel GetUserList()
        {
            ResponseModel responseModel=new ResponseModel();
            var UserList=_applicationDbContext.User.Where(u=>u.Is_delete==false && u.RoleId==2).ToList();
            if (UserList.Count > 0)
            {
                responseModel.ResData = UserList;
                responseModel.ResCode = "I001";
            }
            else
            {
                responseModel.ResCode = "I003";
            }
            return responseModel;
        }

        public ResponseModel GetAdminList()
        {
            ResponseModel responseModel = new ResponseModel();
            var UserList = _applicationDbContext.User.Where(u => u.Is_delete == false && u.RoleId == 1).ToList();
            if (UserList.Count > 0)
            {
                responseModel.ResData = UserList;
                responseModel.ResCode = "I001";
            }
            else
            {
                responseModel.ResCode = "I003";
            }
            return responseModel;
        }
        public ResponseModel UpdateUser(UserModel userModel)
        {
            ResponseModel responseModel = new ResponseModel();
            _applicationDbContext.User.Update(userModel);
            int count=_applicationDbContext.SaveChanges();
            if(count > 0)
            {
                responseModel.ResCode = "I001";
            }
            else
            {
                responseModel.ResCode = "I003";
            }
            return responseModel;

        }
        public ResponseModel GetUserByNameAndPassword(LoginModel loginModel)
        {
            ResponseModel responseModel = new ResponseModel();
            var user = _applicationDbContext.User.Where(u => u.Name == loginModel.Name && u.Password == loginModel.Password && u.Is_delete == false).FirstOrDefault();
            if (user != null)
            {
                responseModel.ResData = user;
                responseModel.ResCode = "I001";
            }
            else
            {
                responseModel.ResCode = "I002";
            }
            return responseModel;
        }
    }
}
