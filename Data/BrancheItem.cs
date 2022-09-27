using System.Text.Json.Serialization;

namespace callWebAPI.Data;

public class BrancheItem
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}