#pragma checksum "C:\Users\Aleksandar\source\repos\ZadatakProizvod\ZadatakProizvod\Views\ProizvodJson\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bc4b78a87932f2c370be2c7838809abb133e7b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProizvodJson_Index), @"mvc.1.0.view", @"/Views/ProizvodJson/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProizvodJson/Index.cshtml", typeof(AspNetCore.Views_ProizvodJson_Index))]
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
#line 1 "C:\Users\Aleksandar\source\repos\ZadatakProizvod\ZadatakProizvod\Views\_ViewImports.cshtml"
using ZadatakProizvod;

#line default
#line hidden
#line 2 "C:\Users\Aleksandar\source\repos\ZadatakProizvod\ZadatakProizvod\Views\_ViewImports.cshtml"
using ZadatakProizvod.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bc4b78a87932f2c370be2c7838809abb133e7b5", @"/Views/ProizvodJson/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a9b301f09b10adcf7929c9153f5a3893815ef58", @"/Views/_ViewImports.cshtml")]
    public class Views_ProizvodJson_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ZadatakProizvod.Models.ProizvodJson>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 92, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(150, 41, false);
#line 10 "C:\Users\Aleksandar\source\repos\ZadatakProizvod\ZadatakProizvod\Views\ProizvodJson\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Naziv));

#line default
#line hidden
            EndContext();
            BeginContext(191, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(247, 40, false);
#line 13 "C:\Users\Aleksandar\source\repos\ZadatakProizvod\ZadatakProizvod\Views\ProizvodJson\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(287, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(343, 46, false);
#line 16 "C:\Users\Aleksandar\source\repos\ZadatakProizvod\ZadatakProizvod\Views\ProizvodJson\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Kategorija));

#line default
#line hidden
            EndContext();
            BeginContext(389, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(445, 47, false);
#line 19 "C:\Users\Aleksandar\source\repos\ZadatakProizvod\ZadatakProizvod\Views\ProizvodJson\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Proizvodjac));

#line default
#line hidden
            EndContext();
            BeginContext(492, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(548, 45, false);
#line 22 "C:\Users\Aleksandar\source\repos\ZadatakProizvod\ZadatakProizvod\Views\ProizvodJson\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Dobavljac));

#line default
#line hidden
            EndContext();
            BeginContext(593, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(649, 40, false);
#line 25 "C:\Users\Aleksandar\source\repos\ZadatakProizvod\ZadatakProizvod\Views\ProizvodJson\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cena));

#line default
#line hidden
            EndContext();
            BeginContext(689, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\Aleksandar\source\repos\ZadatakProizvod\ZadatakProizvod\Views\ProizvodJson\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(807, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(856, 40, false);
#line 34 "C:\Users\Aleksandar\source\repos\ZadatakProizvod\ZadatakProizvod\Views\ProizvodJson\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Naziv));

#line default
#line hidden
            EndContext();
            BeginContext(896, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(952, 39, false);
#line 37 "C:\Users\Aleksandar\source\repos\ZadatakProizvod\ZadatakProizvod\Views\ProizvodJson\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(991, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1047, 45, false);
#line 40 "C:\Users\Aleksandar\source\repos\ZadatakProizvod\ZadatakProizvod\Views\ProizvodJson\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kategorija));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1148, 46, false);
#line 43 "C:\Users\Aleksandar\source\repos\ZadatakProizvod\ZadatakProizvod\Views\ProizvodJson\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Proizvodjac));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1250, 44, false);
#line 46 "C:\Users\Aleksandar\source\repos\ZadatakProizvod\ZadatakProizvod\Views\ProizvodJson\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dobavljac));

#line default
#line hidden
            EndContext();
            BeginContext(1294, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1350, 39, false);
#line 49 "C:\Users\Aleksandar\source\repos\ZadatakProizvod\ZadatakProizvod\Views\ProizvodJson\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cena));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 46, true);
            WriteLiteral("\r\n            </td>\r\n        \r\n        </tr>\r\n");
            EndContext();
#line 53 "C:\Users\Aleksandar\source\repos\ZadatakProizvod\ZadatakProizvod\Views\ProizvodJson\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1438, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ZadatakProizvod.Models.ProizvodJson>> Html { get; private set; }
    }
}
#pragma warning restore 1591