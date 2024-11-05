using BethanysPieShopHRM.Services;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.Components.Pages
{
    public partial class EmployeeOverview
    {
        private List<Employee>Employees { get; set; } = default!;

        protected async override Task OnInitializedAsync()
        {
            Employees = MockDataService.Employees;
            await base.OnInitializedAsync();

        }

    }
}