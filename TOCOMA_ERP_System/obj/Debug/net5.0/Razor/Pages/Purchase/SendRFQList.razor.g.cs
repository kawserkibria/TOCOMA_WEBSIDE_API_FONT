#pragma checksum "G:\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\SendRFQList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2b6cfa16ac3660e5405b59796070dc3ed72841c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/SendRFQList")]
    public partial class SendRFQList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"dashboard-details\"><h4 class=\"p-2\"><img src=\"images/fountain-pen.png\" alt width=\"50\" height=\"50\" class=\"mr-3\"><span class=\"text-uppercase\">SEND RFQ TO VENDORS</span></h4>\r\n    <div class=\"newRequsitionForm-content\"><form action><div class=\"container-fluid\"><div class=\"analytic_details_contain_two\"><table class=\"table table-striped\"><thead style=\"background-color:steelblue;color:white\"><tr><td scope=\"col\"></td>\r\n                                <td scope=\"col\"></td>\r\n                                <td scope=\"col\">Requisition No.</td>\r\n                                <td scope=\"col\">Requester</td>\r\n                                <td scope=\"col\">Request Department</td>\r\n                                <td scope=\"col\">Requisition Title</td>\r\n                                <td scope=\"col\">Request Date</td>\r\n                                <td scope=\"col\">Requisition Total</td>\r\n                                <td scope=\"col\">Currency</td>\r\n                                <td scope=\"col\">Status</td></tr></thead>\r\n                        <tbody><tr><td scope=\"col\"><a href=\"SendRFQ\">SEND RFQ</a></td>\r\n                                <td scope=\"col\"><a href=\"#\">VIEW DETAIL</a></td>\r\n                                <td scope=\"col\">9168-12</td>\r\n                                <td scope=\"col\">Iffat</td>\r\n                                <td scope=\"col\">Supply Chain</td>\r\n                                <td scope=\"col\">Material Purchase</td>\r\n                                <td scope=\"col\">09/02/2022</td>\r\n                                <td scope=\"col\">1,50,000</td>\r\n                                <td scope=\"col\">BDT</td>\r\n                                <td scope=\"col\">Approved</td></tr></tbody></table></div></div></form></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
