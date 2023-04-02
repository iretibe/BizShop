using BizShop.Shared.Domain;
using BizShop.WASM.Models;
using BizShop.WASM.Services;
using Microsoft.AspNetCore.Components;

namespace BizShop.WASM.Pages
{
    public partial class EmployeeDetailComponent
    {
        [Inject]
        public IEmployeeDataService employeeDataService { get; set; }

        [Parameter]
        public string EmployeeId { get; set; }

        public Employee Employee { get; set; } = new Employee();

        protected override async Task OnInitializedAsync()
        {
            Employee = await employeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
        }
    }
}
