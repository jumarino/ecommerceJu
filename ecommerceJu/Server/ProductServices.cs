namespace ecommerceJu.Server.Services.ProductService
{
	public class ProductServices : IProductServices
	{
		private readonly DataContext _context;
	

		public ProductServices(DataContext context)
		{
			_context = context;
			
		}
		public async Task<ServiceResponse<Product>> GetProductsAsync(int productId, ServiceResponse<List<Product>>response)
		{
			var responses = new ServiceResponse<Product>();
			var product = await _context.Products.FindAsync(productId);
			if (product == null)
			{
				responses.Success = false;
				responses.Message = "Sorry, but this product does not exist.";

			}
			else
			{
				responses.Data = product;
			}
			return responses;

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
