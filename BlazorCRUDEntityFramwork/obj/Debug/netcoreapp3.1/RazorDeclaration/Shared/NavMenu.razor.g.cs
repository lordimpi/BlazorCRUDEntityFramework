#pragma checksum "C:\Users\snt-2\Desktop\S2\BlazorCRUDEntityFramwork\BlazorCRUDEntityFramwork\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c32ab7f6a828b4302833accf08f4e0669ff4a71"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCRUDEntityFramwork.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\snt-2\Desktop\S2\BlazorCRUDEntityFramwork\BlazorCRUDEntityFramwork\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\snt-2\Desktop\S2\BlazorCRUDEntityFramwork\BlazorCRUDEntityFramwork\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\snt-2\Desktop\S2\BlazorCRUDEntityFramwork\BlazorCRUDEntityFramwork\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\snt-2\Desktop\S2\BlazorCRUDEntityFramwork\BlazorCRUDEntityFramwork\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\snt-2\Desktop\S2\BlazorCRUDEntityFramwork\BlazorCRUDEntityFramwork\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\snt-2\Desktop\S2\BlazorCRUDEntityFramwork\BlazorCRUDEntityFramwork\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\snt-2\Desktop\S2\BlazorCRUDEntityFramwork\BlazorCRUDEntityFramwork\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\snt-2\Desktop\S2\BlazorCRUDEntityFramwork\BlazorCRUDEntityFramwork\_Imports.razor"
using BlazorCRUDEntityFramwork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\snt-2\Desktop\S2\BlazorCRUDEntityFramwork\BlazorCRUDEntityFramwork\_Imports.razor"
using BlazorCRUDEntityFramwork.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\snt-2\Desktop\S2\BlazorCRUDEntityFramwork\BlazorCRUDEntityFramwork\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\snt-2\Desktop\S2\BlazorCRUDEntityFramwork\BlazorCRUDEntityFramwork\_Imports.razor"
using Data;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\snt-2\Desktop\S2\BlazorCRUDEntityFramwork\BlazorCRUDEntityFramwork\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
