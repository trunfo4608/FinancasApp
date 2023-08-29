#pragma checksum "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12562d31f1cee0ac6575974ce90306047cf83d64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12562d31f1cee0ac6575974ce90306047cf83d64", @"/Views/Account/Register.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinancasApp.presentation.Models.AccountRegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Register.cshtml"
  
    //definindo o layout mestre desta página
    Layout = "~/Views/Shared/_AccountLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mt-2"">
    <div class=""col-md-4 offset-md-4"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""text-center"">
                    <h3>Criar conta de usuário.</h3>
                    <p>Preencha os campos para criar sua conta de acesso ao sistema.</p>
                </div>
                <hr />

");
#nullable restore
#line 19 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Register.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"mb-2\">\r\n                        <label>Nome do usuário:</label>\r\n                        ");
#nullable restore
#line 23 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Register.cshtml"
                   Write(Html.TextBoxFor(model => model.Nome, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"text-danger\">\r\n                            ");
#nullable restore
#line 25 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Register.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"mb-2\">\r\n                        <label>Email de acesso:</label>\r\n                        ");
#nullable restore
#line 31 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Register.cshtml"
                   Write(Html.TextBoxFor(model => model.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"text-danger\">\r\n                            ");
#nullable restore
#line 33 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Register.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"mb-2\">\r\n                        <label>Senha de acesso:</label>\r\n                        ");
#nullable restore
#line 39 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Register.cshtml"
                   Write(Html.PasswordFor(model => model.Senha, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"text-danger\">\r\n                            ");
#nullable restore
#line 41 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Register.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Senha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"mb-2\">\r\n                        <label>Confirme a sua senha:</label>\r\n                        ");
#nullable restore
#line 47 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Register.cshtml"
                   Write(Html.PasswordFor(model => model.SenhaConfirmacao, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"text-danger\">\r\n                            ");
#nullable restore
#line 49 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Register.cshtml"
                       Write(Html.ValidationMessageFor(model => model.SenhaConfirmacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"mb-2 d-grid\">\r\n                        <input type=\"submit\" class=\"btn btn-primary\"\r\n                               value=\"Realizar Cadastro\" />\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"mb-2 d-grid\">\r\n                        <a href=\"/Account/Login\" class=\"btn btn-light\">\r\n                            Já possui conta? <strong>Acesse aqui!</strong>\r\n                        </a>\r\n                    </div>\r\n");
#nullable restore
#line 63 "C:\Projetos C_Sharp\FinancasApp\FinancasApp.presentation\Views\Account\Register.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinancasApp.presentation.Models.AccountRegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
