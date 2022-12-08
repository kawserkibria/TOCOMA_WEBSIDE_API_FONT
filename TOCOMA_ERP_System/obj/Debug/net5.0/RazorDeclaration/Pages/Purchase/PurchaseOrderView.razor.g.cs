// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TOCOMA_ERP_System.Pages.Purchase
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
#nullable restore
#line 6 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderView.razor"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderView.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/PurchaseOrderView/{po_number}")]
    public partial class PurchaseOrderView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 264 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderView.razor"
       

    [Parameter]
    public string po_number { get; set; }
    PurchaseOrderViewModel purchaseOrderView = new PurchaseOrderViewModel();
    List<PurchaseOrderDetailsEntity> purchaseOrderDetailsList = new List<PurchaseOrderDetailsEntity>();
    List<PackagingInstructionModel> packagingInsList = new List<PackagingInstructionModel>();
    List<PurchaseTermsConditionsModel> termsConditionList = new List<PurchaseTermsConditionsModel>();
    string _localcolor;
    string _intcolor;
    int IL_OPTION;
    string packInsId = "";
    string termsId = "";

    protected override async Task OnInitializedAsync()
    {
        await GetPurchaseOrder();
        packInsId = purchaseOrderView.PACKAGING_INSTRUCTION;
        termsId = purchaseOrderView.OTHER_TERMS_AND_CONDITION;
        if (packInsId != null) { packagingInsList = await Http.GetJsonAsync<List<PackagingInstructionModel>>(Utility.BaseUrl + "api/Purchase/GetPackagingInstructionById/" + packInsId); }
        if (termsId != null) { termsConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Purchase/GetTermsAndConditions/" + termsId); }


        if (purchaseOrderView.VENDOR_TYPE_STATUS == "Local")
        {
            IL_OPTION = 1;
            _localcolor = "gray";
        }
        else
        {
            IL_OPTION = 2;
            _intcolor = "gray";
        }

    }
    public async Task GetPurchaseOrder()
    {
        purchaseOrderView = await Http.GetJsonAsync<PurchaseOrderViewModel>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderInfo/" + po_number);
        purchaseOrderDetailsList = await Http.GetJsonAsync<List<PurchaseOrderDetailsEntity>>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderDetailsByPO_NO/" + po_number);
        //requestItemList = await Http.GetJsonAsync<List<OrderItemEntity>>(Utility.BaseUrl + "api/Purchase/GetRequisitionItemDetailsByReqNo/" + requisition_no);
        //othersDetails = await Http.GetJsonAsync<List<PurchaseRequisitionOthersModel>>(Utility.BaseUrl + "api/Purchase/GetRequisitionOthersItemDetailsByReqNo/" + requisition_no);
        AppState.porder = purchaseOrderView;
        AppState.porderDetails = purchaseOrderDetailsList;
    }
    private void Local_Tab_Click()
    {
        _localcolor = "gray";
        _intcolor = "ghostwhite";
        IL_OPTION = 1;
        //selectedVendorList = vendorList.FindAll(x => x.VENDOR_TYPE_STATUS == "Local");
    }
    private void Int_Tab_Click()
    {
        _localcolor = "ghostwhite";
        _intcolor = "gray";
        IL_OPTION = 2;
        //selectedVendorList = vendorList.FindAll(x => x.VENDOR_TYPE_STATUS == "International");
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
