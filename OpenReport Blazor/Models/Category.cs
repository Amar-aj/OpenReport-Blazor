using System.Text.Json.Serialization;

namespace OpenReport_Blazor.Models;

public class Category
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    
    [JsonPropertyName("category_name")]
    public string CategoryName { get; set; } = string.Empty;
    
    [JsonPropertyName("home")]
    public string Home { get; set; } = string.Empty;
    
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;
    
    [JsonPropertyName("position")]
    public string Position { get; set; } = string.Empty;
    
    [JsonPropertyName("is_hidden")]
    public string IsHidden { get; set; } = string.Empty;
}

