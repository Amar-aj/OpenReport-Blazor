using System.Text.Json.Serialization;

namespace OpenReport_Blazor.Models;

public class Channel
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    
    [JsonPropertyName("channelno")]
    public string ChannelNo { get; set; } = string.Empty;
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("image")]
    public string Image { get; set; } = string.Empty;
    
    [JsonPropertyName("videourl")]
    public string VideoUrl { get; set; } = string.Empty;
    
    [JsonPropertyName("channelurl")]
    public string ChannelUrl { get; set; } = string.Empty;
    
    [JsonPropertyName("channelid")]
    public string ChannelId { get; set; } = string.Empty;
    
    [JsonPropertyName("category")]
    public string Category { get; set; } = string.Empty;
    
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;
    
    [JsonPropertyName("position")]
    public string Position { get; set; } = string.Empty;
    
    [JsonPropertyName("is_hidden")]
    public string IsHidden { get; set; } = string.Empty;
}

