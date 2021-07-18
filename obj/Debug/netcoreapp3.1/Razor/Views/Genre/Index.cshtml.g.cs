#pragma checksum "C:\Users\PC\Desktop\Proje\BookApp\Views\Genre\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "677a8dc6bd74c502a6d6ed764e2968fe01ef674c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Genre_Index), @"mvc.1.0.view", @"/Views/Genre/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"677a8dc6bd74c502a6d6ed764e2968fe01ef674c", @"/Views/Genre/Index.cshtml")]
    public class Views_Genre_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookApp.Models.ViewModels.GenreViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\PC\Desktop\Proje\BookApp\Views\Genre\Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""module"">
    <div class=""module-head"">
        <h3>Tür İşlemleri</h3>
        <a style=""float:right; margin-top:-25px;"" href=""/Genre/GenreAdd"">Tür Ekle</a>
    </div>
    <div class=""module-body table"">
        <table cellpadding=""0"" cellspacing=""0"" border=""0"" class=""datatable-1 table table-bordered table-striped	 display"" width=""100%"">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Tür Adı</th>
                    <th>Status</th>
                    <th>Aktif</th>
                    <th>İnaktif</th>
                    <th>Düzenle</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 25 "C:\Users\PC\Desktop\Proje\BookApp\Views\Genre\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"odd gradeX\">\n                        <td>");
#nullable restore
#line 28 "C:\Users\PC\Desktop\Proje\BookApp\Views\Genre\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.GenreId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                        <td>");
#nullable restore
#line 30 "C:\Users\PC\Desktop\Proje\BookApp\Views\Genre\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.GenreName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                        <td>");
#nullable restore
#line 32 "C:\Users\PC\Desktop\Proje\BookApp\Views\Genre\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                        <td>");
#nullable restore
#line 34 "C:\Users\PC\Desktop\Proje\BookApp\Views\Genre\Index.cshtml"
                       Write(Html.ActionLink("Aktif", "GenreActive", new { id = item.GenreId }, new { @class = "btn btn-success", onclick = "return confirm('U Y A R I   |   Seçilen türü aktif etmek üzeresiniz..');" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                        <td>");
#nullable restore
#line 36 "C:\Users\PC\Desktop\Proje\BookApp\Views\Genre\Index.cshtml"
                       Write(Html.ActionLink("İnaktif", "GenreInactive", new { id = item.GenreId }, new { @class = "btn btn-warning", onclick = "return confirm('U Y A R I   |   Seçilen türü inaktif etmek üzeresiniz..');" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                        <td>");
#nullable restore
#line 38 "C:\Users\PC\Desktop\Proje\BookApp\Views\Genre\Index.cshtml"
                       Write(Html.ActionLink("Düzenle", "GenreGet", new { id = item.GenreId }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 40 "C:\Users\PC\Desktop\Proje\BookApp\Views\Genre\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div><!--/.module-->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookApp.Models.ViewModels.GenreViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
