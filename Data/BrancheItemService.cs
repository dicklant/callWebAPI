namespace callWebAPI.Data;
using System.Text.Json;
using System.Text.Json.Serialization;


public interface IBrancheItemService
{
    Task<IEnumerable<BrancheItem>> GetBrancheItems();
}

public class BrancheItemService : IBrancheItemService
{
    private readonly HttpClient httpClient;

    public BrancheItemService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<IEnumerable<BrancheItem>> GetBrancheItems()
    {
        //return await httpClient.GetFromJsonAsync<BrancheItem[]>("/vehicles"); 
//        return await httpClient.GetFromJsonAsync<BrancheItem[]>("/repos/dotnet/AspNetCore.Docs/branches"); 

        var r = await httpClient.GetFromJsonAsync<BrancheItem[]>("branches");

        return r;
    }
}