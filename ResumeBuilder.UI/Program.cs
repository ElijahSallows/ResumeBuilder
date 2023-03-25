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

builder.Services.AddSingleton(BuildResumeModelService());

await builder.Build().RunAsync();


#region BuilderFunctions
// Builder methods for dependency injection
IResumeInfoRepository GetResumeInfoRepository()
{
    return new ResumeInfoRepository();
}

IResumeModelService BuildResumeModelService()
{
    IResumeInfoRepository repo = GetResumeInfoRepository();
    return new ResumeModelService(repo);
}
#endregion
