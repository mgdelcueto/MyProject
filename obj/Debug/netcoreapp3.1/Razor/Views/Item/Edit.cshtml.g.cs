#pragma checksum "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fc713f0661d4dc144da6add4b3b3e8101d75743"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Edit), @"mvc.1.0.view", @"/Views/Item/Edit.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Edit.cshtml"
using MyProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fc713f0661d4dc144da6add4b3b3e8101d75743", @"/Views/Item/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6fe18bfd33a53b99196e5f743c625163e36f2af", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Edit Product</h1>\r\n");
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Edit.cshtml"
 using (Html.BeginForm()) {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Edit.cshtml"
Write(Html.HiddenFor(p => p.ItemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 9 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Edit.cshtml"
       Write(Html.DisplayNameFor(p => p.ItemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Edit.cshtml"
       Write(Html.DisplayFor(p => p.ItemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 13 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Edit.cshtml"
       Write(Html.DisplayNameFor(p => p.ItemOrder));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Edit.cshtml"
       Write(Html.TextBoxFor(p => p.ItemOrder));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Edit.cshtml"
           Write(Html.LabelFor(p => p.ItemMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Edit.cshtml"
           Write(Html.DropDownListFor(p => p.ItemMonth,
               new SelectList(DataSource.GetPeriods(), "PerNum", "PerNam")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Edit.cshtml"
           Write(Html.LabelFor(p => p.ItemYearM));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Edit.cshtml"
           Write(Html.DropDownListFor(p => p.ItemYearM,
               new SelectList(DataSource.GetMonths(), "MoNum", "MoNam")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>    \r\n    <tr>\r\n        <td>");
#nullable restore
#line 31 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Edit.cshtml"
       Write(Html.DisplayNameFor(p => p.ItemDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 32 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Edit.cshtml"
       Write(Html.TextBoxFor(p => p.ItemDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 35 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Edit.cshtml"
       Write(Html.DisplayNameFor(p => p.ItemBudget));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 36 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Edit.cshtml"
       Write(Html.TextBoxFor(p => p.ItemBudget));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n       <td><input type=\"submit\" value=\"Update\" /></td>\r\n     </tr>\r\n    </table>\r\n");
#nullable restore
#line 42 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Edit.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
