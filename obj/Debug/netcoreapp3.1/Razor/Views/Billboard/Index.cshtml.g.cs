#pragma checksum "C:\Users\PC\Desktop\Proje\BookApp\Views\Billboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52ca3eb447eb633ac7af0b85657fc81b654c5ab8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Billboard_Index), @"mvc.1.0.view", @"/Views/Billboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52ca3eb447eb633ac7af0b85657fc81b654c5ab8", @"/Views/Billboard/Index.cshtml")]
    public class Views_Billboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BookApp.Models.ViewModels.BillboardViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PC\Desktop\Proje\BookApp\Views\Billboard\Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""module"">
    <div class=""module-head"">
        <h3>Reklam Yönetimi</h3>
        <a style=""float:right; margin-top:-25px;"" href=""/Billboard/BillboardAdd"">Reklam Ekle</a>
    </div>
    <div class=""module-body table"">
        <table cellpadding=""0"" cellspacing=""0"" border=""0"" class=""datatable-1 table table-bordered table-striped	 display"" width=""100%"">
            <thead>
                <tr>
                    <th> Ana Başlık (1) </th>
                    <th> Ana Başlık (2) </th>
                    <th> Alt Başlık </th>
                    <th> Açıklama </th>
                    <th> Detaylar </th>
                    <th> Sil </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 24 "C:\Users\PC\Desktop\Proje\BookApp\Views\Billboard\Index.cshtml"
                 foreach (var item in Model)
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"odd gradeX\">\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\PC\Desktop\Proje\BookApp\Views\Billboard\Index.cshtml"
                   Write(item.MainTitle1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\PC\Desktop\Proje\BookApp\Views\Billboard\Index.cshtml"
                   Write(item.MainTitle2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\PC\Desktop\Proje\BookApp\Views\Billboard\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\PC\Desktop\Proje\BookApp\Views\Billboard\Index.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\PC\Desktop\Proje\BookApp\Views\Billboard\Index.cshtml"
                   Write(Html.ActionLink("Düzenle", "BillboardGet", new { id = item.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\PC\Desktop\Proje\BookApp\Views\Billboard\Index.cshtml"
                   Write(Html.ActionLink("Sil", "BillboardRemove", new { id = item.Id }, new { @class = "btn btn-danger", onclick = "return confirm('U Y A R I   |   Reklam silinmek üzere..');" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\n");
#nullable restore
#line 34 "C:\Users\PC\Desktop\Proje\BookApp\Views\Billboard\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BookApp.Models.ViewModels.BillboardViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591