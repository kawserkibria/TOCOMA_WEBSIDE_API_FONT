#pragma checksum "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetailsView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1689e1194ee986fb20c0d84a131ca4d4333b0f5f"
// <auto-generated/>
#pragma warning disable 1591
namespace TOCOMA_ERP_System.Pages.Sales
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/QuotationDetailsView/{Id}")]
    public partial class QuotationDetailsView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    fieldset {
        border: 1px solid gray;
        padding: 10px;
        margin: 10px;
    }

    table {
        border-collapse: collapse;
        /*width: 150% !important;*/
    }

    th,
    td {
        border: 1px solid #888;
        /*padding: 0.25em 0.5em;*/
    }

        td i {
            display: inline-block;
        }

    tr td {
        text-align: center;
    }

    tr th {
        text-align: center;
    }
</style>
");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "dashboard-details");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.AddMarkupContent(5, "<a href=\"QuotationList\"><i class=\"bi bi-arrow-left-circle\" style=\"font-size:30px\"></i></a>\r\n        ");
            __builder.OpenElement(6, "fieldset");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "style", "padding-top:10px;padding-left:10px");
            __builder.OpenElement(9, "p");
            __builder.AddAttribute(10, "style", "font-size:15px;font-weight:bold");
            __builder.AddContent(11, "Quotation Type : ");
            __builder.AddContent(12, 
#nullable restore
#line 40 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetailsView.razor"
                                                                             salesQuotationInfo.QUOTATION_TYPE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(13, " ");
            __builder.OpenElement(14, "label");
            __builder.AddAttribute(15, "style", "float:right;margin-right:230px");
            __builder.AddContent(16, 
#nullable restore
#line 40 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetailsView.razor"
                                                                                                                                                                  planandOperationView.ENTRYDATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "p");
            __builder.AddMarkupContent(19, "<b>Quotation No :   </b> ");
            __builder.AddContent(20, 
#nullable restore
#line 41 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetailsView.razor"
                                             salesQuotationInfo.QUOTATION_NO

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "p");
            __builder.AddMarkupContent(23, "<b>Quotation Date :   </b> ");
            __builder.AddContent(24, 
#nullable restore
#line 42 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetailsView.razor"
                                               salesQuotationInfo.QUOTATION_DATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "p");
            __builder.AddMarkupContent(27, "<b>Valid Up To :   </b> ");
            __builder.AddContent(28, 
#nullable restore
#line 43 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetailsView.razor"
                                            salesQuotationInfo.VALID_UP_TO_DATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "p");
            __builder.AddMarkupContent(31, "<b>Ship Via :   </b> ");
            __builder.AddContent(32, 
#nullable restore
#line 44 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetailsView.razor"
                                         salesQuotationInfo.SHIP_VIA

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                \r\n                <br>\r\n                ");
            __builder.OpenElement(34, "table");
            __builder.AddAttribute(35, "style", "width:70%");
            __builder.AddMarkupContent(36, @"<thead><tr><th style=""width:27%;background-color:gainsboro"">Item <br>Description</th>
                            <th style=""width:7%;background-color:gainsboro"">Minimum<br>Order<br>Quantity</th>
                            <th style=""width:7%;background-color:gainsboro"">Unit<br>Of<br>Measure</th>
                            <th style=""width:7%;background-color:gainsboro"">Unit Price</th>

                            <th style=""width:7%;background-color:gainsboro"">AIT(%)</th>
                            <th style=""width:7%;background-color:gainsboro"">VAT(%)</th>
                            <th style=""width:7%;background-color:gainsboro"">Unit Price<br>Including VAT/TAX</th></tr></thead>


                    ");
            __builder.OpenElement(37, "tbody");
#nullable restore
#line 64 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetailsView.razor"
                         if (salesQuotationItemList != null)
                        {
                            foreach (var item in salesQuotationItemList)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "tr");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 69 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetailsView.razor"
                                         item.ITEM_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(41, "<br>");
            __builder.AddContent(42, 
#nullable restore
#line 69 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetailsView.razor"
                                                             (MarkupString)@item.ITEM_DESCRIPTION

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                                    ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 70 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetailsView.razor"
                                         item.ORDER_QUANTITY

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                                    ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 71 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetailsView.razor"
                                         item.UOM

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                                    ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 72 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetailsView.razor"
                                         item.UNIT_PRICE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                    ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 73 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetailsView.razor"
                                         item.AIT

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                    ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 74 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetailsView.razor"
                                         item.VAT

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                    ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 75 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetailsView.razor"
                                         item.TOTAL_PRICE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 77 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetailsView.razor"
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
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetailsView.razor"
       

    [Parameter]
    public string Id { get; set; }
    PlanandOperationViewModel planandOperationView = new PlanandOperationViewModel();
    PlanAndOperationModel planAndOperation = new PlanAndOperationModel();
    SalesQuotationView salesQuotationInfo = new SalesQuotationView();
    List<SalesQuotationItemView> salesQuotationItemList = new List<SalesQuotationItemView>();
    protected override async Task OnInitializedAsync()
    {
        salesQuotationInfo = await Http.GetJsonAsync<SalesQuotationView>(Utility.BaseUrl + "api/Sales/GetsalesQuotationInfoById/" + Id);
        salesQuotationItemList = await Http.GetJsonAsync<List<SalesQuotationItemView>>(Utility.BaseUrl + "api/Sales/GetSalesQuotationItemListById/" + Id);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
