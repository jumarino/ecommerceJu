﻿namespace BlazorEcommerce.Server.Services.ProductService
{
	public class ProductService : IProductService, IProductService1
	{
		private readonly DataContext _context;
		private readonly IHttpContextAccessor _httpContextAccessor;

		public ProductService(DataContext context, IHttpContextAccessor httpContextAccessor)
		{
			_context = context;
			_httpContextAccessor = httpContextAccessor;
		}

		public Task<ServiceResponse<Product>> CreateProduct(Product product)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<bool>> DeleteProduct(int productId)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<List<Product>>> GetAdminProducts()
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<List<Product>>> GetFeaturedProducts()
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<Product>> GetProductAsync(int productId)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<List<Product>>> GetProductsAsync()
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<ProductSearchResult>> SearchProducts(string searchText, int page)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<Product>> UpdateProduct(Product product)
		{
			throw new NotImplementedException();
		}
	}
}
	
