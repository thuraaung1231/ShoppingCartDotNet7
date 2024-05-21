using ShoppingCartApi.DAO;
using ShoppingCartDTO;
using ShoppingCartDTO.Product;
using ShoppingCartDTO.User;

namespace ShoppingCartApi.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public ResponseModel CreateProduct(ProductModel productModel)
        {
            ResponseModel responseModel = new ResponseModel();
            _applicationDbContext.Product.Add(productModel);
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

        public ResponseModel DeleteProduct(int id)
        {
            ResponseModel responseModel = new ResponseModel();
            var product=_applicationDbContext.Product.Where(p=>p.Is_delete==false&&p.Code==id).FirstOrDefault();
            if (product != null)
            {
                product.Is_delete = true;
                _applicationDbContext.Product.Update(product);
                int count=_applicationDbContext.SaveChanges();
                if(count > 0)
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

        public ResponseModel GetProduct(int id)
        {
            ResponseModel responseModel = new ResponseModel();  
            var product=_applicationDbContext.Product.Where(p=>p.Is_delete==false && p.Code==id).FirstOrDefault();
            if(product != null)
            {
                responseModel.ResData= product;
                responseModel.ResCode = "I001";
            }
            else
            {
                responseModel.ResCode = "I003";
            }
            return responseModel;
        }

        public ResponseModel GetProductList()
        {
            ResponseModel responseModel = new ResponseModel();
            var productList=_applicationDbContext.Product.Where(p=>p.Is_delete==false).ToList();
            if(productList.Count > 0)
            {
                responseModel.ResData = productList;
                responseModel.ResCode = "I001";
            }
            else
            {
                responseModel.ResCode = "I003";
            }
            return responseModel;
        }

        public ResponseModel UpdateProduct(ProductModel productModel)
        {
            ResponseModel responseModel = new ResponseModel();
            _applicationDbContext.Product.Update(productModel);
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
    }
}
