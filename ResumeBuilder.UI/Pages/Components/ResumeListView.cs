using Microsoft.AspNetCore.Components;

namespace ResumeBuilder.UI.Pages.Components
{
    public class ResumeListView<T> : ComponentBase where T : new()
    {
        [Parameter]
        public required List<T> List { get; set; }

        [Parameter]
        public required EventCallback<T> OnUpdated { get; set; }

        private protected async Task Delete(T obj)
        {
            List.Remove(obj);
            await OnUpdated.InvokeAsync();
        }

        private protected async Task OnAddClicked()
        {
            List.Add(new T());
            await OnUpdated.InvokeAsync();
        }
    }
}
