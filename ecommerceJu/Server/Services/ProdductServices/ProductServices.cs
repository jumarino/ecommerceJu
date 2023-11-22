﻿


using ecommerceJu.Server.Services.ProductService;

namespace BlazorEcommerce.Server.Services.ProductService
{
	public class ProductService : IProductService
    {
		private readonly DataContext _context;
		

		public ProductService(DataContext context)
		{
			_context = context;
			
		}


        public async Task<ServiceResponse<Product>> GetProductsAsync(int productId, ServiceResponse<Product> response)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                response.Success = false;
                response.Message = "Sorry, but this product does not exist.";

            }
            else
            {
                response.Data = product;
            }
            return response;

        }
        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.ToListAsync()

            };

            return response;
        }
    }
}
	