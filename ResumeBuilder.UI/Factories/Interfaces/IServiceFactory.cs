using Blazored.LocalStorage;
using ResumeBuilder.UI.Services.Interfaces;

namespace ResumeBuilder.UI.Factories.Interfaces
{
    public interface IServiceFactory
    {
        IResumeModelService ResumeModelService { get; }
        ISyncLocalStorageService LocalStorageService { get; set; }
        void Build();
    }
}
