#pragma checksum "C:\Users\EMRE-KESKINBICKI\Desktop\Keskin\NetBT\Abc\Abc.Northwind.Web\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6388b7278bd7cbf25e6d54d7fd691e11eeb516e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6388b7278bd7cbf25e6d54d7fd691e11eeb516e", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9e47e9240df53585b7cbfc3b2ab7e57e7e49e77", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Abc.Northwind.Web.Models.CategoryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"list-group\">\r\n");
#nullable restore
#line 4 "C:\Users\EMRE-KESKINBICKI\Desktop\Keskin\NetBT\Abc\Abc.Northwind.Web\Views\Shared\Components\CategoryList\Default.cshtml"
     foreach (var category in Model.Categories)
    {
        var css = "list-group-item";
        if (category.CategoryId == Model.CurrentCategory)
        {
            css += " active";
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 299, "\"", 350, 2);
            WriteAttributeValue("", 306, "/product/index?category=", 306, 24, true);
#nullable restore
#line 11 "C:\Users\EMRE-KESKINBICKI\Desktop\Keskin\NetBT\Abc\Abc.Northwind.Web\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 330, category.CategoryId, 330, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 351, "\"", 363, 1);
#nullable restore
#line 11 "C:\Users\EMRE-KESKINBICKI\Desktop\Keskin\NetBT\Abc\Abc.Northwind.Web\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 359, css, 359, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "C:\Users\EMRE-KESKINBICKI\Desktop\Keskin\NetBT\Abc\Abc.Northwind.Web\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                       Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 12 "C:\Users\EMRE-KESKINBICKI\Desktop\Keskin\NetBT\Abc\Abc.Northwind.Web\Views\Shared\Components\CategoryList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abc.Northwind.Web.Models.CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
