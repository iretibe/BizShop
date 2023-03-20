using BizShop.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BizShop.WASM.Components
{
    public partial class EmployeeCardComponent
    {
        [Parameter]
        public Employee employeeCard { get; set; } = default!;

        [Parameter]
        public EventCallback<Employee> employeeQuickViewClicked { get; set; } 
    }
}
