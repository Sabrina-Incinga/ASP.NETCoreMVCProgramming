#pragma checksum "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\GetByName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2b83ae992410bd1ec298f152665eb77e28a433a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receta_GetByName), @"mvc.1.0.view", @"/Views/Receta/GetByName.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2b83ae992410bd1ec298f152665eb77e28a433a", @"/Views/Receta/GetByName.cshtml")]
    #nullable restore
    public class Views_Receta_GetByName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaWebMisRecetas.Models.Receta>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\GetByName.cshtml"
  
    ViewData["Title"] = "Buscar por nombre autor";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"recetas\">\r\n    <h2>Lista de recetas de ");
#nullable restore
#line 9 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\GetByName.cshtml"
                       Write(Model.First().Autor.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\GetByName.cshtml"
                                                   Write(Model.First().Autor.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    \r\n    <ul>\r\n        <li>");
#nullable restore
#line 12 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\GetByName.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 13 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\GetByName.cshtml"
       Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 14 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\GetByName.cshtml"
       Write(Html.DisplayNameFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n");
#nullable restore
#line 16 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\GetByName.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul class=\"content\">\r\n            <li>");
#nullable restore
#line 19 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\GetByName.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 20 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\GetByName.cshtml"
           Write(Html.ActionLink(item.Titulo, "Details", "Receta", new{id=item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 21 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\GetByName.cshtml"
           Write(Html.DisplayFor(modelItem => item.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n");
#nullable restore
#line 23 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\GetByName.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</section>\r\n\r\n");
            DefineSection("SideBar", async() => {
                WriteLiteral("\r\n    <aside class=\"aside\">\r\n        <h4>");
#nullable restore
#line 29 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\GetByName.cshtml"
       Write(Html.ActionLink("Nueva receta", "Create", "Receta"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n        <h4> ");
#nullable restore
#line 30 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\GetByName.cshtml"
        Write(Html.ActionLink("Volver", "Index", "receta"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n\r\n    </aside>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemaWebMisRecetas.Models.Receta>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591