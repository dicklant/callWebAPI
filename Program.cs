using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using callWebAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddHttpClient<IUserItemService, UserItemService>(client =>
{
    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
});

/*
builder.Services.AddHttpClient<IBrancheItemService, BrancheItemService>(client =>
{
    client.BaseAddress = new Uri("https://ghibliapi.herokuapp.com");
});
*/

builder.Services.AddHttpClient<IBrancheItemService, BrancheItemService>(client =>
{
    client.BaseAddress = new Uri("https://api.github.com/repos/dotnet/AspNetCore.Docs");
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
