#pragma checksum "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Search\ListProductSearchPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ecfb83e9756ceb8ef0d277a71ce29c2d62448d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_ListProductSearchPartialView), @"mvc.1.0.view", @"/Views/Search/ListProductSearchPartialView.cshtml")]
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
#line 1 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\_ViewImports.cshtml"
using MayMeiAccessory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\_ViewImports.cshtml"
using MayMeiAccessory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ecfb83e9756ceb8ef0d277a71ce29c2d62448d5", @"/Views/Search/ListProductSearchPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"807a6f29a8d8e266aa2b40344db00254b2f6ba5b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Search_ListProductSearchPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tab-content text-charcoal pt-8\">\r\n    <div class=\"tab-pane fade\" id=\"grid-view\" role=\"tabpanel\" aria-labelledby=\"grid-view-tab\">\r\n        <div class=\"product-grid-view row\" id=\"records_table\">\r\n");
#nullable restore
#line 6 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Search\ListProductSearchPartialView.cshtml"
             if (Model != null && Model.Count() > 0)
            {
                foreach (var item in Model)
                {
                    string url = $"/{item.Alias}-{item.ProductId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-sm-6\">\r\n                        <div class=\"product-item\">\r\n                            <div class=\"product-img img-zoom-effect\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 647, "\"", 658, 1);
#nullable restore
#line 14 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Search\ListProductSearchPartialView.cshtml"
WriteAttributeValue("", 654, url, 654, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6ecfb83e9756ceb8ef0d277a71ce29c2d62448d54945", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 725, "~/images/products/", 725, 18, true);
#nullable restore
#line 15 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Search\ListProductSearchPartialView.cshtml"
AddHtmlAttributeValue("", 743, item.Thumb, 743, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Search\ListProductSearchPartialView.cshtml"
AddHtmlAttributeValue("", 761, item.Title, 761, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </a>\r\n");
            WriteLiteral("                            </div>\r\n                            <div class=\"product-content\">\r\n                                <a class=\"product-name\"");
            BeginWriteAttribute("href", " href=\"", 1280, "\"", 1291, 1);
#nullable restore
#line 27 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Search\ListProductSearchPartialView.cshtml"
WriteAttributeValue("", 1287, url, 1287, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Search\ListProductSearchPartialView.cshtml"
                                                               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                <div class=\"price-box pb-1\">\r\n                                    <span class=\"new-price\">");
#nullable restore
#line 29 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Search\ListProductSearchPartialView.cshtml"
                                                       Write(item.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VNĐ</span>
                                </div>
                                <div class=""rating-box"">
                                    <ul>
                                        <li><i class=""pe-7s-star""></i></li>
                                        <li><i class=""pe-7s-star""></i></li>
                                        <li><i class=""pe-7s-star""></i></li>
                                        <li><i class=""pe-7s-star""></i></li>
                                        <li><i class=""pe-7s-star""></i></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 43 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Search\ListProductSearchPartialView.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"tab-pane fade show active\" id=\"list-view\" role=\"tabpanel\" aria-labelledby=\"list-view-tab\">\r\n        <div class=\"product-list-view with-sidebar row\" id=\"records_table\">\r\n");
#nullable restore
#line 50 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Search\ListProductSearchPartialView.cshtml"
             if (Model != null && Model.Count() > 0)
            {
                foreach (var item in Model)
                {
                    string url = $"/{item.Alias}-{item.ProductId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-12 pt-6\">\r\n                        <div class=\"product-item\">\r\n                            <div class=\"product-img img-zoom-effect\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2850, "\"", 2861, 1);
#nullable restore
#line 58 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Search\ListProductSearchPartialView.cshtml"
WriteAttributeValue("", 2857, url, 2857, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6ecfb83e9756ceb8ef0d277a71ce29c2d62448d510713", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2928, "~/images/products/", 2928, 18, true);
#nullable restore
#line 59 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Search\ListProductSearchPartialView.cshtml"
AddHtmlAttributeValue("", 2946, item.Thumb, 2946, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 59 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Search\ListProductSearchPartialView.cshtml"
AddHtmlAttributeValue("", 2964, item.Title, 2964, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </a>\r\n");
            WriteLiteral("                            </div>\r\n                            <div class=\"product-content align-self-center\">\r\n                                <a class=\"product-name pb-2\"");
            BeginWriteAttribute("href", " href=\"", 3537, "\"", 3548, 1);
#nullable restore
#line 72 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Search\ListProductSearchPartialView.cshtml"
WriteAttributeValue("", 3544, url, 3544, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 72 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Search\ListProductSearchPartialView.cshtml"
                                                                    Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                <div class=\"price-box pb-1\">\r\n                                    <span class=\"new-price\">");
#nullable restore
#line 74 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Search\ListProductSearchPartialView.cshtml"
                                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                                <div class=""rating-box pb-2"">
                                    <ul>
                                        <li><i class=""pe-7s-star""></i></li>
                                        <li><i class=""pe-7s-star""></i></li>
                                        <li><i class=""pe-7s-star""></i></li>
                                        <li><i class=""pe-7s-star""></i></li>
                                        <li><i class=""pe-7s-star""></i></li>
                                    </ul>
                                </div>
                                <p class=""short-desc mb-0"">");
#nullable restore
#line 85 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Search\ListProductSearchPartialView.cshtml"
                                                      Write(item.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 89 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Search\ListProductSearchPartialView.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n                    ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
