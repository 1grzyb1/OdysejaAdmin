#pragma checksum "D:\projects\OdysejaAdmin\OdysejaAdmin\Pages\Login\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5a1a3419332bb8de9d7d3b7c4e472795a304f5e"
// <auto-generated/>
#pragma warning disable 1591
namespace OdysejaAdmin.Pages.Login
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
#line 1 "D:\projects\OdysejaAdmin\OdysejaAdmin\Pages\Login\Login.razor"
using OdysejaAdmin.Data;

#line default
#line hidden
#nullable disable
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "hero is-primary is-fullheight");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "hero-body");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "columns is-centered");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "column is-5-tablet is-4-desktop is-3-widescreen");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "box");
#nullable restore
#line 11 "D:\projects\OdysejaAdmin\OdysejaAdmin\Pages\Login\Login.razor"
                         if (!Success)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "notification is-danger");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "delete");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\projects\OdysejaAdmin\OdysejaAdmin\Pages\Login\Login.razor"
                                                  close

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                                Sorry bad credentials\r\n                            ");
            __builder.CloseElement();
#nullable restore
#line 18 "D:\projects\OdysejaAdmin\OdysejaAdmin\Pages\Login\Login.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(18);
            __builder.AddAttribute(19, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "D:\projects\OdysejaAdmin\OdysejaAdmin\Pages\Login\Login.razor"
                                          userCredentials

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "field");
                __builder2.AddMarkupContent(23, "<label for class=\"label\">Login</label>\r\n                                ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "control has-icons-left");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "type", "login");
                __builder2.AddAttribute(28, "placeholder", "Login");
                __builder2.AddAttribute(29, "class", "input");
                __builder2.AddAttribute(30, "required");
                __builder2.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "D:\projects\OdysejaAdmin\OdysejaAdmin\Pages\Login\Login.razor"
                                                                                                          userCredentials.username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userCredentials.username = __value, userCredentials.username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                                    ");
                __builder2.AddMarkupContent(34, "<span class=\"icon is-small is-left\"><i class=\"fa fa-user\"></i></span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                            ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "field");
                __builder2.AddMarkupContent(38, "<label for class=\"label\">Password</label>\r\n                                ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "control has-icons-left");
                __builder2.OpenElement(41, "input");
                __builder2.AddAttribute(42, "type", "password");
                __builder2.AddAttribute(43, "placeholder", "*******");
                __builder2.AddAttribute(44, "class", "input");
                __builder2.AddAttribute(45, "required");
                __builder2.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "D:\projects\OdysejaAdmin\OdysejaAdmin\Pages\Login\Login.razor"
                                                                                                               userCredentials.password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userCredentials.password = __value, userCredentials.password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                                    ");
                __builder2.AddMarkupContent(49, "<span class=\"icon is-small is-left\"><i class=\"fa fa-lock\"></i></span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                            ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "field");
                __builder2.OpenElement(53, "button");
                __builder2.AddAttribute(54, "class", "button is-success");
                __builder2.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\projects\OdysejaAdmin\OdysejaAdmin\Pages\Login\Login.razor"
                                                  login

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(56, "\r\n                                    Login\r\n                                ");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "D:\projects\OdysejaAdmin\OdysejaAdmin\Pages\Login\Login.razor"
 
    private bool Success = true;
    private UserCredentials userCredentials { get; set; } = new UserCredentials("", "");

    private async void login()
    {
        Success = await AuthenticationService.Authenticate(userCredentials.username, userCredentials.password);
        UserStore.SetAuth(Success);
    }

    private void close() => Success = true;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserStore UserStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationService AuthenticationService { get; set; }
    }
}
#pragma warning restore 1591
