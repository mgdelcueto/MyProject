#pragma checksum "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Account\RepportL.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be43ca437dc4cc10e1b6ccccf0efc5fceeb89831"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_RepportL), @"mvc.1.0.view", @"/Views/Account/RepportL.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Account\RepportL.cshtml"
using MyProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be43ca437dc4cc10e1b6ccccf0efc5fceeb89831", @"/Views/Account/RepportL.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6fe18bfd33a53b99196e5f743c625163e36f2af", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_RepportL : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Repport>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Account\RepportL.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<table border=""1"">
    <tr>
        <th>Year</th>
        <th>Enero</th>
        <th>Febrero</th>
        <th>Marzo</th>
        <th>Abril</th>
        <th>Mayo</th>
        <th>Junio</th>
        <th>Julio</th>
        <th>Agosto</th>
        <th>Septiembre</th>
        <th>Octubre</th>
        <th>Noviembre</th>
        <th>Diciembre</th>
        <th>TOTAL</th>        
    </tr>
        <tr>
            <td>");
#nullable restore
#line 23 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Account\RepportL.cshtml"
           Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Account\RepportL.cshtml"
           Write(Model.Enero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Account\RepportL.cshtml"
           Write(Model.Febrero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Account\RepportL.cshtml"
           Write(Model.Marzo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Account\RepportL.cshtml"
           Write(Model.Abril);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Account\RepportL.cshtml"
           Write(Model.Mayo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Account\RepportL.cshtml"
           Write(Model.Junio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Account\RepportL.cshtml"
           Write(Model.Julio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Account\RepportL.cshtml"
           Write(Model.Agosto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Account\RepportL.cshtml"
           Write(Model.Septiembre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Account\RepportL.cshtml"
           Write(Model.Octubre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Account\RepportL.cshtml"
           Write(Model.Noviembre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Account\RepportL.cshtml"
           Write(Model.Diciembre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Account\RepportL.cshtml"
           Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n           \r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Repport> Html { get; private set; }
    }
}
#pragma warning restore 1591
