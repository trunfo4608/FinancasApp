#pragma checksum "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2b9af94430e72a2eafec36abf34ae4f132586ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2b9af94430e72a2eafec36abf34ae4f132586ac", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinancasApp.Presentation.Models.AccountLoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Login.cshtml"
  
    //definindo o layout mestre desta página
    Layout = "~/Views/Shared/_AccountLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mt-5"">
    <div class=""col-md-4 offset-md-4"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""text-center"">
                    <h3>Acessar Sistema</h3>
                    <p>Entre com suas credenciais de acesso</p>
                </div>
                <hr />

");
#nullable restore
#line 19 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Login.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"mb-2\">\r\n                        <label>Email de acesso:</label>\r\n                        ");
#nullable restore
#line 23 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Login.cshtml"
                   Write(Html.TextBoxFor(model => model.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"text-danger\">\r\n                            ");
#nullable restore
#line 25 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Login.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"mb-2\">\r\n                        <label>Senha de acesso:</label>\r\n                        ");
#nullable restore
#line 31 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Login.cshtml"
                   Write(Html.PasswordFor(model => model.Senha, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"text-danger\">\r\n                            ");
#nullable restore
#line 33 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Login.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Senha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"mb-2 text-end\">\r\n                        <a href=\"/Account/ForgotPassword\">\r\n                            Esqueci minha senha!\r\n                        </a>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"mb-2 d-grid\">\r\n                        <input type=\"submit\" class=\"btn btn-primary\"\r\n                               value=\"Acessar Sistema\" />\r\n                    </div>\r\n");
            WriteLiteral(@"                    <div class=""mb-2 d-grid"">
                        <a href=""/Account/Register"" class=""btn btn-light"">
                            Não possui conta? <strong>Cadastre-se aqui!</strong>
                        </a>
                    </div>
");
#nullable restore
#line 53 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Login.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinancasApp.Presentation.Models.AccountLoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
