#pragma checksum "c:\TestASP.NET\Views\Beers\ViewBeer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6c34797e03d7e3e1adc0cd8b73f65744d2da1b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Beers_ViewBeer), @"mvc.1.0.view", @"/Views/Beers/ViewBeer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Beers/ViewBeer.cshtml", typeof(AspNetCore.Views_Beers_ViewBeer))]
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
#line 1 "c:\TestASP.NET\Views\_ViewImports.cshtml"
using TestASP.NET;

#line default
#line hidden
#line 2 "c:\TestASP.NET\Views\_ViewImports.cshtml"
using TestASP.NET.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6c34797e03d7e3e1adc0cd8b73f65744d2da1b6", @"/Views/Beers/ViewBeer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36f68af05012a8b0fa443111a4f12f071b7a213c", @"/Views/_ViewImports.cshtml")]
    public class Views_Beers_ViewBeer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Beers>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "c:\TestASP.NET\Views\Beers\ViewBeer.cshtml"
 foreach(var item in Model){
   

#line default
#line hidden
            BeginContext(64, 13, true);
            WriteLiteral("    <p>Name :");
            EndContext();
            BeginContext(78, 9, false);
#line 5 "c:\TestASP.NET\Views\Beers\ViewBeer.cshtml"
        Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(87, 22, true);
            WriteLiteral("</p>\r\n    <p>Calorie: ");
            EndContext();
            BeginContext(110, 12, false);
#line 6 "c:\TestASP.NET\Views\Beers\ViewBeer.cshtml"
           Write(item.Calorie);

#line default
#line hidden
            EndContext();
            BeginContext(122, 20, true);
            WriteLiteral("</p>\r\n    <p>Price: ");
            EndContext();
            BeginContext(143, 10, false);
#line 7 "c:\TestASP.NET\Views\Beers\ViewBeer.cshtml"
         Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(153, 39, true);
            WriteLiteral("</p>\r\n    <p>====================</p>\r\n");
            EndContext();
#line 9 "c:\TestASP.NET\Views\Beers\ViewBeer.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Beers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
