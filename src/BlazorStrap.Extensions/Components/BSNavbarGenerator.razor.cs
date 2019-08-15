using Microsoft.AspNetCore.Components;
using System;

namespace BlazorStrap.Extensions
{
    public partial class CodeBSNavbarGenerator : ComponentBase
    {
        [Parameter] internal BSNavbarBuilder Items { get; set; } = new BSNavbarBuilder();

      
    }
}
