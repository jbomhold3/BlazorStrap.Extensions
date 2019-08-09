using Microsoft.AspNetCore.Components;
using System;

namespace BlazorStrap.Extensions.Components
{
    public partial class CodeBSNavbarGenerator : ComponentBase
    {
        [Parameter] internal BSNavbarBuilder Items { get; set; } = new BSNavbarBuilder();

      
    }
}
