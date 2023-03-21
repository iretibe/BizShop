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

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        protected override void OnInitialized()
        {
            if (string.IsNullOrEmpty(employeeCard.LastName))
            {
                throw new Exception("Last Name can't be empty.");
            }
        }

        public void NavigateToDetails(Employee selectedEmployee)
        {
            NavigationManager.NavigateTo($"/employeedetailcomponent/{selectedEmployee.EmployeeId}");
        }
    }
}
