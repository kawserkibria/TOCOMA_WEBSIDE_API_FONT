#pragma checksum "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a5a35e72ea97ca977b377dfc3e3ef13a6eb34b6"
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
#nullable restore
#line 6 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderList.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/PurchaseOrderList")]
    public partial class PurchaseOrderList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dashboard-details");
            __builder.AddMarkupContent(2, "<h4 class=\"p-2\"><img src=\"images/fountain-pen.png\" alt width=\"50\" height=\"50\" class=\"mr-3\"><span class=\"text-uppercase\">PURCHASE ORDER LIST</span></h4>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "newRequsitionForm-content");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container-fluid");
            __builder.AddMarkupContent(7, "<br>\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "analytic_details_contain_two");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table table-striped");
            __builder.AddMarkupContent(12, @"<thead style=""background-color:steelblue;color:white""><tr><td>PO No.</td>
                            <td>PO Date</td>
                            <td>PO Total</td>
                            <td>Status</td>
                            <td>Vendor Type</td></tr></thead>
                    ");
            __builder.OpenElement(13, "tbody");
#nullable restore
#line 38 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderList.razor"
                         if (poList != null)
                        {
                            foreach (var item in poList)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "tr");
            __builder.OpenElement(15, "td");
            __builder.AddAttribute(16, "style", "width:150px");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderList.razor"
                                                                           () => PurchaseOrderInvoice(item.PO_NUMBER_LONG_CODE)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "style", "cursor:pointer;color:Highlight");
            __builder.AddContent(20, 
#nullable restore
#line 45 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderList.razor"
                                                                                                                                                                         item.PO_NUMBER_LONG_CODE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "                                    \r\n                                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 46 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderList.razor"
                                         item.PO_DATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 47 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderList.razor"
                                         item.GRAND_TOTAL

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, " ");
            __builder.AddContent(28, 
#nullable restore
#line 47 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderList.razor"
                                                           item.CURRENCY

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                                    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 48 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderList.razor"
                                         item.SHIPMENT_STATUS

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                                    ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 49 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderList.razor"
                                         item.VENDOR_TYPE_STATUS

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderList.razor"
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
#line 61 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderList.razor"
       
    List<PurchaseOrderViewModel> poList = new List<PurchaseOrderViewModel>();

    PurchaseOrderModel poModel = new PurchaseOrderModel();
    List<PurchaseOrderViewModel> pOrderView = new List<PurchaseOrderViewModel>();
    PurchaseOrderViewModel porder = new PurchaseOrderViewModel();
    PurchaseOrderViewModel purchaseOrderView = new PurchaseOrderViewModel();
    List<PurchaseOrderDetailsEntity> purchaseOrderDetailsListByPO_Id = new List<PurchaseOrderDetailsEntity>();
    List<PurchaseOrderDetailsEntity> purchaseOrderDetailsList = new List<PurchaseOrderDetailsEntity>();
    PurchaseOrderDetailsEntity porderDetailsEntity = new PurchaseOrderDetailsEntity();
    DateTime PO_FROM_DATE = System.DateTime.Now;
    DateTime PO_TO_DATE = System.DateTime.Now;
    string str;
    bool isChecked;
    public List<string> checkedPOIds { get; set; } = new List<string>();

    string reportType;

    protected override async Task OnInitializedAsync()
    {
        await GetPurchaseRequisition();
    }
    private async Task GetPurchaseRequisition()
    {
        poList = await Http.GetJsonAsync<List<PurchaseOrderViewModel>>(Utility.BaseUrl + "api/Purchase/GetPOList");
    }
    private async Task PrintOption()
    {
        //if (reportType == "1") { await Http.PostJsonAsync("http://localhost:8060/Report/PurchaseOrder", porder); }
        //else if (reportType == "2")
        //{
        //    await GetPODetailsItemByPOID(PO_FROM_DATE, PO_TO_DATE);
        //    if (pOrderView.Count > 0) { await Http.PostJsonAsync("https://localhost:44350/Report/PurchaseOrderTracker", pOrderView); }


        //}
        if (isChecked == true)
        {
            try
            {
                //await Http.PostJsonAsync("https://localhost:44350/Report/PurchaseOrder", porder);
                //await Http.GetStringAsync("http://localhost:44350/Report/PurchaseOrder/"+porder);
                //var data =await Http.PostJsonAsync<PurchaseOrderViewModel>("http://localhost:44350/Report/PurchaseOrder", porder);
                //var data=await Http.PostJsonAsync<PurchaseOrderViewModel>("http://localhost:44350/api/Test2/PurchaseOrder", porder);


                //var data = await Http.PostJsonAsync<PurchaseOrderViewModel>("http://localhost:8060/api/Test3", porder);  //  web
                var data = await Http.PostJsonAsync<PurchaseOrderViewModel>("http://localhost:8060/api/Test3", porder);

                //using var response = await Http.PostJsonAsync("https://reqres.in/invalid-url", porder);
                //await Http.PostJsonAsync("http://localhost:44350/Report/PurchaseOrder", porder);
                //var data= await Http.PostJsonAsync<PurchaseOrderViewModel>("http://localhost:44350/Report/PurchaseOrder",porder);
                //string reqNo = await Http.GetStringAsync("http://localhost:44350/api/Test2/GetReqNo");
                //porder.ADDRESS = "hgfhgfh";
                //await Http.GetStringAsync("http://localhost:44350/Report/GetReqNo/" + porder.ADDRESS);

                //string url =Utility.ReportUrl + "Report/PurchaseOrder";

                //var data = await Http.PostJsonAsync<PurchaseOrderViewModel>(url, porder);

                //-------













                await js.InvokeVoidAsync("alert", "Success!!");
            }
            catch (Exception ex)
            {
                await js.InvokeVoidAsync("alert", ex.Message);
                return;
            }

        }
        else
        {
            await js.InvokeVoidAsync("alert", "Please Select One to print.");
            return;
        }

    }
    async void CheckboxClicked(string poId, object checkedValue)
    {
        if ((bool)checkedValue)
        {
            isChecked = true;
            //if(reportType=="1")
            //{
            //    await GetPOItemByPOID(poId);
            //}
            await GetPOItemByPOID(poId);

            //if (!checkedBrandIds.Contains(poId))
            //{
            //    checkedBrandIds.Add(poId);
            //}
        }
        else
        {
            //if (checkedBrandIds.Contains(poId))
            //{
            //    checkedBrandIds.Remove(poId);
            //}
            isChecked = false;
        }
        //str = String.Join(",", checkedBrandIds);



    }
    protected async void ReportType_Clicked(ChangeEventArgs categoryevent)
    {
        //pOrderView.REPORT_TYPE = categoryevent.Value.ToString();
        reportType = categoryevent.Value.ToString();
        //pOrderView.Add(porder.REPORT_TYPE);
        //if(categoryevent.Value.ToString()=="1")
        //{
        //    porder= await Http.GetJsonAsync<PurchaseOrderViewModel>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderByPOId/" + poId);
        //}
        //else if(categoryevent.Value.ToString() == "2")
        //{

        //}


        this.StateHasChanged();
    }
    private async Task GetPOItemByPOID(string poId)
    {

        porder = await Http.GetJsonAsync<PurchaseOrderViewModel>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderByPOId/" + poId);
        porder.REPORT_TYPE = "1";
        purchaseOrderDetailsList = await Http.GetJsonAsync<List<PurchaseOrderDetailsEntity>>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderDetailsByPO_ID/" + poId);
        porder.pOrderDetailsList = purchaseOrderDetailsList;

    }
    private async Task GetPODetailsItemByPOID(DateTime date1, DateTime date2)
    {
        //pOrderView = await Http.GetJsonAsync<List<PurchaseOrderViewModel>>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderByPOId/" + poId);
        pOrderView = await Http.GetJsonAsync<List<PurchaseOrderViewModel>>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderIdByPurchaseDate/" + date1 + "/" + date2);

        if (pOrderView.Count > 0)
        {
            foreach (var p in pOrderView)
            {
                if (!checkedPOIds.Contains(Convert.ToString(p.PO_ID)))
                {
                    checkedPOIds.Add(Convert.ToString(p.PO_ID));
                }
                str = String.Join(",", checkedPOIds);
            }
            purchaseOrderDetailsListByPO_Id = await Http.GetJsonAsync<List<PurchaseOrderDetailsEntity>>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderDetailsBYPO_ID_IN/" + str);
            foreach (var p in pOrderView)
            {
                p.pOrderDetailsList = new List<PurchaseOrderDetailsEntity>();
                p.pOrderDetailsList = purchaseOrderDetailsListByPO_Id.FindAll(x => x.PO_ID == p.PO_ID);
            }
        }
        else { toastService.ShowInfo("No Record Found For Print!"); }
    }
    public async Task PurchaseOrderInvoice(string po_number)
    {
        //string packInsId = "";
        //string termsId = "";
        //List<PackagingInstructionModel> packagingInsList = new List<PackagingInstructionModel>();
        //List<PurchaseTermsConditionsModel> termsConditionList = new List<PurchaseTermsConditionsModel>();
        ////purchaseOrderView = new PurchaseOrderViewModel();
        ////purchaseOrderDetailsList = new List<PurchaseOrderDetailsEntity>();





        purchaseOrderView = await Http.GetJsonAsync<PurchaseOrderViewModel>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderInfo/" + po_number);
        if(purchaseOrderView.VENDOR_TYPE_STATUS=="Local")
        {
            await GetLocal(purchaseOrderView.PO_NUMBER_LONG_CODE);
        }
        else if(purchaseOrderView.VENDOR_TYPE_STATUS=="International")
        {
            await GetInt(purchaseOrderView.PO_NUMBER_LONG_CODE);
        }
        //purchaseOrderDetailsList = await Http.GetJsonAsync<List<PurchaseOrderDetailsEntity>>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderDetailsByPO_NO/" + po_number);
        //packInsId = purchaseOrderView.PACKAGING_INSTRUCTION;
        //termsId = purchaseOrderView.OTHER_TERMS_AND_CONDITION;
        //if (packInsId != null && packInsId!="") { packagingInsList = await Http.GetJsonAsync<List<PackagingInstructionModel>>(Utility.BaseUrl + "api/Purchase/GetPackagingInstructionById/" + packInsId); }
        //if (termsId != null && termsId !="") { termsConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Purchase/GetTermsAndConditions/" + termsId); }
        //AppState.porder = purchaseOrderView;
        //AppState.porderDetails = purchaseOrderDetailsList;
        //AppState.termsConditionList = termsConditionList;
        //if (purchaseOrderView.VENDOR_TYPE_STATUS=="Local")
        //{ await js.InvokeAsync<object>("open", "api/RDLCReport/GetPurchaseOrderInvoiceLocal", "_blank"); }
        //else if(purchaseOrderView.VENDOR_TYPE_STATUS == "International")
        //{ await js.InvokeAsync<object>("open", "api/RDLCReport/GetPurchaseOrderInvoiceInt", "_blank"); }


    }

    private async Task GetLocal(string po_number)
    {
        string packInsId = "";
        string termsId = "";
        List<PackagingInstructionModel> packagingInsList = new List<PackagingInstructionModel>();
        List<PurchaseTermsConditionsModel> termsConditionList = new List<PurchaseTermsConditionsModel>();
        purchaseOrderDetailsList = await Http.GetJsonAsync<List<PurchaseOrderDetailsEntity>>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderDetailsByPO_NO/" + po_number);
        packInsId = purchaseOrderView.PACKAGING_INSTRUCTION;
        termsId = purchaseOrderView.OTHER_TERMS_AND_CONDITION;
        if (packInsId != null && packInsId != "") { packagingInsList = await Http.GetJsonAsync<List<PackagingInstructionModel>>(Utility.BaseUrl + "api/Purchase/GetPackagingInstructionById/" + packInsId); }
        if (termsId != null && termsId != "") { termsConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Purchase/GetTermsAndConditions/" + termsId); }
        AppState.porder = purchaseOrderView;
        AppState.porderDetails = purchaseOrderDetailsList;
        AppState.termsConditionList = termsConditionList;

        await js.InvokeAsync<object>("open", "api/RDLCReport/GetPurchaseOrderInvoiceLocal", "_blank");
    }
    private async Task GetInt(string po_number)
    {
        string packInsId = "";
        string termsId = "";
        List<PackagingInstructionModel> packagingInsList = new List<PackagingInstructionModel>();
        List<PurchaseTermsConditionsModel> termsConditionList = new List<PurchaseTermsConditionsModel>();
        purchaseOrderDetailsList = await Http.GetJsonAsync<List<PurchaseOrderDetailsEntity>>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderDetailsByPO_NO/" + po_number);
        packInsId = purchaseOrderView.PACKAGING_INSTRUCTION;
        termsId = purchaseOrderView.OTHER_TERMS_AND_CONDITION;
        if (packInsId != null && packInsId != "") { packagingInsList = await Http.GetJsonAsync<List<PackagingInstructionModel>>(Utility.BaseUrl + "api/Purchase/GetPackagingInstructionById/" + packInsId); }
        if (termsId != null && termsId != "") { termsConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Purchase/GetTermsAndConditions/" + termsId); }
        AppState.porder = purchaseOrderView;
        AppState.porderDetails = purchaseOrderDetailsList;
        AppState.termsConditionList = termsConditionList;
        AppState.packagingList = packagingInsList;

        await js.InvokeAsync<object>("open", "api/RDLCReport/GetPurchaseOrderInvoiceInt", "_blank");
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
