using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using QuestPDF.Helpers;
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
builder.Services.AddSingleton(BuildActiveStateService());

var host = builder.Build();

var localStorageService = host.Services.GetRequiredService<ISyncLocalStorageService>();
var modelService = host.Services.GetRequiredService<IResumeModelService>();
var activeStateService = host.Services.GetRequiredService<IActiveStateService>();

var resumeInfoRepository = GetResumeInfoRepository(localStorageService);
var stateInfoRepository = GetStateInfoRepository(localStorageService);
var generationService = GetGenerationService();

modelService.Initialize(resumeInfoRepository,
    stateInfoRepository,
    generationService);

activeStateService.Initialize(stateInfoRepository);

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

IResumeGenerationService GetGenerationService()
{
    var colors = new ColorModel()
    {
        Main = "#032f67",
        Secondary = "#E0FBFC",
        Tertiary = "#C2DFE3",
        Quaternary = "#9DB4C0",
        Background = "#FFFFFF",
        LightContrast = "#EEEEEE",
        MediumContrast = "#CCCCCC",
        DarkContrast = "#777777",
        BottomContrast = "#2C6E49",
        Subfocus = "#424242"
    };
    var fonts = new FontModel()
    {
        Main = Fonts.Lato,
        Header = Fonts.Lato,
        Social = Fonts.Lato
    };
    var theme = new DocumentTheme(colors, fonts);
    return new ResumeGenerationService(theme);
}

IResumeModelService BuildResumeModelService()
{
    return new ResumeModelService();
}

IActiveStateService BuildActiveStateService()
{
    return new ActiveStateService();
}
#endregion
