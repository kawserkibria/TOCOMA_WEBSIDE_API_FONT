#pragma checksum "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Transection\ReceiveVoucherList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c6e9abda857220dc6fa47d3afdd92ec8e15d429"
// <auto-generated/>
#pragma warning disable 1591
namespace TOCOMA_ERP_System.Pages.Accounce.Transection
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ReceiveVoucherList")]
    public partial class ReceiveVoucherList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "<div class=\"card-header\">\r\n        Receive List /\r\n        <a href=\"ReceiveVoucher\">New Receive</a></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "testbox");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "tablearea");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "id", "example");
            __builder.AddAttribute(9, "class", "display");
            __builder.AddAttribute(10, "style", "width:100%");
            __builder.AddMarkupContent(11, @"<thead><tr><th>Ref No.</th>
                        <th>Ledger Name</th>
                        <th>Voucher Date</th>
                        <th>Month</th>
                        <th>Amount</th>
                        <th></th>
                        <th></th>
                        <th></th></tr></thead>
                ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 31 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Transection\ReceiveVoucherList.razor"
                     if (accCompanyVoucherList != null)
                    {
                        foreach (var item in accCompanyVoucherList)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 36 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Transection\ReceiveVoucherList.razor"
                             item.COMP_REF_NO

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 37 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Transection\ReceiveVoucherList.razor"
                             item.LEDGER_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 38 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Transection\ReceiveVoucherList.razor"
                             item.COMP_VOUCHER_DATE.Day

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, "/");
            __builder.AddContent(23, 
#nullable restore
#line 38 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Transection\ReceiveVoucherList.razor"
                                                         item.COMP_VOUCHER_DATE.Month

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(24, "/");
            __builder.AddContent(25, 
#nullable restore
#line 38 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Transection\ReceiveVoucherList.razor"
                                                                                       item.COMP_VOUCHER_DATE.Year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 39 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Transection\ReceiveVoucherList.razor"
                             item.COMP_VOUCHER_MONTH_ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 40 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Transection\ReceiveVoucherList.razor"
                             item.COMP_VOUCHER_NET_AMOUNT

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "td");
            __builder.AddAttribute(34, "style", "text-align:center;width:6%");
            __builder.OpenElement(35, "a");
            __builder.AddAttribute(36, "href", "EditReceiveVoucher/" + (
#nullable restore
#line 41 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Transection\ReceiveVoucherList.razor"
                                                                                            item.COMP_REF_NO

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "td");
            __builder.AddAttribute(40, "style", "text-align:center;width:6%");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Transection\ReceiveVoucherList.razor"
                                                                             () => DeletePayment(item.COMP_REF_NO)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(43, "<span style=\"color:red\" class=\"oi oi-trash\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.OpenElement(45, "td");
            __builder.AddAttribute(46, "style", "text-align:center;width:6%");
            __builder.OpenElement(47, "a");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Transection\ReceiveVoucherList.razor"
                                                                             () => PaymentViewReport(item.COMP_REF_NO)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "style", "cursor:pointer;color:Highlight");
            __builder.AddContent(50, "View");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Transection\ReceiveVoucherList.razor"
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
            __builder.AddMarkupContent(51, "\r\n\r\n");
            __builder.AddMarkupContent(52, "<form action=\"RDLCReport/GetPaymentReport\" target=\"_blank\" method=\"post\" style=\"display:none\"><button type=\"submit\" id=\"submitbutton\"></button></form>");
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Transection\ReceiveVoucherList.razor"
       
    List<ACC_COMPANY_VOUCHER_MODEL> accCompanyVoucherList = new List<ACC_COMPANY_VOUCHER_MODEL>();
    string btnLabel;
    int Receive_Voucher_Type = 2;
    List<ACC_VOUCHER_MODEL> voucher = new List<ACC_VOUCHER_MODEL>();
    SessionData session = new SessionData();
    protected override async Task OnInitializedAsync()
    {
        btnLabel = "Save";
        await GetVoucherList();
        StateHasChanged();
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");

    }
    private async Task GetVoucherList()
    {
        accCompanyVoucherList = await Http.GetJsonAsync<List<ACC_COMPANY_VOUCHER_MODEL>>(Utility.BaseUrl + "api/Transection/GetVoucherList/" + Receive_Voucher_Type);
    }


    private void EditClick(int Code)
    {
        btnLabel = "Update";
        //branch = branchList.FirstOrDefault(x => x.BRANCH_ID == branchCode);
    }
    private async Task DeletePayment(string Code)
    {
        if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete ?"))
            return;

        ACC_COMPANY_VOUCHER_MODEL vouchermodel = new ACC_COMPANY_VOUCHER_MODEL();
        vouchermodel.COMP_REF_NO = Code;
        vouchermodel.COMP_VOUCHER_TYPE =2;
        await Http.PostJsonAsync(Utility.BaseUrl + "api/Transection/DeletePaymentByRefNo", vouchermodel);
        await GetVoucherList();
    }
    public async Task PaymentViewReport(string REFNO)
    {

        voucher = new List<ACC_VOUCHER_MODEL>();
        voucher = await Http.GetJsonAsync<List<ACC_VOUCHER_MODEL>>(Utility.BaseUrl + "api/Transection/GetACCVoucherByRefNo/" + REFNO);
        SessionData.paymentDataList = voucher;
        int type = 2;
        await JSRuntime.InvokeAsync<object>("open", "api/RDLCReport/GetPaymentReport/" + REFNO+"/"+ type, "_blank");
        //var postBody = new { Title = "Blazor POST Request Example" };
        //using var response = await Http.PostJsonAsync("https://reqres.in/invalid-url", postBody);
        //var request = new HttpRequestMessage(HttpMethod.Post, "RDLCReport/GetPaymentReport");
        //accCompanyVoucherModel = await Http.GetJsonAsync<ACC_COMPANY_VOUCHER_MODEL>(Utility.BaseUrl + "api/Transection/GetPaymentVoucherByRefNo/" + REFNO);
        //voucher = new List<ACC_VOUCHER_MODEL>();
        //voucher = await Http.GetJsonAsync<List<ACC_VOUCHER_MODEL>>(Utility.BaseUrl + "api/Transection/GetACCVoucherByRefNo/" + REFNO);
        //SessionData.paymentDataList = new List<ACC_VOUCHER_MODEL>();
        //href = "http://localhost:7558/api/RDLCReport/GetPaymentReport/@item.COMP_REF_NO"
        //SessionData.paymentDataList = voucher;

        //navManager.NavigateTo("api/RDLCReport/GetPaymentReport/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
    }
}
#pragma warning restore 1591
