namespace BlazorEcommerce.Server.Services.ProductService
{
	public interface IProductService
	{
		Task GetProductAsync(int productId);
		Task<ServiceResponse<List<Product>>> GetProductsAsync();
		Task GetProductsAsync(int productId);
	}
}