// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OdysejaAdmin.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using OdysejaAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using OdysejaAdmin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using OdysejaAdmin.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using OdysejaAdmin.Pages.Login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using OdysejaAdmin.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using OdysejaAdmin.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using OdysejaAdmin.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\projects\OdysejaAdmin\OdysejaAdmin\Components\PerformanceComponent.razor"
using OdysejaAdmin.Data;

#line default
#line hidden
#nullable disable
    public partial class PerformanceComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "D:\projects\OdysejaAdmin\OdysejaAdmin\Components\PerformanceComponent.razor"
 
    private bool editMode;

    [Parameter]
    public Performance Performance { get; set; }
    
    [Parameter]
    public EventCallback OnDelete { get; set; }

    private void Edit() => editMode = true;

    private void Save()
    {
        editMode = false;
        RestService.Put("/timeTable", Performance);
    }

    private async void Del()
    {
        await RestService.Delete("/timeTable", Performance.id.ToString());
        OnDelete.InvokeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RestService RestService { get; set; }
    }
}
#pragma warning restore 1591
