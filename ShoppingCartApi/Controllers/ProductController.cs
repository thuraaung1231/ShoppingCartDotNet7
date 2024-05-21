using Microsoft.AspNetCore.Mvc;
using ShoppingCartDTO.User;
using ShoppingCartDTO;
using ShoppingCartApi.Services.Product;
using ShoppingCartDTO.Product;

namespace ShoppingCartApi.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost]
        [Route("CreateProduct")]
        public Task<ResponseModel> CreateProduct(ProductModel productModel)
        {
            ResponseModel responseModel = new ResponseModel();
            responseModel = _productService.CreateProduct(productModel);
            return Task.FromResult(responseModel);
        }

        [HttpPost]
        [Route("GetProductById/{id}")]
        public Task<ResponseModel> GetProductById(int id)
        {
            ResponseModel responseModel = new ResponseModel();
            responseModel = _productService.GetProduct(id);
            return Task.FromResult(responseModel);
        }

        [HttpGet]
        [Route("GetProductList")]
        public Task<ResponseModel> GetProductList()
        {
            ResponseModel responseModel = new ResponseModel();
            responseModel = _productService.GetProductList();
            return Task.FromResult(responseModel);
        }

        [HttpPost]
        [Route("UpdateProduct")]
        public Task<ResponseModel> UpdateProduct(ProductModel productModel)
        {
            ResponseModel responseModel = new ResponseModel();
            responseModel = _productService.UpdateProduct(productModel);
            return Task.FromResult(responseModel);
        }

        [HttpPost]
        [Route("DeleteProduct/{id}")]
        public Task<ResponseModel> DeleteProduct(int id)
        {
            ResponseModel responseModel = new ResponseModel();
            responseModel = _productService.DeleteProduct(id);
            return Task.FromResult(responseModel);
        }
    }
}
