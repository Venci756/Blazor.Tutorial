using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagment.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace EmployeeManagment.Web.Pages
{
    public class EmployeeDetailsBase : ComponentBase
    {
        public Employee Employee { get; set; } = new Employee();
        protected string Coordinates { get; set; }
        public string ButtonText { get; set; } = "Hide Footer";
        public string CssClass { get; set; } = null;
        
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        
        [Parameter]
        public string Id { get; set; }

        protected  override async Task OnInitializedAsync()
        {
            Id ??= "1";
           Employee = await EmployeeService.GetEmployee(int.Parse(Id));
        }

        protected void Mouse_Move(MouseEventArgs e)
        {
            Coordinates = $"X = {e.ClientX} Y = {e.ClientY}";
        }

        protected void Button_Click()
        {
            if (ButtonText == "Hide Footer")
            {
                ButtonText = "Show Footer";
                CssClass = "HideFooter";
            }
            else
            {
                CssClass = null;
                ButtonText = "Hide Footer";
            }
        }
    }
}