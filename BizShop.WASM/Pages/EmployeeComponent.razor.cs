using BizShop.Shared.Domain;
using BizShop.WASM.Models;

namespace BizShop.WASM.Pages
{
    public partial class EmployeeComponent
    {
        public List<Employee>? employees { get; set; } = default!;
        private Employee? _selectedEmployee;

        protected override void OnInitialized()
        {
            employees = MockDataService.Employees;
        }

        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}
