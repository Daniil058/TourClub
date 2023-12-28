using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EquipmentStorageWeb.Services;
using EquipmentStorageWeb;
using Blazored.LocalStorage;
using Blazored.SessionStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7196") });
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IRoleProvider, RoleProvider>();
builder.Services.AddScoped<IEquipmentProvider, EquipmentProvider>();
builder.Services.AddScoped<IUserAuthProvider, UserAuthProvider>();
builder.Services.AddScoped<IContactInformationProvider, ContactInformationProvider>();
builder.Services.AddScoped<IConditionProvider, ConditionProvider>();
builder.Services.AddScoped<ICategoryEquipmentProvider, CategoryEquipmentProvider>();
builder.Services.AddScoped<IUserDataRegProvider, UserDataRegProvider>();
builder.Services.AddScoped<IBookingProvider, BookingProvider>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredSessionStorage();
await builder.Build().RunAsync();

