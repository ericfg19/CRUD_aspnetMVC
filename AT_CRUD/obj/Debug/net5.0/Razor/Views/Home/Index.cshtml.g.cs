#pragma checksum "C:\Users\EricFG\Documents\SAFE_ZONE\Trabalhos_InfNet\Bloco Desenvolvimento .NET\Fundamentos ASP.NET\AT_CRUD_AMIGOS\AT_CRUD\AT_CRUD\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "889718957c3bdd2781176d1e029f3fd34df7bacf"
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
#nullable restore
#line 1 "C:\Users\EricFG\Documents\SAFE_ZONE\Trabalhos_InfNet\Bloco Desenvolvimento .NET\Fundamentos ASP.NET\AT_CRUD_AMIGOS\AT_CRUD\AT_CRUD\Views\_ViewImports.cshtml"
using AT_CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EricFG\Documents\SAFE_ZONE\Trabalhos_InfNet\Bloco Desenvolvimento .NET\Fundamentos ASP.NET\AT_CRUD_AMIGOS\AT_CRUD\AT_CRUD\Views\_ViewImports.cshtml"
using AT_CRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"889718957c3bdd2781176d1e029f3fd34df7bacf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1c21d13443eef816e7f3425b81702f5779fd0b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AT_CRUD.Models.AniversarianteViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\EricFG\Documents\SAFE_ZONE\Trabalhos_InfNet\Bloco Desenvolvimento .NET\Fundamentos ASP.NET\AT_CRUD_AMIGOS\AT_CRUD\AT_CRUD\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h2>Bem-vindo</h2>
    <h1 class=""display-4"">CRUD - Cadastro de Amigos</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>

</div>
<div class=""align-content-lg-between"">
    <div class=""text-center"">
        <p>???? Aniversariante do dia ????</p>
        <p>##</p>
        <table class=""table"">
");
#nullable restore
#line 18 "C:\Users\EricFG\Documents\SAFE_ZONE\Trabalhos_InfNet\Bloco Desenvolvimento .NET\Fundamentos ASP.NET\AT_CRUD_AMIGOS\AT_CRUD\AT_CRUD\Views\Home\Index.cshtml"
             foreach (var item in Model.Aniversariantes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 22 "C:\Users\EricFG\Documents\SAFE_ZONE\Trabalhos_InfNet\Bloco Desenvolvimento .NET\Fundamentos ASP.NET\AT_CRUD_AMIGOS\AT_CRUD\AT_CRUD\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 25 "C:\Users\EricFG\Documents\SAFE_ZONE\Trabalhos_InfNet\Bloco Desenvolvimento .NET\Fundamentos ASP.NET\AT_CRUD_AMIGOS\AT_CRUD\AT_CRUD\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SobreNome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 28 "C:\Users\EricFG\Documents\SAFE_ZONE\Trabalhos_InfNet\Bloco Desenvolvimento .NET\Fundamentos ASP.NET\AT_CRUD_AMIGOS\AT_CRUD\AT_CRUD\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Aniversario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                </tr>\r\n");
#nullable restore
#line 32 "C:\Users\EricFG\Documents\SAFE_ZONE\Trabalhos_InfNet\Bloco Desenvolvimento .NET\Fundamentos ASP.NET\AT_CRUD_AMIGOS\AT_CRUD\AT_CRUD\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n        <hr />\r\n        <p>Pr??ximos aniversariantes:</p>\r\n\r\n        <table class=\"table\">\r\n");
#nullable restore
#line 38 "C:\Users\EricFG\Documents\SAFE_ZONE\Trabalhos_InfNet\Bloco Desenvolvimento .NET\Fundamentos ASP.NET\AT_CRUD_AMIGOS\AT_CRUD\AT_CRUD\Views\Home\Index.cshtml"
             foreach (var item in Model.ProximosAniversariantes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "C:\Users\EricFG\Documents\SAFE_ZONE\Trabalhos_InfNet\Bloco Desenvolvimento .NET\Fundamentos ASP.NET\AT_CRUD_AMIGOS\AT_CRUD\AT_CRUD\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 45 "C:\Users\EricFG\Documents\SAFE_ZONE\Trabalhos_InfNet\Bloco Desenvolvimento .NET\Fundamentos ASP.NET\AT_CRUD_AMIGOS\AT_CRUD\AT_CRUD\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SobreNome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 48 "C:\Users\EricFG\Documents\SAFE_ZONE\Trabalhos_InfNet\Bloco Desenvolvimento .NET\Fundamentos ASP.NET\AT_CRUD_AMIGOS\AT_CRUD\AT_CRUD\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Aniversario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                </tr>\r\n");
#nullable restore
#line 52 "C:\Users\EricFG\Documents\SAFE_ZONE\Trabalhos_InfNet\Bloco Desenvolvimento .NET\Fundamentos ASP.NET\AT_CRUD_AMIGOS\AT_CRUD\AT_CRUD\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AT_CRUD.Models.AniversarianteViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
