using Microsoft.AspNetCore.Components;

namespace BizShop.WASM.Components
{
    public partial class ProfilePictureComponent
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
