#pragma checksum "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\SpecialTag\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ab25fac45b58dcc1125b04641c99c2d6309492d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SpecialTag_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SpecialTag/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/SpecialTag/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_SpecialTag_Index))]
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
#line 1 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\_ViewImports.cshtml"
using Online_Shop;

#line default
#line hidden
#line 1 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\SpecialTag\Index.cshtml"
using Online_Shop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ab25fac45b58dcc1125b04641c99c2d6309492d", @"/Areas/Admin/Views/SpecialTag/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06c341d60b42f081b259587877284be7fea141da", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SpecialTag_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<specialTag>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TagPageButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\SpecialTag\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(101, 168, true);
            WriteLiteral("<br /><br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Special Tag List</h2>\r\n\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n       ");
            EndContext();
            BeginContext(269, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ab25fac45b58dcc1125b04641c99c2d6309492d4822", async() => {
                BeginContext(313, 55, true);
                WriteLiteral("<i class=\"fa-solid fa-plus\"></i> &nbsp; New Special Tag");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(372, 157, true);
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>\r\n<br />\r\n<div>\r\n    <table class=\"table table-striped border\" >\r\n        <tr class=\"table-info\">\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(530, 52, false);
#line 23 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\SpecialTag\Index.cshtml"
           Write(Html.DisplayNameFor(expression:c=>c.specialTageName));

#line default
#line hidden
            EndContext();
            BeginContext(582, 84, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n            <th></th>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 29 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\SpecialTag\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(715, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(762, 20, false);
#line 32 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\SpecialTag\Index.cshtml"
                   Write(item.specialTageName);

#line default
#line hidden
            EndContext();
            BeginContext(782, 68, true);
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n                                 ");
            EndContext();
            BeginContext(850, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6ab25fac45b58dcc1125b04641c99c2d6309492d7700", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 35 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\SpecialTag\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(906, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 38 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\SpecialTag\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(971, 24, true);
            WriteLiteral("\r\n    </table>\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1012, 218, true);
                WriteLiteral("\r\n            <script src=\"//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/alertify.min.js\"></script>\r\n            <script type=\"text/javascript\">\r\n                    $(function(){\r\n                        var save = \'");
                EndContext();
                BeginContext(1231, 16, false);
#line 47 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\SpecialTag\Index.cshtml"
                               Write(TempData["Save"]);

#line default
#line hidden
                EndContext();
                BeginContext(1247, 147, true);
                WriteLiteral("\'\r\n                    if(save!=\'\') {\r\n                        alertify.success(save);\r\n                    }\r\n                        var edit = \'");
                EndContext();
                BeginContext(1395, 18, false);
#line 51 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\SpecialTag\Index.cshtml"
                               Write(TempData["Update"]);

#line default
#line hidden
                EndContext();
                BeginContext(1413, 146, true);
                WriteLiteral("\'\r\n                    if(edit!=\'\') {\r\n                        alertify.success(edit);\r\n                    }\r\n                        var del = \'");
                EndContext();
                BeginContext(1560, 18, false);
#line 55 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\SpecialTag\Index.cshtml"
                              Write(TempData["Delete"]);

#line default
#line hidden
                EndContext();
                BeginContext(1578, 159, true);
                WriteLiteral("\'\r\n                    if (del!=\'\') {\r\n                        alertify.error(del);\r\n                    }\r\n                })\r\n\r\n\r\n\r\n\r\n            </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<specialTag>> Html { get; private set; }
    }
}
#pragma warning restore 1591
