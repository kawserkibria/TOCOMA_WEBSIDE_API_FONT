#pragma checksum "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "504d0bcc29ddaca6f8e6ee74f6631f36714913e0"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditSalesOrderTracking/{PONO}")]
    public partial class EditSalesOrderTracking : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    th {\r\n        font-weight: bold;\r\n    }\r\n</style>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "dashboard-details");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.AddMarkupContent(5, "<br>\r\n        <br>\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-lg-8");
            __builder.AddAttribute(8, "style", "border: 1px solid #888");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
                              EditSales

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "class", "btn btn-info");
            __builder.AddAttribute(12, "data-dismiss", "modal");
            __builder.AddAttribute(13, "style", "border:none;width:120px;float:right;margin-left:10px");
            __builder.AddContent(14, "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n            ");
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "width", "100%");
            __builder.OpenElement(18, "thead");
            __builder.AddMarkupContent(19, "<tr><th>PO NO</th>\r\n                        <th>PO Date</th></tr>\r\n                    ");
            __builder.OpenElement(20, "tr");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 26 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
                             sales.PO_WO_NUMBER

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 27 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
                             sales.PO_WO_DATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.AddMarkupContent(27, "<tr><th colspan=\"3\">ETA to TL-WH With QTY</th>\r\n                        <th colspan=\"3\">Expected Delivery Date</th></tr>\r\n                    ");
            __builder.AddMarkupContent(28, @"<tr><th>1st Date</th>
                        <th>2nd Date</th>
                        <th>3rd Date</th>
                        <th>1st Date</th>
                        <th>2nd Date</th>
                        <th>3rd Date</th></tr>
                    ");
            __builder.OpenElement(29, "tr");
            __builder.OpenElement(30, "th");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "id", "date_1");
            __builder.AddAttribute(34, "autocomplete", "off");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
                                                                                            eta_1st_date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => eta_1st_date = __value, eta_1st_date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "th");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "text");
            __builder.AddAttribute(41, "id", "date_2");
            __builder.AddAttribute(42, "autocomplete", "off");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
                                                                                            eta_2nd_date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => eta_2nd_date = __value, eta_2nd_date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "th");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "text");
            __builder.AddAttribute(49, "id", "date_3");
            __builder.AddAttribute(50, "autocomplete", "off");
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
                                                                                            eta_3rd_date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => eta_3rd_date = __value, eta_3rd_date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.OpenElement(54, "th");
            __builder.OpenElement(55, "input");
            __builder.AddAttribute(56, "type", "text");
            __builder.AddAttribute(57, "id", "date_4");
            __builder.AddAttribute(58, "autocomplete", "off");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
                                                                                            ed_1st_date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ed_1st_date = __value, ed_1st_date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.OpenElement(62, "th");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "text");
            __builder.AddAttribute(65, "id", "date_5");
            __builder.AddAttribute(66, "autocomplete", "off");
            __builder.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
                                                                                            ed_2nd_date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ed_2nd_date = __value, ed_2nd_date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.OpenElement(70, "th");
            __builder.OpenElement(71, "input");
            __builder.AddAttribute(72, "type", "text");
            __builder.AddAttribute(73, "id", "date_6");
            __builder.AddAttribute(74, "autocomplete", "off");
            __builder.AddAttribute(75, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
                                                                                            ed_3rd_date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ed_3rd_date = __value, ed_3rd_date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.AddMarkupContent(78, "<tr><th>Parcentage of Complete</th>\r\n                        <th>Status of Shipment</th></tr>\r\n                    ");
            __builder.OpenElement(79, "tr");
            __builder.OpenElement(80, "th");
            __builder.OpenElement(81, "input");
            __builder.AddAttribute(82, "type", "text");
            __builder.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
                                                             sales.PARCHENTAGE_OF_COMPLETE

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sales.PARCHENTAGE_OF_COMPLETE = __value, sales.PARCHENTAGE_OF_COMPLETE));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.OpenElement(86, "th");
            __builder.OpenElement(87, "input");
            __builder.AddAttribute(88, "type", "text");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
                                                             sales.STATUS_OF_SHIPMENT

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sales.STATUS_OF_SHIPMENT = __value, sales.STATUS_OF_SHIPMENT));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n\r\n            <br>\r\n            ");
            __builder.OpenElement(92, "table");
            __builder.AddAttribute(93, "width", "100%");
            __builder.AddMarkupContent(94, "<thead><tr><th>Item</th>\r\n                        <th>UOM</th>\r\n                        <th>Quantity</th>\r\n                        <th>UnitPrice</th>\r\n                        <th>Total</th></tr></thead>\r\n                ");
            __builder.OpenElement(95, "tbody");
