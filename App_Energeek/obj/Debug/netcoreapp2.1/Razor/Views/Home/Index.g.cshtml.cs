#pragma checksum "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77bbc01f29ff7af9ba23b3163e9f046d10d82788"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/_ViewImports.cshtml"
using App_Energeek;

#line default
#line hidden
#line 2 "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/_ViewImports.cshtml"
using App_Energeek.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77bbc01f29ff7af9ba23b3163e9f046d10d82788", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a227b8928ef5913f53da33cef37b90922a34b96f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<App_Energeek.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 77, true);
            WriteLiteral("\r\n<h1>Bienvenue sur Energeek</h1>\r\n<div>\r\n    <h2>Votre installation</h2>\r\n\r\n");
            EndContext();
            BeginContext(168, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 10 "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/Home/Index.cshtml"
     foreach (var element in Model)
    {

#line default
#line hidden
            BeginContext(212, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(224, 29, false);
#line 12 "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/Home/Index.cshtml"
      Write(Html.DisplayFor(m => element));

#line default
#line hidden
            EndContext();
            BeginContext(253, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 13 "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/Home/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(266, 39, true);
            WriteLiteral("</div>\r\n\r\n\r\n\r\n<div class=\"text-danger\">");
            EndContext();
            BeginContext(306, 15, false);
#line 18 "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/Home/Index.cshtml"
                    Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(321, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            BeginContext(332, 38, false);
#line 20 "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/Home/Index.cshtml"
Write(Html.Partial("Product", new Product()));

#line default
#line hidden
            EndContext();
            BeginContext(370, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 22 "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/Home/Index.cshtml"
 if (@ViewBag.Message != null)
{

#line default
#line hidden
            BeginContext(409, 89, true);
            WriteLiteral("    <script type=\"text/javascript\">\r\n            $(function () {\r\n                alert(\"");
            EndContext();
            BeginContext(499, 15, false);
#line 26 "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/Home/Index.cshtml"
                  Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(514, 36, true);
            WriteLiteral("\")\r\n            });\r\n    </script>\r\n");
            EndContext();
#line 29 "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/Home/Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<App_Energeek.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
