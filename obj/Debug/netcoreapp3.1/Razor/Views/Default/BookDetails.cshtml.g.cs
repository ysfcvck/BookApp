#pragma checksum "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5e696a8f2842de5c99894395131e3579d0f8eaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_BookDetails), @"mvc.1.0.view", @"/Views/Default/BookDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5e696a8f2842de5c99894395131e3579d0f8eaf", @"/Views/Default/BookDetails.cshtml")]
    public class Views_Default_BookDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookApp.Models.ViewModels.BookViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- KİTAP DETAYI -->

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
#line 20 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
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
#line 36 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
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
                </div>
            </div>

            <div class=""col-sm-9 padding-right"">
                <div class=""product-details"">
                    <!--product-details-->
");
#nullable restore
#line 48 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                     foreach (var item in Model)
                    {
                        if (item.BookId == ViewBag.x)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-sm-5\">\r\n                                <div class=\"view-product\">\r\n                                    <img style=\"height:500px;\"");
            BeginWriteAttribute("src", " src=\"", 2382, "\"", 2402, 1);
#nullable restore
#line 54 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
WriteAttributeValue("", 2388, item.ImageURL, 2388, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2403, "\"", 2409, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                </div>
                            </div>
                            <div class=""col-sm-7"">
                                <div class=""product-information"">
                                    <!--/product-information-->
                                    <h2>");
#nullable restore
#line 60 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                    <p><a");
            BeginWriteAttribute("href", " href=\"", 2773, "\"", 2818, 2);
            WriteAttributeValue("", 2780, "/Default/BookCategory/", 2780, 22, true);
#nullable restore
#line 61 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
WriteAttributeValue("", 2802, item.CategoryId, 2802, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                                                   Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> | <a");
            BeginWriteAttribute("href", " href=\"", 2856, "\"", 2895, 2);
            WriteAttributeValue("", 2863, "/Default/BookGenre/", 2863, 19, true);
#nullable restore
#line 61 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
WriteAttributeValue("", 2882, item.GenreId, 2882, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                                                                                                                                Write(item.Genre.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                                    <p>ID : ");
#nullable restore
#line 62 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                       Write(item.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <span>\r\n                                        <span>");
#nullable restore
#line 64 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</span>\r\n\r\n                                        <!-- Ürün stok sayısı 0\'dan büyükse sepete ekle butonu aktif olacak -->\r\n");
#nullable restore
#line 67 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                         if (item.Stock > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a");
            BeginWriteAttribute("href", " href=\"", 3368, "\"", 3401, 2);
            WriteAttributeValue("", 3375, "/Cart/CartAdd/", 3375, 14, true);
#nullable restore
#line 69 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
WriteAttributeValue("", 3389, item.BookId, 3389, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default add-to-cart\"><i class=\"fa fa-shopping-cart\"></i>Sepete Ekle</a>\r\n");
#nullable restore
#line 70 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <!-- Ürün stok sayısı 0 veya 0\'dan küçükse sepete ekle butonu devre dışı kalacak-->\r\n");
#nullable restore
#line 73 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                         if (item.Stock <= 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"btn btn-default add-to-cart\"><i class=\"fa fa-shopping-cart\"></i>Stokta yok</a>\r\n");
#nullable restore
#line 76 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </span><br /><br />\r\n                                    <p><b>Yazar:</b> ");
#nullable restore
#line 79 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                Write(item.Writer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p><b>Yayınevi:</b> ");
#nullable restore
#line 80 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                   Write(item.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p><b>Dil:</b> ");
#nullable restore
#line 81 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                              Write(item.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p><b>Baskı Yılı:</b> ");
#nullable restore
#line 82 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                     Write(item.PublishYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p><b>Sayfa Sayısı:</b> ");
#nullable restore
#line 83 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                       Write(item.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\r\n                                    <p><b>Açıklama:</b> ");
#nullable restore
#line 84 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\r\n                                    <p>Toplu alımlar için lütfen bizimle iletişime geçin..</p>\r\n                                </div><!--/product-information-->\r\n                            </div>\r\n");
#nullable restore
#line 88 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div><!--/product-details-->

                <div style=""margin-top:200px;"" class=""recommended_items"">
                    <!--recommended_items-->
                    <h2 class=""title text-center"">Önerilen Kitaplar</h2>

                    <div id=""recommended-item-carousel"" class=""carousel slide"" data-ride=""carousel"">
                        <div class=""carousel-inner"">
                            <div class=""item active"">

");
#nullable restore
#line 100 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                 foreach (var item in Model.Reverse().Take(3))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""col-sm-4"">
                                        <div class=""product-image-wrapper"">
                                            <div class=""single-products"">
                                                <div class=""productinfo text-center"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 5652, "\"", 5692, 2);
            WriteAttributeValue("", 5659, "/Default/BookDetails/", 5659, 21, true);
#nullable restore
#line 106 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
WriteAttributeValue("", 5680, item.BookId, 5680, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img class=\"indexrndm\"");
            BeginWriteAttribute("src", " src=\"", 5716, "\"", 5736, 1);
#nullable restore
#line 106 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
WriteAttributeValue("", 5722, item.ImageURL, 5722, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5737, "\"", 5743, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                                                    <h2>");
#nullable restore
#line 107 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</h2>\r\n                                                    <p>");
#nullable restore
#line 108 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                                    <!-- Ürün stok sayısı 0\'dan büyükse sepete ekle butonu aktif olacak -->\r\n");
#nullable restore
#line 111 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                     if (item.Stock > 0)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a");
            BeginWriteAttribute("href", " href=\"", 6214, "\"", 6248, 2);
            WriteAttributeValue("", 6221, "/Cart/CartAddd/", 6221, 15, true);
#nullable restore
#line 113 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
WriteAttributeValue("", 6236, item.BookId, 6236, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default add-to-cart\"><i class=\"fa fa-shopping-cart\"></i>Sepete Ekle</a>\r\n");
#nullable restore
#line 114 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    <!-- Ürün stok sayısı 0 veya 0\'dan küçükse sepete ekle butonu devre dışı kalacak-->\r\n");
#nullable restore
#line 117 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                     if (item.Stock <= 0)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a class=\"btn btn-default add-to-cart\"><i class=\"fa fa-shopping-cart\"></i>Stokta yok</a>\r\n");
#nullable restore
#line 120 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 126 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n\r\n                            <div class=\"item\">\r\n");
#nullable restore
#line 130 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                 foreach (var item in Model.Take(3))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""col-sm-4"">
                                        <div class=""product-image-wrapper"">
                                            <div class=""single-products"">
                                                <div class=""productinfo text-center"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 7644, "\"", 7684, 2);
            WriteAttributeValue("", 7651, "/Default/BookDetails/", 7651, 21, true);
#nullable restore
#line 136 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
WriteAttributeValue("", 7672, item.BookId, 7672, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img class=\"indexrndm\"");
            BeginWriteAttribute("src", " src=\"", 7708, "\"", 7728, 1);
#nullable restore
#line 136 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
WriteAttributeValue("", 7714, item.ImageURL, 7714, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7729, "\"", 7735, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                                                    <h2>");
#nullable restore
#line 137 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</h2>\r\n                                                    <p>");
#nullable restore
#line 138 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                                    <!-- Ürün stok sayısı 0\'dan büyükse sepete ekle butonu aktif olacak -->\r\n");
#nullable restore
#line 141 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                     if (item.Stock > 0)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a");
            BeginWriteAttribute("href", " href=\"", 8206, "\"", 8240, 2);
            WriteAttributeValue("", 8213, "/Cart/CartAddd/", 8213, 15, true);
#nullable restore
#line 143 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
WriteAttributeValue("", 8228, item.BookId, 8228, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default add-to-cart\"><i class=\"fa fa-shopping-cart\"></i>Sepete Ekle</a>\r\n");
#nullable restore
#line 144 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    <!-- Ürün stok sayısı 0 veya 0\'dan küçükse sepete ekle butonu devre dışı kalacak-->\r\n");
#nullable restore
#line 147 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                     if (item.Stock <= 0)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a class=\"btn btn-default add-to-cart\"><i class=\"fa fa-shopping-cart\"></i>Stokta yok</a>\r\n");
#nullable restore
#line 150 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 156 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\BookDetails.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                        <a class=""left recommended-item-control"" href=""#recommended-item-carousel"" data-slide=""prev"">
                            <i class=""fa fa-angle-left""></i>
                        </a>
                        <a class=""right recommended-item-control"" href=""#recommended-item-carousel"" data-slide=""next"">
                            <i class=""fa fa-angle-right""></i>
                        </a>
                    </div>
                </div><!--/recommended_items-->
            </div>
        </div>
    </div>
</section>");
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
