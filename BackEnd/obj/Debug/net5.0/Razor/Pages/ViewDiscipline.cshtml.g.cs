#pragma checksum "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76b27a37b24f5a71d78476f01bc62e12acb992b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_ViewDiscipline), @"mvc.1.0.razor-page", @"/Pages/ViewDiscipline.cshtml")]
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
#line 2 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml"
using Server.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76b27a37b24f5a71d78476f01bc62e12acb992b8", @"/Pages/ViewDiscipline.cshtml")]
    public class Pages_ViewDiscipline : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml"
  
    Layout="_Layout";
    ViewData["Title"]="Discipline";

#line default
#line hidden
#nullable disable
            DefineSection("Style", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"Styles/Stil.css\">\r\n");
            }
            );
            WriteLiteral(@"<h1>Lista svih disciplina u bazi podataka</h1>
<table>
    <tr>
        <th>Naziv</th>
        <th>Lokacija</th>
        <th>Trenutni broj učesnika</th>
        <th>Maksimalni broj učesnika</th>
        <th>Napravi učesnika</th>
        <th>Pobednik</th>
        <th>Turnir</th>
        <th>Izmeni</th>
        <th>Obriši</th>
    </tr>
");
#nullable restore
#line 24 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml"
     for(int i=0; i < Model.Discipline.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml"
           Write(Model.Discipline[i].Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml"
           Write(Model.Discipline[i].Lokacija);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml"
           Write(Model.TrenutniBrojUcesnika[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml"
           Write(Model.Discipline[i].MaxUcesnici);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 845, "\"", 934, 4);
            WriteAttributeValue("", 852, "./CreateUcesnik?turnirID=", 852, 25, true);
#nullable restore
#line 31 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml"
WriteAttributeValue("", 877, Model.Turniri[i].ID, 877, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 897, "&disciplinaID=", 897, 14, true);
#nullable restore
#line 31 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml"
WriteAttributeValue("", 911, Model.Discipline[i].ID, 911, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Dodaj učesnika</a></td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml"
           Write(Model.VratiPobednika(i));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1026, "\"", 1123, 4);
            WriteAttributeValue("", 1033, "./ViewDisciplineTurnira?turnirID=", 1033, 33, true);
#nullable restore
#line 33 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml"
WriteAttributeValue("", 1066, Model.Turniri[i].ID, 1066, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1086, "&disciplinaID=", 1086, 14, true);
#nullable restore
#line 33 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml"
WriteAttributeValue("", 1100, Model.Discipline[i].ID, 1100, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml"
                                                                                                                Write(Model.VratiTurnir(i));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1175, "\"", 1267, 4);
            WriteAttributeValue("", 1182, "./UpdateDisciplina?turnirID=", 1182, 28, true);
#nullable restore
#line 34 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml"
WriteAttributeValue("", 1210, Model.Turniri[i].ID, 1210, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1230, "&disciplinaID=", 1230, 14, true);
#nullable restore
#line 34 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml"
WriteAttributeValue("", 1244, Model.Discipline[i].ID, 1244, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Izmeni</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1304, "\"", 1396, 4);
            WriteAttributeValue("", 1311, "./DeleteDisciplina?turnirID=", 1311, 28, true);
#nullable restore
#line 35 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml"
WriteAttributeValue("", 1339, Model.Turniri[i].ID, 1339, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1359, "&disciplinaID=", 1359, 14, true);
#nullable restore
#line 35 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml"
WriteAttributeValue("", 1373, Model.Discipline[i].ID, 1373, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Obriši</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\stefa\Documents\Faks\III godina\V semestar\Web Programiranje\Projekat (v1)\BackEnd\Pages\ViewDiscipline.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewDisciplineModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ViewDisciplineModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ViewDisciplineModel>)PageContext?.ViewData;
        public ViewDisciplineModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
