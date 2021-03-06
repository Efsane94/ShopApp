#pragma checksum "C:\Users\Code\Desktop\Shop\ShoppApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16b8f5b5654ac350f59d48ab980081f6c730edc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategoryList), @"mvc.1.0.view", @"/Views/Admin/CategoryList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/CategoryList.cshtml", typeof(AspNetCore.Views_Admin_CategoryList))]
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
#line 1 "C:\Users\Code\Desktop\Shop\ShoppApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Entities;

#line default
#line hidden
#line 2 "C:\Users\Code\Desktop\Shop\ShoppApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
#line 3 "C:\Users\Code\Desktop\Shop\ShoppApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16b8f5b5654ac350f59d48ab980081f6c730edc3", @"/Views/Admin/CategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c568fe72079a0164016bc682254953f086523ecc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deletecategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Code\Desktop\Shop\ShoppApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
  
    ViewData["Title"] = "CategoryList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(121, 35, true);
            WriteLiteral("\r\n<h1>CategoryList</h1>\r\n\r\n<hr />\r\n");
            EndContext();
#line 10 "C:\Users\Code\Desktop\Shop\ShoppApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
 if (Model.Categories.Count() > 0)
{

#line default
#line hidden
            BeginContext(195, 238, true);
            WriteLiteral("    <table class=\"table table-bordered\">\r\n        <thead>\r\n            <tr>\r\n                <td style=\"width:30px;\">Id</td>\r\n                <td>Name</td>\r\n                <td></td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 21 "C:\Users\Code\Desktop\Shop\ShoppApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
             foreach (var item in Model.Categories)
            {

#line default
#line hidden
            BeginContext(501, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(548, 7, false);
#line 24 "C:\Users\Code\Desktop\Shop\ShoppApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(555, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(587, 9, false);
#line 25 "C:\Users\Code\Desktop\Shop\ShoppApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(596, 59, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 655, "\"", 690, 2);
            WriteAttributeValue("", 662, "/admin/EditCategory/", 662, 20, true);
#line 27 "C:\Users\Code\Desktop\Shop\ShoppApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 682, item.Id, 682, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(691, 71, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Edit</a>\r\n                        ");
            EndContext();
            BeginContext(762, 293, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16b8f5b5654ac350f59d48ab980081f6c730edc36969", async() => {
                BeginContext(837, 68, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"categoryId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 905, "\"", 921, 1);
#line 29 "C:\Users\Code\Desktop\Shop\ShoppApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 913, item.Id, 913, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(922, 126, true);
                WriteLiteral(" />\r\n                            <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1055, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "C:\Users\Code\Desktop\Shop\ShoppApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
            }

#line default
#line hidden
            BeginContext(1122, 34, true);
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 38 "C:\Users\Code\Desktop\Shop\ShoppApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1168, 83, true);
            WriteLiteral("    <div class=\"alert alert-warning\">\r\n        <h4>No Categories</h4>\r\n    </div>\r\n");
            EndContext();
#line 44 "C:\Users\Code\Desktop\Shop\ShoppApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
