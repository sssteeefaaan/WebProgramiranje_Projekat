#pragma checksum "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\UpdateUcesnik.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a06fde97adf6fc0f6dfe7563191a18b28216e88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_UpdateUcesnik), @"mvc.1.0.razor-page", @"/Pages/UpdateUcesnik.cshtml")]
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
#nullable restore
#line 2 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\UpdateUcesnik.cshtml"
using Server.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a06fde97adf6fc0f6dfe7563191a18b28216e88", @"/Pages/UpdateUcesnik.cshtml")]
    public class Pages_UpdateUcesnik : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\UpdateUcesnik.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Ažurirajte učesnika";

#line default
#line hidden
#nullable disable
            DefineSection("Style", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"Styles/FormStil.css\">\r\n");
            }
            );
            WriteLiteral("<div class=\"Container\">\r\n    <h1>Unesite podatke o učesniku</h1>\r\n    <form method=\"POST\" query=\"Hello\">\r\n        ");
#nullable restore
#line 14 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\UpdateUcesnik.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <p><input type=\"hidden\" name=\"GoBack\"");
            BeginWriteAttribute("value", " value=\"", 396, "\"", 417, 1);
#nullable restore
#line 15 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\UpdateUcesnik.cshtml"
WriteAttributeValue("", 404, Model.GoBack, 404, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></p>\r\n        <p><input type=\"text\" name=\"Ucesnik.Ime\"");
            BeginWriteAttribute("value", " value=\"", 473, "\"", 499, 1);
#nullable restore
#line 16 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\UpdateUcesnik.cshtml"
WriteAttributeValue("", 481, Model.Ucesnik.Ime, 481, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></p>\r\n        <p><input type=\"text\" name=\"Ucesnik.Prezime\"");
            BeginWriteAttribute("value", " value=\"", 559, "\"", 589, 1);
#nullable restore
#line 17 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\UpdateUcesnik.cshtml"
WriteAttributeValue("", 567, Model.Ucesnik.Prezime, 567, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></p>\r\n        <p><input type=\"number\" name=\"Ucesnik.Brzina\"");
            BeginWriteAttribute("value", " value=\"", 650, "\"", 679, 1);
#nullable restore
#line 18 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\UpdateUcesnik.cshtml"
WriteAttributeValue("", 658, Model.Ucesnik.Brzina, 658, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></p>\r\n        <p><input type=\"submit\" value=\"Izmenite učesnika\"></p>\r\n    </form>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UpdateUcesnikModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UpdateUcesnikModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UpdateUcesnikModel>)PageContext?.ViewData;
        public UpdateUcesnikModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
