#pragma checksum "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07475cb8fc681cb3d8aeebd711cc03dfae02d6b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Edit), @"mvc.1.0.view", @"/Views/Account/Edit.cshtml")]
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
#line 1 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/_ViewImports.cshtml"
using MyProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
using MyProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07475cb8fc681cb3d8aeebd711cc03dfae02d6b1", @"/Views/Account/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6fe18bfd33a53b99196e5f743c625163e36f2af", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TAccount>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Edit Product</h1>\n");
#nullable restore
#line 5 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
 using (Html.BeginForm()) {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
Write(Html.HiddenFor(p => p.AccId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
Write(Html.HiddenFor(p => p.AccItem));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!--");
#nullable restore
#line 8 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
   Write(Html.HiddenFor(p => p.AccDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("-->    \n");
#nullable restore
#line 9 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
Write(Html.HiddenFor(p => p.AccOrder));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
Write(Html.HiddenFor(p => p.AccYear));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
Write(Html.HiddenFor(p => p.AccMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\n    <tr>\n        <td><label for=\"AccYear\">Year</label></td>\n        <td><label for=\"AccDesc\">Description</label></td>     \n    </tr>\n    <tr>\n        <td>");
#nullable restore
#line 18 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
       Write(Html.DisplayFor(p => p.AccYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 19 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
       Write(Html.TextBoxFor(p => p.AccDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
    </tr>
    <tr>
        <td><label for=""AccBud01"">Enero</label></td>
        <td><label for=""AccBud02"">Febrero</label></td>     
        <td><label for=""AccBud03"">Marzo</label></td>
        <td><label for=""AccBud04"">Abril</label></td>                
    </tr>
    <tr>
        <td>");
#nullable restore
#line 28 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
       Write(Html.TextBoxFor(p => p.AccBud01));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 29 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
       Write(Html.TextBoxFor(p => p.AccBud02));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 30 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
       Write(Html.TextBoxFor(p => p.AccBud03));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 31 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
       Write(Html.TextBoxFor(p => p.AccBud04));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

    </tr>    
    <tr>
        <td><label for=""AccBud01"">Mayo</label></td>
        <td><label for=""AccBud02"">Junio</label></td>     
        <td><label for=""AccBud03"">Julio</label></td>
        <td><label for=""AccBud04"">Agosto</label></td>    
    </tr>
    <tr>
        <td>");
#nullable restore
#line 41 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
       Write(Html.TextBoxFor(p => p.AccBud05));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 42 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
       Write(Html.TextBoxFor(p => p.AccBud06));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 43 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
       Write(Html.TextBoxFor(p => p.AccBud07));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 44 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
       Write(Html.TextBoxFor(p => p.AccBud08));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
    </tr>
    <tr>
        <td><label for=""AccBud01"">Septiembre</label></td>
        <td><label for=""AccBud02"">Octubre</label></td>     
        <td><label for=""AccBud03"">Noviembre</label></td>
        <td><label for=""AccBud04"">Diciembre</label></td>    
    </tr>    
    <tr>
        <td>");
#nullable restore
#line 53 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
       Write(Html.TextBoxFor(p => p.AccBud09));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 54 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
       Write(Html.TextBoxFor(p => p.AccBud10));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 55 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
       Write(Html.TextBoxFor(p => p.AccBud11));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 56 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
       Write(Html.TextBoxFor(p => p.AccBud12));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>    \n    <tr>\n       <td><input type=\"submit\" value=\"Update\" /></td>\n     </tr>\n    </table>\n");
#nullable restore
#line 62 "/home/manuel-gabriel/Azure_PRJ/MyProject/MyProject/Views/Account/Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TAccount> Html { get; private set; }
    }
}
#pragma warning restore 1591