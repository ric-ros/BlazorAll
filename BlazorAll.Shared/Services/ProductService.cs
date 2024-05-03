using BlazorAll.Shared.Models;
using System.Net.Http.Json;

namespace BlazorAll.Shared.Services;

public class ProductService(HttpClient httpClient)
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<List<Product>> GetProducts()
    {
        var response = await _httpClient.GetFromJsonAsync<ProductApiResponse>("https://dummyjson.com/products") ?? throw new Exception("No response");

        return response.Products;
    }
}
