using System.Net.Http.Json;
using System;

public class ProductService
{
    private readonly HttpClient _http;

    public ProductService(HttpClient http)
    {
        _http = http;
    }
    //get
    public async Task<List<Product>> GetProductsAsync()
    {
        try
        {
            var response = await _http.GetFromJsonAsync<ProductResponse>("products?limit=25");
            return response?.Products ?? new List<Product>();
        }
        catch
        {
            return new List<Product>(); 
        }
    }

    // post
    public async Task<Product?> AddProductAsync(Product newProduct)
    {
        var response = await _http.PostAsJsonAsync("products/add", newProduct);
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<Product>();
        }
        return null;
    }

    // put
    public async Task<Product?> UpdateProductAsync(int id, Product updatedProduct)
    {
        var response = await _http.PutAsJsonAsync($"products/{id}", updatedProduct);
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<Product>();
        }
        return null;
    }

    // delete
    public async Task<bool> DeleteProductAsync(int id)
    {
        try
        {
            var response = await _http.DeleteAsync($"products/{id}");
            return response.IsSuccessStatusCode;
        }
        catch
        {
            return false;
        }
    }
}