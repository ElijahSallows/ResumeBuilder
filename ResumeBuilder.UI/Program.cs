using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ResumeBuilder.Shared.Models;
using ResumeBuilder.UI;
using ResumeBuilder.UI.Repositories;
using ResumeBuilder.UI.Repositories.Interfaces;
using ResumeBuilder.UI.Services;
using ResumeBuilder.UI.Services.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddSingleton(BuildResumeModelService());

var host = builder.Build();

var localStorageService = host.Services.GetRequiredService<ISyncLocalStorageService>();
var modelService = host.Services.GetRequiredService<IResumeModelService>();

modelService.Initialize(GetResumeInfoRepository(localStorageService), GetStateInfoRepository(localStorageService));

await host.RunAsync();


// Builder methods for dependency injection
#region BuilderFunctions
IResumeInfoRepository GetResumeInfoRepository(ISyncLocalStorageService localStorageService)
{
    return new ResumeInfoRepository(localStorageService);
}

IStateInfoRepository GetStateInfoRepository(ISyncLocalStorageService localStorageService)
{
    return new StateInfoRepository(localStorageService);
}

IResumeModelService BuildResumeModelService()
{
    return new ResumeModelService<ResumeInfoModel>();
}
#endregion
