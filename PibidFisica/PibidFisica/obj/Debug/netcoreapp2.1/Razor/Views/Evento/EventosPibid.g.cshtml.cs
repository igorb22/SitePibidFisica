#pragma checksum "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosPibid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbd04817f7bc5b5e48579a042fb832db645cd31e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evento_EventosPibid), @"mvc.1.0.view", @"/Views/Evento/EventosPibid.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Evento/EventosPibid.cshtml", typeof(AspNetCore.Views_Evento_EventosPibid))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbd04817f7bc5b5e48579a042fb832db645cd31e", @"/Views/Evento/EventosPibid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1f0c619f55a4cd716e5cc56d0b5122b7c93634b", @"/Views/_ViewImports.cshtml")]
    public class Views_Evento_EventosPibid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.EventoModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pibid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Trabalhos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TrabalhosPibid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosPibid.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(83, 261, true);
            WriteLiteral(@"
<table style=""width: 100%"">
    <tr>
        <td>
            <h2>Participações em Eventos do Pibid</h2>
        </td>

        <td>
            <div style=""text-align: right"">
                <div class=""btn-group"" role=""group"">
                    ");
            EndContext();
            BeginContext(344, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2a1e6b5c48a4094935c87f13be96e82", async() => {
                BeginContext(424, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(432, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(454, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddd9d92b38994418a4980258ce6e97ab", async() => {
                BeginContext(549, 16, true);
                WriteLiteral("Nossos Trabalhos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(569, 92, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </td>\r\n    </tr>\r\n</table>\r\n\r\n<br />\r\n");
            EndContext();
#line 25 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosPibid.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
            BeginContext(690, 70, true);
            WriteLiteral("    <p style=\"color: orangered\">Não há participações em eventos.</p>\r\n");
            EndContext();
#line 28 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosPibid.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(772, 26, true);
            WriteLiteral("    <div align=\"center\">\r\n");
            EndContext();
#line 32 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosPibid.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(847, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 861, "\"", 928, 1);
#line 34 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosPibid.cshtml"
WriteAttributeValue("", 868, Url.Action("Details", "Evento", new { id = item.IdEvento }), 868, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(929, 134, true);
            WriteLiteral(" class=\"btn btn-default btn-sm estiloCardViewItem\">\r\n                <img style=\"height: 90%;width: 100%\" title=\"Clique para ver mais\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1063, "\"", 1087, 1);
#line 35 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosPibid.cshtml"
WriteAttributeValue("", 1069, item.ImagemEvento, 1069, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1088, 156, true);
            WriteLiteral(" /><br />\r\n                <p style=\"white-space: nowrap;overflow: hidden;text-overflow: ellipsis;font-weight: bold;font-size: 10pt;\">\r\n                    ");
            EndContext();
            BeginContext(1245, 41, false);
#line 37 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosPibid.cshtml"
               Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(1286, 42, true);
            WriteLiteral("\r\n                </p>\r\n            </a>\r\n");
            EndContext();
#line 40 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosPibid.cshtml"
        }

#line default
#line hidden
            BeginContext(1339, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 42 "C:\Users\igorb\Documents\SitePibidFisica\PibidFisica\PibidFisica\Views\Evento\EventosPibid.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.EventoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
