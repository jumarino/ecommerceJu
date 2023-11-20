namespace BlazorEcommerce.Server.Services.ProductService
{
	public interface IProductService1
	{
		Task<ServiceResponse<Product>> CreateProduct(Product product);
		Task<ServiceResponse<bool>> DeleteProduct(int productId);
		Task<ServiceResponse<List<Product>>> GetAdminProducts();
		Task<ServiceResponse<List<Product>>> GetFeaturedProducts();
		Task<ServiceResponse<Product>> GetProductAsync(int productId);
		Task<ServiceResponse<List<Product>>> GetProductsAsync();
		Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);
		Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText);
		Task<ServiceResponse<ProductSearchResult>> SearchProducts(string searchText, int page);
		Task<ServiceResponse<Product>> UpdateProduct(Product product);
	}
}