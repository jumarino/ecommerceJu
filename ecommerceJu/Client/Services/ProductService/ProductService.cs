global using ecommerceJu.Shared;
global using ecommerceJu.Client.Services.ProductService;
global using System.Net.Http.Json;
using static System.Net.WebRequestMethods;


namespace ecommerceJu.Client.Services.ProductService

{
	public class ProductService : IProductService
	{ 

			private readonly HttpClient _http;
	public ProductService(HttpClient http)
	{
		_http = http;
	}

	public List<Product> Products { get; set; } = new List<Product>();
		public List<Product> products { get; set; }

		public async Task GetProducts()
		{
			var result = 
			await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
		if (result != null && result.Data != null)
			Products = result.Data;
		}

	}
}

