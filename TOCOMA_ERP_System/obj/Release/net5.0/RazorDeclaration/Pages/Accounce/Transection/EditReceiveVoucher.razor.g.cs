// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TOCOMA_ERP_System.Pages.Accounce.Transection
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditReceiveVoucher/{REFNO}")]
    public partial class EditReceiveVoucher : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 198 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Transection\EditReceiveVoucher.razor"
       
    LedgerModel ledger = new LedgerModel();
    List<LedgerModel> ledgerList = new List<LedgerModel>();
    List<BranchModel> branchList = new List<BranchModel>();
    [Parameter]
    public string REFNO { get; set; }
    string MyProperty;
    List<string> itemList = new List<string>();
    List<CountryModel> countryList = new List<CountryModel>();
    private LedgerModel SelectedArticle;
    private string newTodo;
    List<VoucherItem> voucherItemList = new List<VoucherItem>();
    VoucherItem paymentvoucher = new VoucherItem();
    ACC_COMPANY_VOUCHER_MODEL accCompanyVoucherModel = new ACC_COMPANY_VOUCHER_MODEL();
    List<ACC_VOUCHER_MODEL> paymentVoucherDetails = new List<ACC_VOUCHER_MODEL>();
    ACC_VOUCHER_MODEL voucherDetails = new ACC_VOUCHER_MODEL();
    decimal amount;
    string KeyPressed = "";
    public string Value { get; set; }
    public string MyDrValue { get; set; }
    public string MyCrValue { get; set; }
    private ElementReference myref;
    private ElementReference narrationref;
    private bool isDrDisable { get; set; }
    private bool isCrDisable { get; set; }
    decimal totalDebit;
    decimal totalCredit;
    int visibletext;
    string BranchName;
    string voucherDate;
    string chequeDate;
    string narration;
    int visible_Status = 0;
    string rowId;
    string comRefNo;
    public bool checkedStatus = false;
    // protected bool checkedStatus { get; set; }
    string parent;
    string SelectedString = "";
    int bankStatus = 0;
    string chequeNo;
    string drawnon;
    string voucherChequedate = "";
    string checkuncheckText = "unchecked";

    protected override async Task OnInitializedAsync()
    {
        MyProperty = "Dr";
        visibletext = 1;
        onDisable(MyProperty);
        //await GetCountry();
        await GetLedger();
        await GetBranch();
        StateHasChanged();

    }
    public async Task GetBranch()
    {

        branchList = await Http.GetJsonAsync<List<BranchModel>>(Utility.BaseUrl + "api/Setup/GetBranchList");
        accCompanyVoucherModel = await Http.GetJsonAsync<ACC_COMPANY_VOUCHER_MODEL>(Utility.BaseUrl + "api/Transection/GetPaymentVoucherByRefNo/" + REFNO);
        voucherDate = accCompanyVoucherModel.COMP_VOUCHER_DATE.Year + "-" + (accCompanyVoucherModel.COMP_VOUCHER_DATE.Month).ToString().PadLeft(2, '0') + "-" + accCompanyVoucherModel.COMP_VOUCHER_DATE.Day.ToString().PadLeft(2, '0');
        accCompanyVoucherModel.COMP_VOUCHER_DATE = Convert.ToDateTime(voucherDate);
        narration = accCompanyVoucherModel.COMP_VOUCHER_NARRATION;


        if (branchList.Count > 0)
        { BranchName = branchList.FirstOrDefault().BRANCH_NAME; }
        foreach (var item in accCompanyVoucherModel.accVoucherList)
        {
            paymentvoucher = new VoucherItem();
            paymentvoucher.Serial = item.VOUCHER_SERIAL;
            paymentvoucher.ComRefNo = item.COMP_REF_NO;
            paymentvoucher.symbol = item.VOUCHER_TOBY;
            paymentvoucher.particular = item.LEDGER_NAME;
            paymentvoucher.debitAmount = item.VOUCHER_DEBIT_AMOUNT;
            paymentvoucher.creditAmount = item.VOUCHER_CREDIT_AMOUNT;
            paymentvoucher.ChequeNo = item.VOUCHER_CHEQUE_NUMBER;
            paymentvoucher.chequedate = item.Voucherchequedate;
            paymentvoucher.ChequeDate = item.VOUCHER_CHEQUE_DATE;
            paymentvoucher.DrawnOn = item.VOUCHER_CHEQUE_DRAWN_ON;
            voucherItemList.Add(paymentvoucher);
        }


        GetTotal();
    }
    void DoStuff(ChangeEventArgs e)
    {
        SelectedString = e.Value.ToString();
        Console.WriteLine("It is definitely: " + SelectedString);
    }
    private async Task GetLedger()
    {
        ledgerList = await Http.GetJsonAsync<List<LedgerModel>>(Utility.BaseUrl + "api/Setup/GetLedger");
    }
    //private async Task GetCountry()
    //{
    //    countryList = await Http.GetJsonAsync<List<CountryModel>>(Utility.BaseUrl + "api/Setup/GetCountry");
    //}

    private async void GetChequeDate(ChangeEventArgs change)
    {
        voucherChequedate = change.Value.ToString();
    }
    private async Task<IEnumerable<LedgerModel>> SearchLedger(string searchText)
    {
        return await Task.FromResult(ledgerList.Where(x => x.LEDGER_NAME.ToLower().Contains(searchText.ToLower())).ToList());

        //return await Task.FromResult(ledgerList);
    }
    private async Task<IEnumerable<LedgerModel>> KeyPressLedger(string searchText)
    {
        return await Task.FromResult(ledgerList.Where(x => x.LEDGER_NAME.ToLower().Contains(searchText.ToLower())).ToList());
    }


    public async Task SavePaymentVoucher()
    {
        //if (IsValidation() != true)
        //{
        if (!await jsruntime.InvokeAsync<bool>("confirm", $"Do you want to save ?"))
            return;



        try
        {
            accCompanyVoucherModel.BRANCH_ID = branchList.Find(x => x.BRANCH_NAME == BranchName).BRANCH_ID;
            accCompanyVoucherModel.LEDGER_NAME = voucherItemList.FirstOrDefault().particular;
            accCompanyVoucherModel.COMP_VOUCHER_AMOUNT = totalDebit;
            accCompanyVoucherModel.COMP_VOUCHER_ADD_AMOUNT = totalDebit;
            accCompanyVoucherModel.COMP_VOUCHER_LESS_AMOUNT = totalDebit;
            accCompanyVoucherModel.COMP_VOUCHER_NET_AMOUNT = totalDebit;
            accCompanyVoucherModel.COMP_VOUCHER_PROCESS_AMOUNT = totalDebit;
            accCompanyVoucherModel.COMP_VOUCHER_NARRATION = narration;
            accCompanyVoucherModel.COMP_VOUCHER_TYPE =2;
            accCompanyVoucherModel.ENTRYBY = "Asaduzzaman";
            accCompanyVoucherModel.UPDATEBY = "Asaduzzaman";



            //var data = await Http.PostJsonAsync<ACC_COMPANY_VOUCHER_MODEL>(Utility.BaseUrl + "api/Transection/AddPaymentVoucher", accCompanyVoucherModel);
            accCompanyVoucherModel.accVoucherList = new List<ACC_VOUCHER_MODEL>();
            foreach (var item in voucherItemList)
            {
                voucherDetails = new ACC_VOUCHER_MODEL();

                voucherDetails.COMP_REF_NO = accCompanyVoucherModel.COMP_REF_NO;
                voucherDetails.VOUCHER_REF_KEY = "";
                voucherDetails.BRANCH_ID = accCompanyVoucherModel.BRANCH_ID;
                voucherDetails.COMP_VOUCHER_DATE = accCompanyVoucherModel.COMP_VOUCHER_DATE;
                voucherDetails.COMP_VOUCHER_TYPE =2;
                voucherDetails.LEDGER_NAME = item.particular;
                voucherDetails.VOUCHER_DEBIT_AMOUNT = item.debitAmount;
                voucherDetails.VOUCHER_CREDIT_AMOUNT = item.creditAmount;
                voucherDetails.VOUCHER_ADD_AMOUNT = item.creditAmount;
                voucherDetails.VOUCHER_LESS_AMOUNT = item.creditAmount;
                voucherDetails.VOUCHER_TOBY = item.symbol;
                voucherDetails.VOUCHER_FC_DEBIT_AMOUNT = 0;
                voucherDetails.VOUCHER_FC_CREDIT_AMOUNT = 0;
                if (item.ChequeNo != "" && item.ChequeNo != null && item.ChequeNo != "NULL")
                {
                    voucherDetails.VOUCHER_CHEQUE_NUMBER = item.ChequeNo;
                    voucherDetails.VOUCHER_CHEQUE_DATE = item.ChequeDate;
                    voucherDetails.VOUCHER_CHEQUE_DRAWN_ON = item.DrawnOn;
                }

                //paymentVoucherDetails.Add(voucherDetails);

                accCompanyVoucherModel.accVoucherList.Add(voucherDetails);
            }
            //var voucher = await Http.PostJsonAsync<List<ACC_VOUCHER_MODEL>>(Utility.BaseUrl + "api/Transection/AddPaymentVoucherDetails", paymentVoucherDetails);
            bool rowexists = accCompanyVoucherModel.accVoucherList.Exists(x => x.VOUCHER_TOBY == "Cr");
            if (rowexists != true)
            { toastService.ShowError("Credit Info. not exist"); }
            else
            {
                var data = await Http.PostJsonAsync<ACC_COMPANY_VOUCHER_MODEL>(Utility.BaseUrl + "api/Transection/UpdatePaymentVoucher", accCompanyVoucherModel);
                if (data.status == true)
                { toastService.ShowSuccess("Save Successfully!!!"); }
                else { toastService.ShowError("Not Save :" + data.ErrorMessage); }
            }

        }
        catch (Exception ex)
        {

        }
    }
    private void Keypress(KeyboardEventArgs args)
    {
        string value;
        value = args.Key;
        if (value == "c" || value == "C")
        { MyProperty = "Cr"; }
        else if (value == "d" || value == "D")
        { MyProperty = "Dr"; }
        StateHasChanged();
        onDisable(MyProperty);
    }
    private void onDisable(string property)
    {
        if (property == "Dr")
        {
            this.isDrDisable = false;
            this.isCrDisable = true;
            MyCrValue = "";
        }
        else if (property == "Cr")
        {
            this.isCrDisable = false;
            this.isDrDisable = true;
        }

    }
    //private void Enter(KeyboardEventArgs e)
    //private void Enter()
    //{
    //    //if (e.Key == "Enter")
    //    {
    //        if (!string.IsNullOrWhiteSpace(newTodo))
    //        {
    //            //todos.Add(new TodoItem { Title = newTodo });
    //            //newTodo = string.Empty;
    //        }
    //    }
    //}
    private async void DoTheThing(KeyboardEventArgs eventArgs)
    {
        if (eventArgs.Key == "Enter")        // fire on enter
        {
            //Console.WriteLine("Done the thing: " + MyValue);

            paymentvoucher = new VoucherItem();
            bool rowexists = voucherItemList.Exists(x => x.Serial == rowId);
            if (rowexists != true)
            {
                paymentvoucher.symbol = MyProperty;
                paymentvoucher.particular = SelectedString;//; SelectedArticle.LEDGER_NAME;
                if (MyProperty == "Dr")
                {
                    paymentvoucher.debitAmount = Convert.ToDecimal(MyDrValue);
                }
                if (MyProperty == "Cr")
                {
                    paymentvoucher.creditAmount = Convert.ToDecimal(MyCrValue);
                }
                if (chequeNo != "" && chequeNo != null)
                {
                    paymentvoucher.ChequeNo = chequeNo;
                    paymentvoucher.ChequeDate = Convert.ToDateTime(chequeDate);
                    paymentvoucher.DrawnOn = drawnon;

                }
                else
                {
                    paymentvoucher.ChequeNo = "NULL";
                    paymentvoucher.ChequeDate = Convert.ToDateTime("1900-01-01");
                    paymentvoucher.DrawnOn = "NULL";
                }

                voucherItemList.Add(paymentvoucher);
                voucherItemList.Where(w => w.symbol == "Cr").ToList().ForEach(s => s.creditAmount = voucherItemList.Sum(item => item.debitAmount));
            }
            else
            {
                voucherItemList.Where(w => w.Serial == rowId).ToList().ForEach(s => s.symbol = MyProperty);
                if (SelectedString != "")
                { voucherItemList.Where(w => w.Serial == rowId).ToList().ForEach(s => s.particular = SelectedString); }
                voucherItemList.Where(w => w.Serial == rowId).ToList().ForEach(s => s.debitAmount = Convert.ToDecimal(MyDrValue));
                voucherItemList.Where(w => w.symbol == "Cr").ToList().ForEach(s => s.creditAmount = Convert.ToDecimal(MyDrValue));
                //if (MyProperty=="Dr")
                //{ voucherItemList.Where(w => w.Serial == rowId).ToList().ForEach(s => s.debitAmount = Convert.ToDecimal(MyDrValue)); }
                //if(MyProperty=="Cr")
                //{ voucherItemList.Where(w => w.Serial == rowId).ToList().ForEach(s => s.creditAmount = Convert.ToDecimal(MyDrValue)); }


                voucherItemList.Where(w => w.Serial == rowId).ToList().ForEach(s => s.ChequeNo = Convert.ToString(chequeNo));
                voucherItemList.Where(w => w.Serial == rowId).ToList().ForEach(s => s.ChequeDate = Convert.ToDateTime(chequeDate));
                voucherItemList.Where(w => w.Serial == rowId).ToList().ForEach(s => s.DrawnOn = Convert.ToString(drawnon));

                //voucherItemList = voucherItemList.Where(w => w.symbol == MyProperty).Select(s => { s.symbol=MyProperty; return s; }).ToList();
                //voucherItemList = voucherItemList.Where(w => w.particular == SelectedArticle.LEDGER_NAME).Select(s => { s.particular= SelectedArticle.LEDGER_NAME; return s; }).ToList();
            }


            totalDebit = voucherItemList.Sum(item => item.debitAmount);
            totalCredit = voucherItemList.Sum(item => item.debitAmount); //voucherItemList.Sum(item => item.creditAmount);



            bool exists = voucherItemList.Exists(x => x.symbol == "Cr");

            if (exists != true)
            {
                MyProperty = "Cr";
                //double total = myList.Sum(item => item.Amount);
                MyCrValue = Convert.ToString(voucherItemList.Sum(item => item.debitAmount));
                //SelectedArticle.LEDGER_NAME = "";
                MyDrValue = "";
                onDisable(MyProperty);

                await myref.FocusAsync();

            }
            else
            {
                visibletext = 0;
                StateHasChanged();
                MyProperty = "";
                //SelectedArticle.LEDGER_NAME = "";
                MyDrValue = "";
                MyCrValue = "";
                visible_Status = 0;
                checkedStatus = false;

                await narrationref.FocusAsync();
            }



        }
    }
    public void Enter(KeyboardEventArgs e)
    {
        if (e.Code == "Enter" || e.Code == "NumpadEnter")
        {
            // ...
            KeyPressed = "Key Pressed is " + this.Value;

            //amount = e.Key;
            paymentvoucher = new VoucherItem();
            paymentvoucher.symbol = MyProperty;
            paymentvoucher.particular = SelectedArticle.LEDGER_NAME;
            if (MyProperty == "Dr")
            {
                paymentvoucher.debitAmount = amount;
            }
            if (MyProperty == "Cr")
            {
                paymentvoucher.creditAmount = amount;
            }

            voucherItemList.Add(paymentvoucher);



        }
    }
    //public class VoucherItem
    //{
    //    public string Serial { get; set; }
    //    public string ComRefNo { get; set; }
    //    public string symbol { get; set; }
    //    public string particular { get; set; }
    //    public decimal debitAmount { get; set; }
    //    public decimal creditAmount { get; set; }
    //}
    private async void GetDate(ChangeEventArgs change)
    {
        string date = change.Value.ToString();
        accCompanyVoucherModel.COMP_VOUCHER_DATE = Convert.ToDateTime(date);
    }
    async void ChequeClicked(object checkedValue, string serialNo, string refNo)
    {
        if ((bool)checkedValue)
        {
            visible_Status = 1;
            visibletext = 1;

            rowId = serialNo;
            comRefNo = refNo;

            string B = voucherItemList.Find(x => x.Serial == serialNo).particular;
            if (B == "Bank Accounts")
            { bankStatus = 1; }

        }
        else
        {
            visible_Status = 0;
            visibletext = 0;
            bankStatus = 0;

        }
        StateHasChanged();
    }
    private async void EditClick(string serial)
    {
        //btnLabel = "Update";
        //currencyModel = currencyList.FirstOrDefault(x => x.CURRENCY_SERIAL == serial);
        MyProperty = voucherItemList.Find(x => x.Serial == serial).symbol;
        string name = voucherItemList.Find(x => x.Serial == serial).particular;
        MyDrValue = Convert.ToString(voucherItemList.Find(x => x.Serial == serial).debitAmount);
        MyCrValue = Convert.ToString(voucherItemList.Find(x => x.Serial == serial).creditAmount);
        SelectedArticle = ledgerList.FirstOrDefault(x => x.LEDGER_NAME == name);
        //ledgerList.Where(x => x.LEDGER_NAME.ToLower().Contains(searchText.ToLower())).ToList()
        //await myref.FocusAsync();
        //SelectedArticle.LEDGER_NAME = voucherItemList.Find(x => x.Serial == serial).particular; //ledgerList.Find(x => x.LEDGER_NAME == name).LEDGER_NAME;

        parent = voucherItemList.Find(x => x.Serial == serial).particular;
        chequeNo = voucherItemList.Find(x => x.Serial == serial).ChequeNo;
        if (chequeNo != "" && chequeNo != null)
        {
            chequeDate = voucherItemList.Find(x => x.Serial == serial).ChequeDate.Year + "-" +
                (voucherItemList.Find(x => x.Serial == serial).ChequeDate.Month).ToString().PadLeft(2, '0') + "-" +
                (voucherItemList.Find(x => x.Serial == serial).ChequeDate.Day).ToString().PadLeft(2, '0');
        }
        drawnon = voucherItemList.Find(x => x.Serial == serial).DrawnOn;
        onDisable(MyProperty);

        //chequeDate = Convert.ToDateTime(voucherItemList.Find(x => x.Serial == serial).chequedate);
        //accCompanyVoucherModel.COMP_VOUCHER_DATE = Convert.ToDateTime(voucherDate);
        StateHasChanged();

    }
    private async Task DeleteRow(string serial)
    {
        //if (!await jsruntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete ?"))
        //    return;
        //await Http.DeleteAsync(Utility.BaseUrl + "api/Setup/DeleteCurrency/" + refNo);
        //await GetCurrency();
        voucherItemList.RemoveAll(x => x.Serial == serial);
        visibletext = 0;
        visible_Status = 0;
        GetTotal();
        rowId = "";

        bool exists = voucherItemList.Exists(x => x.Serial == rowId);
        //if(exists == true)
        //{
        //    checkedStatus = true;
        //}
        //else { checkedStatus = false; }
        for (int i = 1; i < voucherItemList.Count; i++)
        {
            checkedStatus = false;
            StateHasChanged();
        }


    }
    private void GetTotal()
    {
        totalDebit = voucherItemList.Sum(item => item.debitAmount);
        totalCredit = voucherItemList.Sum(item => item.debitAmount);
    }
    void CloseClicked() { UriHelper.NavigateTo("ReceiveVoucherList"); }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsruntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
