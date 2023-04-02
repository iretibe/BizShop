using BizShop.Shared.Domain;
using BizShop.WASM.Services;
using Microsoft.AspNetCore.Components;

namespace BizShop.WASM.Pages
{
    public partial class EmployeeComponent
    {
        [Inject]
        public IEmployeeDataService employeeDataService { get; set; }

        public List<Employee> employees { get; set; } = default!;

        private Employee _selectedEmployee;

        private string Title = "Employee Overview";

        protected override async Task OnInitializedAsync()
        {
            employees = (await employeeDataService.GetAllEmployees()).ToList();
        }

        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}
