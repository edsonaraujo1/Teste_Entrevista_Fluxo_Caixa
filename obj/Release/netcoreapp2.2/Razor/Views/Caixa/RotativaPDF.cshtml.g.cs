#pragma checksum "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe282e580388ecd68c6028e1a78ae0b4207557ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Caixa_RotativaPDF), @"mvc.1.0.view", @"/Views/Caixa/RotativaPDF.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Caixa/RotativaPDF.cshtml", typeof(AspNetCore.Views_Caixa_RotativaPDF))]
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
#line 1 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\_ViewImports.cshtml"
using WebAppEdson;

#line default
#line hidden
#line 2 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\_ViewImports.cshtml"
using WebAppEdson.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe282e580388ecd68c6028e1a78ae0b4207557ec", @"/Views/Caixa/RotativaPDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f170f7a72498def08ff400b8cd480097124a3de", @"/Views/_ViewImports.cshtml")]
    public class Views_Caixa_RotativaPDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAppEdson.Models.Caixa>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
  
    Layout = null;
    ViewData["Title"] = "Index";
    string style = "";
    double entrada = 0;
    double saida = 0;
    double saldo = 0;

#line default
#line hidden
            BeginContext(204, 126, true);
            WriteLiteral("\r\n<h1>Relat??rio de Fluxo de Caixa</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(331, 40, false);
#line 18 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
           Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(371, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(427, 40, false);
#line 21 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(467, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(523, 45, false);
#line 24 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(568, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(624, 41, false);
#line 27 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
           Write(Html.DisplayNameFor(model => model.Forma));

#line default
#line hidden
            EndContext();
            BeginContext(665, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(721, 40, false);
#line 30 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(761, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(817, 41, false);
#line 33 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(858, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 39 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
         foreach (var item in Model)
        {

            

#line default
#line hidden
#line 42 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
             if (item.Tipo == "CREDITO")
            {
                style = "color: green";
                entrada = entrada + item.Valor;
            }
            else
            {
                style = "color: red";
                saida = saida + item.Valor;
            }

#line default
#line hidden
            BeginContext(1293, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1304, "\"", 1318, 1);
#line 54 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
WriteAttributeValue("", 1312, style, 1312, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1319, 37, true);
            WriteLiteral(">\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1357, 39, false);
#line 56 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
           Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
            EndContext();
            BeginContext(1396, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1452, 39, false);
#line 59 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1491, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1547, 44, false);
#line 62 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1591, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1647, 40, false);
#line 65 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
           Write(Html.DisplayFor(modelItem => item.Forma));

#line default
#line hidden
            EndContext();
            BeginContext(1687, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1743, 39, false);
#line 68 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(1782, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1838, 40, false);
#line 71 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
           Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1878, 38, true);
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 75 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
        }

#line default
#line hidden
            BeginContext(1927, 135, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n<hr />\r\n<div>\r\n    <table>\r\n        <tr>\r\n            <td style=\"color:green\">\r\n                Entrada: (+) ");
            EndContext();
            BeginContext(2063, 22, false);
#line 84 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
                        Write(entrada.ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(2085, 116, true);
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n        <tr>\r\n            <td style=\"color:red;\">\r\n                Saida: (-) ");
            EndContext();
            BeginContext(2202, 20, false);
#line 90 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
                      Write(saida.ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(2222, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 93 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
          
            saldo = (saida - entrada);
        

#line default
#line hidden
            BeginContext(2321, 80, true);
            WriteLiteral("        <tr>\r\n            <td style=\"color:black;\">\r\n                Saldo: (=) ");
            EndContext();
            BeginContext(2402, 20, false);
#line 98 "D:\BACKUP_DRIVE_E\Desenv5\WebAppEdson\WebAppEdson\Views\Caixa\RotativaPDF.cshtml"
                      Write(saldo.ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(2422, 56, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAppEdson.Models.Caixa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
