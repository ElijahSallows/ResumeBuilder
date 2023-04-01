using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
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
//var ModelServiceFactory = new 
//builder.Services.AddSingleton(BuildResumeModelService(localStorageInstance));

var host = builder.Build();

var localStorageService = host.Services.GetRequiredService<ISyncLocalStorageService>();
//ModelServiceFactory

await host.RunAsync();


#region BuilderFunctions
// Builder methods for dependency injection
IResumeInfoRepository GetResumeInfoRepository(ISyncLocalStorageService localStorageInstance)
{
    return new ResumeInfoRepository(localStorageInstance);
}

IStateInfoRepository GetStateInfoRepository(ISyncLocalStorageService localStorageInstance)
{
    return new StateInfoRepository(localStorageInstance);
}

IResumeModelService BuildResumeModelService(ISyncLocalStorageService localStorageInstance)
{
    IResumeInfoRepository resumeInfoRepo = GetResumeInfoRepository(localStorageInstance);
    IStateInfoRepository stateInfoRepo = GetStateInfoRepository(localStorageInstance);
    return new ResumeModelService(resumeInfoRepo, stateInfoRepo);
}
#endregion
