// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AdvancedTodo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\abdul\RiderProjects\Blazor\AdvancedTodo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\RiderProjects\Blazor\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abdul\RiderProjects\Blazor\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\abdul\RiderProjects\Blazor\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\abdul\RiderProjects\Blazor\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\abdul\RiderProjects\Blazor\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\abdul\RiderProjects\Blazor\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\abdul\RiderProjects\Blazor\AdvancedTodo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\abdul\RiderProjects\Blazor\AdvancedTodo\_Imports.razor"
using AdvancedTodo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\abdul\RiderProjects\Blazor\AdvancedTodo\_Imports.razor"
using AdvancedTodo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\RiderProjects\Blazor\AdvancedTodo\Pages\Edit.razor"
using AdvancedTodo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abdul\RiderProjects\Blazor\AdvancedTodo\Pages\Edit.razor"
using AdvancedTodo.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Edit/{Id:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\abdul\RiderProjects\Blazor\AdvancedTodo\Pages\Edit.razor"
       

    [Parameter]
    public int Id { get; set; }

    private Todo todoToEdit;

    protected override async Task OnInitializedAsync()
    {
        todoToEdit = TodoData.Get(Id);
    }

    private void Save()
    {
        TodoData.Update(todoToEdit);
        NavMgr.NavigateTo("/Todos");
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITodoData TodoData { get; set; }
    }
}
#pragma warning restore 1591
