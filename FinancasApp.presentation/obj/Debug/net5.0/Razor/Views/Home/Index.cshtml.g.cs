#pragma checksum "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91326eb99c94c3b2e31787dfa15780737a5381b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91326eb99c94c3b2e31787dfa15780737a5381b7", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinancasApp.Presentation.Models.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container mt-4\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4>Dashboard Principal</h4>\r\n            <p>Seja bem vindo ao sistema de controle financeiro.</p>\r\n\r\n");
#nullable restore
#line 13 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Home\Index.cshtml"
             using (Html.BeginForm())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row mb-2\">\r\n                    <div class=\"col-md-3\">\r\n                        <label>Data de início:</label>\r\n                        ");
#nullable restore
#line 18 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(model => model.DataInicio, "{0:yyyy-MM-dd}",
                            new { @class = "form-control", @type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"text-danger\">\r\n                            ");
#nullable restore
#line 21 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Home\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.DataInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-3\">\r\n                        <label>Data de término:</label>\r\n                        ");
#nullable restore
#line 26 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(model => model.DataFim, "{0:yyyy-MM-dd}",
                            new { @class = "form-control", @type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"text-danger\">\r\n                            ");
#nullable restore
#line 29 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Home\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.DataFim));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-md-3"">
                        <input type=""submit"" class=""btn btn-success mt-4"" value=""Pesquisar contas"" />
                    </div>
                </div>
");
#nullable restore
#line 36 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class=""row mt-2"">
                <div class=""col"">
                    <div id=""donutChart""></div>
                </div>
                <div class=""col"">
                    <div id=""columnChart""></div>
                </div>
            </div>

        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n    <script src=\"https://code.highcharts.com/highcharts.js\"></script>\r\n\r\n    <script>\r\n        var donutData = [];\r\n        var columnData = { categories: [], data: [] }\r\n    </script>\r\n\r\n");
#nullable restore
#line 60 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Home\Index.cshtml"
     foreach (var item in Model.DonutChart)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n            donutData.push({\r\n                name: \'");
#nullable restore
#line 64 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Home\Index.cshtml"
                  Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                y: ");
#nullable restore
#line 65 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Home\Index.cshtml"
              Write(item.Data);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            })\r\n        </script>\r\n");
#nullable restore
#line 68 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 70 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Home\Index.cshtml"
     foreach (var item in Model.ColumnChart)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n            columnData.categories.push(\'");
#nullable restore
#line 73 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Home\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n            columnData.data.push(");
#nullable restore
#line 74 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Home\Index.cshtml"
                            Write(item.Data);

#line default
#line hidden
#nullable disable
                WriteLiteral(");\r\n        </script>\r\n");
#nullable restore
#line 76 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script>

        // Configuração do primeiro gráfico (donut)
        Highcharts.chart('donutChart', {
            chart: {
                type: 'pie',
            },
            title: {
                text: 'Comparativo de Contas a Pagar e Contas a Receber'
            },
            plotOptions: {
                pie: {
                    innerSize: '50%',
                    dataLabels: {
                        enabled: true,
                        format: '{point.name}: {point.percentage:.1f}%'
                    }
                }
            },
            series: [{
                name: 'Valor',
                data: donutData
            }]
        });

        // Configuração do segundo gráfico (colunas)
        Highcharts.chart('columnChart', {
            chart: {
                type: 'column'
            },
            title: {
                text: 'Total de Contas por Categoria'
            },
            xAxis: {
                categories: colu");
                WriteLiteral(@"mnData.categories
            },
            yAxis: {
                title: {
                    text: 'Valor'
                }
            },
            series: [{
                name: 'Valor',
                data: columnData.data
            }]
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinancasApp.Presentation.Models.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
