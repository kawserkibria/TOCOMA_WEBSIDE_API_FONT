#pragma checksum "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "444a696a7e3c86d87606e015b457ddd41cc5c435"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/QuotationList")]
    public partial class QuotationList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "height:100%");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-header");
            __builder.AddMarkupContent(5, "\r\n        Quotation List &nbsp;\r\n        ");
            __builder.AddMarkupContent(6, "<a href=\"SalesQuotation\">New Quotation</a>");
#nullable restore
#line 15 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
         if (checkStatus == true)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<form action=\"Excel/SalesQuotation\" method=\"post\" style=\"display:none\"><button type=\"submit\" id=\"submitbutton\"></button></form>");
#nullable restore
#line 20 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "style", "float:right");
            __builder.OpenElement(10, "label");
            __builder.AddContent(11, 
#nullable restore
#line 25 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
                    StartNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, "-");
            __builder.AddContent(13, 
#nullable restore
#line 25 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
                                 EndNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, " of ");
            __builder.AddContent(15, 
#nullable restore
#line 25 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
                                               customerList.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(16, " ");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "style", "color:Highlight");
            __builder.OpenElement(19, "i");
            __builder.AddAttribute(20, "class", "bi bi-arrow-left-circle");
            __builder.AddAttribute(21, "style", "font-size:30px");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
                                                                                                                                                                             e => NavigatTo("prev")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddContent(23, "????");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "style", "color:Highlight");
            __builder.OpenElement(26, "i");
            __builder.AddAttribute(27, "class", "bi bi-arrow-right-circle");
            __builder.AddAttribute(28, "style", "font-size:30px;margin-right:10px");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
                                                                                                                                                                                                                                                                                                                                              e => NavigatTo("next")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "table");
            __builder.AddAttribute(32, "class", "table");
            __builder.AddMarkupContent(33, @"<thead><tr><th></th>
                <td>New PO</td>
                <th>Quotation No</th>
                <td>Quotation Date</td>
                <td>Customer</td>
                <td>Sales Person</td>
                <td>Quotation<br>Type</td></tr></thead>
        ");
            __builder.OpenElement(34, "tbody");
#nullable restore
#line 45 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
             if (AllquotationList != null)
            {
                foreach (var item in AllquotationList)
                {
                    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "tr");
            __builder.OpenElement(36, "td");
            __builder.AddAttribute(37, "style", "text-align:center;width:30px");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "href", "EditSalesQuotation/" + (
#nullable restore
#line 52 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
                                                                                      item.QUOTATION_NO

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(40, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "td");
            __builder.AddAttribute(43, "style", "text-align:center;width:85px");
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "href", "SalesOrder/" + (
#nullable restore
#line 53 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
                                                                              item.QUOTATION_NO

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, "New PO");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "td");
            __builder.AddAttribute(49, "style", "width:150px");
            __builder.OpenElement(50, "a");
            __builder.AddAttribute(51, "style", "color:Highlight;cursor:pointer");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
                                                                                             () => GetSalesQuotationById(item.SALES_QUOTATION_ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(53, 
#nullable restore
#line 54 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
                                                                                                                                                    item.QUOTATION_NO

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n                ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 56 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
                     item.QUOTATION_DATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 57 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
                     item.CUSTOMER_NAME_SHORT_FORM

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "td");
            __builder.AddContent(62, 
#nullable restore
#line 58 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
                     item.SALES_PERSON

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "td");
            __builder.AddContent(65, 
#nullable restore
#line 59 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
                     item.QUOTATION_TYPE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "modal fade bd-example-modal-lg");
            __builder.AddAttribute(69, "tabindex", "-1");
            __builder.AddAttribute(70, "role", "dialog");
            __builder.AddAttribute(71, "aria-labelledby", "myLargeModalLabel");
            __builder.AddAttribute(72, "aria-hidden", "true");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "modal-dialog modal-xl");
            __builder.AddMarkupContent(75, "<div class=\"col-md-12\"></div>\r\n        ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "modal-content");
            __builder.AddMarkupContent(78, @"<div class=""modal-header""><div class=""form-outline""><h4 class=""p-2""><img src=""images/fountain-pen.png"" alt width=""50"" height=""50"" class=""mr-3""><span class=""text-uppercase""> UPDATE SHIPMENT INFORMATION</span></h4></div>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button></div>
            ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(81);
            __builder.AddAttribute(82, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 90 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
                                  customer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(84, @"<table class=""table""><thead style=""font-weight:bold""><tr><td>PO NO</td>
                                <td>PO Date</td>
                                <td>Supplier</td>
                                <td>Concern Person</td></tr></thead>

                        <tbody></tbody></table>
                    <br>
                    ");
                __builder2.AddMarkupContent(85, @"<table class=""table table-striped ""><thead style=""font-weight:bold""><tr><td scope=""col"" colspan=""3"">ETD with QTY</td>
                                <td scope=""col"" colspan=""3"">ETA to CTG</td>
                                <td scope=""col"" colspan=""3"">EA at TL-WH</td></tr>
                            <tr><td>1st Date</td>
                                <td>2nd Date</td>
                                <td>3rd Date</td>
                                <td>1st Date</td>
                                <td>2nd Date</td>
                                <td>3rd Date</td>
                                <td>1st Date</td>
                                <td>2nd Date</td>
                                <td>3rd Date</td></tr></thead>
                        <tbody></tbody></table>
                    <br>
                    ");
                __builder2.AddMarkupContent(86, "<table width=\"100%\"><thead style=\"font-weight:bold\"><tr><td>Receive Date</td>\r\n                                <td>Shipment Status</td></tr></thead>\r\n                        <tbody></tbody></table>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\r\n            ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "modal-footer");
            __builder.OpenElement(90, "div");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "class", "btn btn-info");
            __builder.AddAttribute(93, "data-dismiss", "modal");
            __builder.AddAttribute(94, "style", "border:none;width:120px;float:right;margin-left:10px");
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 144 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
                                                                                                                                             SaveCustomer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(96, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                    ");
            __builder.AddMarkupContent(98, "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 156 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationList.razor"
       

    CustomerModel customer = new CustomerModel();
    List<CustomerViewModel> allcustomerList = new List<CustomerViewModel>();
    List<CustomerViewModel> customerList = new List<CustomerViewModel>();
    List<SalesQuotationView> AllquotationList = new List<SalesQuotationView>();
    List<SalesQuotationView> quotationList = new List<SalesQuotationView>();
    SalesQuotationView salesQuotationInfo = new SalesQuotationView();
    List<SalesQuotationItemView> salesQuotationItemList = new List<SalesQuotationItemView>();
    List<PurchaseTermsConditionsModel> termsConditionList = new List<PurchaseTermsConditionsModel>();
    public int pageSize { get; set; }
    public int TotalPage { get; set; }
    public int Currentpage { get; set; }
    public int StartNumber { get; set; }
    public int EndNumber { get; set; }
    bool checkStatus = false;
    int iOption = 0;

    protected override async Task OnInitializedAsync()
    {
        AllquotationList = await Http.GetJsonAsync<List<SalesQuotationView>>(Utility.BaseUrl + "api/Sales/GetAllQuotation");
        quotationList = await Http.GetJsonAsync<List<SalesQuotationView>>(Utility.BaseUrl + "api/Sales/GetAllQuotation");
        //AppState.salesQuotation = quotationList;
        Pagination();
    }
    public async Task SaveCustomer()
    {

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
        AllquotationList = quotationList.Skip(pageNumber * pageSize).Take(pageSize).ToList();
        Currentpage = pageNumber;
        if (allcustomerList.Count > 0)
        {
            StartNumber = AllquotationList.FirstOrDefault().SL;
            EndNumber = AllquotationList[AllquotationList.Count - 1].SL;
        }

    }
    private void Pagination()
    {
        pageSize = 20;
        if (quotationList.Count > 0)
        {
            AllquotationList = quotationList.Take(pageSize).ToList();
            TotalPage = (int)Math.Ceiling(customerList.Count() / (decimal)pageSize);
            StartNumber = AllquotationList.FirstOrDefault().SL;
            EndNumber = AllquotationList[AllquotationList.Count - 1].SL;
        }

    }
    async void CheckboxClicked(int poId, object checkedValue)
    {
        if ((bool)checkedValue)
        {

            await GetSalesQuotationById(poId);
            checkStatus = true;
            StateHasChanged();
        }
    }
    private async Task GetSalesQuotationById(int poId)
    {

        salesQuotationInfo = await Http.GetJsonAsync<SalesQuotationView>(Utility.BaseUrl + "api/Sales/GetsalesQuotationInfoById/" + poId);
        if (salesQuotationInfo.TERMS_AND_CONDITION != null && salesQuotationInfo.TERMS_AND_CONDITION != "")
        {
            termsConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Sales/GetSalesTermsAndConditionsByIds/" + salesQuotationInfo.TERMS_AND_CONDITION);
            AppState.SalestermsConditionList = termsConditionList;
        }

        //porder.REPORT_TYPE = "1";
        salesQuotationItemList = await Http.GetJsonAsync<List<SalesQuotationItemView>>(Utility.BaseUrl + "api/Sales/GetSalesQuotationItemListById/" + poId);
        //porder.pOrderDetailsList = purchaseOrderDetailsList;
        AppState.salesQuotation = salesQuotationInfo;
        AppState.salesQuotationitemList = salesQuotationItemList;

        await js.InvokeAsync<object>("open", "api/RDLCReport/GetSalesQuotation", "_blank");
    }
    private void Download()
    {
        if (checkStatus == true)
        {
            iOption = 1;
            StateHasChanged();


        }
        else { toastService.ShowWarning("Please Select Item For Download"); }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
