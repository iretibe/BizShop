﻿using BizShop.WASM.Components.Widgets;

namespace BizShop.WASM.Pages
{
    public partial class Index
    {
        public List<Type> Widgets { get; set; } = new List<Type>()
        {
            typeof(EmployeeCountWidget), typeof(InboxWidget)
        };
    }
}
