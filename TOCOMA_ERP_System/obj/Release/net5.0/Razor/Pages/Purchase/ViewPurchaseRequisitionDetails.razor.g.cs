#pragma checksum "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e4b5b134a93e8e0bd87cbfc706cb981ebc5a094"
// <auto-generated/>
#pragma warning disable 1591
namespace TOCOMA_ERP_System.Pages.Purchase
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewPurchaseRequisitionDetails/{requisition_no}")]
    public partial class ViewPurchaseRequisitionDetails : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.OpenElement(5, "fieldset");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "style", "padding-top:10px;padding-left:10px");
            __builder.OpenElement(8, "p");
            __builder.AddAttribute(9, "style", "font-size:15px;font-weight:bold");
            __builder.AddContent(10, "Requisition NO : ");
            __builder.AddContent(11, 
#nullable restore
#line 149 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                                             requisitionDetails.REQUISITION_NO

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(12, " ");
            __builder.OpenElement(13, "label");
            __builder.AddAttribute(14, "style", "float:right;margin-right:230px");
            __builder.AddContent(15, 
#nullable restore
#line 149 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                                                                                                                                  requisitionDetails.ENTRYDATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "p");
            __builder.AddMarkupContent(18, "<b>Requester:  </b> ");
            __builder.AddContent(19, 
#nullable restore
#line 150 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                        requisitionDetails.REQUESTED_BY

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "p");
            __builder.AddMarkupContent(22, "<b>Request Department :   </b> ");
            __builder.AddContent(23, 
#nullable restore
#line 151 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                   requisitionDetails.DEPARTMENT_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "p");
            __builder.AddMarkupContent(26, "<b>Request Receive Department :   </b> ");
            __builder.AddContent(27, 
#nullable restore
#line 152 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                           requisitionDetails.DEPARTMENT_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "p");
            __builder.AddMarkupContent(30, "<b>Request Date:   </b> ");
            __builder.AddContent(31, 
#nullable restore
#line 153 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                            requisitionDetails.REQUEST_DATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "p");
            __builder.AddMarkupContent(34, "<b>Require Date:   </b> ");
            __builder.AddContent(35, 
#nullable restore
#line 154 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                            requisitionDetails.REQUIRED_DATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "p");
            __builder.AddMarkupContent(38, "<b>Priority:   </b> ");
            __builder.AddContent(39, 
#nullable restore
#line 155 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                        requisitionDetails.PRIORITY

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "p");
            __builder.AddMarkupContent(42, "<b>Purpose of Requisition:   </b> ");
            __builder.AddContent(43, 
#nullable restore
#line 156 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                      requisitionDetails.REQUISITION_PURPOSE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n                <br>\r\n                ");
            __builder.AddMarkupContent(45, "<label>Item Details</label>\r\n                ");
            __builder.OpenElement(46, "table");
            __builder.AddAttribute(47, "style", "width:50%");
            __builder.AddMarkupContent(48, "<tr><th>Item</th>\r\n                        <th>Quantity</th>\r\n                        <th>Rate</th>\r\n                        <th>Amount</th></tr>\r\n                    ");
            __builder.OpenElement(49, "tbody");
#nullable restore
#line 168 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                         foreach (var tableitem in requestItemList)
                        {
                            double itemTotal = Convert.ToDouble(tableitem.Rate) * Convert.ToDouble(tableitem.Quantity);

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "tr");
            __builder.OpenElement(51, "td");
            __builder.AddAttribute(52, "scope", "col");
            __builder.AddContent(53, 
#nullable restore
#line 172 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                 tableitem.ITEM_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                ");
            __builder.OpenElement(55, "td");
            __builder.AddAttribute(56, "scope", "col");
            __builder.AddContent(57, 
#nullable restore
#line 173 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                 tableitem.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                ");
            __builder.OpenElement(59, "td");
            __builder.AddAttribute(60, "scope", "col");
            __builder.AddContent(61, 
#nullable restore
#line 174 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                 tableitem.Rate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                                ");
            __builder.OpenElement(63, "td");
            __builder.AddAttribute(64, "scope", "col");
            __builder.AddContent(65, 
#nullable restore
#line 175 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                 itemTotal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 177 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "tr");
            __builder.AddMarkupContent(67, "<td colspan=\"3\" style=\"text-align:right\"><b>Total</b></td>\r\n                            ");
            __builder.OpenElement(68, "td");
            __builder.OpenElement(69, "b");
            __builder.AddContent(70, 
#nullable restore
#line 180 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                    requisition_Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                <br>\r\n\r\n                ");
            __builder.AddMarkupContent(72, "<label>Others</label>\r\n                ");
            __builder.OpenElement(73, "table");
            __builder.AddAttribute(74, "style", "width:50%");
            __builder.AddMarkupContent(75, "<tr><th>Item</th>\r\n                        <th>Quantity</th>\r\n                        <th>Rate</th>\r\n                        <th>Total</th></tr>\r\n                    ");
            __builder.OpenElement(76, "tbody");
#nullable restore
#line 195 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                         foreach (var others in othersDetails)
                        {
                            decimal total=0;
                            if (others.RATE!=null || others.RATE!=0)
                            {  total = Convert.ToDecimal(others.QUANTITY) * Convert.ToDecimal(others.RATE); }


#line default
#line hidden
#nullable disable
            __builder.OpenElement(77, "tr");
            __builder.OpenElement(78, "td");
            __builder.AddAttribute(79, "scope", "col");
            __builder.AddContent(80, 
#nullable restore
#line 202 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                 others.OTHERS_ITEM

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                                ");
            __builder.OpenElement(82, "td");
            __builder.AddAttribute(83, "scope", "col");
            __builder.AddContent(84, 
#nullable restore
#line 203 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                 others.QUANTITY

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                                ");
            __builder.OpenElement(86, "td");
            __builder.AddAttribute(87, "scope", "col");
            __builder.AddContent(88, 
#nullable restore
#line 204 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                 others.RATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                                ");
            __builder.OpenElement(90, "td");
            __builder.AddAttribute(91, "scope", "col");
            __builder.AddContent(92, 
#nullable restore
#line 205 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                 total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 207 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(93, "tr");
            __builder.AddMarkupContent(94, "<td colspan=\"3\" style=\"text-align:right\"><b>Total</b></td>\r\n                            ");
            __builder.OpenElement(95, "td");
            __builder.OpenElement(96, "b");
            __builder.AddContent(97, 
#nullable restore
#line 210 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                    others_Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                <br>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 218 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
         if (department == "Admin & HR")
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "col-6");
            __builder.AddAttribute(101, "style", "margin-bottom:150px");
            __builder.AddMarkupContent(102, "<label>Actions:</label>&nbsp;\r\n                ");
            __builder.OpenElement(103, "select");
            __builder.AddAttribute(104, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 222 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                requisitionDetails.STATUS

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => requisitionDetails.STATUS = __value, requisitionDetails.STATUS));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(106, "option");
            __builder.AddAttribute(107, "value");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                    ");
            __builder.OpenElement(109, "option");
            __builder.AddContent(110, "Open");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                    ");
            __builder.OpenElement(112, "option");
            __builder.AddContent(113, "Approved");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                    ");
            __builder.OpenElement(115, "option");
            __builder.AddContent(116, "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n\r\n                ");
            __builder.OpenElement(118, "button");
            __builder.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 230 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                   () => ChangeStatus(requisitionDetails.REQUISITION_NO,requisitionDetails.STATUS)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(120, "class", "btn btn-info");
            __builder.AddContent(121, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                ");
            __builder.OpenElement(123, "label");
            __builder.AddContent(124, 
#nullable restore
#line 231 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                        message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 233 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 239 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
       
    [Parameter]
    public string requisition_no { get; set; }
    PurchaseRequisitionViewEntity requisitionDetails = new PurchaseRequisitionViewEntity();
    List<PurchaseRequisitionOthersModel> othersDetails = new List<PurchaseRequisitionOthersModel>();
    List<OrderItemEntity> requestItemList = new List<OrderItemEntity>();
    string message;
    string department = "";
    double otherstotal;
    decimal others_Total;
    decimal requisition_Total;

    protected override async Task OnInitializedAsync()
    {
        await GetRequisitionDetails();
        department = await sessionStorage.GetItemAsync<string>("session_employeeDepartment");
    }
    public async Task GetRequisitionDetails()
    {
        requisitionDetails = await Http.GetJsonAsync<PurchaseRequisitionViewEntity>(Utility.BaseUrl + "api/Purchase/GetPurchaseRequisitionInfoByNo/" + requisition_no);
        requestItemList = await Http.GetJsonAsync<List<OrderItemEntity>>(Utility.BaseUrl + "api/Purchase/GetRequisitionItemDetailsByReqNo/" + requisition_no);
        othersDetails = await Http.GetJsonAsync<List<PurchaseRequisitionOthersModel>>(Utility.BaseUrl + "api/Purchase/GetRequisitionOthersItemDetailsByReqNo/" + requisition_no);
        requisition_Total= Convert.ToDecimal(String.Format("{0:0.00}", requisitionDetails.REQUISITION_TOTAL));
        foreach (var item in othersDetails)
        {
            otherstotal += item.QUANTITY * item.RATE;
        }
        others_Total = Convert.ToDecimal(String.Format("{0:0.00}", otherstotal));
    }
    private async void ChangeStatus(string ReqNo, string Status)
    {
        PurchaseRequisitionEntity p = new PurchaseRequisitionEntity();
        p.REQUISITION_NO = ReqNo;
        p.STATUS = Status;

        await Http.PutJsonAsync<PurchaseRequisitionEntity>(Utility.BaseUrl + "api/Purchase/UpdateRequisitionStatus", p);
        if (Status == "Approved")
        { toastService.ShowSuccess("Requisition Approved"); }
        else if (Status == "Cancel")
        {
            toastService.ShowError("Requisition Cancel");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
