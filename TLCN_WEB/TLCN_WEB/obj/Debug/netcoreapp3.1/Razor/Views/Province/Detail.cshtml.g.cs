#pragma checksum "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Province\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13135fbe672b162c9f507436388fd1fe5dec5eea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Province_Detail), @"mvc.1.0.view", @"/Views/Province/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13135fbe672b162c9f507436388fd1fe5dec5eea", @"/Views/Province/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5374ec5fb2261d732ab0fb66bcdf90b8e4f92c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Province_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TLCN_WEB.Models.Province>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Province\Detail.cshtml"
  
    ViewBag.Title = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Detail</h2>\r\n\r\n<div>\r\n    <h4>Student</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 15 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Province\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.ProvinceID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 19 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Province\Detail.cshtml"
       Write(Html.DisplayFor(model => model.ProvinceID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 22 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Province\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.ProvinceName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 26 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Province\Detail.cshtml"
       Write(Html.DisplayFor(model => model.ProvinceName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        \r\n\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
#nullable restore
#line 34 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Province\Detail.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.ProvinceID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 35 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Province\Detail.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TLCN_WEB.Models.Province> Html { get; private set; }
    }
}
#pragma warning restore 1591
