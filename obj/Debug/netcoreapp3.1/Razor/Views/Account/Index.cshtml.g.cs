#pragma checksum "C:\Users\PC\Desktop\Proje\BookApp\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8670878a4ec0de5baa2f7cc00272ebce63405c86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8670878a4ec0de5baa2f7cc00272ebce63405c86", @"/Views/Account/Index.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookApp.Models.ViewModels.AppUserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:350px; margin-left:100px; margin-top:60px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/BookShop/images/myProfile.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\PC\Desktop\Proje\BookApp\Views\Account\Index.cshtml"
  
    Layout = Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- KULLANICI BİLGİ GÜNCELLEME -->\r\n\r\n<section id=\"cart_items\">\r\n    <div class=\"container\">\r\n        <div class=\"col-md-6\" id=\"myaccount\">\r\n            <p style=\"font-size:25px; color:#fe980f;\">Hesap Bilgileri</p>\r\n");
#nullable restore
#line 12 "C:\Users\PC\Desktop\Proje\BookApp\Views\Account\Index.cshtml"
             using (Html.BeginForm())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\PC\Desktop\Proje\BookApp\Views\Account\Index.cshtml"
           Write(Html.HiddenFor(x => x.Id, new { @readonly = true, @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>\r\n                    <b><i>Ad Soyad:</i> </b>\r\n                    ");
#nullable restore
#line 18 "C:\Users\PC\Desktop\Proje\BookApp\Views\Account\Index.cshtml"
               Write(Html.ValidationMessageFor(model => model.NameSurname, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 19 "C:\Users\PC\Desktop\Proje\BookApp\Views\Account\Index.cshtml"
               Write(Html.TextBoxFor(x => x.NameSurname, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    <b><i>Kullanıcı Adı:</i> </b>\r\n                    ");
#nullable restore
#line 23 "C:\Users\PC\Desktop\Proje\BookApp\Views\Account\Index.cshtml"
               Write(Html.ValidationMessageFor(model => model.UserName, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 24 "C:\Users\PC\Desktop\Proje\BookApp\Views\Account\Index.cshtml"
               Write(Html.TextBoxFor(x => x.UserName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    <b><i>E-Posta:</i> </b>\r\n                    ");
#nullable restore
#line 28 "C:\Users\PC\Desktop\Proje\BookApp\Views\Account\Index.cshtml"
               Write(Html.ValidationMessageFor(model => model.Email, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 29 "C:\Users\PC\Desktop\Proje\BookApp\Views\Account\Index.cshtml"
               Write(Html.TextBoxFor(x => x.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    <b><i>Telefon Numarası:</i> </b>\r\n                    ");
#nullable restore
#line 33 "C:\Users\PC\Desktop\Proje\BookApp\Views\Account\Index.cshtml"
               Write(Html.ValidationMessageFor(model => model.PhoneNumber, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 34 "C:\Users\PC\Desktop\Proje\BookApp\Views\Account\Index.cshtml"
               Write(Html.TextBoxFor(x => x.PhoneNumber, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    <b><i>Adres:</i> </b>\r\n                    ");
#nullable restore
#line 38 "C:\Users\PC\Desktop\Proje\BookApp\Views\Account\Index.cshtml"
               Write(Html.ValidationMessageFor(model => model.Adress, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 39 "C:\Users\PC\Desktop\Proje\BookApp\Views\Account\Index.cshtml"
               Write(Html.TextBoxFor(x => x.Adress, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n");
            WriteLiteral("                <button class=\"btn btn-primary\">Güncelle</button>\r\n");
#nullable restore
#line 43 "C:\Users\PC\Desktop\Proje\BookApp\Views\Account\Index.cshtml"
                
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-5\" id=\"myorder\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8670878a4ec0de5baa2f7cc00272ebce63405c868461", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <a style=""margin-left:100px;"" class=""btn btn-primary"" href=""/Account/MyShippedOrders"">Tamamlanan siparişlerim</a>
            <a class=""btn btn-primary"" href=""/Account/MyUnShippedOrders"">Bekleyen siparişlerim</a>
        </div>
    </div>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookApp.Models.ViewModels.AppUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
