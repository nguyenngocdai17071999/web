#pragma checksum "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93f30e789ed3b650f327931b78ba5b139a34f1fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dish_Edit), @"mvc.1.0.view", @"/Views/Dish/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93f30e789ed3b650f327931b78ba5b139a34f1fd", @"/Views/Dish/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5374ec5fb2261d732ab0fb66bcdf90b8e4f92c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Dish_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TLCN_WEB.Models.Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
  
    ViewBag.Title = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <h4>Student</h4>\r\n    <hr />\r\n    ");
#nullable restore
#line 17 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 19 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
   Write(Html.LabelFor(model => model.Dish_ID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
       Write(Html.EditorFor(model => model.Dish_ID, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 22 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Dish_ID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 27 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
   Write(Html.LabelFor(model => model.DishName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
       Write(Html.EditorFor(model => model.DishName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 30 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.DishName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 34 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
   Write(Html.LabelFor(model => model.DishPrice, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
       Write(Html.EditorFor(model => model.DishPrice, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 37 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.DishPrice, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 42 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
   Write(Html.LabelFor(model => model.DishPicture, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
       Write(Html.EditorFor(model => model.DishPicture, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 45 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.DishPicture, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>        <div class=\"form-group\">\r\n        ");
#nullable restore
#line 48 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
   Write(Html.LabelFor(model => model.DishType_ID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
       Write(Html.EditorFor(model => model.DishType_ID, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 51 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.DishType_ID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 56 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
   Write(Html.LabelFor(model => model.Menu_ID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 58 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
       Write(Html.EditorFor(model => model.Menu_ID, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 59 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Menu_ID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 69 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 72 "C:\Users\Dai\Desktop\TLCN\TLCN_WEB\TLCN_WEB\Views\Dish\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TLCN_WEB.Models.Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