#nullable restore
#line 80 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
                     if (salesitemList != null)
                    {
                        foreach (var item in salesitemList)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(96, "tr");
            __builder.OpenElement(97, "td");
            __builder.AddContent(98, 
#nullable restore
#line 85 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
                                     item.ITEM_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                                ");
            __builder.OpenElement(100, "td");
            __builder.AddContent(101, 
#nullable restore
#line 86 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
                                     item.UOM

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                                ");
            __builder.OpenElement(103, "td");
            __builder.AddContent(104, 
#nullable restore
#line 87 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
                                     item.SALES_QUANTITY

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                                ");
            __builder.OpenElement(106, "td");
            __builder.AddContent(107, 
#nullable restore
#line 88 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
                                     item.UNIT_PRICE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                                ");
            __builder.OpenElement(109, "td");
            __builder.AddContent(110, 
#nullable restore
#line 89 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
                                     item.TOTAL_PRICE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 91 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
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
#line 103 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrderTracking.razor"
       
    [Parameter]
    public string PONO { get; set; }
    SalesOrderModel sales = new SalesOrderModel();
    List<SalesItemDetailsModel> salesitemList = new List<SalesItemDetailsModel>();
    string quotation_ref_date;
    string eta_1st_date;
    string eta_2nd_date;
    string eta_3rd_date;
    string ed_1st_date;
    string ed_2nd_date;
    string ed_3rd_date;


    protected override async Task OnInitializedAsync()
    {
        salesitemList = await Http.GetJsonAsync<List<SalesItemDetailsModel>>(Utility.BaseUrl + "api/Sales/GetSalesItemByPONo/" + PONO);
        sales = await Http.GetJsonAsync<SalesOrderModel>(Utility.BaseUrl + "api/Sales/GetSalesByPONo/" + PONO);
        eta_1st_date = sales.ETA_TL_WH_1st_DATE;
        eta_2nd_date = sales.ETA_TL_WH_2nd_DATE;
        eta_3rd_date = sales.ETA_TL_WH_3rd_DATE;
        ed_1st_date = sales.EXPECTED_DELIVERY_1st_DATE;
        ed_2nd_date = sales.EXPECTED_DELIVERY_2nd_DATE;
        ed_3rd_date = sales.EXPECTED_DELIVERY_3rd_DATE;
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JsRuntime.InvokeVoidAsync("JsInteropDatepicker");
    }

    public async Task EditSales()
    {

        try
        {
            sales.ETA_TL_WH_1st_DATE = eta_1st_date;
            sales.ETA_TL_WH_2nd_DATE = eta_2nd_date;
            sales.ETA_TL_WH_3rd_DATE = eta_3rd_date;
            sales.EXPECTED_DELIVERY_1st_DATE = ed_1st_date;
            sales.EXPECTED_DELIVERY_2nd_DATE = ed_2nd_date;
            sales.EXPECTED_DELIVERY_3rd_DATE = ed_3rd_date;
            var data = await Http.PutJsonAsync<SalesOrderModel>(Utility.BaseUrl + "api/Sales/UpdateSalesTrackingInfo", sales);
            toastService.ShowSuccess("Update SuccessfullY !!");                
        }
        catch (Exception ex)
        {

        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.JSInterop.IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
