#pragma checksum "C:\Users\Meu Computador\source\repos\Zap\Zap\Views\Home\Conversacao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "281ba68adb326946a00798b915350d7c14915552"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Conversacao), @"mvc.1.0.view", @"/Views/Home/Conversacao.cshtml")]
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
#line 1 "C:\Users\Meu Computador\source\repos\Zap\Zap\Views\_ViewImports.cshtml"
using Zap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Meu Computador\source\repos\Zap\Zap\Views\_ViewImports.cshtml"
using Zap.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"281ba68adb326946a00798b915350d7c14915552", @"/Views/Home/Conversacao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bffed7f27eb60d110e253229cd6b810edf4c8305", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Conversacao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("style", async() => {
                WriteLiteral("\r\n    <style type=\"text/css\">\r\n        body {\r\n            background-color: #F0F0F0;\r\n        }\r\n        .container-button {\r\n            display: none;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral(@"<div class=""sidenav"">
    <div class=""container-logo"">
        <img src=""/imagem/logonew.png"" style=""width: 30%;"" />
        <a href=""#"" id=""btnSair"">Sair</a>
    </div>
    <div id=""users"">
        
    </div>

</div>

<!-- Page content -->
<div class=""main"" id=""tela-conversacao"">
    <div class=""container-messages"">
    

    </div>

    <div class=""container-button"">
        <input type=""text"" placeholder=""Mensagem"" id=""mensagem"" />
        <button class=""btn-send"" id=""btnEnviar"" ></button>
    </div>

</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
