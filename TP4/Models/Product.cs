using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

public class Product
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    [JsonPropertyName("category")]
    public string Category { get; set; } = "General";

    [JsonPropertyName("thumbnail")]
    public string Thumbnail { get; set; } = string.Empty;
}

public class ProductResponse
{
    [JsonPropertyName("products")]
    public List<Product> Products { get; set; } = new();
}   

