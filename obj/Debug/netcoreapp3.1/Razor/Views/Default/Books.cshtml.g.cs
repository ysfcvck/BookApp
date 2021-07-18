#pragma checksum "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Books.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e08612172923eb27567850900c86d25618f103c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Books), @"mvc.1.0.view", @"/Views/Default/Books.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e08612172923eb27567850900c86d25618f103c0", @"/Views/Default/Books.cshtml")]
    public class Views_Default_Books : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookApp.Models.ViewModels.BookViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Books.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- TÜM KİTAPLAR -->

<section>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-3"">
                <div class=""left-sidebar"">
                    <h2>Kategoriler</h2>
                    <div class=""panel-group category-products"" id=""accordian"">
                        <!--category-productsr-->
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><a href=""/Default/Books"">Tüm Kitaplar</a></h4>
                            </div>
                            ");
#nullable restore
#line 20 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Books.cshtml"
                       Write(await Component.InvokeAsync("CategoryGetList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>

                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse"" data-parent=""#accordian"" href=""#sportswear"">
                                        <span class=""badge pull-right""><i class=""fa fa-plus""></i></span>
                                        Alt Kategoriler
                                    </a>
                                </h4>
                            </div>
                            <div id=""sportswear"" class=""panel-collapse collapse"">
                                <div class=""panel-body"">
                                    <ul>
                                        ");
#nullable restore
#line 36 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Books.cshtml"
                                   Write(await Component.InvokeAsync("GenreGetList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div><!--/category-products-->

                    <div class=""shipping text-center"">
                        <!--shipping-->
                        <p><img style=""width:270px;"" src=""https://c0.wallpaperflare.com/preview/698/843/707/ireland-dublin-trinity-college-culture.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2116, "\"", 2122, 0);
            EndWriteAttribute();
            WriteLiteral(" /></p>\r\n                        <p><img style=\"width:270px;\" src=\"https://i.pinimg.com/564x/be/93/a2/be93a21ea57e8879d59c4ec44a423e6a.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2262, "\"", 2268, 0);
            EndWriteAttribute();
            WriteLiteral(" /></p>\r\n                        <p><img style=\"width:270px;\" src=\"https://www.backgroundscool.com/wp-content/uploads/2019/03/book_coffee_bed_shadow_117507_938x1668.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2438, "\"", 2444, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></p>
                    </div><!--/shipping-->

                </div>
            </div>

            <div class=""col-sm-9 padding-right"">
                <div class=""features_items"">
                    <!--features_items-->
                    <h2 class=""title text-center"">Tüm Kitaplar</h2>
");
#nullable restore
#line 57 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Books.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-sm-4"">
                            <div class=""product-image-wrapper"">
                                <div class=""single-products"">
                                    <div class=""productinfo text-center"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 3120, "\"", 3160, 2);
            WriteAttributeValue("", 3127, "/Default/BookDetails/", 3127, 21, true);
#nullable restore
#line 63 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Books.cshtml"
WriteAttributeValue("", 3148, item.BookId, 3148, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img class=\"indeximg\"");
            BeginWriteAttribute("src", " src=\"", 3183, "\"", 3203, 1);
#nullable restore
#line 63 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Books.cshtml"
WriteAttributeValue("", 3189, item.ImageURL, 3189, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3204, "\"", 3210, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                                        <h2>");
#nullable restore
#line 64 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Books.cshtml"
                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</h2>\r\n                                        <p>");
#nullable restore
#line 65 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Books.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                        <!-- Ürün stok sayısı 0\'dan büyükse sepete ekle butonu aktif olacak -->\r\n");
#nullable restore
#line 68 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Books.cshtml"
                                         if (item.Stock > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a");
            BeginWriteAttribute("href", " href=\"", 3609, "\"", 3643, 2);
            WriteAttributeValue("", 3616, "/Cart/CartAddd/", 3616, 15, true);
#nullable restore
#line 70 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Books.cshtml"
WriteAttributeValue("", 3631, item.BookId, 3631, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default add-to-cart\"><i class=\"fa fa-shopping-cart\"></i>Sepete Ekle</a>\r\n");
#nullable restore
#line 71 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Books.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <!-- Ürün stok sayısı 0 veya 0\'dan küçükse sepete ekle butonu devre dışı kalacak-->\r\n");
#nullable restore
#line 74 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Books.cshtml"
                                         if (item.Stock <= 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"btn btn-default add-to-cart\"><i class=\"fa fa-shopping-cart\"></i>Stokta yok</a>\r\n");
#nullable restore
#line 77 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Books.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 83 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Books.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div><!--features_items-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookApp.Models.ViewModels.BookViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
