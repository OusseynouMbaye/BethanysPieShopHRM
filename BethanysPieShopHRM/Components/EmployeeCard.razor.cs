using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;

        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }

        private async Task ShowQuickViewClicked()
        {
            await EmployeeQuickViewClicked.InvokeAsync(Employee);
        }   

        protected override void OnInitialized()
        {
            if (string.IsNullOrEmpty(Employee.LastName))
            {
                throw new ArgumentNullException($"Last name of {Employee.FirstName} can't be empty" );
            }
        }
    }
}