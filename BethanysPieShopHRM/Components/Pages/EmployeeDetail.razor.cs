using BethanysPieShopHRM.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();

        protected override void OnInitialized()
        {
            Task.Delay(2000);
          
                Employee = MockDataService.Employees.Single(e => e.EmployeeId == EmployeeId);
            
        }
    }
}