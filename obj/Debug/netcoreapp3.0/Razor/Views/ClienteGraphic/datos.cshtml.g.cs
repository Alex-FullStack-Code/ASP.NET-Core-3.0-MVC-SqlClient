#pragma checksum "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\ClienteGraphic\datos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65cd60ee9b57e2ed342eb3178bd601b745429090"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ClienteGraphic_datos), @"mvc.1.0.view", @"/Views/ClienteGraphic/datos.cshtml")]
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
#line 1 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\_ViewImports.cshtml"
using Cineplus_DSW_Proyecto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\_ViewImports.cshtml"
using Cineplus_DSW_Proyecto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65cd60ee9b57e2ed342eb3178bd601b745429090", @"/Views/ClienteGraphic/datos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6bfc7d95b8abc286b8bc3c57159846576b38980", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ClienteGraphic_datos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cineplus_DSW_Proyecto.Models.Cliente>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "B", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "A", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "I", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "datos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ClienteGraphic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\ClienteGraphic\datos.cshtml"
  
    ViewData["Title"] = "datos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-12 mb-3"">

        <h1 class=""text-center"" style=""font-size:3rem;""> <span class=""badge badge-primary"">Cuadro de datos de Clientes</span></h1>
    </div>

    <div class=""col-6 mt-2"">

        <h2> <span class=""font-weight-bold"">Datos del Cuadro Estadístico</span></h2>
        <p>
            <span>
                Este cuadro estadístico permite poder ver un panorama
                de la cantidad de Clientes que estan activos e inactivos,
                de esta manera recopilamos información de cuantos clientes
                estan usando el servicio del cine.
            </span>
        </p>
    </div>

    <div class=""col-6"">
        <canvas id=""myChart"" width=""70"" height=""40""></canvas>
    </div>

    <div class=""col-12 mt-2 mb-2"">

        <div class=""col-12 mt-2 mb-2"">

            <h3 class=""text-center""> <span class=""badge badge-dark"" style=""font-size:3rem;"">Listado de Clientes</span></h3>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65cd60ee9b57e2ed342eb3178bd601b7454290906968", async() => {
                WriteLiteral(@"

                <div class=""row justify-content-center"">
                    <div class=""col-lg-5"">
                        <div class=""input-group"">
                            <span class=""input-group-btn"">
                                <button class=""btn btn-outline-info"">Consultar!</button>
                            </span>
                            <select name=""estado"" class=""form-control"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65cd60ee9b57e2ed342eb3178bd601b7454290907686", async() => {
                    WriteLiteral("[Seleccionar]");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65cd60ee9b57e2ed342eb3178bd601b7454290909271", async() => {
                    WriteLiteral("Activo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65cd60ee9b57e2ed342eb3178bd601b74542909010526", async() => {
                    WriteLiteral("Inactivo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </select>\r\n                        </div><!-- /input-group -->\r\n                            <div>\r\n                                <span class=\"text-danger\">");
#nullable restore
#line 51 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\ClienteGraphic\datos.cshtml"
                                                     Write(ViewBag.validacion);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </div>\r\n                    </div><!-- /.col-lg-6 -->\r\n                </div><!-- /.row -->\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <br />\r\n        </div>\r\n        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 63 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\ClienteGraphic\datos.cshtml"
                   Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 66 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\ClienteGraphic\datos.cshtml"
                   Write(Html.DisplayNameFor(model => model.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 69 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\ClienteGraphic\datos.cshtml"
                   Write(Html.DisplayNameFor(model => model.telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 72 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\ClienteGraphic\datos.cshtml"
                   Write(Html.DisplayNameFor(model => model.direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 75 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\ClienteGraphic\datos.cshtml"
                   Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 78 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\ClienteGraphic\datos.cshtml"
                   Write(Html.DisplayNameFor(model => model.estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 84 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\ClienteGraphic\datos.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 88 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\ClienteGraphic\datos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 91 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\ClienteGraphic\datos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 94 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\ClienteGraphic\datos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 97 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\ClienteGraphic\datos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 100 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\ClienteGraphic\datos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 103 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\ClienteGraphic\datos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 106 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\ClienteGraphic\datos.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n\r\n        jQuery.ajax({\r\n            url: \'");
#nullable restore
#line 120 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\ClienteGraphic\datos.cshtml"
             Write(Url.Action("clienteDatos","ClienteGraphic"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
            type: ""Get"",
            dataType: ""json"",
            contentType: ""application/json; charset=utf-8"",
            success: function(data) {
                console.log(data);

                var arregloCantidad = [];
                var arregloEstado = [""Activo"", ""Inactivo""];
                for (let i = 0; i < data.length; i++) {
                    arregloCantidad.push(data[i].cantidad)
                }
                console.log(arregloCantidad);
                console.log(arregloEstado);



                const ctx = document.getElementById('myChart').getContext('2d');
                const myChart = new Chart(ctx, {
                    type: 'pie',
                    data: {
                        labels: arregloEstado,
                        datasets: [{
                            label: '# of Votes',
                            data: arregloCantidad,
                            backgroundColor: [
                                'rgba(255, 99, 132, 0.2)");
                WriteLiteral(@"',
                                'rgba(54, 162, 235, 0.2)'
                            ],
                            borderColor: [
                                'rgba(255, 99, 132, 1)',
                                'rgba(54, 162, 235, 1)'
                            ],
                            borderWidth: 1
                        }]
                    },
                    options: {
                         plugins: {
                            
                            title: {
                                display: true,
                                text:""Estadística de Clientes"",
                                font: { size: ""25""}
                            }

                        },
                        scales: {
                            y: {
                                beginAtZero: true
                            }
                        }
                    }
                });






            },
            error: function(");
                WriteLiteral("error) {\r\n                console.log(error)\r\n            }\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cineplus_DSW_Proyecto.Models.Cliente>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591