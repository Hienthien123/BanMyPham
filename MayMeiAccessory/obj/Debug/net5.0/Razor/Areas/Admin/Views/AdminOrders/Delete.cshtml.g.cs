#pragma checksum "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25f4d811b5dfc26cb16ae1040032ec2a2e034074"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminOrders_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminOrders/Delete.cshtml")]
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
#line 1 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\_ViewImports.cshtml"
using MayMeiAccessory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\_ViewImports.cshtml"
using MayMeiAccessory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25f4d811b5dfc26cb16ae1040032ec2a2e034074", @"/Areas/Admin/Views/AdminOrders/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"807a6f29a8d8e266aa2b40344db00254b2f6ba5b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminOrders_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MayMeiAccessory.Models.Order>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
  
    ViewData["Title"] = "Thông tin đơn hàng #" + Model.OrderId;
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    List<OrderDetail> orderDetails = ViewBag.ChiTiet;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"page-header\">\r\n    <h2 class=\"header-title\"></h2>\r\n    <div class=\"header-sub-title\">\r\n        <nav class=\"breadcrumb breadcrumb-dash\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25f4d811b5dfc26cb16ae1040032ec2a2e0340746458", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25f4d811b5dfc26cb16ae1040032ec2a2e0340748161", async() => {
                WriteLiteral("Danh sách đơn hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <span class=""breadcrumb-item active"">Chi tiết đơn hàng</span>
        </nav>
    </div>
</div>
<div class=""container"">
    <div class=""card"">
        <div class=""card-body"">
            <div id=""invoice"" class=""p-h-30"">
                <div class=""row m-t-20 lh-2"">
                    <div class=""col-sm-6"">
                        <h3 class=""p-l-10 m-t-10"">THÔNG TIN ĐƠN HÀNG:</h3>
                        <address class=""p-l-10 m-t-10"">
                            <span class=""font-weight-semibold text-dark"">Họ và Tên: ");
#nullable restore
#line 28 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
                                                                               Write(Model.Customer.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                            <span>Địa chỉ: ");
#nullable restore
#line 29 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
                                      Write(Model.Customer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                            <span>Số điện thoại: ");
#nullable restore
#line 30 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
                                            Write(Model.Customer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </address>
                    </div>
                    <div class=""col-sm-6"">
                        <div class=""m-t-80"">
                            <div class=""text-dark text-uppercase d-inline-block"">
                                <span class=""font-weight-semibold text-dark"">Mã đơn hàng :</span>
                            </div>
                            <div class=""float-right"">#");
#nullable restore
#line 38 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
                                                 Write(Model.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""text-dark text-uppercase d-inline-block"">
                            <span class=""font-weight-semibold text-dark"">Ngày đặt hàng :</span>
                        </div>
                        <div class=""float-right"">");
#nullable restore
#line 43 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
                                            Write(Model.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        <br />
                        <div class=""text-dark text-uppercase d-inline-block"">
                            <span class=""font-weight-semibold text-dark"">Ngày Ship hàng :</span>
                        </div>
                        <div class=""float-right"">");
#nullable restore
#line 48 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
                                            Write(Model.ShipDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        <br />
                        <div class=""text-dark text-uppercase d-inline-block"">
                            <span class=""font-weight-semibold text-dark"">Trạng thái đơn hàng :</span>
                        </div>
                        <div class=""float-right"">");
#nullable restore
#line 53 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
                                            Write(Model.TransactStatus.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                </div>
                <div class=""m-t-20"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>No.</th>
                                    <th>Items</th>
                                    <th>Quantity</th>
                                    <th>Price</th>
                                    <th>Total</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 69 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
                                 if (orderDetails != null && orderDetails.Count() > 0)
                                {
                                    int i = 1;
                                    foreach (var item in orderDetails)
                                    {
                                        string url = $"/{item.Product.Alias}-{item.Product.ProductId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <th>");
#nullable restore
#line 76 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <td><a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 4019, "\"", 4030, 1);
#nullable restore
#line 77 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
WriteAttributeValue("", 4026, url, 4026, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 77 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
                                                                          Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                            <td>");
#nullable restore
#line 78 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
                                           Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 79 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
                                           Write(item.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\r\n                                            <td>");
#nullable restore
#line 80 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
                                           Write(item.TotalMoney.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 82 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
                                        i++;
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </tbody>
                        </table>
                    </div>
                    <div class=""row m-t-30 lh-1-8"">
                        <div class=""col-sm-12"">
                            <div class=""float-right text-right"">
                                <h3><span class=""font-weight-semibold text-dark"">Tổng tiền :</span>");
#nullable restore
#line 93 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
                                                                                              Write(orderDetails.Sum(x => x.TotalMoney).Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</h3>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25f4d811b5dfc26cb16ae1040032ec2a2e03407418811", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25f4d811b5dfc26cb16ae1040032ec2a2e03407419074", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 105 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrderId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Xác nhận xóa đơn hàng\" class=\"btn btn-danger\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "asp-for-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 104 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminOrders\Delete.cshtml"
AddHtmlAttributeValue("", 5155, Model.OrderId, 5155, 14, false);

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
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MayMeiAccessory.Models.Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
