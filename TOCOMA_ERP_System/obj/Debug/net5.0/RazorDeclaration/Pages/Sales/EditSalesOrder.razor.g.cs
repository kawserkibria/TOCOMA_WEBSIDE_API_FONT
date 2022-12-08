// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 6 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrder.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditSalesOrder/{salesOrderNo}")]
    public partial class EditSalesOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 516 "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditSalesOrder.razor"
       
    List<CustomerModel> customerList = new List<CustomerModel>();
    SalesOrderModel salesOrder = new SalesOrderModel();
    CustomerModel customer = new CustomerModel();
    List<EmployeeModel> employeeList = new List<EmployeeModel>();
    SalesOrderItemDetailsModel salesItemDetails = new SalesOrderItemDetailsModel();
    List<SalesOrderItemDetailsModel> salesItemDetailsList = new List<SalesOrderItemDetailsModel>();
    ItemEntity item = new ItemEntity();
    List<UnitModel> unitList = new List<UnitModel>();
    List<PurchaseTermsConditionsModel> termsConditionList = new List<PurchaseTermsConditionsModel>();
    PurchaseTermsConditionsModel termsconditions = new PurchaseTermsConditionsModel();
    string workOrderDate = "";
    string deliveryDate = "";
    string selectedunit;
    private string value { get; set; }
    string noOfPack;
    string terms_And_Conditions_No;
    decimal discount_amount_In_Parcent;
    decimal discount_amount_In_Taka;
    decimal advance_amount_In_Parcent;
    decimal advance_amount_In_Taka;
    decimal netAmount = 0;
    decimal totalNetAmount = 0;
    decimal deliveryAndOthers = 0;
    [Parameter]
    public string salesOrderNo { get; set; }
    string customerName;
    int editfieldsetareastatus = 0;

    //---------------------

    private List<PurchaseRequisitionEntity> Customers { get; set; }
    PurchaseRequisitionEntity purchaseRequisition = new PurchaseRequisitionEntity();
    SalesQuotationModel salesQuotation = new SalesQuotationModel();
    SalesItemDetailsModel salesItem = new SalesItemDetailsModel();
    List<SalesItemDetailsModel> salesItemList = new List<SalesItemDetailsModel>();
    List<SalesItemDetailsModel> itemList = new List<SalesItemDetailsModel>();
    List<PurchaseRequisitionDetailsEntity> requisitionDetailsEntities = new List<PurchaseRequisitionDetailsEntity>();
    PurchaseRequisitionDetailsEntity details = new PurchaseRequisitionDetailsEntity();
    PurchaseRequisitionOthersModel reqOthers = new PurchaseRequisitionOthersModel();
    List<PurchaseRequisitionOthersModel> reqOthersList = new List<PurchaseRequisitionOthersModel>();
    List<DepartmentEntity> departmentList = new List<DepartmentEntity>();
    List<ItemEntity> productList = new List<ItemEntity>();
    private ItemEntity SelectedArticle;
    List<OrderItemEntity> requestItemList = new List<OrderItemEntity>();
    List<OthersRequisitionItemsModel> othersItemList = new List<OthersRequisitionItemsModel>();
    OthersRequisitionItemsModel othersItem = new OthersRequisitionItemsModel();
    List<CustomerTypeModel> customerType = new List<CustomerTypeModel>();
    List<PurchaseTermsConditionsModel> AlltermsConditionList = new List<PurchaseTermsConditionsModel>();
    List<PurchaseTermsConditionsModel> selectedtermsConditionList = new List<PurchaseTermsConditionsModel>();
    TAX_CLASS tax = new TAX_CLASS();
    string searchitem = "";
    OrderItemEntity orderitem;
    OrderItemEntity order_itm = null;
    BlazoredTextEditor itemDescription;
    string q = "";
    decimal unitPrice = 0;
    string itemname;
    double requisitionTotal = 0;
    decimal salesSubTotal = 0;

    double othersSubTotal = 0;
    //DateTime request_date = System.DateTime.Now;
    string quotation_date;
    string validupto_date;
    int tablerow;
    string selected_department;
    int selected_department_Id;
    string cheque_Date;
    bool checked_cheque;
    decimal GrandTotal;
    decimal Total = 0;
    decimal LC_AMOUNT;
    decimal LC_COMMISSION;
    decimal INSURANCE;
    string Inwords;
    string othersItemName;
    string othersitemQuantity;
    string OthersitemRate;
    string reqNo;
    protected bool REQ_IS_DISABLE { get; set; }

    string companyShortForm = "";
    int termsconditionId;
    string termsId;
    decimal ait;
    decimal vat;
    decimal ait_in_Parcent = 0;
    decimal VAT_with_Price_and_AIT = 0;
    decimal totalUnitPrice = (decimal)0.00;



    protected override async Task OnInitializedAsync()
    {
        tablerow = 1;
        //itemname = itemname + "_" + tablerow;
        await DepartmentList();
        await GetItemList();
        await GetCustomer();
        await GetCustomerType();
        await GetReqNo();
        await GetEmployee();
        unitList = await Http.GetJsonAsync<List<UnitModel>>(Utility.BaseUrl + "api/Setup/GetUnitList");
        termsConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Setup/GetSalesTermsConditions");
        AlltermsConditionList = termsConditionList;
        salesOrder = await Http.GetJsonAsync<SalesOrderModel>(Utility.BaseUrl + "api/Sales/GetSalesInfoBySalesOrderNo/" + salesOrderNo);
        salesItemList = await Http.GetJsonAsync<List<SalesItemDetailsModel>>(Utility.BaseUrl + "api/Sales/GetSalesItemByPONo/" + salesOrderNo);
        workOrderDate = salesOrder.PO_WO_DATE.Day + "/" + salesOrder.PO_WO_DATE.Month + "/" + salesOrder.PO_WO_DATE.Year;
        deliveryDate = salesOrder.DELIVERY_DATE.Day + "/" + salesOrder.DELIVERY_DATE.Month + "/" + salesOrder.DELIVERY_DATE.Year;
        customerName = salesOrder.CUSTOMER_NAME;
        if (customerList != null)
        {
            customer.CONTACT_PERSON_NAME = customerList.Find(x => x.CUSTOMER_ID == salesOrder.CUSTOMER_ID).CONTACT_PERSON_NAME;
        }
        termsId = salesOrder.TERMS_AND_CONDITION;
        if (termsId != null && termsId != "") { selectedtermsConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Sales/GetSalesTermsAndConditionsByIds/" + termsId); }
        tax=await Http.GetJsonAsync<TAX_CLASS>(Utility.BaseUrl + "api/Setup/GetTaxInfo");
        ait = tax.AIT;
        vat = tax.VAT;


    }
    public async void EditTermsConditionItem()
    {
        if (termsconditionId != 0)
        {
            editfieldsetareastatus = 1;
            termsconditions.TERMS_AND_CONDITIONS = termsConditionList.Find(x => x.SALES_TERMS_CONDITION_ID == termsconditionId).TERMS_AND_CONDITIONS;
        }
    }
    private async Task DeleteTermsCondition()
    {
        if (termsconditionId != 0)
        {
            if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete ?"))
                return;

            await Http.DeleteAsync(Utility.BaseUrl + "api/Setup/DeleteTermsConditions/" + termsconditionId);
            await GetAllTermsCondition();
        }


    }

    private async Task GetItemList()
    {
        productList = await Http.GetJsonAsync<List<ItemEntity>>(Utility.BaseUrl + "api/Product");
    }
    private async Task GetCustomer()
    {
        customerList = await Http.GetJsonAsync<List<CustomerModel>>(Utility.BaseUrl + "api/Customer");
    }
    private async Task GetCustomerType()
    {
        customerType = await Http.GetJsonAsync<List<CustomerTypeModel>>(Utility.BaseUrl + "api/Customer/GetCustomerType");
    }
    private async Task GetEmployee()
    {
        employeeList = await Http.GetJsonAsync<List<EmployeeModel>>(Utility.BaseUrl + "api/Employee");
    }
    public async Task GetReqNo()
    {
        //var reqNo = await Http.GetJsonAsync<RequisitionNo>(Utility.BaseUrl + "api/Purchase/GetReqNo");
        reqNo = await Http.GetStringAsync(Utility.BaseUrl + "api/Purchase/GetReqNo");
        purchaseRequisition.REQUISITION_NO = Convert.ToString(reqNo);

        REQ_IS_DISABLE = true;
        StateHasChanged();
    }

    private async Task<IEnumerable<ItemEntity>> SearchArticles(string searchText)
    {
        searchitem = searchText;
        return await Task.FromResult(productList.Where(x => x.ITEM_NAME.ToLower().Contains(searchText.ToLower())));
    }
    private async Task DepartmentList()
    {
        departmentList = await Http.GetJsonAsync<List<DepartmentEntity>>(Utility.BaseUrl + "api/Department");

    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync("JsInteropDatepicker");
    }
    private void Add()
    {
        tablerow = tablerow + 1;
        itemname = itemname + "_" + tablerow;
        StateHasChanged();
    }
    private async Task UnitPriceCLicked(ChangeEventArgs change)
    {
        if (change.Value != "") { unitPrice = Convert.ToDecimal(change.Value); }
        else { unitPrice = 0; }

        Calculation();
    }

    private void Calculation()
    {
        decimal AIT = (unitPrice * ait) / 100;
        ait_in_Parcent = Convert.ToDecimal(String.Format("{0:0.00}", AIT));
        decimal unitPriceAndAit = unitPrice + ait_in_Parcent;
        decimal p = (unitPriceAndAit * Convert.ToDecimal(vat)) / 100;
        VAT_with_Price_and_AIT = Convert.ToDecimal(String.Format("{0:0.00}", p));
        decimal tUnitPrice = unitPrice + ait_in_Parcent + p;
        totalUnitPrice = Convert.ToDecimal(String.Format("{0:0.00}", tUnitPrice));
        StateHasChanged();
    }
    protected async Task AddItem()
    {
        if (IsValidation_Table_Item() != true)
        {
            bool alreadyExists = productList.Any(x => x.ITEM_NAME.ToString().Trim() == itemname.ToString().Trim());
            order_itm = new OrderItemEntity();
            salesItem = new SalesItemDetailsModel();
            salesItem.ITEM_ID = productList.Find(x => x.ITEM_NAME == itemname).ITEM_ID;
            salesItem.ITEM_NAME = itemname;
            salesItem.PACK_SIZE = item.PACK_SIZE;
            salesItem.UOM = item.UOM;
            salesItem.NUMBER_OF_PACK = noOfPack;
            salesItem.ORDER_QUANTITY = Convert.ToDouble(q);
            salesItem.UNIT_PRICE = Convert.ToDecimal(unitPrice);
            salesItem.UOM = productList.Find(x => x.ITEM_NAME == itemname).UOM;
            salesItem.PACK_SIZE = productList.Find(x => x.ITEM_NAME == itemname).PACK_SIZE;
            if (ait != null && ait !=0)
            { salesItem.AIT = Convert.ToDecimal(ait); }
            if (vat != null && vat !=0)
            { salesItem.VAT = Convert.ToDecimal(vat); }
            salesItem.ITEM_DESCRIPTION = await this.itemDescription.GetHTML();

            //if (alreadyExists == true)
            //{
            //    order_itm.ITEM_ID = productList.FirstOrDefault(x => x.ITEM_NAME.ToString().Trim() == itemname.ToString().Trim()).ITEM_ID;
            //    order_itm.PACK_SIZE = productList.FirstOrDefault(x => x.ITEM_NAME.ToString().Trim() == itemname.ToString().Trim()).PACK_SIZE;
            //    order_itm.UOM = productList.FirstOrDefault(x => x.ITEM_NAME.ToString().Trim() == itemname.ToString().Trim()).UOM;
            //}
            //else
            //{
            //    order_itm.ITEM_ID = await Http.GetJsonAsync<int>(Utility.BaseUrl + "api/Purchase/GetItemId/" + itemname);
            //}

            salesItem.TOTAL_PRICE = totalUnitPrice;//Convert.ToDecimal(salesItem.ORDER_QUANTITY) * Convert.ToDecimal(salesItem.UNIT_PRICE);
            salesSubTotal += salesItem.TOTAL_PRICE;
            salesItemList.Add(salesItem);

            //q = "";
            //r = "";
            //itemname = "";
            TotalCalculation();
            salesItem = new SalesItemDetailsModel();
            itemname = "";
            q = "";
            unitPrice =0;
            ait = tax.AIT;
            vat = tax.VAT;

        }


    }
    public List<string> checkedOtherTermsIds { get; set; } = new List<string>();
    void OtherTermsClicked(string termsConditionids, object checkedValue)
    {
        if ((bool)checkedValue)
        {
            if (!checkedOtherTermsIds.Contains(termsConditionids))
            {
                checkedOtherTermsIds.Add(termsConditionids);
            }
        }
        else
        {
            if (checkedOtherTermsIds.Contains(termsConditionids))
            {
                checkedOtherTermsIds.Remove(termsConditionids);
            }
        }
        terms_And_Conditions_No = String.Join(",", checkedOtherTermsIds);
    }
    public async Task SaveTermsConditions()
    {

        if (IsValidation_TermsConditions() != true)
        {
            try
            {
                var data = await Http.PostJsonAsync<PurchaseTermsConditionsModel>(Utility.BaseUrl + "api/Setup/AddTermsConditions", termsconditions);
                toastService.ShowSuccess("Insert Successfully!!!");
            }
            catch (Exception ex)
            {

            }


        }
        termsConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Setup/GetTermsConditions");
        termsconditions.TERMS_AND_CONDITIONS = "";
    }
    private bool IsValidation_TermsConditions()
    {
        bool flag = false;
        if (termsconditions.TERMS_AND_CONDITIONS == "" || termsconditions.TERMS_AND_CONDITIONS == string.Empty || termsconditions.TERMS_AND_CONDITIONS == null)
        {
            toastService.ShowWarning("Terms & Condition Field Cannot be empty!");
            flag = true;
        }

        return flag;
    }
    protected async Task AddOthersItem()
    {
        othersItem = new OthersRequisitionItemsModel();
        othersItem.OTHERS_ITEM = othersItemName;
        if (othersitemQuantity != null && othersitemQuantity != "")
        { othersItem.QUANTITY = Convert.ToDouble(othersitemQuantity); }
        else { othersItem.QUANTITY = 0; }

        othersItem.RATE = Convert.ToDouble(OthersitemRate);
        if (othersitemQuantity != null && othersitemQuantity != "" && othersitemQuantity != "0") { othersItem.TOTAL = Convert.ToDouble(othersitemQuantity) * Convert.ToDouble(OthersitemRate); }
        else { othersItem.TOTAL = Convert.ToDouble(OthersitemRate); }

        othersSubTotal += othersItem.TOTAL;
        othersItemList.Add(othersItem);
        othersItemName = "";
        othersitemQuantity = "";
        OthersitemRate = "";
        TotalCalculation();
    }
    public async void DeleteOthersItem(string item)
    {
        var itemToRemove = othersItemList.Single(r => r.OTHERS_ITEM == item);
        othersItemList.Remove(itemToRemove);
        if (othersItemList.Count > 0)
        {
            othersSubTotal = 0;
            foreach (var _oitem in othersItemList)
            {
                othersSubTotal += _oitem.TOTAL;
            }
        }
        else { othersSubTotal = 0; }

        TotalCalculation();
        StateHasChanged();
    }
    //--------------
    public async void DeleteItem(string item)
    {
        var itemToRemove = salesItemList.Single(r => r.ITEM_NAME == item);
        salesItemList.Remove(itemToRemove);
        if (salesItemList.Count > 0)
        {
            salesSubTotal = 0;
            foreach (var _oitem in salesItemList)
            {
                salesSubTotal += _oitem.TOTAL_PRICE;
            }
        }
        else { salesSubTotal = 0; }

        TotalCalculation();
        StateHasChanged();
    }
    public async void EditItem(string item)
    {
        itemname = salesItemList.Single(r => r.ITEM_NAME == item).ITEM_NAME;
        q = Convert.ToString(salesItemList.Single(r => r.ITEM_NAME == item).ORDER_QUANTITY);
        unitPrice = Convert.ToDecimal(salesItemList.Single(r => r.ITEM_NAME == item).UNIT_PRICE);
        ait = Convert.ToDecimal(salesItemList.Single(r => r.ITEM_NAME == item).AIT);
        vat = Convert.ToDecimal(salesItemList.Single(r => r.ITEM_NAME == item).VAT);
        var itemToRemove = salesItemList.Single(r => r.ITEM_NAME == item);
        salesItemList.Remove(itemToRemove);
        if (requestItemList.Count > 0)
        {
            salesSubTotal = 0;
            foreach (var _oitem in requestItemList)
            {
                salesSubTotal += Convert.ToDecimal(_oitem.Total);
            }
        }
        else { salesSubTotal = 0; }
        TotalCalculation();
        StateHasChanged();
    }
    //
    public async void EditOthersItem(string item)
    {
        othersItemName = othersItemList.Single(r => r.OTHERS_ITEM == item).OTHERS_ITEM;
        othersitemQuantity = Convert.ToString(othersItemList.Single(r => r.OTHERS_ITEM == item).QUANTITY);
        OthersitemRate = Convert.ToString(othersItemList.Single(r => r.OTHERS_ITEM == item).RATE);
        var itemToRemove = othersItemList.Single(r => r.OTHERS_ITEM == item);
        othersItemList.Remove(itemToRemove);
        if (othersItemList.Count > 0)
        {
            othersSubTotal = 0;
            foreach (var _oitem in othersItemList)
            {
                othersSubTotal += _oitem.TOTAL;
            }
        }
        else { othersSubTotal = 0; }
        TotalCalculation();
        StateHasChanged();
    }

    //public async Task GetSalesOrderNo()
    //{
    //    string prefix = "";
    //    prefix = companyShortForm;
    //    //string C = salesQuotation.CUSTOMER_NAME;
    //    //var firstChars = C.Split(' ').Select(s => s[0]);
    //    //foreach(var p in firstChars)
    //    //{
    //    //    prefix += p;
    //    //}
    //    salesOrderNo = await Http.GetStringAsync(Utility.BaseUrl + "api/Sales/GetSalesOrderNo");
    //    salesOrder.SALES_ORDER_NO = salesOrderNo;
    //}
    public async Task SaveSalesOrder()
    {

        if (IsValidation() != true)
        {
            try
            {
                string d = workOrderDate.Replace("/", "-");
                salesOrder.PO_WO_DATE = Convert.ToDateTime(d);
                string dd = deliveryDate.Replace("/", "-");
                salesOrder.DELIVERY_DATE = Convert.ToDateTime(dd);
                salesOrder.GRAND_TOTAL = Convert.ToDouble(GrandTotal);
                salesOrder.TERMS_AND_CONDITION = terms_And_Conditions_No;
                salesOrder.REG_BY = await sessionStorage.GetItemAsync<string>("session_employeeLoginId");
                salesOrder.TOTAL_AMOUNT = Total;
                salesOrder.DISCOUNT_IN_PARCHENT = discount_amount_In_Parcent;
                salesOrder.DISCOUNT_IN_TAKA = discount_amount_In_Taka;
                salesOrder.ADVANCE_PAID_IN_PARCHENT = advance_amount_In_Parcent;
                salesOrder.ADVANCE_PAID_IN_TAKA = advance_amount_In_Taka;
                salesOrder.DELIVERY_CHARGE = deliveryAndOthers;

                //await GetSalesOrderNo();
                var data = await Http.PutJsonAsync<SalesOrderModel>(Utility.BaseUrl + "api/Sales/UpdateSalesOrder/", salesOrder);

                //var id = await Http.GetJsonAsync<int>(Utility.BaseUrl + "api/Sales/GetSalesOrderId/" + salesOrder.PO_WO_NUMBER);
                foreach (var item in salesItemList)
                {
                    salesItem = new SalesItemDetailsModel();
                    salesItem.SALES_ID = item.SALES_ID;
                    salesItem.PO_WO_NUMBER = salesOrder.PO_WO_NUMBER;
                    salesItem.SALES_ORDER_NO = salesOrder.SALES_ORDER_NO;
                    salesItem.ITEM_ID = item.ITEM_ID;
                    salesItem.ITEM_DESCRIPTION = item.ITEM_DESCRIPTION;
                    salesItem.ORDER_QUANTITY = item.ORDER_QUANTITY;
                    salesItem.UOM = item.UOM;
                    salesItem.PACK_SIZE = item.PACK_SIZE;
                    salesItem.UNIT_PRICE = item.UNIT_PRICE;
                    salesItem.AIT = item.AIT;
                    salesItem.VAT = item.VAT;
                    salesItem.TOTAL_PRICE = item.TOTAL_PRICE;

                    itemList.Add(salesItem);
                }
                var salesitem_details = await Http.PutJsonAsync<List<SalesItemDetailsModel>>(Utility.BaseUrl + "api/Sales/UpdateSalesOrderDetails", itemList);

                toastService.ShowSuccess("Insert Successfully!!!");
                salesItem = new SalesItemDetailsModel();

            }
            catch (Exception ex)
            {
                toastService.ShowWarning("Not Save" + ex.Message);
            }

        }
    }
    private bool IsValidation_Table_Item()
    {
        bool flag = false;
        if (itemname == "" || itemname == string.Empty || itemname == null)
        {
            toastService.ShowWarning("Please Select Item!");
            flag = true;
        }
        else if (q == "" || q == string.Empty || q == null)
        {
            toastService.ShowWarning("Quantity Field is Empty!");
            flag = true;
        }
        else if (unitPrice ==0 && unitPrice == null)
        {
            toastService.ShowWarning("Unit Price Field is Empty!");
            flag = true;
        }
        return flag;
    }
    //private async void ItemSelected(ChangeEventArgs changeEvent)
    //{
    //    item = await Http.GetJsonAsync<ItemEntity>(Utility.BaseUrl + "api/Product/GetItemByItemName/" + itemname);
    //    selectedunit = item.UNIT_NAME;
    //}

    private async void ItemSelected(Microsoft.AspNetCore.Components.ChangeEventArgs args)
    {
        value = (string)args.Value;
        itemname = value;
        item = await Http.GetJsonAsync<ItemEntity>(Utility.BaseUrl + "api/Product/GetItemByItemName/" + value);
        selectedunit = item.UNIT_NAME;
        StateHasChanged();
    }

    private bool IsValidation()
    {
        bool flag = false;
        if (salesOrder.PO_WO_NUMBER == "" || salesOrder.PO_WO_NUMBER == string.Empty || salesOrder.PO_WO_NUMBER == null)
        {
            toastService.ShowWarning("PO/WO No. cannot be empty!");
            flag = true;
        }


        return flag;
    }
    //private void ClearData()
    //{
    //    purchaseRequisition.REQUISITION_NO = "";
    //    purchaseRequisition.REQUESTED_BY = "";
    //    purchaseRequisition.REQUEST_DATE = System.DateTime.Now;
    //    purchaseRequisition.REQUIRED_DATE = System.DateTime.Now;
    //    purchaseRequisition.REQUEST_FOR = "";
    //    purchaseRequisition.REQUISITION_PURPOSE = "";
    //    requestItemList = null;

    //}
    private async Task Requesst_Receive_Dept_Click(ChangeEventArgs changeEventArgs)
    {

        selected_department_Id = Convert.ToInt32(changeEventArgs.Value);
        selected_department = departmentList.Find(x => x.DEPARTMENT_ID == selected_department_Id).DEPARTMENT_NAME;
        StateHasChanged();
    }
    private async Task LC_Amount_Clicked(ChangeEventArgs lcAmount)
    {
        if (lcAmount.Value.ToString() != "0" && lcAmount.Value.ToString() != null && lcAmount.Value.ToString() != "")
        {
            LC_AMOUNT = Convert.ToDecimal(lcAmount.Value.ToString());
            TotalCalculation();
        }
        else
        {
            LC_AMOUNT = 0;
            TotalCalculation();
        }


    }
    private async Task LC_Commission_Clicked(ChangeEventArgs lcCommission)
    {
        if (lcCommission.Value.ToString() != "0" && lcCommission.Value.ToString() != null && lcCommission.Value.ToString() != "")
        {
            LC_COMMISSION = Convert.ToDecimal(lcCommission.Value.ToString());
            TotalCalculation();
        }
        else
        {
            LC_COMMISSION = 0;
            TotalCalculation();
        }

    }
    private async Task Insurance_Clicked(ChangeEventArgs Insurance)
    {
        if (Insurance.Value.ToString() != "0" && Insurance != null && Insurance.Value.ToString() != "")
        {
            INSURANCE = Convert.ToDecimal(Insurance.Value.ToString());
            TotalCalculation();
        }
        else
        {
            INSURANCE = 0;
            TotalCalculation();
        }

    }

    async void PaymentMode_ChequeClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        {
            checked_cheque = true;
            purchaseRequisition.PAYMENT_MODE = "Cheque";
        }
        else
        {
            checked_cheque = false;
            cheque_Date = "";
            purchaseRequisition.PAYMENT_MODE = "";
        }
        StateHasChanged();
    }
    //PaymentMode_PayorderClicked(
    //PaymentMode_TTClicked( event
    //PaymentMode_InAdvanceClicked
    //PaymentMode_OthersClicked(e
    async void PaymentMode_CashClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        { purchaseRequisition.PAYMENT_MODE = "Cash"; }
        else { purchaseRequisition.PAYMENT_MODE = ""; }

    }
    async void PaymentMode_PayorderClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        { purchaseRequisition.PAYMENT_MODE = "Payorder"; }
        else { purchaseRequisition.PAYMENT_MODE = ""; }
    }
    async void PaymentMode_TTClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        { purchaseRequisition.PAYMENT_MODE = "TT"; }
        else { purchaseRequisition.PAYMENT_MODE = ""; }
    }
    async void PaymentMode_InAdvanceClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        { purchaseRequisition.PAYMENT_MODE = "InAdvance"; }
        else { purchaseRequisition.PAYMENT_MODE = ""; }
    }
    async void PaymentMode_OthersClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        { purchaseRequisition.PAYMENT_MODE = "Others"; }
        else { purchaseRequisition.PAYMENT_MODE = ""; }
    }
    async void Customer_Clicked(ChangeEventArgs eventArgs)
    {
        salesOrder.CUSTOMER_ID = Convert.ToInt32(eventArgs.Value.ToString());
        await GetCustomerData(salesOrder.CUSTOMER_ID);
    }
    private async Task GetCustomerData(int customerId)
    {
        customer = await Http.GetJsonAsync<CustomerModel>(Utility.BaseUrl + "api/Customer/GetCustomerData/" + customerId);


        StateHasChanged();
    }
    private async Task discount_amount_In_Parcent_Clicked(ChangeEventArgs change)
    {
        if (Total != 0 && change.Value != "")
        { discount_amount_In_Parcent = (Total * Convert.ToDecimal(change.Value)) / 100; }
        else { discount_amount_In_Parcent = 0; }
        TotalCalculation();
    }
    private async Task discount_amount_In_TK_Clicked(ChangeEventArgs change)
    {
        if (Total != 0 && change.Value != "") { discount_amount_In_Taka = Convert.ToDecimal(change.Value); }
        else { discount_amount_In_Taka = 0; }
        TotalCalculation();
    }
    private async Task advance_amount_In_Parcent_Clicked(ChangeEventArgs change)
    {
        if (Total != 0 && change.Value != "") { advance_amount_In_Parcent = (Total * Convert.ToDecimal(change.Value)) / 100; }
        else { advance_amount_In_Parcent = 0; }
        TotalCalculation();
    }
    private async Task advance_amount_In_TK_Clicked(ChangeEventArgs change)
    {
        if (Total != 0 && change.Value != "") { advance_amount_In_Taka = Convert.ToDecimal(change.Value); }
        else { advance_amount_In_Taka = 0; }
        TotalCalculation();
    }
    private async Task delivery_And_Others_Clicked(ChangeEventArgs change)
    {
        if (change.Value != "") { deliveryAndOthers = Convert.ToDecimal(change.Value); }
        else { deliveryAndOthers = 0; }
        TotalCalculation();
    }

    private void TotalCalculation()
    {
        //if (requisitionTotal != 0 || requisitionTotal != null)
        //{ GrandTotal = Convert.ToDecimal(requisitionTotal); }
        //if(LC_AMOUNT!=0||LC_AMOUNT!=null)
        //{ GrandTotal= }
        Total = Convert.ToDecimal(salesSubTotal) + LC_AMOUNT + LC_COMMISSION + INSURANCE + Convert.ToDecimal(othersSubTotal);
        netAmount = Total;
        totalNetAmount = Total;
        GrandTotal = Total;
        if (discount_amount_In_Parcent != 0)
        {
            netAmount = Total - discount_amount_In_Parcent;
            totalNetAmount = netAmount;
            GrandTotal = netAmount;
        }
        if (discount_amount_In_Taka != 0)
        {
            netAmount = Total - discount_amount_In_Taka;
            totalNetAmount = netAmount;
            GrandTotal = netAmount;
        }
        if (advance_amount_In_Parcent != 0)
        {
            //decimal sum = advance_amount_In_Parcent + discount_amount_In_Parcent + discount_amount_In_Taka;
            totalNetAmount = Total - (advance_amount_In_Parcent + discount_amount_In_Parcent + discount_amount_In_Taka);
            GrandTotal = totalNetAmount;
        }
        if (advance_amount_In_Taka != 0)
        {
            totalNetAmount = Total - (advance_amount_In_Taka + discount_amount_In_Parcent + discount_amount_In_Taka);
            GrandTotal = totalNetAmount;
        }
        if (deliveryAndOthers != 0)
        {
            GrandTotal = totalNetAmount + deliveryAndOthers;
        }


        //GrandTotal = (Convert.ToDecimal(salesSubTotal) + LC_AMOUNT + LC_COMMISSION + INSURANCE + Convert.ToDecimal(othersSubTotal))- discount_amount_In_Parcent;
        //GrandTotal = (Convert.ToDecimal(salesSubTotal) + LC_AMOUNT + LC_COMMISSION + INSURANCE + Convert.ToDecimal(othersSubTotal)) - discount_amount_In_Taka;
        double inwordValue = Convert.ToDouble(GrandTotal);
        Inwords = NumberToWords.ConvertAmount(inwordValue);
    }
    private Task OnValueChanged(int value)
    {
        // Assign the selected value to the Model
        purchaseRequisition.REQUEST_RECEIVE_DEPARTMENT_ID = Convert.ToInt32(value);
        return Task.CompletedTask;
    }
    private async Task ReceiveDepartmentClicked(ChangeEventArgs changeEvent)
    {
        int changeId = Convert.ToInt32(changeEvent.Value.ToString());
        purchaseRequisition.REQUEST_RECEIVE_DEPARTMENT_ID = changeId;
        string dName = departmentList.Find(x => x.DEPARTMENT_ID == changeId).DEPARTMENT_NAME;
        if (dName == "Accounts & Finance")
        {
            reqNo = reqNo + "AF";
            purchaseRequisition.REQUISITION_NO = reqNo;
        }
    }
    public async Task AddCustomer()
    {

        if (IsCustomerValidation() != true)
        {
            try
            {
                var data = await Http.PostJsonAsync<CustomerModel>(Utility.BaseUrl + "api/Customer", customer);

                toastService.ShowSuccess("Requisition Generate Successfully!!!");
                await GetCustomer();
                customer = new CustomerModel();

            }
            catch (Exception ex)
            {

            }

        }
    }
    private bool IsCustomerValidation()
    {
        bool flag = false;
        if (customer.CUSTOMER_NAME == "" || customer.CUSTOMER_NAME == string.Empty || customer.CUSTOMER_NAME == null)
        {
            toastService.ShowWarning("Customer Name cannot be empty!");
            flag = true;
            flag = true;
        }


        return flag;
    }
    public async Task EditTermsCondition()
    {

        if (IsValidation_TermsConditions() != true)
        {
            try
            {
                termsconditions.SALES_TERMS_CONDITION_ID = termsconditionId;
                var data = await Http.PutJsonAsync<PurchaseTermsConditionsModel>(Utility.BaseUrl + "api/Setup/UpdateSalesTermsConditions", termsconditions);

            }
            catch (Exception ex)
            {

            }


        }
        await GetAllTermsCondition();
        termsconditions.TERMS_AND_CONDITIONS = "";
        editfieldsetareastatus = 0;
    }
    private async Task GetAllTermsCondition()
    {
        termsConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Setup/GetSalesTermsConditions");
    }
    private async Task SearchCondition(ChangeEventArgs changeEvent)
    {
        string value = changeEvent.Value.ToString();
        if (value != "")
        { termsConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Setup/GetSalesTermsConditionsBySearch/" + value); }
        else { await GetAllTermsCondition(); }


    }
    private void Cancel()
    {
        UriHelper.NavigateTo("/SalesOrderList");
    }
    private async Task GetSelectedTerms()
    {
        int[] nums = Array.ConvertAll(terms_And_Conditions_No.Split(','), int.Parse);
        PurchaseTermsConditionsModel tcon = new PurchaseTermsConditionsModel();
        foreach (var item in nums)
        {
            tcon = new PurchaseTermsConditionsModel();
            tcon.PURCHASE_TERMS_CONDITION_ID = 0;
            tcon.SALES_TERMS_CONDITION_ID = AlltermsConditionList.Find(x => x.SALES_TERMS_CONDITION_ID == item).SALES_TERMS_CONDITION_ID;
            tcon.SL = 0;
            tcon.TERMS_AND_CONDITIONS = AlltermsConditionList.Find(x => x.SALES_TERMS_CONDITION_ID == item).TERMS_AND_CONDITIONS;


            if (!selectedtermsConditionList.Exists(x => x.SALES_TERMS_CONDITION_ID == item))
            {

                selectedtermsConditionList.Add(tcon);

            }
            else
            {
                selectedtermsConditionList.Where(w => w.SALES_TERMS_CONDITION_ID == item).ToList().ForEach(s => s.SALES_TERMS_CONDITION_ID = tcon.SALES_TERMS_CONDITION_ID);
                selectedtermsConditionList.Where(w => w.SALES_TERMS_CONDITION_ID == item).ToList().ForEach(s => s.TERMS_AND_CONDITIONS = tcon.TERMS_AND_CONDITIONS);
            }

        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.JSInterop.IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
