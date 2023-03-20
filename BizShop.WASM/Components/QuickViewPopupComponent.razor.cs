using BizShop.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BizShop.WASM.Components
{
    public partial class QuickViewPopupComponent
    {
        private Employee? _employee;

        [Parameter]
        public Employee? Employee { get; set; }

        protected override void OnParametersSet()
        {
            _employee = Employee;
        }

        public void Close()
        {
            _employee = null;
        }
    }
}
