using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using M2E_conseiller;
using MudBlazor.Services;
using Smoby.Web.ExtensionMethods;
using Smoby.Web.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSmobyWebServices(builder);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

Dictionary<string, object> configurationParameters = new Dictionary<string, object>();
configurationParameters.Add("CloudConfigurationParameters",new CloudConfigurationParameters());
ServiceLocator.ConfigurationService.InitializationParameters = configurationParameters;
ServiceLocator.InitializationService.AddIInitializeObject(ServiceLocator.ConfigurationService);
ServiceLocator.InitializationService.InitializeAll();

await builder.Build().RunAsync();


