#pragma checksum "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\Pages\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d494562b1458e9f8e1bb8effd0e282865548622c"
// <auto-generated/>
#pragma warning disable 1591
namespace AdvancedTodo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\_Imports.razor"
using AdvancedTodo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\_Imports.razor"
using AdvancedTodo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\Pages\Edit.razor"
using AdvancedTodo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\Pages\Edit.razor"
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
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Edit todo with id: ");
            __builder.AddContent(2, 
#nullable restore
#line 10 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\Pages\Edit.razor"
                        Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\Pages\Edit.razor"
 if (todoToEdit == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<em>Todo not found!</em>");
#nullable restore
#line 15 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\Pages\Edit.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\Pages\Edit.razor"
                      todoToEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\Pages\Edit.razor"
                                                  Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddContent(9, " ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, " User Id:<br> ");
                __Blazor.AdvancedTodo.Pages.Edit.TypeInference.CreateInputNumber_0(__builder2, 15, 16, 
#nullable restore
#line 20 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\Pages\Edit.razor"
                                                                         todoToEdit.TodoId

#line default
#line hidden
#nullable disable
                , 17, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => todoToEdit.TodoId = __value, todoToEdit.TodoId)), 18, () => todoToEdit.TodoId);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, " Title:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(23);
                __builder2.AddAttribute(24, "rows", "4");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\Pages\Edit.razor"
                                                                                  todoToEdit.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => todoToEdit.Title = __value, todoToEdit.Title))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => todoToEdit.Title));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.AddMarkupContent(29, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Save</button></p>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 26 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\Pages\Edit.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\abdul\RiderProjects\BlazorGraphQL\AdvancedTodo\Pages\Edit.razor"
       

    [Parameter]
    public int Id { get; set; }

    private Todo todoToEdit;

    protected override async Task OnInitializedAsync()
    {
        todoToEdit = await TodoData.Get(Id);
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
namespace __Blazor.AdvancedTodo.Pages.Edit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
