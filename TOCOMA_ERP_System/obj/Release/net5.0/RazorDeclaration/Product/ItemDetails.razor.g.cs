// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TOCOMA_ERP_System.Product
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_System.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_ClassLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_System.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ItemDetails/{ItemCode}")]
    public partial class ItemDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
       
    [Parameter]
    public string ItemCode { get; set; }
    ItemViewModel itemDetails = new ItemViewModel();
    List<string> tdslist = new List<string>();
    List<string> sdslist = new List<string>();
    List<string> videolist = new List<string>();
    protected override async Task OnInitializedAsync()
    {
        itemDetails = await Http.GetJsonAsync<ItemViewModel>(Utility.BaseUrl + "api/Product/GetItemByCode/" + ItemCode);
        var path = $"{env.WebRootPath}\\images\\File\\TDS";
        string[] tdsfilelist = Directory.GetFiles(path);

        var sdspath = $"{env.WebRootPath}\\images\\File\\SDS";
        string[] sdsfilelist = Directory.GetFiles(sdspath);

        var videoPath = $"{env.WebRootPath}\\Video";
        string[] allvideolist = Directory.GetFiles(videoPath);

        List<string> file = new List<string>();
        //itemDetails.ITEM_CODE = "100";
        foreach (var item in tdsfilelist)
        {
            if (item.Contains(itemDetails.ITEM_CODE))
            {
                tdslist.Add(Path.GetFileName(item));
            }

        }
        //----------------
        foreach (var item in sdsfilelist)
        {
            if (item.Contains(itemDetails.ITEM_CODE))
            {
                sdslist.Add(Path.GetFileName(item));
            }

        }
        //--------------
        foreach (var item in allvideolist)
        {
            if (item.Contains(itemDetails.ITEM_CODE))
            {
                videolist.Add(Path.GetFileName(item));
            }

        }

    }
    private async Task DownloadTDS(string item)
    {
        try
        {
            //var path = $"{env.WebRootPath}\\images\\File\\TDS";
            var path = "images//File//TDS";
            var fileName = item;
            //var fileURL = "https://localhost:5001/files/quote.txt";
            var fileURL = path + "//" + item;
            await JSRuntime.InvokeVoidAsync("triggerFileDownload", fileName, fileURL);
        }
        catch (Exception EX)
        {

        }

    }
    private async Task DownloadSDS(string item)
    {
        try
        {
            //var path = $"{env.WebRootPath}\\images\\File\\TDS";
            var path = "images//File//SDS";
            var fileName = item;
            //var fileURL = "https://localhost:5001/files/quote.txt";
            var fileURL = path + "//" + item;
            await JSRuntime.InvokeVoidAsync("triggerFileDownload", fileName, fileURL);
        }
        catch (Exception EX)
        {

        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
