#pragma checksum "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/Home/Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0436dce90ebe4084b27ea3b633d59a94bb1d9bf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Product), @"mvc.1.0.view", @"/Views/Home/Product.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Product.cshtml", typeof(AspNetCore.Views_Home_Product))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0436dce90ebe4084b27ea3b633d59a94bb1d9bf2", @"/Views/Home/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a227b8928ef5913f53da33cef37b90922a34b96f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/Home/Product.cshtml"
  
    ViewData["Title"] = "Product";

#line default
#line hidden
            BeginContext(43, 33, true);
            WriteLiteral("\r\n<h2>Ajouter un produit</h2>\r\n\r\n");
            EndContext();
#line 8 "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/Home/Product.cshtml"
 using (@Html.BeginForm(null, null, FormMethod.Post, new { @class = "addProduct-form" }))

{

#line default
#line hidden
            BeginContext(187, 65, false);
#line 10 "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/Home/Product.cshtml"
Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(257, 87, false);
#line 12 "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/Home/Product.cshtml"
Write(Html.TextBoxFor(m => m.Name, new { @class = "addProduct-input", placeholder = "name" }));

#line default
#line hidden
            EndContext();
            BeginContext(349, 91, false);
#line 14 "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/Home/Product.cshtml"
Write(Html.TextBoxFor(m => m.Kwh_yr, new { @class = "addProduct-input", placeholder = "KWH/an" }));

#line default
#line hidden
            EndContext();
            BeginContext(442, 38, true);
            WriteLiteral("    <p>Génère de l\'electricité :</p>\r\n");
            EndContext();
            BeginContext(481, 110, false);
#line 16 "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/Home/Product.cshtml"
Write(Html.RadioButtonFor(m => m.Generating, "true", new { @class = "addProduct-input", placeholder = "last name" }));

#line default
#line hidden
            EndContext();
            BeginContext(609, 105, true);
            WriteLiteral("<div class=\"submit-container\">\r\n    <button type=\"submit\" class=\"login-button\">Ajouter</button>\r\n</div>\r\n");
            EndContext();
#line 28 "/Users/bayard/Desktop/ETNA/NET5/marcha_r/rendu/App_Energeek/App_Energeek/Views/Home/Product.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
