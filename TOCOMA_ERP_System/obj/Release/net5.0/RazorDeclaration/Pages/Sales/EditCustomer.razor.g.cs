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
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditCustomer/{customerId}")]
    public partial class EditCustomer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 542 "F:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\EditCustomer.razor"
       
    [Parameter]
    public string customerId { get; set; }
    CustomerModel customer = new CustomerModel();
    CustomerProjectModel customerProject = new CustomerProjectModel();
    CustomerProjectModel cProject = new CustomerProjectModel();
    List<CustomerProjectModel> customerProjectlist = new List<CustomerProjectModel>();
    List<CustomerProjectModel> Projectlist = new List<CustomerProjectModel>();
    List<CustomerTypeModel> customerTypeList = new List<CustomerTypeModel>();
    CustomerContactModel customerContactModel = new CustomerContactModel();
    CustomerContactModel customerContact = new CustomerContactModel();
    List<CustomerContactModel> customerContactList = new List<CustomerContactModel>();
    List<CustomerContactModel> ContactList = new List<CustomerContactModel>();
    List<DepartmentEntity> departmentList = new List<DepartmentEntity>();
    int customerCode;
    string btnAdd;
    protected override async Task OnInitializedAsync()
    {
        btnAdd = "ADD";
        customerTypeList = await Http.GetJsonAsync<List<CustomerTypeModel>>(Utility.BaseUrl + "api/Customer/GetCustomerType");
        departmentList = await Http.GetJsonAsync<List<DepartmentEntity>>(Utility.BaseUrl + "api/Department");
        customer = await Http.GetJsonAsync<CustomerModel>(Utility.BaseUrl + "api/Customer/GetCustomerData/" + customerId);
        customerContactList = await Http.GetJsonAsync<List<CustomerContactModel>>(Utility.BaseUrl + "api/Customer/GetCustomerContactList/" + customer.CUSTOMER_CODE);
        customerProjectlist = await Http.GetJsonAsync<List<CustomerProjectModel>>(Utility.BaseUrl + "api/Customer/GetCustomerProjectList/" + customerId);

        customerContact.CUSTOMER_VENDOR_CODE = customer.CUSTOMER_CODE;
    }
    public async Task AddItem()
    {
        //if(cProject.CUSTOMER_ID!=0)
        //{
        customerProject = new CustomerProjectModel();
        customerProject.SHIPPING_PROJECT_NAME = cProject.SHIPPING_PROJECT_NAME;
        customerProject.PROJECT_NAME_SHORT_FORM = cProject.PROJECT_NAME_SHORT_FORM;
        customerProject.PROJECT_ADDRESS = cProject.PROJECT_ADDRESS;
        customerProject.PROJECT_CONTACT_PERSON_NAME = cProject.PROJECT_CONTACT_PERSON_NAME;
        customerProject.PROJECT_CONTACT_PERSON_PHONE = cProject.PROJECT_CONTACT_PERSON_PHONE;
        customerProject.PROJECT_CONTACT_PERSON_EMAIL = cProject.PROJECT_CONTACT_PERSON_EMAIL;

        customerProjectlist.Add(customerProject);
        StateHasChanged();
        //    }
        //else { toastService.ShowWarning("Please Select Customer"); }

    }
    public async Task AddCustomerContact()
    {
        if(btnAdd=="ADD")
        {
            customerContactModel = new CustomerContactModel();
            customerContactModel.CUSTOMER_VENDOR_CODE = customer.CUSTOMER_CODE;
            customerContactModel.CUSTOMER_CONTACT_ID = customerContact.CUSTOMER_CONTACT_ID;
            customerContactModel.NAME = customerContact.NAME;
            customerContactModel.DESIGNATION = customerContact.DESIGNATION;
            customerContactModel.DEPARTMENT_NAME = customerContact.DEPARTMENT_NAME;
            customerContactModel.MOBILE = customerContact.MOBILE;
            customerContactModel.EMAIL = customerContact.EMAIL;
            customerContactModel.WECHAT = customerContact.WECHAT;
            customerContactModel.WHATSAPP = customerContact.WHATSAPP;

            customerContactList.Add(customerContactModel);
        }
        else if(btnAdd=="EDIT")
        {
            btnAdd = "EDIT";
            customerContactList.Where(w => w.CUSTOMER_CONTACT_ID == customerCode).ToList().ForEach(s => s.NAME = Convert.ToString(customerContact.NAME));
            customerContactList.Where(w => w.CUSTOMER_CONTACT_ID == customerCode).ToList().ForEach(s => s.DESIGNATION = customerContact.DESIGNATION);
            //customerContactList.Where(w => w.CUSTOMER_VENDOR_CODE == customerCode).ToList().ForEach(s => s.DEPARTMENT_ID = customerContact.DEPARTMENT_ID);
            customerContactList.Where(w => w.CUSTOMER_CONTACT_ID == customerCode).ToList().ForEach(s => s.DEPARTMENT_NAME = customerContact.DEPARTMENT_NAME);
            customerContactList.Where(w => w.CUSTOMER_CONTACT_ID == customerCode).ToList().ForEach(s => s.MOBILE = customerContact.MOBILE);
            customerContactList.Where(w => w.CUSTOMER_CONTACT_ID == customerCode).ToList().ForEach(s => s.EMAIL = customerContact.EMAIL);
            customerContactList.Where(w => w.CUSTOMER_CONTACT_ID == customerCode).ToList().ForEach(s => s.WECHAT = customerContact.WECHAT);
            customerContactList.Where(w => w.CUSTOMER_CONTACT_ID == customerCode).ToList().ForEach(s => s.WHATSAPP = customerContact.WHATSAPP);
        }

        StateHasChanged();
        close();

    }
    public async Task SaveCustomer()
    {
        if (IsValidation() != true)
        {
            try
            {
                //customerCode = await Http.GetStringAsync(Utility.BaseUrl + "api/Customer/GetCustomerCode");
                //customer.CUSTOMER_CODE = customerCode;
                var data = await Http.PutJsonAsync<CustomerModel>(Utility.BaseUrl + "api/Customer", customer);

                var id = await Http.GetJsonAsync<int>(Utility.BaseUrl + "api/Customer/GetCustomerId/" + customer.CUSTOMER_CODE);
                foreach (var item in customerProjectlist)
                {
                    customerProject = new CustomerProjectModel();
                    customerProject.CUSTOMER_ID = id;
                    customerProject.CUSTOMER_PROJECT_ID = item.CUSTOMER_PROJECT_ID;
                    customerProject.SHIPPING_PROJECT_NAME = item.SHIPPING_PROJECT_NAME;
                    customerProject.PROJECT_NAME_SHORT_FORM = item.PROJECT_NAME_SHORT_FORM;
                    customerProject.PROJECT_ADDRESS = item.PROJECT_ADDRESS;
                    customerProject.PROJECT_CONTACT_PERSON_NAME = item.PROJECT_CONTACT_PERSON_NAME;
                    customerProject.PROJECT_CONTACT_PERSON_PHONE = item.PROJECT_CONTACT_PERSON_PHONE;
                    customerProject.PROJECT_CONTACT_PERSON_EMAIL = item.PROJECT_CONTACT_PERSON_EMAIL;

                    Projectlist.Add(customerProject);
                }
                var project = await Http.PutJsonAsync<List<CustomerProjectModel>>(Utility.BaseUrl + "api/Customer/UpdateCustomerProject", Projectlist);

                foreach (var item in customerContactList)
                {
                    customerContactModel = new CustomerContactModel();
                    customerContactModel.CUSTOMER_VENDOR_CODE = item.CUSTOMER_VENDOR_CODE;
                    customerContactModel.CUSTOMER_CONTACT_ID = item.CUSTOMER_CONTACT_ID;
                    customerContactModel.NAME = item.NAME;
                    customerContactModel.DESIGNATION = item.DESIGNATION;
                    customerContactModel.DEPARTMENT_NAME = item.DEPARTMENT_NAME;
                    customerContactModel.MOBILE = item.MOBILE;
                    customerContactModel.EMAIL = item.EMAIL;
                    customerContactModel.WECHAT = item.WECHAT;
                    customerContactModel.WHATSAPP = item.WHATSAPP;

                    ContactList.Add(customerContactModel);
                }

                var customercontact = await Http.PutJsonAsync<List<CustomerContactModel>>(Utility.BaseUrl + "api/Customer/UpdateCustomerContact", ContactList);
                toastService.ShowSuccess("Save Success!!");
            }
            catch (Exception EX)
            {

            }
        }

    }
    private bool IsValidation()
    {
        bool flag = false;
        if (customer.CUSTOMER_NAME == "" || customer.CUSTOMER_NAME == string.Empty || customer.CUSTOMER_NAME == null)
        {
            toastService.ShowWarning("Customer Name Is Empty!");
            flag = true;
        }

        return flag;
    }
    public async Task EditItem(int Id)
    {
        btnAdd = "EDIT";
        customerCode = Id;
        customerContact.NAME = customerContactList.Find(x => x.CUSTOMER_CONTACT_ID == Id).NAME;
        customerContact.DESIGNATION = customerContactList.Find(x => x.CUSTOMER_CONTACT_ID == Id).DESIGNATION;
        customerContact.DEPARTMENT_NAME = customerContactList.Find(x => x.CUSTOMER_CONTACT_ID == Id).DEPARTMENT_NAME;
        customerContact.MOBILE = customerContactList.Find(x => x.CUSTOMER_CONTACT_ID == Id).MOBILE;
        customerContact.EMAIL = customerContactList.Find(x => x.CUSTOMER_CONTACT_ID == Id).EMAIL;
        customerContact.WECHAT = customerContactList.Find(x => x.CUSTOMER_CONTACT_ID == Id).WECHAT;
        customerContact.WHATSAPP = customerContactList.Find(x => x.CUSTOMER_CONTACT_ID == Id).WHATSAPP;
    }
    public async Task DeleteItem(int code)
    {
        if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete ?"))
            return;

        await Http.DeleteAsync(Utility.BaseUrl + "api/Customer/DeleteCustomerContact/" + code);
        var itemToRemove = customerContactList.Single(r => r.CUSTOMER_CONTACT_ID == code);
        customerContactList.Remove(itemToRemove);
    }
    private void close()
    {
        btnAdd = "ADD";
        customerContact = new CustomerContactModel();
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
