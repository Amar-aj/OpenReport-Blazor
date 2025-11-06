using System.Text.Json.Serialization;

namespace OpenReport_Blazor.Models;

public class Slider
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    
    [JsonPropertyName("image")]
    public string Image { get; set; } = string.Empty;
    
    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;
}

