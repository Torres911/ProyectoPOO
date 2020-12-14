#pragma checksum "D:\Universidad\Semestre V\Programacion Orientada a Objetos\Proyecto\ProyectoPOO\AgraMarket\Views\User\ClientePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2f55c9402a29118cb7eea226a1af778b3a84ee8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ClientePage), @"mvc.1.0.view", @"/Views/User/ClientePage.cshtml")]
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
#line 1 "D:\Universidad\Semestre V\Programacion Orientada a Objetos\Proyecto\ProyectoPOO\AgraMarket\Views\_ViewImports.cshtml"
using AgraMarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Universidad\Semestre V\Programacion Orientada a Objetos\Proyecto\ProyectoPOO\AgraMarket\Views\_ViewImports.cshtml"
using AgraMarket.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2f55c9402a29118cb7eea226a1af778b3a84ee8", @"/Views/User/ClientePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b75ba864ad8694fb66c2ba31060b35f7d702e703", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ClientePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AgraMarket.Models.UsuarioModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f55c9402a29118cb7eea226a1af778b3a84ee83416", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>Cliente</title>
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
    <link rel=""canonical"" href=""https://getbootstrap.com/docs/4.0/examples/jumbotron/"">
    <link rel=""stylesheet"" href=""wwwroot/css/HomeClienteStyle.css"">
  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f55c9402a29118cb7eea226a1af778b3a84ee84835", async() => {
                WriteLiteral(@"
  <!--<form asp-action=""VerificarUsuario"" method=""GET"" asp-controller=""User"">-->
    <main role=""main"">
      <div class=""jumbotron"">
        <div class=""container"">
          <h1 class=""display-3"">Bienvenido,</h1>
          <p>Este es el lobby de su cuenta, aqui podra disfrutar de los mejores productos del campo. No esperes más para hacer tus pedidos hoy.</p>
        </div>
      </div>

      <div class=""container"">
        <div class=""row"">
          <div class=""col-6"">
            <h2>Navegar la tienda</h2>
            <p>Mira todos los productos disponibles y compra todo lo que se le antoje en AgraMarket.</p>
            <p><a class=""btn btn-secondary"" href=""#"" role=""button"">Ver productos &raquo;</a></p>
          </div>
          <div class=""col-6"">
            <h2>Gestionar cuenta</h2>
            <p>Aqui podrás acceder a los detalles de tu cuenta y poder cambiarlos a tu gusto.</p>
            <p><a class=""btn btn-secondary"" href=""#"" role=""button"">Ver detalles &raquo;</a></p>
    ");
                WriteLiteral(@"      </div>
        </div>
        <hr>
      </div> 
      <div class=""container"">
        <div class=""row"">
           <div class=""col-6"">
            <h2>Gestionar pago</h2>
            <p>Aqui podrás acceder a tu información de pago y recargar directamente dinero a tu tarjeta.</p>
            <p><a class=""btn btn-secondary"" href=""#"" role=""button"">Ver detalles &raquo;</a></p>
          </div>
          <div class=""col-6"">
            <h2>Cerrar sesión</h2>
            <p>Si necesitas cambiar de cuenta o crear un nuevo usuario. Regresa a la pagina principal aqui.</p>
            <p><a class=""btn btn-secondary"" href=""#"" role=""button"">Cerrar sesión &raquo;</a></p>
          </div>
        </div>
       
        <hr>
      </div> 
    </main>
    <!--</form>-->
  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AgraMarket.Models.UsuarioModel> Html { get; private set; }
    }
}
#pragma warning restore 1591