#pragma checksum "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\BusinessType\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1967da3f33d98f1955ab4d0daf392d98e5434034"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BusinessType_Create), @"mvc.1.0.view", @"/Views/BusinessType/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1967da3f33d98f1955ab4d0daf392d98e5434034", @"/Views/BusinessType/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5374ec5fb2261d732ab0fb66bcdf90b8e4f92c4", @"/Views/_ViewImports.cshtml")]
    public class Views_BusinessType_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TLCN_WEB.Models.BusinessType>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\BusinessType\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Create</h2>\r\n");
#nullable restore
#line 9 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\BusinessType\Create.cshtml"
 using (Html.BeginForm("Create", "BusinessType", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Student</h4>\r\n        <hr />\r\n        ");
#nullable restore
#line 16 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\BusinessType\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\BusinessType\Create.cshtml"
       Write(Html.LabelFor(model => model.BusinessTypeID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 20 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\BusinessType\Create.cshtml"
           Write(Html.EditorFor(model => model.BusinessTypeID, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\BusinessType\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.BusinessTypeID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\BusinessType\Create.cshtml"
       Write(Html.LabelFor(model => model.BusinessTypeName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 28 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\BusinessType\Create.cshtml"
           Write(Html.EditorFor(model => model.BusinessTypeName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 29 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\BusinessType\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.BusinessTypeName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 39 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\BusinessType\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 42 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\BusinessType\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TLCN_WEB.Models.BusinessType> Html { get; private set; }
    }
}
#pragma warning restore 1591