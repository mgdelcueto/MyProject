#pragma checksum "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Periods\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d4ac0f6705bf6c32c05be6ca6e123e2a7748603"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Periods_Index), @"mvc.1.0.view", @"/Views/Periods/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\_ViewImports.cshtml"
using MyProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\_ViewImports.cshtml"
using MyProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d4ac0f6705bf6c32c05be6ca6e123e2a7748603", @"/Views/Periods/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6fe18bfd33a53b99196e5f743c625163e36f2af", @"/Views/_ViewImports.cshtml")]
    public class Views_Periods_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyProject.Models.Periods>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Periods\Index.cshtml"
  
    ViewData["Title"] = "Periods Index Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Periods\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<table border=\"1\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Number</th>\r\n        <th>Name</th>        \r\n        <th>Delete</th>\r\n        <th>Edit</th>\r\n        <th>Detail</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Periods\Index.cshtml"
     foreach (var p in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Periods\Index.cshtml"
           Write(p.PerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Periods\Index.cshtml"
           Write(p.PerNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Periods\Index.cshtml"
           Write(p.PerNam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Periods\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = p.PerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Periods\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = p.PerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Periods\Index.cshtml"
           Write(Html.ActionLink("Detail", "ShowDetail", new { id = p.PerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Periods\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 27 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Periods\Index.cshtml"
Write(Html.ActionLink("Add a New Item", "Create"));

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyProject.Models.Periods>> Html { get; private set; }
    }
}
#pragma warning restore 1591
