#pragma checksum "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c771d669de7aeaa93a2a236544ec153b3fb1aa1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_Index))]
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
#line 1 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
using Online_Shop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c771d669de7aeaa93a2a236544ec153b3fb1aa1b", @"/Areas/Admin/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06c341d60b42f081b259587877284be7fea141da", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(99, 244, true);
            WriteLiteral("<link rel=\"stylesheet\" type=\"text/css\" href=\"/DataTables/datatables.css\">\r\n\r\n<br />\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Product List</h2>\r\n\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            EndContext();
            BeginContext(343, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c771d669de7aeaa93a2a236544ec153b3fb1aa1b5450", async() => {
                BeginContext(387, 56, true);
                WriteLiteral("<i class=\"fa-solid fa-plus\"></i> &nbsp; Add New Product ");
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
            BeginContext(447, 20, true);
            WriteLiteral("\r\n\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(467, 525, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c771d669de7aeaa93a2a236544ec153b3fb1aa1b6979", async() => {
                BeginContext(487, 435, true);
                WriteLiteral(@"
        <div class=""row ml-1"">
            <div class=""col-4"">
                <input type=""number"" class=""form-control"" name=""lowAmount"" />
            </div>
            <div class=""col-4"">
                <input type=""number"" class=""form-control"" name=""largeAmount"" />
            </div>
            <div class=""col-4 d"">
                <input type=""submit"" value=""Search"" class=""btn btn-success"" />
            </div>
");
                EndContext();
                BeginContext(965, 20, true);
                WriteLiteral("        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(992, 186, true);
            WriteLiteral("\r\n\r\n\r\n</div>\r\n<br />\r\n<div>\r\n    <table class=\"table table-striped border\" id=\"myTable\">\r\n        <thead>\r\n            <tr class=\"table-info\">\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1179, 44, false);
#line 42 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(expression: c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1291, 45, false);
#line 45 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(expression: c => c.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1336, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1404, 52, false);
#line 48 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(expression: c => c.ProductColor));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1524, 51, false);
#line 51 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(expression: c => c.IsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1575, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1643, 53, false);
#line 54 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(expression: c => c.ProductTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(1696, 69, true);
            WriteLiteral("\r\n\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1766, 39, false);
#line 58 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.SpcialTagId));

#line default
#line hidden
            EndContext();
            BeginContext(1805, 145, true);
            WriteLiteral("\r\n                </th>\r\n\r\n\r\n                <th></th>\r\n                <th>Action</th>\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 68 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(2007, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(2054, 9, false);
#line 71 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2063, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2095, 10, false);
#line 72 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2105, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2137, 17, false);
#line 73 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.ProductColor);

#line default
#line hidden
            EndContext();
            BeginContext(2154, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2186, 16, false);
#line 74 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.IsAvailable);

#line default
#line hidden
            EndContext();
            BeginContext(2202, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2234, 29, false);
#line 75 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.ProductTypes.Producttype);

#line default
#line hidden
            EndContext();
            BeginContext(2263, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2295, 31, false);
#line 76 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.specialTag.specialTageName);

#line default
#line hidden
            EndContext();
            BeginContext(2326, 59, true);
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2385, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c771d669de7aeaa93a2a236544ec153b3fb1aa1b14730", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 79 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
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
            BeginContext(2435, 54, true);
            WriteLiteral("\r\n\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 83 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(2506, 48, true);
            WriteLiteral("\r\n        </tbody>\r\n\r\n\r\n\r\n    </table>\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2571, 444, true);
                WriteLiteral(@"
    <script src=""//cdn.jsdelivr.net/npm/alertifyjs@1.11.2/build/alertify.min.js""></script>

    <script type=""text/javascript"">
        $(document).ready( function () {
            $('#myTable').DataTable({
                dom: 'Bfrtip',
                buttons: [
                    'pageLength','copy', 'csv', 'excel', 'pdf', 'print'
                ]
            });
        } );
        $(function(){
            var save = '");
                EndContext();
                BeginContext(3016, 16, false);
#line 105 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(TempData["save"]);

#line default
#line hidden
                EndContext();
                BeginContext(3032, 111, true);
                WriteLiteral("\'\r\n            if(save!=\'\') {\r\n                alertify.success(save);\r\n            }\r\n            var edit = \'");
                EndContext();
                BeginContext(3144, 16, false);
#line 109 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(TempData["edit"]);

#line default
#line hidden
                EndContext();
                BeginContext(3160, 110, true);
                WriteLiteral("\'\r\n            if(edit!=\'\') {\r\n                alertify.success(edit);\r\n            }\r\n            var del = \'");
                EndContext();
                BeginContext(3271, 18, false);
#line 113 "E:\ProjectC#\Online_Shop\Online_Shop\Areas\Admin\Views\Product\Index.cshtml"
                  Write(TempData["delete"]);

#line default
#line hidden
                EndContext();
                BeginContext(3289, 111, true);
                WriteLiteral("\'\r\n            if (del!=\'\') {\r\n                alertify.error(del);\r\n            }\r\n        })\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(3403, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
