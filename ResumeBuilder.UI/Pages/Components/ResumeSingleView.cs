using Microsoft.AspNetCore.Components;

namespace ResumeBuilder.UI.Pages.Components
{
    public class ResumeSingleView<T> : ComponentBase
    {
        [Parameter]
        public required T Info { get; set; }
    }
}
