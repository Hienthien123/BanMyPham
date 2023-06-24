#pragma checksum "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae1c5f0a2adfa75943185368e080ae742c9c206c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminAccounts_AdminDashboard), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminAccounts/AdminDashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae1c5f0a2adfa75943185368e080ae742c9c206c", @"/Areas/Admin/Views/AdminAccounts/AdminDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"807a6f29a8d8e266aa2b40344db00254b2f6ba5b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminAccounts_AdminDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MayMeiAccessory.Models.Customer>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml"
  
    ViewData["Title"] = "AdminDashboard";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    List<Order> DanhSachDonHang = ViewBag.DonHang;
    var total = DanhSachDonHang.Sum(x => x.TotalMoney).ToString("#,##0");
    MayMeiAccessory.ModelViews.ChangePasswordViewModel changePassword = new MayMeiAccessory.ModelViews.ChangePasswordViewModel();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""assets/images/breadcrumb/bg/1-1-1920x373.jpg"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h2 class=""breadcrumb-heading"">Product Related</h2>
                        <ul>
                            <li>
                                <a href=""/"">Trang chủ <i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li>Tài khoản của tôi</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""account-page-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <ul class=""nav myaccount-tab-trigger"" id=""account-page-tab"" role=""tab");
            WriteLiteral(@"list"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""account-dashboard-tab"" data-bs-toggle=""tab"" href=""#account-dashboard"" role=""tab"" aria-controls=""account-dashboard"" aria-selected=""true"">Thông tin tài khoản</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-orders-tab"" data-bs-toggle=""tab"" href=""#account-orders"" role=""tab"" aria-controls=""account-orders"" aria-selected=""false"">Danh sách đơn hàng</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-details-tab"" data-bs-toggle=""tab"" href=""#account-details"" role=""tab"" aria-controls=""account-details"" aria-selected=""false"">Thay đổi mật khẩu</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-user"" data-bs-toggle=""tab"" href=""#account-use");
            WriteLiteral(@"r"" role=""tab"" aria-controls=""account-user"" aria-selected=""false"">Chỉnh sửa thông tin</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-logout-tab"" href=""dang-xuat.html"" role=""tab"" aria-selected=""false"">Đăng xuất</a>
                        </li>
                    </ul>
                </div>
                <div class=""col-lg-9"">
                    <div class=""tab-content myaccount-tab-content"" id=""account-page-tab-content"">
                        <div class=""tab-pane fade show active"" id=""account-dashboard"" role=""tabpanel"" aria-labelledby=""account-dashboard-tab"">
                            <div class=""myaccount-dashboard"">
                                <p>
                                    Xin chào, <b>");
#nullable restore
#line 56 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml"
                                            Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                </p>\r\n                                <p>Email: ");
#nullable restore
#line 58 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml"
                                     Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Số điện thoại: ");
#nullable restore
#line 59 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml"
                                             Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Địa chỉ: ");
#nullable restore
#line 60 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml"
                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-orders"" role=""tabpanel"" aria-labelledby=""account-orders-tab"">
                            <div class=""myaccount-orders"">
                                <h4 class=""small-title"">DANH SÁCH ĐƠN HÀNG</h4>
");
#nullable restore
#line 66 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml"
                                 if (DanhSachDonHang != null && DanhSachDonHang.Count() > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""table-responsive"">
                                        <table class=""table table-bordered table-hover"">
                                            <tbody>
                                                <tr>
                                                    <th>ID</th>
                                                    <th>Ngày mua hàng</th>
                                                    <th>Ngày ship hàng</th>
                                                    <th>Trạng thái</th>
                                                </tr>
");
#nullable restore
#line 77 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml"
                                                 foreach (var item in DanhSachDonHang)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td><a class=\"account-order-id\" href=\"javascript:void(0)\">#");
#nullable restore
#line 80 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml"
                                                                                                              Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                                        <td>");
#nullable restore
#line 81 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml"
                                                       Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 82 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml"
                                                       Write(item.ShipDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 83 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml"
                                                       Write(item.TransactStatus.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>\r\n                                                            <a href=\"javascript:void(0)\" class=\"xemdonhang\" data-madonhang=\"");
#nullable restore
#line 85 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml"
                                                                                                                       Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xem đơn hàng</a>\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 88 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                            </tbody>
                                        </table>
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <hr />
                                        <div id=""records_table"">
                                        </div>
                                    </div>
");
#nullable restore
#line 101 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>Chưa có đơn hàng!</p>\r\n");
#nullable restore
#line 105 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-address"" role=""tabpanel"" aria-labelledby=""account-address-tab"">
                            <div class=""myaccount-address"">
                                <p>The following addresses will be used on the checkout page by default.</p>
                                <div class=""row"">
                                    <div class=""col"">
                                        <h4 class=""small-title"">BILLING ADDRESS</h4>
                                        <address>
                                            ");
#nullable restore
#line 115 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml"
                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </address>
                                    </div>
                                    <div class=""col"">
                                        <h4 class=""small-title"">SHIPPING ADDRESS</h4>
                                        <address>
                                            ");
#nullable restore
#line 121 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml"
                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </address>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-details"" role=""tabpanel"" aria-labelledby=""account-details-tab"">
                            ");
#nullable restore
#line 128 "C:\Users\ADMIN\Downloads\test\MayMeiAccessory\MayMeiAccessory\Areas\Admin\Views\AdminAccounts\AdminDashboard.cshtml"
                       Write(await Html.PartialAsync("_ChangePasswordPartialView", changePassword));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <div class=""tab-pane fade"" id=""account-user"" role=""tabpanel"" aria-labelledby=""account-details-tab"">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".xemdonhang"").click(function () {
                var madonhang = $(this).attr(""data-madonhang"")
                $.ajax({
                    url: '/DonHang/Details',
                    datatype: ""json"",
                    type: ""POST"",
                    data: { id: madonhang },
                    async: true,
                    success: function (results) {
                        $(""#records_table"").html("""");
                        $(""#records_table"").html(results);
                    },
                    error: function (xhr) {
                        alert('error');
                    }
                });
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MayMeiAccessory.Models.Customer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
