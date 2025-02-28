﻿using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.Contracts.Services
{
    public interface IEmployeeDataService
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int employeeId);
    }
}
