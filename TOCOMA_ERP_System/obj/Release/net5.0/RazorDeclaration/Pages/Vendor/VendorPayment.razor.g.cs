// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TOCOMA_ERP_System.Pages.Vendor
{
    #line hidden
    using System;
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
#line 3 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\VendorPayment.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\VendorPayment.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\VendorPayment.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\VendorPayment.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\VendorPayment.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/VendorPayment/{vendorCode}")]
    public partial class VendorPayment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 319 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\VendorPayment.razor"
       
    [Parameter]
    public string requisition_no { get; set; }
    [Parameter]
    public string vendorCode { get; set; }
    //private ReportService _ReportService = new ReportService();
    DataSet DS_OUTPUT_DATA = new DataSet();
    List<ItemEntity> productList = new List<ItemEntity>();
    PurchaseOrderEntity purchaseOrder = new PurchaseOrderEntity();
    DateTime invoice_Date = System.DateTime.Now;
    DateTime document_Date = System.DateTime.Now;
    DateTime cheque_Date = System.DateTime.Now;
    DateTime nextpayment_date = System.DateTime.Now;
    PurchaseOrderModel purchaseOrderModel = new PurchaseOrderModel();
    List<VendorEntity> vendorList = new List<VendorEntity>();
    PRE pp = new PRE();
    List<VendorEntity> vendorlist = new List<VendorEntity>();
    List<OrderItemEntity> requestItemList = new List<OrderItemEntity>();
    public string po_no { get; set; }
    string payment_type;
    PurchaseOrderDetailsEntity details = new PurchaseOrderDetailsEntity();
    List<PurchaseOrderViewModel> purchaseDetailsList = new List<PurchaseOrderViewModel>();
    List<PurchaseOrderDetailsEntity> oOrderDetailsList = new List<PurchaseOrderDetailsEntity>();
    VendorPaymentModel vendorPayment = new VendorPaymentModel();
    List<BankModel> bankList = new List<BankModel>();
    List<BankBranchModel> branchList = new List<BankBranchModel>();
    DateTime payment_date = System.DateTime.Now;
    List<PurchaseOrderViewModel> poList = new List<PurchaseOrderViewModel>();
    string vendor;
    string Vendor_Id;
    double t;
    double FinalTotal;
    double balance;
    double paidAmount;
    double due;
    double OUTSTANDING_BALANCE = 0;


    //protected bool IsDisabled { get; set; }




    //[Parameter]
    //public string Format { get; set; } = "dd/mm/yyyy";


    public async Task GetProductDetailsBYPO()
    {
        string pono = vendorPayment.PO_NUMBER_LONG_CODE;
        //purchaseDetailsList = await Http.GetJsonAsync<List<PurchaseOrderDetailsEntity>>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderDetailsByPO_NO/" + pono);
        //pOrderList = await Http.GetJsonAsync<List<PurchaseOrderEntity>>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderDetailsByPO_NO/" + pono);
        //pOrderList = await Http.GetJsonAsync<List<PurchaseOrderViewModel>>(Utility.BaseUrl + "api/Purchase/GetPOList");
        purchaseDetailsList = await Http.GetJsonAsync<List<PurchaseOrderViewModel>>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderDetailsByPO/" + pono);

        foreach (var data in purchaseDetailsList)
        {
            t = 0;
            t = Convert.ToDouble(data.UNIT_PRICE) * Convert.ToDouble(data.QUANTITY);
            FinalTotal += t;
        }
        var first = purchaseDetailsList.First();
        vendor = first.VENDOR_NAME;
        //Vendor_Id = first.VENDOR_ID;
        //GetVendorOutStandingBalance(Vendor_Id);



    }
    //private async void GetVendorOutStandingBalance(int vendor_id)
    //{
    //    double OUTSTANDING_BALANCE = await Http.GetJsonAsync<double>(Utility.BaseUrl + "api/Vendor/GetSupplierOutStandingBalance/" + vendor_id);
    //}
    private async void PaidAmount_Clicked(ChangeEventArgs paidAmountevent)
    {
        balance = FinalTotal - Convert.ToDouble(paidAmountevent.Value.ToString());
    }
    private async void PaymentTypeClicked(ChangeEventArgs changeEventArgs)
    {
        payment_type = changeEventArgs.Value.ToString();
    }
    private async void BankClicked(ChangeEventArgs changeEventArgs)
    {
        branchList = await Http.GetJsonAsync<List<BankBranchModel>>(Utility.BaseUrl + "api/Bank/GetBranchList/" + changeEventArgs.Value.ToString());
        StateHasChanged();
    }
    protected override async Task OnInitializedAsync()
    {

        ////IsDisabled = true;
        //requestItemList = await Http.GetJsonAsync<List<OrderItemEntity>>(Utility.BaseUrl + "api/Purchase/GetRequisitionItemDetailsByReqNo/" + requisition_no);
        bankList = await Http.GetJsonAsync<List<BankModel>>(Utility.BaseUrl + "api/Bank");
        //purchaseDetailsList= await Http.GetJsonAsync<List<PurchaseOrderDetailsEntity>>(Utility.BaseUrl + "api/Purchase/GetRequisitionItemDetailsByReqNo/" + requisition_no);
        await GetSupplier();
        poList = await Http.GetJsonAsync<List<PurchaseOrderViewModel>>(Utility.BaseUrl + "api/Purchase/GetUnPaidPoListByVendorCode/" + vendorCode);
        //OUTSTANDING_BALANCE = await Http.GetJsonAsync<double>(Utility.BaseUrl + "api/Vendor/GetSupplierOutStandingBalance/" + vendorPayment.PO_NUMBER_LONG_CODE);
        if (vendorlist.Count > 0)
        {
            vendor = vendorlist.FirstOrDefault(x => x.VENDOR_ID == Convert.ToInt32(vendorCode)).VENDOR_NAME;
            vendorPayment.VENDOR_ID = vendorlist.FirstOrDefault(x => x.VENDOR_ID == Convert.ToInt32(vendorCode)).VENDOR_ID;
        }
    }
    private async Task GetSupplier()
    {
        vendorlist = await Http.GetJsonAsync<List<VendorEntity>>(Utility.BaseUrl + "api/Vendor");
    }
    async void CheckboxClicked(string poId, object checkedValue)
    {
        if ((bool)checkedValue)
        {
            vendorPayment.PO_NUMBER_LONG_CODE = poId;
            OUTSTANDING_BALANCE = await Http.GetJsonAsync<double>(Utility.BaseUrl + "api/Vendor/GetSupplierOutStandingBalance/" + vendorPayment.PO_NUMBER_LONG_CODE);
        }
        this.StateHasChanged();
    }
    public async Task SavePurchaseOrder()
    {

        if (IsValidation() != true)
        {
            try
            {
                //vendorPayment.AMOUNT_PAID = paidAmount;
                vendorPayment.PAYMENT_DATE = payment_date;
                //vendorPayment.PO_ID = purchaseDetailsList.First().PO_ID;
                //vendorPayment.PO_NUMBER_LONG_CODE = purchaseDetailsList.First().PO_NUMBER_LONG_CODE;
                //vendorPayment.VENDOR_ID = purchaseOrderModel.VENDOR_ID;//Convert.ToInt32(Vendor_Id);//purchaseDetailsList.First().VENDOR_ID;
                vendorPayment.CHEQUE_DATE = cheque_Date;
                vendorPayment.PAYMENT_AMOUNT = FinalTotal;
                vendorPayment.AMOUNT_DUE = due;
                vendorPayment.NEXT_PAYMENT_DATE = nextpayment_date;

                vendorPayment.TOTAL_INVOICE_AMOUNT = FinalTotal;
                vendorPayment.REG_BY = "Asad";
                vendorPayment.TYPE_OF_PAYMENT = payment_type;

                var payment = await Http.PostJsonAsync<VendorPaymentModel>(Utility.BaseUrl + "api/Vendor/AddVendorPayment", vendorPayment);
                //var id = await Http.GetJsonAsync<int>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderId/" + purchaseOrderModel.PO_NUMBER_LONG_CODE);

                //var payment = await Http.PostJsonAsync<List<PurchaseOrderDetailsEntity>>(Utility.BaseUrl + "api/Purchase/AddPurchaseOrderDetails", purchaseDetailsList);
                toastService.ShowSuccess("Insert Successfully!!!");
            }
            catch (Exception ex)
            {

            }

        }
    }
    private bool IsValidation()
    {
        bool flag = false;
        //if (vendorPayment.AMOUNT_PAID== "" || purchaseOrderModel.PO_NUMBER_LONG_CODE == string.Empty || purchaseOrderModel.PO_NUMBER_LONG_CODE == null)
        //{
        //    toastService.ShowWarning("Requisition No cannot be empty!");
        //    flag = true;
        //}

        return flag;
    }
    protected async void Vendor_Clicked(ChangeEventArgs changeEventArgs)
    {
        //pOrderView.REPORT_TYPE = categoryevent.Value.ToString();
        Vendor_Id = changeEventArgs.Value.ToString();
        OUTSTANDING_BALANCE = await Http.GetJsonAsync<double>(Utility.BaseUrl + "api/Vendor/GetSupplierOutStandingBalance/" + Vendor_Id);
        this.StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
