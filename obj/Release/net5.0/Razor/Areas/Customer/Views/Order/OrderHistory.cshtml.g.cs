#pragma checksum "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "263c18d779e34d0f08b8fab8edeb19275bab1a8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Order_OrderHistory), @"mvc.1.0.view", @"/Areas/Customer/Views/Order/OrderHistory.cshtml")]
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
#line 1 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\_ViewImports.cshtml"
using Resturant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\_ViewImports.cshtml"
using Resturant.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
using Resturant.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263c18d779e34d0f08b8fab8edeb19275bab1a8c", @"/Areas/Customer/Views/Order/OrderHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"765c8df35a572ef43d98f276ec7529e0ea866496", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Order_OrderHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Resturant.Models.ViewModel.OrderListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
   ViewData["Title"] = "Index";
                Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n<br />\n<div class=\"border backgroundWhite\">\n    <div class=\"row\">\n        <div class=\"col-6\">\n            <h2 class=\"text-info\"> Past Order List</h2>\n        </div>\n        <div class=\"col-6 text-right\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "263c18d779e34d0f08b8fab8edeb19275bab1a8c4247", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n    <br />\n    <div>\n");
#nullable restore
#line 19 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
         if (Model.Orders.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-striped border\">\n    <tr class=\"table-secondary\">\n        <th>\n            ");
#nullable restore
#line 24 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
       Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 27 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
       Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 30 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
       Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 33 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
       Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.PickUpTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 36 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
       Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            Total Items\n        </th>\n        <th></th>\n\n    </tr>\n");
#nullable restore
#line 44 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
     foreach (var item in Model.Orders)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 48 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
   Write(Html.DisplayFor(m => item.OrderHeader.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 51 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
   Write(Html.DisplayFor(m => item.OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 54 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
   Write(Html.DisplayFor(m => item.OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 57 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
   Write(Html.DisplayFor(m => item.OrderHeader.PickUpTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 60 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
   Write(Html.DisplayFor(m => item.OrderHeader.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 63 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
   Write(Html.DisplayFor(m => item.OrderDetails.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        <button type=\"submit\" class=\"btn btn-success anchorDetail\" data-id=\"");
#nullable restore
#line 66 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
                                                                       Write(item.OrderHeader.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\">\n            <i class=\"far fa-list-alt\"></i> Details\n        </button>\n");
#nullable restore
#line 69 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
         if (item.OrderHeader.Status == SD.StatusSubmitted || item.OrderHeader.Status == SD.StatusInProcess || item.OrderHeader.Status == SD.StatusCompleted || item.OrderHeader.Status == SD.StatusReady)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<button type=\"button\" class=\"btn btn-info btnOrderStatus\" data-id=\"");
#nullable restore
#line 71 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
                                                              Write(item.OrderHeader.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\">\n    <i class=\"far fa-clock\"></i> Status\n</button>");
#nullable restore
#line 73 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\n</tr>                ");
#nullable restore
#line 75 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n                <div");
            BeginWriteAttribute("page-model", " page-model=\"", 2346, "\"", 2376, 1);
#nullable restore
#line 77 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
WriteAttributeValue("", 2359, Model.PagingInfo, 2359, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" page-classes-enabled=""true"" page-class=""btn border""
                     page-class-normal=""btn btn-light"" page-class-selected=""btn btn-info active""
                     class=""btn-group float-right"">
                </div>
                                <br /> ");
#nullable restore
#line 81 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
                                       }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>No category exists...</p>");
#nullable restore
#line 84 "E:\project\onlineResurant\Resturant\Resturant\Areas\Customer\Views\Order\OrderHistory.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog-centered modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-success text-light justify-content-center"">
                <h5 class=""modal-title"">Order Details</h5>
            </div>
            <div class=""modal-body justify-content-center"" id=""myModalContent"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" style=""width:20%"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""myOrderStatus"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-info text-light justify-content-center"">
                <h5 class=""modal-title"">Order Status </h5>
        ");
            WriteLiteral(@"    </div>
            <div class=""modal-body justify-content-center"" id='myOrderStatusContent'>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" style=""width:20%"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>var PostBackURL = '/Customer/Order/GetOrderDetails';
        var OrderStatusURL = '/Customer/Order/GetOrderStatus';

        $(function () {
            $("".anchorDetail"").click(function () {

                var $buttonClicked = $(this);
                var id = $buttonClicked.attr('data-id');

                $.ajax({
                    type: ""GET"",
                    url: PostBackURL,
                    contentType: ""application/json; charset=utf-8"",
                    data: { ""Id"": id },
                    cache: false,
                    dataType: ""html"",
                    success: function (data) {
                        $('#myModalContent').html(data);
                        $('#myModal').modal('show');
                    },
                    error: function () {
                        alert(""Dynamic content load failed"");
                    }
                });

            });

            $("".btnOrderStatus"").click(function () {
                var $buttonClicked = $(thi");
                WriteLiteral(@"s);
                var id = $buttonClicked.attr('data-id');
                $.ajax({
                    type: ""GET"",
                    url: OrderStatusURL,
                    contentType: ""text/html; charset=utf-8"",
                    data: { ""Id"": id },
                    cache: false,
                    dataType: ""html"",
                    success: function (data) {
                        $('#myOrderStatusContent').html(data);
                        $('#myOrderStatus').modal('show');

                    },
                    error: function () {
                        alert(""Dynamic content load failed."");
                    }
                });
            });
        });</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Resturant.Models.ViewModel.OrderListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
