using BethanysPieShopHRM.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components.Pages;

public partial class EmployeeOverview
{
    private List<Employee> Employees { get; set; } = default!;
    private Employee? _selectedEmployee;

    private string Title { get; set; } = "Employee Overview";

    protected async override Task OnInitializedAsync()
    {
        await Task.Delay(2000);
        Employees = MockDataService.Employees;
        await base.OnInitializedAsync();
    }

    private void ShowQuickViewPopup(Employee selectedEmployee)
    {
        _selectedEmployee = selectedEmployee;
    }
}
