#pragma checksum "C:\git\pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time2-agd\WebAPIAgendAI\WebAPIAgendAI\Views\Funcionarios\Agendamentos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2999d7f7db1115358b955ef218c142f4e0f9526"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionarios_Agendamentos), @"mvc.1.0.view", @"/Views/Funcionarios/Agendamentos.cshtml")]
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
#line 1 "C:\git\pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time2-agd\WebAPIAgendAI\WebAPIAgendAI\Views\_ViewImports.cshtml"
using WebAPIAgendAI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time2-agd\WebAPIAgendAI\WebAPIAgendAI\Views\_ViewImports.cshtml"
using WebAPIAgendAI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2999d7f7db1115358b955ef218c142f4e0f9526", @"/Views/Funcionarios/Agendamentos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aad0e853abed1a9a07774ad13e7931f43d99ae6", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionarios_Agendamentos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAPIAgendAI.Models.Funcionario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\git\pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time2-agd\WebAPIAgendAI\WebAPIAgendAI\Views\Funcionarios\Agendamentos.cshtml"
   ViewData["Title"] = "Agendamentos"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Funcionario: ");
#nullable restore
#line 5 "C:\git\pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time2-agd\WebAPIAgendAI\WebAPIAgendAI\Views\Funcionarios\Agendamentos.cshtml"
            Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

<div>
    <h4>Agendamentos</h4>
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Data
                </th>
                <th>
                    Quantidade
                </th>
                <th>
                    Sala
                </th>
                <th>
                    Tipo
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 27 "C:\git\pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time2-agd\WebAPIAgendAI\WebAPIAgendAI\Views\Funcionarios\Agendamentos.cshtml"
             foreach (var item in Model.Agendamentos.OrderByDescending(c => c.Data))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 31 "C:\git\pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time2-agd\WebAPIAgendAI\WebAPIAgendAI\Views\Funcionarios\Agendamentos.cshtml"
   Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 34 "C:\git\pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time2-agd\WebAPIAgendAI\WebAPIAgendAI\Views\Funcionarios\Agendamentos.cshtml"
   Write(Html.DisplayFor(modelItem => item.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 37 "C:\git\pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time2-agd\WebAPIAgendAI\WebAPIAgendAI\Views\Funcionarios\Agendamentos.cshtml"
   Write(Html.DisplayFor(modelItem => item.Sala));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 40 "C:\git\pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time2-agd\WebAPIAgendAI\WebAPIAgendAI\Views\Funcionarios\Agendamentos.cshtml"
   Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n</tr>");
#nullable restore
#line 42 "C:\git\pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time2-agd\WebAPIAgendAI\WebAPIAgendAI\Views\Funcionarios\Agendamentos.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAPIAgendAI.Models.Funcionario> Html { get; private set; }
    }
}
#pragma warning restore 1591
