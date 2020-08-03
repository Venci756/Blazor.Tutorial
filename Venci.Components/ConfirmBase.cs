using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Venci.Components
{
    public class ConfirmBase : ComponentBase
    {
        protected bool ShowConfirmation { get; set; }
        [Parameter]
        public string ConfirmationTitle { get; set; } = "Delete Confirmation";
        [Parameter]
        public string ConfirmationMessage { get; set; } = "Are you sure you want to delete?";
        [Parameter]
        public string ConfirmationButtonCancel { get; set; } = "Cancel";
        [Parameter]
        public string ConfirmationButtonConfirm { get; set; } = "Delete";
        public void Show()
        {
            ShowConfirmation = true;
            StateHasChanged();
        }
        
        [Parameter]
        public EventCallback<bool>ConfirmationChanged { get; set; }

        protected async Task OnConfirmationChange(bool value)
        {
            ShowConfirmation = false;
            await ConfirmationChanged.InvokeAsync(value);
        }
    }
}
