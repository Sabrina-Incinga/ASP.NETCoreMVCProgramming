#pragma checksum "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5048091876bc67adad906a23326588eacba184a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_Index), @"mvc.1.0.view", @"/Views/Empleado/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5048091876bc67adad906a23326588eacba184a", @"/Views/Empleado/Index.cshtml")]
    #nullable restore
    public class Views_Empleado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCEmpleado.Models.Empleado>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml"
  
    ViewData["Title"] = "Index Empleados";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml"
Write(Html.ActionLink("Nuevo", "Create", "Empleado"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 11 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 12 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 13 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 14 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Legajo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 15 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 16 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th></th>\r\n        </tr>\r\n");
#nullable restore
#line 19 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Legajo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml"
               Write(Html.ActionLink("Detalle", "Details", "Empleado", new{id=item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 30 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml"
               Write(Html.ActionLink("Eliminar", "Delete", "Empleado", new{id=item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "H:\Sabrina\Accenture\ASP.NETCoreMVCProgramming\ASP.NETCoreMVCProgramming\EjercicioIntegradorMVC\SistemaWebEmpleado\MVCEmpleado\Views\Empleado\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
            DefineSection("SideBar", async() => {
                WriteLiteral("\r\n    <aside class=\"aside\">\r\n        <h3>Administración de empleados</h3>\r\n    </aside>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCEmpleado.Models.Empleado>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591