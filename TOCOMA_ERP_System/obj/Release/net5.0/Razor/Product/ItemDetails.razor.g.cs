#pragma checksum "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc5f75153462fbf7e6dcf35d72d64ab97de7c363"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddAttribute(2, "style", "height:1200px");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-2");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "src", 
#nullable restore
#line 16 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
                       itemDetails.ITEM_IMAGE

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "style", "width:250px;height:170px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-10");
            __builder.OpenElement(13, "h2");
            __builder.AddAttribute(14, "style", "margin-top:20px");
            __builder.AddContent(15, 
#nullable restore
#line 19 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
                                         itemDetails.ITEM_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            <br>\r\n            ");
            __builder.OpenElement(17, "p");
            __builder.AddMarkupContent(18, "<b>Category:</b> ");
            __builder.AddContent(19, 
#nullable restore
#line 21 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
                                 itemDetails.CATEGORY_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "p");
            __builder.AddMarkupContent(22, "<b>Brand:</b> ");
            __builder.AddContent(23, 
#nullable restore
#line 22 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
                              itemDetails.BRAND_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "p");
            __builder.AddMarkupContent(26, "<b>Brand Origin Country:</b> ");
            __builder.AddContent(27, 
#nullable restore
#line 23 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
                                             itemDetails.BRAND_ORIGIN_COUNTRY

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "p");
            __builder.AddMarkupContent(30, "<b>Made In Country:</b> ");
            __builder.AddContent(31, 
#nullable restore
#line 24 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
                                        itemDetails.MAID_IN_COUNTRY

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "p");
            __builder.AddMarkupContent(34, "<b>Import From:</b> ");
            __builder.AddContent(35, 
#nullable restore
#line 25 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
                                    itemDetails.IMPORT_FROM

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n            <hr>\r\n            ");
            __builder.AddMarkupContent(37, "<h6>About This Item</h6>\r\n            ");
            __builder.OpenElement(38, "p");
            __builder.AddContent(39, 
#nullable restore
#line 29 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
                 (MarkupString)@itemDetails.SHORT_DESCRIPTION

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n            ");
            __builder.OpenElement(41, "p");
            __builder.AddContent(42, 
#nullable restore
#line 31 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
                 (MarkupString)@itemDetails.LONG_DESCRIPTION

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n            ");
            __builder.AddMarkupContent(44, "<h4>Application Video</h4>");
#nullable restore
#line 34 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
             foreach (var item in videolist)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "video");
            __builder.AddAttribute(46, "controls", "controls");
            __builder.AddAttribute(47, "width", "400px");
            __builder.AddAttribute(48, "height", "300px");
            __builder.OpenElement(49, "source");
            __builder.AddAttribute(50, "src", "/Video/" + (
#nullable restore
#line 37 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
                                         item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "type", "video/mp4");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(52, "<br>\r\n            <br>");
#nullable restore
#line 43 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
             if (tdslist != null && tdslist.Count > 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "<h3>TDS/Datasheet Download</h3>\r\n                ");
            __builder.OpenElement(54, "table");
            __builder.AddAttribute(55, "width", "70%");
            __builder.OpenElement(56, "tbody");
#nullable restore
#line 48 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
                         foreach (var item in tdslist)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(57, "tr");
            __builder.OpenElement(58, "td");
            __builder.AddAttribute(59, "style", "width:90%");
            __builder.OpenElement(60, "p");
            __builder.AddContent(61, 
#nullable restore
#line 51 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
                                                          item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                                ");
            __builder.OpenElement(63, "td");
            __builder.AddAttribute(64, "style", "width:10%");
            __builder.OpenElement(65, "button");
            __builder.AddAttribute(66, "class", "raise");
            __builder.AddAttribute(67, "style", "background-color: black; color: white");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
                                                                                                                                     () => DownloadTDS(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(69, "Download");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"

                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(70, "<br>\r\n            <br>");
#nullable restore
#line 61 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
             if (sdslist != null && sdslist.Count > 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(71, "<h2>SDS Download</h2>\r\n                ");
            __builder.OpenElement(72, "table");
            __builder.AddAttribute(73, "width", "70%");
            __builder.OpenElement(74, "tbody");
#nullable restore
#line 66 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
                         foreach (var item in sdslist)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(75, "tr");
            __builder.OpenElement(76, "td");
            __builder.AddAttribute(77, "style", "width:90%");
            __builder.OpenElement(78, "p");
            __builder.AddContent(79, 
#nullable restore
#line 69 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
                                                          item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                                ");
            __builder.OpenElement(81, "td");
            __builder.AddAttribute(82, "style", "width:10%");
            __builder.OpenElement(83, "button");
            __builder.AddAttribute(84, "style", "background-color: black; color: white");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
                                                                                                                       () => DownloadSDS(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(86, "Download");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"

                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 76 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
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