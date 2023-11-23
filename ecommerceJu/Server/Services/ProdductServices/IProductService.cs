using Microsoft.AspNetCore.Mvc;

namespace ecommerceJu.Server.Services.ProductService
{
	public interface IProductService
	{
        Task<ServiceResponse<Product>> GetProductsAsync(int productId, ServiceResponse<Product> response);

        Task<ServiceResponse<List<Product>>> GetProductsAsync();
      
}
}
