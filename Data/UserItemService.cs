namespace callWebAPI.Data;
using System.Text.Json;
using System.Text.Json.Serialization;


public interface IUserItemService {
    Task<IEnumerable<UserItem>> GetUserItems();
} 

public class UserItemService : IUserItemService
{
    private readonly HttpClient httpClient;

    public UserItemService(HttpClient httpClient) {
        this.httpClient = httpClient;
    }
    
    public async Task<IEnumerable<UserItem>> GetUserItems()
    {
        return await httpClient.GetFromJsonAsync<UserItem[]>("/users");
    }
}