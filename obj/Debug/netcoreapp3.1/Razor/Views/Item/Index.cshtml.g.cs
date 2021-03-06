#pragma checksum "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6e637a5ba2a706b570bc3a781bac0e82369599e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Index), @"mvc.1.0.view", @"/Views/Item/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6e637a5ba2a706b570bc3a781bac0e82369599e", @"/Views/Item/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6fe18bfd33a53b99196e5f743c625163e36f2af", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyProject.Models.ItemView>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Index.cshtml"
  
    ViewData["Title"] = "Item Index Page";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>
        .head-text {color: #DDDDDD;
        background-color: #000000;
        text-align: left;
        }
    </style>
    <style>
        .col-text {color: #888888;
        background-color: #000000;
        text-align: right;
        }
    </style>
    <style>
        .norm-text {color: #CCCCCC;
        background-color: #000000;
        text-align: right;
        }
    </style>
    <style>
        .botcol-text {color: #2222EE;
        background-color: #222222;
        text-align: right;
        }
    </style>    
    <style>
        .red-number {color: #DD0000;        
        background-color: #000000;
        text-align: right;
        }

    </style>    <style>
       .blue-number {color: #999999;        
        background-color: #000000;
        text-align: right;
        }
    </style>
    <style>
        .botred-number {color: #DD0000;        
        background-color: #222222;
        text-align: right;
        }

    </style>
    <style>
");
                WriteLiteral("       .botblue-number {color: #999999;        \r\n        background-color: #222222;\r\n        text-align: right;\r\n        }\r\n    </style>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 80 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<table border=""1"">
    <tr>
        <!--<th>ID</th>-->
        <!--<th>Order List</th>-->
        <th class=""head-text"">Description</th>        
        <th class=""head-text"">Periodicity</th>        
        <th class=""head-text"">Yearly Month</th>
        <th class=""head-text"">Budget</th>
        <th class=""head-text"">Delete</th>
        <th class=""head-text"">Edit</th>
        <!--<th>Detail</th>-->
    </tr>
");
#nullable restore
#line 93 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Index.cshtml"
     foreach (var p in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <!--<td>");
#nullable restore
#line 95 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Index.cshtml"
               Write(p.ItemId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>-->\r\n            <!--<td>");
#nullable restore
#line 96 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Index.cshtml"
               Write(p.ItemOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>-->\r\n            <td class =\"col-text\">");
#nullable restore
#line 97 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Index.cshtml"
                             Write(p.ItemDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class =\"norm-text\">");
#nullable restore
#line 98 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Index.cshtml"
                              Write(p.ItemMoNam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class =\"norm-text\">");
#nullable restore
#line 99 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Index.cshtml"
                              Write(p.ItemYMNam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td");
            BeginWriteAttribute("class", " class=", 2564, "", 2593, 1);
#nullable restore
#line 100 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Index.cshtml"
WriteAttributeValue("", 2571, mycolor(p.ItemBudget), 2571, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 100 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Index.cshtml"
                                        Write(myformat(@p.ItemBudget));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <!--<td>");
#nullable restore
#line 101 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = p.ItemId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>-->\r\n            <td class=\"col-text\">");
#nullable restore
#line 102 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Index.cshtml"
                            Write(Html.ActionLink("Delete", "Delete", new { id = p.ItemId }, new { onclick="return confirm('Are you sure?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-text\">");
#nullable restore
#line 103 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Index.cshtml"
                            Write(Html.ActionLink("Edit", "Edit", new { id = p.ItemId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <!--<td>");
#nullable restore
#line 104 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Index.cshtml"
               Write(Html.ActionLink("Detail", "ShowDetail", new { id = p.ItemId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>-->\r\n        </tr>\r\n");
#nullable restore
#line 106 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 108 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Index.cshtml"
Write(Html.ActionLink("Add a New Item", "Create"));

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\Users\mgdel\VSProjects\MyProject\MyProject\Views\Item\Index.cshtml"
            
    string myformat(double? value){
    string ret =string.Format("{0:C2}", value);
    //string rets = value.ToString("N", CultureInfo.InvariantCulture);
    return ret;
}
    string mycolor(double? value){
    string retcol="red-number";
    if (value >=0 ){
        retcol="blue-number";}
    return retcol;
    }
    string colcolor(int item){
    string retcol="col-text";
    if (item==0)
    {
        retcol="botcol-text";
    }
    return retcol;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyProject.Models.ItemView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
