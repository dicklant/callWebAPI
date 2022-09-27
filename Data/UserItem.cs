using System.Text.Json.Serialization;

namespace callWebAPI.Data;

public class UserItem
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("username")]
    public string Username { get; set;}
    [JsonPropertyName("email")]
    public string Email { get; set; }

}

