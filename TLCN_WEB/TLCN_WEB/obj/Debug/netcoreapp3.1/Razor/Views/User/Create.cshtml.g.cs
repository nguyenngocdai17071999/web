#pragma checksum "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28148d084f3e35f5268b262f5b12d1780f775538"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Create), @"mvc.1.0.view", @"/Views/User/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28148d084f3e35f5268b262f5b12d1780f775538", @"/Views/User/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5374ec5fb2261d732ab0fb66bcdf90b8e4f92c4", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TLCN_WEB.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Create</h2>\r\n");
#nullable restore
#line 9 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
 using (Html.BeginForm("Create", "User", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <h4>Student</h4>\r\n    <hr />\r\n    ");
#nullable restore
#line 16 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 18 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
   Write(Html.LabelFor(model => model.UserID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.EditorFor(model => model.UserID, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 21 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.UserID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 26 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
   Write(Html.LabelFor(model => model.UserName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.EditorFor(model => model.UserName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 29 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 33 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
   Write(Html.LabelFor(model => model.Phone, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.EditorFor(model => model.Phone, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 36 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Phone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 41 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
   Write(Html.LabelFor(model => model.Address, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.EditorFor(model => model.Address, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 44 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Address, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 48 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
   Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 51 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 56 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
   Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 58 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 59 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 65 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
   Write(Html.LabelFor(model => model.Picture, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 67 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.EditorFor(model => model.Picture, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 68 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Picture, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 72 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
   Write(Html.LabelFor(model => model.Sex, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.EditorFor(model => model.Sex, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 75 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Sex, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 80 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
   Write(Html.LabelFor(model => model.Birthday, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 82 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.EditorFor(model => model.Birthday, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 83 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Birthday, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 87 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
   Write(Html.LabelFor(model => model.UserTypeID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.EditorFor(model => model.UserTypeID, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 90 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.UserTypeID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 101 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 104 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\User\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TLCN_WEB.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
