#pragma checksum "C:\Users\PC\Desktop\Proje\BookApp\Views\Order\UnShippedOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09e812e556bc9df0e7429da8aca162883905a07a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_UnShippedOrders), @"mvc.1.0.view", @"/Views/Order/UnShippedOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09e812e556bc9df0e7429da8aca162883905a07a", @"/Views/Order/UnShippedOrders.cshtml")]
    public class Views_Order_UnShippedOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BookApp.Models.ViewModels.OrderViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PC\Desktop\Proje\BookApp\Views\Order\UnShippedOrders.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""module"">
    <div class=""module-head"">
        <h3>Bekleyen Siparişler</h3>
        <a style=""float:right; margin-top:-25px;"" href=""/Order/ShippedOrders"">Gönderilen Siparişler</a>
    </div>
    <div class=""module-body table"">
        <table cellpadding=""0"" cellspacing=""0"" border=""0"" class=""datatable-1 table table-bordered table-striped	 display"" width=""100%"">
            <thead>
                <tr>
                    <th> Sipariş No </th>
                    <th> Kitap Adı </th>
                    <th> Adet </th>
                    <th> Tarih </th>
                    <th> Detaylar </th>
                    <th> Göderildi </th>
                    <th> İptal </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 25 "C:\Users\PC\Desktop\Proje\BookApp\Views\Order\UnShippedOrders.cshtml"
                 foreach (var item in Model)
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"odd gradeX\">\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\PC\Desktop\Proje\BookApp\Views\Order\UnShippedOrders.cshtml"
                   Write(item.OrderNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\PC\Desktop\Proje\BookApp\Views\Order\UnShippedOrders.cshtml"
                   Write(item.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\PC\Desktop\Proje\BookApp\Views\Order\UnShippedOrders.cshtml"
                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\PC\Desktop\Proje\BookApp\Views\Order\UnShippedOrders.cshtml"
                   Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\PC\Desktop\Proje\BookApp\Views\Order\UnShippedOrders.cshtml"
                   Write(Html.ActionLink("Detaylar", "OrderDetail", new { id = item.Id }, new { @class = "btn btn-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\PC\Desktop\Proje\BookApp\Views\Order\UnShippedOrders.cshtml"
                   Write(Html.ActionLink("Gönderildi", "SendOrder", new { id = item.Id }, new { @class = "btn btn-primary", onclick = "return confirm('U Y A R I   |   Sipariş gönderildi olarak işaretlenmek üzere..');" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\PC\Desktop\Proje\BookApp\Views\Order\UnShippedOrders.cshtml"
                   Write(Html.ActionLink("İptal", "OrderRemove", new { id = item.Id }, new { @class = "btn btn-danger", onclick = "return confirm('U Y A R I   |   Şipariş iptal edilmek üzere..');" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\n");
#nullable restore
#line 36 "C:\Users\PC\Desktop\Proje\BookApp\Views\Order\UnShippedOrders.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div><!--/.module-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BookApp.Models.ViewModels.OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591