#pragma checksum "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Editoriales\EditorialEditar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b980e48e77d8ee8b7dce72764674714e020ec19"
// <auto-generated/>
#pragma warning disable 1591
namespace Proyecto_programación_web.Client.Pages.Editoriales
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\_Imports.razor"
using Proyecto_programación_web.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\_Imports.razor"
using Proyecto_programación_web.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\_Imports.razor"
using Proyecto_programación_web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\_Imports.razor"
using Proyecto_programación_web.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editorialIndex/Editar/{Id:int}")]
    public partial class EditorialEditar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar editorial</h3>\r\n");
#nullable restore
#line 8 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Editoriales\EditorialEditar.razor"
     if (miEditorial != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Editoriales\EditorialEditar.razor"
                          miEditorial

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Editoriales\EditorialEditar.razor"
                                                      Modificar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-6");
                __builder2.AddMarkupContent(11, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "type", "text");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Editoriales\EditorialEditar.razor"
                                                    miEditorial.NombreManga

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => miEditorial.NombreManga = __value, miEditorial.NombreManga))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => miEditorial.NombreManga));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                ");
                __Blazor.Proyecto_programación_web.Client.Pages.Editoriales.EditorialEditar.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 14 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Editoriales\EditorialEditar.razor"
                                        ()=>miEditorial.NombreManga

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.AddMarkupContent(23, "<div class=\"row\">\r\n                <div class=\"col\">\r\n                    <button type=\"submit\" class=\"btn btn-success\">Modificar</button>\r\n                </div>\r\n            </div>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 22 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Editoriales\EditorialEditar.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Editoriales\EditorialEditar.razor"
           
        Editorial miEditorial = new Editorial();

        [Parameter]
        public int Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            miEditorial = await http.GetFromJsonAsync<Editorial>($"/api/editoriales/{Id}");
        }

        private async Task Modificar()
        {
            await http.PutAsJsonAsync($"api/editoriales/{miEditorial.Id}", miEditorial);
            navegar.NavigateTo("editorialIndex");
        }


    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navegar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.Proyecto_programación_web.Client.Pages.Editoriales.EditorialEditar
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
