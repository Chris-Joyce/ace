#pragma checksum "C:\Users\fifz\Desktop\ace-ets\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc0f7af281495fbcf1ea6ce4e4913ec049cc96e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\fifz\Desktop\ace-ets\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\_ViewImports.cshtml"
using EmployeeTrackingSystem;

#line default
#line hidden
#line 2 "C:\Users\fifz\Desktop\ace-ets\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\_ViewImports.cshtml"
using EmployeeTrackingSystem.Models;

#line default
#line hidden
#line 1 "C:\Users\fifz\Desktop\ace-ets\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Admin\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc0f7af281495fbcf1ea6ce4e4913ec049cc96e4", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e0f292b5e911f4cbf5465c386adf7ec5dcc2066", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Microsoft.AspNetCore.Identity.IdentityUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\fifz\Desktop\ace-ets\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
            BeginContext(185, 96, true);
            WriteLiteral("\n<h2>Index</h2>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(282, 41, false);
#line 14 "C:\Users\fifz\Desktop\ace-ets\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(323, 75, true);
            WriteLiteral("\n            </th>\n            <th>\n                Role\n            </th>\n");
            EndContext();
            BeginContext(531, 39, true);
            WriteLiteral("        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 28 "C:\Users\fifz\Desktop\ace-ets\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Admin\Index.cshtml"
         foreach (var user in Model)
        {

#line default
#line hidden
            BeginContext(617, 58, true);
            WriteLiteral("            <tr>\n                <th>\n                    ");
            EndContext();
            BeginContext(676, 36, false);
#line 32 "C:\Users\fifz\Desktop\ace-ets\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Admin\Index.cshtml"
               Write(Html.DisplayFor(model => user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(712, 23, true);
            WriteLiteral("\n                </th>\n");
            EndContext();
#line 34 "C:\Users\fifz\Desktop\ace-ets\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Admin\Index.cshtml"
                 if (await UserManager.IsInRoleAsync(user, "Admin"))
                {

#line default
#line hidden
            BeginContext(822, 35, true);
            WriteLiteral("                    <th>Admin</th>\n");
            EndContext();
#line 37 "C:\Users\fifz\Desktop\ace-ets\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Admin\Index.cshtml"
                }
                else if (await UserManager.IsInRoleAsync(user, "Manager"))
                {

#line default
#line hidden
            BeginContext(968, 37, true);
            WriteLiteral("                    <th>Manager</th>\n");
            EndContext();
#line 41 "C:\Users\fifz\Desktop\ace-ets\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Admin\Index.cshtml"
                }
                else if (await UserManager.IsInRoleAsync(user, "User"))
                {

#line default
#line hidden
            BeginContext(1113, 34, true);
            WriteLiteral("                    <th>User</th>\n");
            EndContext();
#line 45 "C:\Users\fifz\Desktop\ace-ets\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Admin\Index.cshtml"
                }
                

#line default
#line hidden
            BeginContext(1775, 18, true);
            WriteLiteral("            </tr>\n");
            EndContext();
#line 61 "C:\Users\fifz\Desktop\ace-ets\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Admin\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1803, 23, true);
            WriteLiteral("    </tbody>\n</table>\n\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Microsoft.AspNetCore.Identity.IdentityUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591