#pragma checksum "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Mangas\MangaEditar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7a903233f4dceccbeaff5a8ae14e67d33fa0984"
// <auto-generated/>
#pragma warning disable 1591
namespace Proyecto_programación_web.Client.Pages.Mangas
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/mangaIndex/EditarManga/{Id:int}")]
    public partial class MangaEditar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar el manga</h3>\r\n\r\n");
#nullable restore
#line 6 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Mangas\MangaEditar.razor"
 if (myEditoriales != null && miManga != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Mangas\MangaEditar.razor"
                      miManga

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Mangas\MangaEditar.razor"
                                              Modificar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-6");
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "type", "text");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Mangas\MangaEditar.razor"
                                                miManga.Descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => miManga.Descripcion = __value, miManga.Descripcion))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => miManga.Descripcion));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __Blazor.Proyecto_programación_web.Client.Pages.Mangas.MangaEditar.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 12 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Mangas\MangaEditar.razor"
                                    () => miManga.Descripcion

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-md-6");
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.AddMarkupContent(26, "<label> Publicaciones : </label>\r\n            ");
                __Blazor.Proyecto_programación_web.Client.Pages.Mangas.MangaEditar.TypeInference.CreateInputNumber_1(__builder2, 27, 28, "form-control", 29, 
#nullable restore
#line 17 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Mangas\MangaEditar.razor"
                                      miManga.Publicaciones

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => miManga.Publicaciones = __value, miManga.Publicaciones)), 31, () => miManga.Publicaciones);
                __builder2.AddMarkupContent(32, "\r\n            ");
                __Blazor.Proyecto_programación_web.Client.Pages.Mangas.MangaEditar.TypeInference.CreateValidationMessage_2(__builder2, 33, 34, 
#nullable restore
#line 18 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Mangas\MangaEditar.razor"
                                    ()=>miManga.Publicaciones

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n\r\n        ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.AddMarkupContent(40, "<label for=\"editorial\">Editorial</label>\r\n            ");
                __Blazor.Proyecto_programación_web.Client.Pages.Mangas.MangaEditar.TypeInference.CreateInputSelectNumber_3(__builder2, 41, 42, "form-control", 43, "editorial", 44, 
#nullable restore
#line 23 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Mangas\MangaEditar.razor"
                                                                 miManga.EditorialId

#line default
#line hidden
#nullable disable
                , 45, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => miManga.EditorialId = __value, miManga.EditorialId)), 46, () => miManga.EditorialId, 47, (__builder3) => {
                    __builder3.AddMarkupContent(48, "\r\n");
#nullable restore
#line 24 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Mangas\MangaEditar.razor"
                 foreach (Editorial edit in myEditoriales)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(49, "                    ");
                    __builder3.OpenElement(50, "option");
                    __builder3.AddAttribute(51, "value", 
#nullable restore
#line 26 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Mangas\MangaEditar.razor"
                                    edit.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(52, 
#nullable restore
#line 26 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Mangas\MangaEditar.razor"
                                              edit.NombreManga

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(53, "\r\n");
#nullable restore
#line 27 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Mangas\MangaEditar.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(54, "            ");
                }
                );
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.AddMarkupContent(57, "<div class=\"col\">\r\n            <button type=\"submit\" class=\"btn btn-success\">Editar</button>\r\n        </div>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 34 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Mangas\MangaEditar.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\Mangas\MangaEditar.razor"
       
    [Parameter]
    public int Id { get; set; }
    Manga miManga;
    private List<Editorial> myEditoriales = new List<Editorial>();

    protected override async Task OnInitializedAsync()//obtener valores para la lista
    {

        myEditoriales = await http.GetFromJsonAsync<List<Editorial>>("api/editoriales");
        miManga = await http.GetFromJsonAsync<Manga>($"api/mangas/{Id}");
    }

    private async Task Modificar()
    {
        await http.PutAsJsonAsync("api/mangas", miManga);
        navegar.NavigateTo("mangaIndex");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navegar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.Proyecto_programación_web.Client.Pages.Mangas.MangaEditar
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelectNumber_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Proyecto_programación_web.Client.Shared.InputSelectNumber<T>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
