#pragma checksum "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4252ce21a6b0760ef00fed0179aa7849181ad185"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Index), @"mvc.1.0.view", @"/Views/Menu/Index.cshtml")]
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
#line 1 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\_ViewImports.cshtml"
using TLCN_WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\_ViewImports.cshtml"
using TLCN_WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4252ce21a6b0760ef00fed0179aa7849181ad185", @"/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5374ec5fb2261d732ab0fb66bcdf90b8e4f92c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TLCN_WEB.Models.Menu>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Menu\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 10 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Menu\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 15 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Menu\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.MenuID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 18 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Menu\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Store_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 21 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Menu\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.MenuName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>          \r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 26 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Menu\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Menu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MenuID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Menu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Store_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Menu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MenuName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Menu\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.MenuID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 43 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Menu\Index.cshtml"
           Write(Html.ActionLink("Detail", "Detail", new { id = item.MenuID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 44 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Menu\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.MenuID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Menu\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TLCN_WEB.Models.Menu>> Html { get; private set; }
    }
}
#pragma warning restore 1591