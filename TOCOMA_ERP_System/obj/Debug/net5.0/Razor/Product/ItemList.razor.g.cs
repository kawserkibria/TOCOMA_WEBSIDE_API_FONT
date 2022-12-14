#pragma checksum "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96af777ecd9de1b1a98539467632c0b028b1d1bc"
// <auto-generated/>
#pragma warning disable 1591
namespace TOCOMA_ERP_System.Product
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_System.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_ClassLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_System.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ItemList")]
    public partial class ItemList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "<div class=\"card-header\">\r\n        Item List &nbsp;\r\n        <a href=\"NewProduct\">New Item</a></div>\r\n\r\n\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "testbox");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "tablearea");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "id", "example");
            __builder.AddAttribute(9, "class", "display");
            __builder.AddAttribute(10, "style", "width:100%");
            __builder.AddMarkupContent(11, @"<thead><tr><th></th>
                        <th>Code</th>
                        <td>Item</td>
                        <td>Category</td>
                        <td>Short</td>
                        <td>Details</td>
                        <td>Image</td></tr></thead>
                ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 32 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemList.razor"
                     if (AllitemList != null)
                    {
                        foreach (var item in AllitemList)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
            __builder.AddAttribute(15, "style", "text-align:center");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "href", "EditItem/" + (
#nullable restore
#line 37 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemList.razor"
                                                                                 item.ITEM_CODE

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(18, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                                ");
            __builder.OpenElement(20, "td");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", "ItemDetails/" + (
#nullable restore
#line 38 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemList.razor"
                                                          item.ITEM_CODE

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, 
#nullable restore
#line 38 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemList.razor"
                                                                           item.ITEM_CODE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 39 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemList.razor"
                                     item.ITEM_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 40 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemList.razor"
                                     item.CATEGORY_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 41 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemList.razor"
                                      (MarkupString)@item.SHORT_DESCRIPTION

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 42 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemList.razor"
                                      (MarkupString)@item.LONG_DESCRIPTION

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                                ");
            __builder.OpenElement(37, "td");
            __builder.OpenElement(38, "img");
            __builder.AddAttribute(39, "style", "width:100px;height:100px");
            __builder.AddAttribute(40, "src", 
#nullable restore
#line 43 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemList.razor"
                                                                                item.ITEM_IMAGE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemList.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemList.razor"
       
    public int pageSize { get; set; }
    public int TotalPage { get; set; }
    public int Currentpage { get; set; }
    public int StartNumber { get; set; }
    public int EndNumber { get; set; }
    bool checkStatus = false;
    int iOption = 0;
    List<ItemViewModel> AllitemList = new List<ItemViewModel>();
    List<ItemViewModel> itemList = new List<ItemViewModel>();

    protected override async Task OnInitializedAsync()
    {
        AllitemList = await Http.GetJsonAsync<List<ItemViewModel>>(Utility.BaseUrl + "api/Product");
        itemList = await Http.GetJsonAsync<List<ItemViewModel>>(Utility.BaseUrl + "api/Product");
        StateHasChanged();
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
        Pagination();
    }
    private void NavigatTo(string direction)
    {
        if (direction == "prev" && Currentpage != 0)
            Currentpage -= 1;
        if (direction == "next" && Currentpage != TotalPage - 1)
            Currentpage += 1;

        UpdateList(Currentpage);
    }
    private void UpdateList(int pageNumber)
    {
        AllitemList = itemList.Skip(pageNumber * pageSize).Take(pageSize).ToList();
        Currentpage = pageNumber;
        if (itemList.Count > 0)
        {
            StartNumber = AllitemList.FirstOrDefault().SL;
            EndNumber = AllitemList[AllitemList.Count - 1].SL;
        }
    }
    private void Pagination()
    {
        pageSize = 20;
        if (itemList.Count > 0)
        {
            AllitemList = itemList.Take(pageSize).ToList();
            TotalPage = (int)Math.Ceiling(itemList.Count() / (decimal)pageSize);
            StartNumber = AllitemList.FirstOrDefault().SL;
            EndNumber = AllitemList[AllitemList.Count - 1].SL;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
