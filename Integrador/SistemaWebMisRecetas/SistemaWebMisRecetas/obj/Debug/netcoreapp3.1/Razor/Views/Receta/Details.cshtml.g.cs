#pragma checksum "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01f1d907f2a030be181a2f76e1e1697d9315224e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receta_Details), @"mvc.1.0.view", @"/Views/Receta/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01f1d907f2a030be181a2f76e1e1697d9315224e", @"/Views/Receta/Details.cshtml")]
    #nullable restore
    public class Views_Receta_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaWebMisRecetas.Models.Receta>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
  
    ViewData["Title"] = "Detalle receta";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section>\r\n    <h2>Detalles de: ");
#nullable restore
#line 8 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
                Write(Model.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <article>\r\n        <p>\r\n            ");
#nullable restore
#line 11 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral(": \r\n            ");
#nullable restore
#line 12 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
       Write(Html.DisplayFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            ");
#nullable restore
#line 15 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ingredientes));

#line default
#line hidden
#nullable disable
            WriteLiteral(": \r\n            ");
#nullable restore
#line 16 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ingredientes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            ");
#nullable restore
#line 19 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Instrucciones));

#line default
#line hidden
#nullable disable
            WriteLiteral(": \r\n            ");
#nullable restore
#line 20 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
       Write(Html.DisplayFor(model => model.Instrucciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            ");
#nullable restore
#line 23 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Autor.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(": \r\n            ");
#nullable restore
#line 24 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
       Write(Html.DisplayFor(model => model.Autor.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </article>\r\n    ");
#nullable restore
#line 27 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.ActionLink("Volver", "Index", "receta"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</section>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaWebMisRecetas.Models.Receta> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591