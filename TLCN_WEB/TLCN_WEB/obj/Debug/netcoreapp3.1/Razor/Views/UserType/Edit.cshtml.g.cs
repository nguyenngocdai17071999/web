#pragma checksum "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\UserType\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7ceace0492d26d83e30d6d53a86c405b60e1394"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserType_Edit), @"mvc.1.0.view", @"/Views/UserType/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7ceace0492d26d83e30d6d53a86c405b60e1394", @"/Views/UserType/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5374ec5fb2261d732ab0fb66bcdf90b8e4f92c4", @"/Views/_ViewImports.cshtml")]
    public class Views_UserType_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TLCN_WEB.Models.UserType>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\UserType\Edit.cshtml"
  
    ViewBag.Title = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\UserType\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\UserType\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <h4>Student</h4>\r\n    <hr />\r\n    ");
#nullable restore
#line 17 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\UserType\Edit.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 19 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\UserType\Edit.cshtml"
   Write(Html.LabelFor(model => model.UserTypeID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\UserType\Edit.cshtml"
       Write(Html.EditorFor(model => model.UserTypeID, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 22 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\UserType\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.UserTypeID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 27 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\UserType\Edit.cshtml"
   Write(Html.LabelFor(model => model.UserTypeName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\UserType\Edit.cshtml"
       Write(Html.EditorFor(model => model.UserTypeName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 30 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\UserType\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.UserTypeName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>  \r\n\r\n</div>\r\n");
#nullable restore
#line 42 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\UserType\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 45 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\UserType\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TLCN_WEB.Models.UserType> Html { get; private set; }
    }
}
#pragma warning restore 1591
