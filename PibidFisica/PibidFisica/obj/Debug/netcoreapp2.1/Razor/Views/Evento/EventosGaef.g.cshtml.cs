#pragma checksum "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosGaef.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "661b75aa635a67cafb5d0e8b5bf1b94e7fa93a59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evento_EventosGaef), @"mvc.1.0.view", @"/Views/Evento/EventosGaef.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Evento/EventosGaef.cshtml", typeof(AspNetCore.Views_Evento_EventosGaef))]
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
#line 1 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\_ViewImports.cshtml"
using PibidFisica;

#line default
#line hidden
#line 2 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\_ViewImports.cshtml"
using PibidFisica.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"661b75aa635a67cafb5d0e8b5bf1b94e7fa93a59", @"/Views/Evento/EventosGaef.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1f0c619f55a4cd716e5cc56d0b5122b7c93634b", @"/Views/_ViewImports.cshtml")]
    public class Views_Evento_EventosGaef : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.EventoModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosGaef.cshtml"
  
    ViewData["Title"] = "Index";
    int posicaoAtual = 0;
    int contadorItens = 0;
    int indice = 1;

#line default
#line hidden
            BeginContext(159, 172, true);
            WriteLiteral("\r\n\r\n\r\n<div align=\"center\">\r\n\r\n    <br />\r\n    <h2>\r\n        Nossas Participações em Eventos\r\n    </h2>\r\n\r\n</div>\r\n\r\n<br />\r\n<table class=\"table\">\r\n    <br />\r\n    <tbody>\r\n");
            EndContext();
#line 25 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosGaef.cshtml"
         for (int i = 0; i < (Model.Count() / 5) + 1; i++)
        {

#line default
#line hidden
            BeginContext(402, 48, true);
            WriteLiteral("            <tr style=\"white-space: pre-wrap\">\r\n");
            EndContext();
#line 28 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosGaef.cshtml"
                 foreach (var item in Model)
                {
                    indice++;

                    if (indice > posicaoAtual)
                    {
                        contadorItens++;

#line default
#line hidden
            BeginContext(661, 95, true);
            WriteLiteral("                        <td>\r\n                            <a style=\"height: 130pt;width: 150pt\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 756, "\"", 823, 1);
#line 36 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosGaef.cshtml"
WriteAttributeValue("", 763, Url.Action("Details", "Evento", new { id = item.IdEvento }), 763, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(824, 134, true);
            WriteLiteral(" class=\"btn btn-default btn-sm\">\r\n                                <img style=\"height: 110pt;width: 130pt\" title=\"Clique para ver mais\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 958, "\"", 982, 1);
#line 37 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosGaef.cshtml"
WriteAttributeValue("", 964, item.ImagemEvento, 964, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(983, 202, true);
            WriteLiteral(" /><br />\r\n                                <p style=\"white-space: nowrap;overflow: hidden;text-overflow: ellipsis;font-weight: bold;font-size: 10pt;color: #2e6da4\">\r\n                                    ");
            EndContext();
            BeginContext(1186, 41, false);
#line 39 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosGaef.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(1227, 105, true);
            WriteLiteral("\r\n                                </p>\r\n                            </a>\r\n                        </td>\r\n");
            EndContext();
#line 43 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosGaef.cshtml"
                    }

                    if (contadorItens == 5)
                    {
                        posicaoAtual = indice;
                        contadorItens = 0;
                        break;
                    }
                }

#line default
#line hidden
            BeginContext(1591, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 53 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosGaef.cshtml"
            indice = 1;
        }

#line default
#line hidden
            BeginContext(1646, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.EventoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
