#pragma checksum "C:\Users\EMRE-KESKINBICKI\Desktop\Keskin\NetBT\Abc\Abc.Northwind.Web\Views\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d513654be8ab93524556815b4141d80d83777d14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__Layout), @"mvc.1.0.view", @"/Views/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d513654be8ab93524556815b4141d80d83777d14", @"/Views/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9e47e9240df53585b7cbfc3b2ab7e57e7e49e77", @"/Views/_ViewImports.cshtml")]
    public class Views__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d513654be8ab93524556815b4141d80d83777d142873", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
#nullable restore
#line 6 "C:\Users\EMRE-KESKINBICKI\Desktop\Keskin\NetBT\Abc\Abc.Northwind.Web\Views\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <link href=""\node_modules\bootstrap\dist\css\bootstrap.css"" rel=""stylesheet"" />
    <script src=""\node_modules\jquery\dist\jquery.min.js""></script>
    <script src=""\node_modules\bootstrap\dist\js\bootstrap.js""></script>
    <script src=""\node_modules\jquery-validation\dist\jquery.validate.js""></script>
    <script src=""\node_modules\jquery-validation-unobtrusive\dist\jquery.validate.unobtrusive.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d513654be8ab93524556815b4141d80d83777d144594", async() => {
                WriteLiteral(@"
    <div class=""col-md-12"">
        <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
            <a class=""navbar-brand"" href=""/Admin/Index"">Northwind</a>
            <button class=""navbar-toggler"" t~ype=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>

            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""#"">Home <span class=""sr-only"">(current)</span></a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">Link</a>
                    </li>
                </ul>
                <div class=""nav-item dropdown"">
                    <a class=""nav-link drop");
                WriteLiteral("down-toggle\" href=\"#\" id=\"navbarDropdown\" role=\"button\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                        Dropdown\r\n                    </a>\r\n                    ");
#nullable restore
#line 34 "C:\Users\EMRE-KESKINBICKI\Desktop\Keskin\NetBT\Abc\Abc.Northwind.Web\Views\_Layout.cshtml"
               Write(await Component.InvokeAsync("CartSummary"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </nav>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\">\r\n            ");
#nullable restore
#line 41 "C:\Users\EMRE-KESKINBICKI\Desktop\Keskin\NetBT\Abc\Abc.Northwind.Web\Views\_Layout.cshtml"
       Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n");
#nullable restore
#line 44 "C:\Users\EMRE-KESKINBICKI\Desktop\Keskin\NetBT\Abc\Abc.Northwind.Web\Views\_Layout.cshtml"
             if(TempData["message"] != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"alert alert-info\" role=\"alert\">");
#nullable restore
#line 46 "C:\Users\EMRE-KESKINBICKI\Desktop\Keskin\NetBT\Abc\Abc.Northwind.Web\Views\_Layout.cshtml"
                                                      Write(TempData["message"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 47 "C:\Users\EMRE-KESKINBICKI\Desktop\Keskin\NetBT\Abc\Abc.Northwind.Web\Views\_Layout.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
#nullable restore
#line 48 "C:\Users\EMRE-KESKINBICKI\Desktop\Keskin\NetBT\Abc\Abc.Northwind.Web\Views\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-md-12\">\r\n        Footer\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591