#pragma checksum "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5eade7006de294b7bcb28c948ed9e94f8551b97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receta_Edit), @"mvc.1.0.view", @"/Views/Receta/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5eade7006de294b7bcb28c948ed9e94f8551b97", @"/Views/Receta/Edit.cshtml")]
    #nullable restore
    public class Views_Receta_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaWebMisRecetas.Models.Receta>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
  
    ViewData["Title"] = "Editar receta";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Modificar Receta</h2>\r\n\r\n");
#nullable restore
#line 10 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
 using(Html.BeginForm("Edit", "receta", FormMethod.Post, new { @class = "createForm" })){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
#nullable restore
#line 12 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.LabelFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.TextBoxFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        ");
#nullable restore
#line 17 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.LabelFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 18 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.TextBoxFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 19 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        ");
#nullable restore
#line 22 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.LabelFor(model => model.Ingredientes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 23 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.EditorFor(model => model.Ingredientes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 24 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.Ingredientes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        ");
#nullable restore
#line 27 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.LabelFor(model => model.Instrucciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 28 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.EditorFor(model => model.Instrucciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 29 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.Instrucciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p class=\"hide\">\r\n        ");
#nullable restore
#line 32 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.LabelFor(model => model.AutorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 33 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.TextBoxFor(model => model.AutorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 34 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.AutorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p class=\"hide\">\r\n        ");
#nullable restore
#line 37 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.LabelFor(model => model.Autor.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 38 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.TextBoxFor(model => model.Autor.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 39 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.Autor.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        ");
#nullable restore
#line 42 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.LabelFor(model => model.Autor.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 43 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.TextBoxFor(model => model.Autor.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 44 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.Autor.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        ");
#nullable restore
#line 47 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.LabelFor(model => model.Autor.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 48 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.TextBoxFor(model => model.Autor.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 49 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.Autor.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        ");
#nullable restore
#line 52 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.LabelFor(model => model.Autor.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 53 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.TextBoxFor(model => model.Autor.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 54 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.Autor.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        ");
#nullable restore
#line 57 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.LabelFor(model => model.Autor.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 58 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.TextBoxFor(model => model.Autor.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 59 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.Autor.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <button type=\"submit\" class=\"cancelBtn\">Enviar</button>\r\n");
#nullable restore
#line 62 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("SideBar", async() => {
                WriteLiteral("\r\n    <aside class=\"aside\">\r\n        <h4> ");
#nullable restore
#line 66 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\Integrador\SistemaWebMisRecetas\SistemaWebMisRecetas\Views\Receta\Edit.cshtml"
        Write(Html.ActionLink("Cancelar", "Details", "Receta", new{id=@Model.Id}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n\r\n    </aside>\r\n");
            }
            );
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