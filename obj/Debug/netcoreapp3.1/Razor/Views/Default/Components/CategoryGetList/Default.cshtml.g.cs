#pragma checksum "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Components\CategoryGetList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03826ca532f48a2cd557e185e3d0fa0fc8b414f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Components_CategoryGetList_Default), @"mvc.1.0.view", @"/Views/Default/Components/CategoryGetList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03826ca532f48a2cd557e185e3d0fa0fc8b414f7", @"/Views/Default/Components/CategoryGetList/Default.cshtml")]
    public class Views_Default_Components_CategoryGetList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookApp.Models.ViewModels.CategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- category list -->\n\n");
#nullable restore
#line 4 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Components\CategoryGetList\Default.cshtml"
 foreach (var item in Model)
{
    if (item.Status == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"panel-heading\">\n            <h4 class=\"panel-title\"><a");
            BeginWriteAttribute("href", " href=\"", 228, "\"", 273, 2);
            WriteAttributeValue("", 235, "/Default/BookCategory/", 235, 22, true);
#nullable restore
#line 9 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Components\CategoryGetList\Default.cshtml"
WriteAttributeValue("", 257, item.CategoryId, 257, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Components\CategoryGetList\Default.cshtml"
                                                                                Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\n        </div>\n");
#nullable restore
#line 11 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Components\CategoryGetList\Default.cshtml"
    }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookApp.Models.ViewModels.CategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591