using BethanysPieShopHRM.Contracts.Services;
using BethanysPieShopHRM.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components.Pages;

public partial class EmployeeOverview
{
    private List<Employee> Employees { get; set; } = default!;
    private Employee? _selectedEmployee;

    private string Title { get; set; } = "Employee Overview";

    [Inject]
    public IEmployeeDataService? EmployeeDataService { get; set; }
    protected async override Task OnInitializedAsync()
    {
        Employees = (await EmployeeDataService!.GetAllEmployees()).ToList();

    }

    private void ShowQuickViewPopup(Employee selectedEmployee)
    {
        _selectedEmployee = selectedEmployee;
    }
}
