// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Proyecto_programación_web.Client.Pages
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
#line 11 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\_Imports.razor"
using Proyecto_programación_web.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\FetchData.razor"
using Proyecto_programación_web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\Facultad\4_CUARTO_SEMESTRE\Programación_Web\Proyecto_programación_web\Proyecto_programación_web\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
