using System.Text.Json.Serialization;

namespace OpenReport_Blazor.Models;

public class ChannelListResponse
{
    [JsonPropertyName("channels")]
    public List<Channel> Channels { get; set; } = new();

    [JsonPropertyName("category")]
    public List<Category> Categories { get; set; } = new();

    [JsonPropertyName("slider")]
    public List<Slider> Sliders { get; set; } = new();
}

