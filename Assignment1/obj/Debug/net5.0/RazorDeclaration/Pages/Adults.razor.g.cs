// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\arasi\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\arasi\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\arasi\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\arasi\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\arasi\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\arasi\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\arasi\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\arasi\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\arasi\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\arasi\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\arasi\RiderProjects\Assignment1\Assignment1\Pages\Adults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\arasi\RiderProjects\Assignment1\Assignment1\Pages\Adults.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\arasi\RiderProjects\Assignment1\Assignment1\Pages\Adults.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\arasi\RiderProjects\Assignment1\Assignment1\Pages\Adults.razor"
       
    private IList<Adult> adultsAll;
    private IList<Adult> adultsToShow;

    private string? filterByName;
    

    protected override async Task OnInitializedAsync()
    {
        adultsAll = new List<Adult>();
        adultsAll = PersonService.GetAll();
        adultsToShow = new List<Adult>();
        adultsToShow = adultsAll;
    }

    private void FilterByName(ChangeEventArgs args)
    {
        filterByName = null;
        try
        {
            filterByName = args.Value.ToString();
        }
        catch (Exception e){ }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        adultsToShow = adultsAll.Where(a=>
            filterByName !=null && a.LastName.Contains(filterByName) || filterByName == null).ToList();
    }

    private void RemoveAdult(int AdultId)
    {
        Adult toRemove = adultsAll.First(a => a.Id == AdultId);
        PersonService.RemovePerson(AdultId);
        adultsAll.Remove(toRemove);
        adultsToShow.Remove(toRemove);
    }

    private void Edit(int id)
    {
        NavigationManager.NavigateTo($"Edit/{id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonService PersonService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
