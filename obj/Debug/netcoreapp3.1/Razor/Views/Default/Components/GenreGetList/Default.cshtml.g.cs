#pragma checksum "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Components\GenreGetList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e09fe824eca6a911fd57d24943786f1516cd72e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Components_GenreGetList_Default), @"mvc.1.0.view", @"/Views/Default/Components/GenreGetList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e09fe824eca6a911fd57d24943786f1516cd72e8", @"/Views/Default/Components/GenreGetList/Default.cshtml")]
    public class Views_Default_Components_GenreGetList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookApp.Models.ViewModels.GenreViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- genre list -->\r\n");
#nullable restore
#line 3 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Components\GenreGetList\Default.cshtml"
 foreach (var item in Model)
{
    if (item.Status == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a");
            BeginWriteAttribute("href", " href=\"", 167, "\"", 206, 2);
            WriteAttributeValue("", 174, "/Default/BookGenre/", 174, 19, true);
#nullable restore
#line 7 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Components\GenreGetList\Default.cshtml"
WriteAttributeValue("", 193, item.GenreId, 193, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 7 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Components\GenreGetList\Default.cshtml"
                                                  Write(item.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 8 "C:\Users\PC\Desktop\Proje\BookApp\Views\Default\Components\GenreGetList\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookApp.Models.ViewModels.GenreViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
