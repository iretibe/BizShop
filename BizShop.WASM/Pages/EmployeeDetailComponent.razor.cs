using BizShop.Shared.Domain;
using BizShop.WASM.Models;
using Microsoft.AspNetCore.Components;

namespace BizShop.WASM.Pages
{
    public partial class EmployeeDetailComponent
    {
        [Parameter]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();

        protected override Task OnInitializedAsync()
        {
            Employee = MockDataService.Employees.FirstOrDefault(e => e.EmployeeId == int.Parse(EmployeeId));

            return base.OnInitializedAsync();
        }
    }
}
