#pragma checksum "C:\Users\PC\Desktop\Proje\BookApp\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3108c6a1b0876360bc26f21a6dbe2c905723479"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3108c6a1b0876360bc26f21a6dbe2c905723479", @"/Views/Contact/Index.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookApp.Models.ViewModels.ContactViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PC\Desktop\Proje\BookApp\Views\Contact\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- İLETİŞİM FORMU -->

<div id=""contact-page"" class=""container"">
    <div class=""bg"">
        <div class=""row"">
            <div class=""col-sm-8"" style=""margin-top:50px;"">
                <div class=""contact-form"">
                    <h2 class=""title text-center"">İLETİŞİM FORMU</h2>
                    <div class=""status alert alert-success"" style=""display: none""></div>
");
#nullable restore
#line 16 "C:\Users\PC\Desktop\Proje\BookApp\Views\Contact\Index.cshtml"
                     using (Html.BeginForm(new { @class = "contact-form row" }))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"form-group col-md-6\">\r\n                            ");
#nullable restore
#line 19 "C:\Users\PC\Desktop\Proje\BookApp\Views\Contact\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.NameSurname, new { @placeholder = "Ad Soyad..", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group col-md-6\">\r\n                            ");
#nullable restore
#line 22 "C:\Users\PC\Desktop\Proje\BookApp\Views\Contact\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.Email, new { @placeholder = "Eposta..", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group col-md-12\">\r\n                            ");
#nullable restore
#line 25 "C:\Users\PC\Desktop\Proje\BookApp\Views\Contact\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.Subject, new { @placeholder = "Konu..", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group col-md-12\">\r\n                            ");
#nullable restore
#line 28 "C:\Users\PC\Desktop\Proje\BookApp\Views\Contact\Index.cshtml"
                       Write(Html.TextAreaFor(x => x.Message, new { @placeholder = "Lütfen iletmek istediğiniz mesajı yazın..", @class = "form-control", @id = "message", @rows = "8" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <div class=""form-group col-md-12"">
                            <input type=""submit"" class=""btn btn-primary pull-right"" value=""Gönder"">
                            <div style=""color:#fe980f"">
                                ");
#nullable restore
#line 33 "C:\Users\PC\Desktop\Proje\BookApp\Views\Contact\Index.cshtml"
                           Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 36 "C:\Users\PC\Desktop\Proje\BookApp\Views\Contact\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
            <div class=""col-sm-4"" style=""margin-top:50px;"">
                <div class=""contact-info"">
                    <h2 class=""title text-center"">İLETİŞİM BİLGİLERİ</h2>
                    <address>
                        <p>BookApp</p><br />
                        <p>Boğaziçi Üniversitesi Hisar Kampüsü Yönetim Bilişim Sistemleri Bölümü 34342</p>
                        <p>Bebek, İstanbul</p><br />
                        <p>Telefon: (0212) 359 72 87</p>
                        <p>Fax: (0212) 287 32 97</p>
                        <p>Email: bookapp34@gmail.com</p>
                    </address>
                </div>
            </div>
        </div>
    </div>
</div><!--/#contact-page-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookApp.Models.ViewModels.ContactViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
