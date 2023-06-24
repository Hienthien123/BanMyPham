#pragma checksum "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Checkout\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fef72c64b663dacd374953d5a2425013a647cb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Success), @"mvc.1.0.view", @"/Views/Checkout/Success.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fef72c64b663dacd374953d5a2425013a647cb5", @"/Views/Checkout/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"807a6f29a8d8e266aa2b40344db00254b2f6ba5b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Checkout_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MayMeiAccessory.ModelViews.MuaHangSuccessVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Accounts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Checkout\Success.cshtml"
  
    ViewData["Title"] = "Mua hàng";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style type=""text/css"">
        .nice-select .list {
            border-radius: 0px;
            overflow-y: auto;
            overflow: hidden;
            max-height: 200px;
            overflow-y: scroll;
        }

        .nice-select .option:hover, .nice-select .option.focus, .nice-select .option.selected.focus {
            color: red;
            background: none;
        }
    </style>
");
            }
            );
            WriteLiteral(@"



    <main class=""main-content"">
        <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""/assets/images/banner/bannershop.png"">
            <div class=""container h-100"">
                <div class=""row h-100"">
                    <div class=""col-lg-12"">
                        <div class=""breadcrumb-item"">
                            <h2 class=""breadcrumb-heading"">THÔNG TIN MUA HÀNG</h2>
                            <ul>
                                <li>
                                    <a href=""/"">Trang chủ <i class=""pe-7s-angle-right""></i></a>
                                </li>
                                <li>THÔNG TIN MUA HÀNG</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""checkout-area section-space-y-axis-100"">
            <div class=""container"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fef72c64b663dacd374953d5a2425013a647cb55878", async() => {
                WriteLiteral(@"

                    <div class=""row"">
                        <div class=""col-lg-6 col-12"">

                            <div class=""checkbox-form"">
                                <h3>Đặt hàng thành công</h3>
                                <p>Mã đơn hàng: #");
#nullable restore
#line 54 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Checkout\Success.cshtml"
                                            Write(Model.DonHangID);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                <p>Cảm ơn bạn đã đặt hàng</p>
                                <br />
                                <h3>THÔNG TIN ĐƠN HÀNG</h3>
                                <p>Thông tin giao hàng</p>
                                <p>Người nhận hàng: ");
#nullable restore
#line 59 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Checkout\Success.cshtml"
                                               Write(Model.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p>Số điện thoại: ");
#nullable restore
#line 60 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Checkout\Success.cshtml"
                                             Write(Model.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p>Địa chỉ: ");
#nullable restore
#line 61 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Views\Checkout\Success.cshtml"
                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <br />\r\n                                Để xem chi tiết đơn hàng vui lòng truy cập vào ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fef72c64b663dacd374953d5a2425013a647cb58029", async() => {
                    WriteLiteral("<strong>Tài khoản cá nhân.</strong>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@" Cần hỗ trợ? Liên hệ với chúng tôi qua số điện thoại 0353464740
                            </div>
                        </div>
                        <div class=""col-lg-6 col-12"">
                            <img src=""/assets/images/logo/lion.png"" width=""400px"" height=""500px"" />
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MayMeiAccessory.ModelViews.MuaHangSuccessVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
