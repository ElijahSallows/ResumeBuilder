﻿using Microsoft.AspNetCore.Components;

namespace ResumeBuilder.UI.Pages.Components
{
    public class ResumeListComponent<T> : ComponentBase
    {
        [Parameter]
        public required List<T> List { get; set; }

        [Parameter]
        public required EventCallback<T> OnDeleted { get; set; }

        private protected async Task Delete(T obj)
        {
            await OnDeleted.InvokeAsync(obj);
        }
    }
}
