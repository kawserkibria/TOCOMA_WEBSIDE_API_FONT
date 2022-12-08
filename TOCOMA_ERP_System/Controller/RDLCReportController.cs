using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AspNetCore.Reporting;
using TOCOMA_ERP_ClassLibrary.Models;
using System.Net.Http;
using System.Net.Http.Json;
using TOCOMA_ERP_System.Data;

namespace TOCOMA_ERP_System.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RDLCReportController : ControllerBase
    {

        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly HttpClient Http;
        //SessionData sessiondata = new SessionData();
        Dictionary<string, string> parameters = new Dictionary<string, string>();
        public RDLCReportController(IWebHostEnvironment webHostEnvironment)
        {
            this._webHostEnvironment = webHostEnvironment;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        public List<ACC_VOUCHER_MODEL> GetPlanAndWork(string REFNO)
        {
            List<ACC_VOUCHER_MODEL> listPlanOperation = new List<ACC_VOUCHER_MODEL>();
            //listPlanOperation = Http.GetAsync(Utility.BaseUrl + "api/Setup/GetWorkScheduleBySuperAdmin");
            var response = Http.GetAsync(Utility.BaseUrl + "api/Transection/GetACCVoucherByRefNo/" + REFNO).GetAwaiter().GetResult();
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                //return responseContent.ReadFromJsonAsync<ACC_VOUCHER_MODEL>.ReadAsStringAsync().GetAwaiter().GetResult();
            }
            //return await Http.GetFromJsonAsync<List<ACC_VOUCHER_MODEL>>(Utility.BaseUrl + "api/Setup/GetWorkScheduleBySuperAdmin");
            return listPlanOperation;
        }
        [HttpGet]
        [Route("GetPaymentReport/{refNo}/{Type}")]
        public IActionResult GetPlanAndScheduleReport(string refNo, int Type)
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            //List<ACC_VOUCHER_MODEL> voucher = new List<ACC_VOUCHER_MODEL>();
            //listdata.Add(SessionData.paymentDataList);
            //listdata = await Http.GetJsonAsync<List<ACC_VOUCHER_MODEL>>(Utility.BaseUrl + "api/Transection/GetACCVoucherByRefNo/" + refNo);
            //listdata = GetPlanAndWork(refNo);
            dt = lsttodt.ToDataTable(SessionData.paymentDataList);

            string mimetype = "";
            int extention = 1;
            //strResourcePath =Server.MapPath("~") + Path;
            //var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\PlanAndScheduleReport.rdlc";
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\PaymentVoucher.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();



            if (dt.Rows.Count > 0)
            {
                double voucher_total_value;
                voucher_total_value = Convert.ToDouble(dt.Rows[0].ItemArray[8].ToString());
                Inwords = NumberToWords.ConvertAmount(voucher_total_value);
                string debit_value = String.Format("{0:#,###,###.##}", voucher_total_value);


                parameters.Add("param", dt.Rows[0].ItemArray[1].ToString());
                parameters.Add("voucher_date", dt.Rows[0].ItemArray[7].ToString());
                parameters.Add("debit_total", debit_value);
                parameters.Add("credit_total", debit_value);
                parameters.Add("amount_in_word", Inwords);
                parameters.Add("narration", dt.Rows[0].ItemArray[9].ToString());
                parameters.Add("printed_date", current_date);
                parameters.Add("printed_time", current_time);
                if (Type == 1)
                { parameters.Add("voucherType", "Payment"); }
                else if (Type == 2)
                { parameters.Add("voucherType", "Receipt"); }
                else if (Type == 3)
                { parameters.Add("voucherType", "Journal"); }
                else if (Type == 4)
                { parameters.Add("voucherType", "Contra"); }



            }


            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("dsPaymentVoucher", dt);
            var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }
        [HttpGet]
        [Route("GetTrialBalanceReport")]
        public IActionResult GetTrialBalanceReport(string refNo, string Type)
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_Trial_Balance_Report> listdata = new List<ACC_Trial_Balance_Report>();
            dt = lsttodt.ToDataTable(SessionData.trialBalanceList);

            string mimetype = "";
            int extention = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\TrialBalance.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));
            parameters.Add("dateFrom", SessionData.From_date);
            parameters.Add("dateTo", SessionData.To_date);
            parameters.Add("profitLoss", totalprofitloss);
            //parameters.Add("totalProfitLoss", totalprofitloss);
            LocalReport localReport3 = new LocalReport(path);

            localReport3.AddDataSource("dsTrialBalance", dt);
            int ext = (int)(DateTime.Now.Ticks >> 10);
            var result = localReport3.Execute(RenderType.Pdf, ext, parameters);
            //var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }

        [HttpGet]
        [Route("GetBalanceSheetReport")]
        public IActionResult GetBalanceSheetReport(string refNo, int Type)
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            dt = lsttodt.ToDataTable(SessionData.balanceSheetList);

            string mimetype = "";
            int extention = 3;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\BalanceSheet.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));
            parameters.Add("dateFrom", System.DateTime.Now.ToShortDateString());
            parameters.Add("profitLoss", totalprofitloss);
            //parameters.Add("dateTo", System.DateTime.Now.ToShortDateString());
            //parameters.Add("totalProfitLoss", totalprofitloss);
            LocalReport localReport1 = new LocalReport(path);

            localReport1.AddDataSource("dsBalanceSheet", dt);
            int ext = (int)(DateTime.Now.Ticks >> 10);
            var result = localReport1.Execute(RenderType.Pdf, ext, parameters);
            //var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }
        //[HttpGet]
        //[Route("GetProfitLossReport/{refNo}/{Type}")]
        [HttpGet]
        [Route("GetProfitLossReport")]
        public IActionResult GetProfitLossReport(string refNo, int Type)
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            dt = lsttodt.ToDataTable(SessionData.profitAndLossList);

            string mimetype = "";
            int extention = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\ProfitAndLoss.rdlc";

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));
            parameters.Add("dateFrom", SessionData.From_date);
            parameters.Add("dateTo", SessionData.To_date);
            parameters.Add("profitLoss", totalprofitloss);



            LocalReport localReport2 = new LocalReport(path);

            localReport2.AddDataSource("dsProfitLoss", dt);
            int ext = (int)(DateTime.Now.Ticks >> 10);
            var result = localReport2.Execute(RenderType.Pdf, ext, parameters);
            //var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }
        [HttpGet]
        [Route("GetSalesDeliveryNote")]
        public IActionResult GetSalesDeliveryNote(string rptType, int Type)
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            dt = lsttodt.ToDataTable(AppState.salesItemDetails);

            string mimetype = "";
            int extention = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesDeliveryNote.rdlc";
            //if (rptType=="1")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesDeliveryNote.rdlc"; }
            //else if(rptType=="2")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesInvoice.rdlc"; }


            Dictionary<string, string> parameters = new Dictionary<string, string>();
            //string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));
            parameters.Add("companyNameShortForm", AppState.salesOrderView.CUSTOMER_NAME_SHORT_FORM);
            parameters.Add("corporateAddress", AppState.salesOrderView.CORPORATE_ADDRESS);
            parameters.Add("shippingProject", AppState.salesOrderView.SHIPPING_PROJECT_NAME);
            parameters.Add("contactPerson", AppState.salesOrderView.CONTACT_PERSON_NAME);
            parameters.Add("customerCode", AppState.salesOrderView.CUSTOMER_CODE);
            parameters.Add("contactPhone", AppState.salesOrderView.CONTACT_PERSON_PHONE);
            parameters.Add("poNumber", AppState.salesOrderView.PO_WO_NUMBER);
            parameters.Add("podate", AppState.salesOrderView.PO_WO_DATE);
            //parameters.Add("dateTo", SessionData.To_date);
            //parameters.Add("profitLoss", totalprofitloss);



            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("dsSalesDeliveryNote", dt);
            var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }
        [HttpGet]
        [Route("GetSalesInvoice")]
        public IActionResult GetSalesInvoice(string rptType, int Type)
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            var dt2 = new DataTable();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<SalesOrderViewModel> salesOrder = new List<SalesOrderViewModel>();
            salesOrder.Add(AppState.salesOrderView);
            dt = lsttodt.ToDataTable(AppState.salesItemDetails);
            dt1 = lsttodt.ToDataTable(AppState.SalestermsConditionList);
            dt2 = lsttodt.ToDataTable(salesOrder);

            string mimetype = "";
            int extention = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesInvoice.rdlc";
            //if (rptType=="1")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesDeliveryNote.rdlc"; }
            //else if(rptType=="2")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesInvoice.rdlc"; }


            Dictionary<string, string> parameters = new Dictionary<string, string>();
            //string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));
            //parameters.Add("companyNameShortForm", AppState.salesOrderView.CUSTOMER_NAME_SHORT_FORM);
            //parameters.Add("corporateAddress", AppState.salesOrderView.CORPORATE_ADDRESS);
            //parameters.Add("shippingProject", AppState.salesOrderView.SHIPPING_PROJECT_NAME);
            //parameters.Add("contactPerson", AppState.salesOrderView.CONTACT_PERSON_NAME);
            //parameters.Add("customerCode", AppState.salesOrderView.CUSTOMER_CODE);
            //parameters.Add("contactPhone", AppState.salesOrderView.CONTACT_PERSON_PHONE);
            //parameters.Add("poNumber", AppState.salesOrderView.PO_WO_NUMBER);
            //parameters.Add("podate", AppState.salesOrderView.PO_WO_DATE);

            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("DataSet1", dt);
            localReport.AddDataSource("DataSet2", "");
            localReport.AddDataSource("DataSet3", dt1);
            localReport.AddDataSource("DataSet4", "");
            localReport.AddDataSource("DataSet5", "");
            localReport.AddDataSource("DataSet6",dt2);
            var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }
        public static DataTable CombineDataTables(params DataTable[] args)
        {
            return args.SelectMany(dt => dt.AsEnumerable()).CopyToDataTable();
        }
        //[HttpGet]
        //[Route("GetPurchaseOrderInvoiceLocal")]
        //public IActionResult GetPurchaseOrderInvoiceLocal()
        //{
        //    string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
        //    string current_time = System.DateTime.Now.ToShortTimeString().ToString();
        //    string Inwords = "";
        //    var dt = new DataTable();
        //    var dt1 = new DataTable();
        //    var dt2 = new DataTable();
        //    var dt3 = new DataTable();
        //    var DS = new DataSet();
        //    ListtoDataTable lsttodt = new ListtoDataTable();
        //    List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
        //    List<PurchaseOrderViewModel> pOrderList = new List<PurchaseOrderViewModel>();
        //    PurchaseInvoiceLocal pl = new PurchaseInvoiceLocal();
        //    List<PurchaseInvoiceLocal> plList = new List<PurchaseInvoiceLocal>();
        //    pOrderList.Add(AppState.porder);

        //    pl.PO_NUMBER_LONG_CODE = AppState.porder.PO_NUMBER_LONG_CODE;
        //    pl.PO_DATE = AppState.porder.PO_DATE;
        //    plList.Add(pl);

        //    dt = lsttodt.ToDataTable(AppState.porderDetails);
        //    dt2 = lsttodt.ToDataTable(AppState.termsConditionList);
        //    dt3 = lsttodt.ToDataTable(plList);
        //    //dt.Rows.Add(row);
        //    //DS = lsttodt.ToDataTable(AppState.termsConditionList);
        //    //dt3 = dt;
        //    //DS.Tables.Add(dt);
        //    //DS.Tables.Add(dt1);
        //    //DS.Tables.Add(dt2);
        //    //dt3 = DS.Tables[0];
        //    //dt3 = DS.Tables[1];
        //    //dt3 = DS.Tables[2];

        //    //for (int i=0;i<DS.Tables.Count;i++)
        //    //{
        //    //    dt3 += DS.Tables[i];
        //    //}


        //    string mimetype = "";
        //    int extention = 1;
        //    var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\PurchaseInvoiceLocal.rdlc";
        //    //if (rptType=="1")
        //    //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesDeliveryNote.rdlc"; }
        //    //else if(rptType=="2")
        //    //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesInvoice.rdlc"; }


        //    parameters = new Dictionary<string, string>();
        //    //string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));
        //    double voucher_total_value = 0;
        //    for (int k = 0; k < dt.Rows.Count; k++)
        //    { voucher_total_value += Convert.ToDouble(dt.Rows[k].ItemArray[8].ToString()); }
        //    Inwords = NumberToWords.ConvertAmount(voucher_total_value);
        //    string total = String.Format("{0:#,###,###.##}", voucher_total_value);




        //    parameters.Add("poNumber", AppState.porder.PO_NUMBER_LONG_CODE);
        //    parameters.Add("supplierName", AppState.porder.VENDOR_NAME);
        //    parameters.Add("corporateAddress", AppState.porder.ADDRESS);
        //    parameters.Add("contactPerson", AppState.porder.CONTACT_PERSON_NAME_1);
        //    parameters.Add("contactPhone", AppState.porder.CONTACT_PERSON_CONTACT_NO_1);

        //    parameters.Add("podate", AppState.porder.PO_DATE);
        //    parameters.Add("consignee", AppState.porder.CONSIGNEE_NAME);
        //    parameters.Add("consigneeAddress", AppState.porder.ADDRESS);
        //    parameters.Add("contactPersonEmail", AppState.porder.CONATACT_PERSON_EMAIL_1);
        //    parameters.Add("termsOfDelivery", AppState.porder.TERMS_OF_DELIVERY);
        //    parameters.Add("deliveryMode", AppState.porder.DELIVERY_MODE);
        //    parameters.Add("shippingAddress", AppState.porder.SHIPPING_ADDRESS);
        //    parameters.Add("paymentTerm", AppState.porder.PAYMENT_TERM);
        //    parameters.Add("paymentMode", AppState.porder.PAYMENT_MODE);
        //    parameters.Add("quotRefNo", AppState.porder.QUOTATION_REFERANCE_NO);
        //    parameters.Add("quotRefDate", AppState.porder.QUOTATION_REFERANCE_DATE);


        //    parameters.Add("vendorContactPerson", AppState.porder.CONTACT_PERSON_NAME);
        //    parameters.Add("vendorContactNo", AppState.porder.CONTACT_NO);
        //    parameters.Add("vendorContactEmail", AppState.porder.VENDOR_CONTACT_EMAIL);



        //    parameters.Add("A", AppState.porder.PAYMENT_MODE);
        //    parameters.Add("B", AppState.porder.PAYMENT_MODE);
        //    parameters.Add("C", AppState.porder.PAYMENT_MODE);
        //    parameters.Add("D", AppState.porder.PAYMENT_MODE);






        //    parameters.Add("inWord", Inwords);
        //    parameters.Add("grandTotal", total);

        //    //21







        //    //parameters.Add("contactPhone", AppState.porder.CONSIGNEE_NAME);

        //    //parameters.Add("dateTo", SessionData.To_date);
        //    //parameters.Add("profitLoss", totalprofitloss);



        //    LocalReport localReport4 = new LocalReport(path);

        //    localReport4.AddDataSource("DataSet1", dt);
        //    localReport4.AddDataSource("DataSet2", dt2);
        //    localReport4.AddDataSource("DataSet3", dt3);

        //    //localReport.AddDataSource("dsTermsAndConditions", dt1);

        //    int ext = (int)(DateTime.Now.Ticks >> 10);
        //    var result = localReport4.Execute(RenderType.Pdf, ext, parameters);

        //    //var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
        //    return File(result.MainStream, "application/pdf");
        //}

        public class CandidateInfo
        {
            public int CandidateId { get; set; }
            public string Name { get; set; }
            public string CellNo { get; set; }
            public int Age { get; set; }
            //Add more properties here as you need them. Ex:
            public string GroupName { get; set; }
        }
        public class TotalTable
        {
            public string INWORD { get; set; }
            public string TOTAL_AMOUNT { get; set; }
        }

        [HttpGet]
        [Route("GetPurchaseOrderInvoiceLocal")]
        public IActionResult GetPurchaseOrderInvoiceLocal()
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            var dt2 = new DataTable();
            var dt3 = new DataTable();
            var DS = new DataSet();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            List<PurchaseOrderViewModel> pOrderList = new List<PurchaseOrderViewModel>();
            PurchaseInvoiceLocal pl = new PurchaseInvoiceLocal();
            List<PurchaseInvoiceLocal> plList = new List<PurchaseInvoiceLocal>();
            PurchaseOrderDetailsEntity porD = new PurchaseOrderDetailsEntity();
            List<PurchaseOrderDetailsEntity> porDList = new List<PurchaseOrderDetailsEntity>();
            TotalTable t = new TotalTable();
            List<TotalTable> tList = new List<TotalTable>();
            pOrderList.Add(AppState.porder);

            

            //foreach (var item in AppState.porderDetails)
            //{
            //    porD = new PurchaseOrderDetailsEntity();
            //    porD.ITEM_NAME = item.ITEM_NAME;
            //    //porD.INWORDS=

            //    //porDList.Add(porD);
            //}
            
            dt1 = lsttodt.ToDataTable(AppState.porderDetails);
            dt2 = lsttodt.ToDataTable(AppState.termsConditionList);

            double voucher_total_value = 0;
            for (int k = 0; k < dt1.Rows.Count; k++)
            { voucher_total_value += Convert.ToDouble(dt1.Rows[k].ItemArray[8].ToString()); }
            Inwords = NumberToWords.ConvertAmount(voucher_total_value);
            string total = String.Format("{0:#,###,###.##}", voucher_total_value);

            t.INWORD = Inwords;
            t.TOTAL_AMOUNT = total;

            tList.Add(t);
            dt3= lsttodt.ToDataTable(tList);


            pl.PO_NUMBER_LONG_CODE = AppState.porder.PO_NUMBER_LONG_CODE;
            pl.PO_DATE = AppState.porder.PO_DATE;
            pl.VENDOR_NAME = AppState.porder.VENDOR_NAME;
            pl.REGISTERED_ADDRESS = AppState.porder.REGISTERED_ADDRESS;
            pl.QUOTATION_REFERANCE_NO = AppState.porder.QUOTATION_REFERANCE_NO;
            pl.QUOTATION_REFERANCE_DATE = AppState.porder.QUOTATION_REFERANCE_DATE;
            pl.CONSIGNEE_NAME = AppState.porder.CONSIGNEE_NAME;
            pl.ADDRESS = AppState.porder.ADDRESS;
            pl.CONTACT_PERSON_NAME = AppState.porder.CONTACT_PERSON_NAME;
            pl.CONTACT_NO = AppState.porder.CONTACT_NO;
            pl.VENDOR_CONTACT_EMAIL = AppState.porder.VENDOR_CONTACT_EMAIL;
            pl.CONTACT_PERSON_NAME_1 = AppState.porder.CONTACT_PERSON_NAME_1;
            pl.CONTACT_PERSON_CONTACT_NO_1 = AppState.porder.CONTACT_PERSON_CONTACT_NO_1;
            pl.CONATACT_PERSON_EMAIL_1 = AppState.porder.CONATACT_PERSON_EMAIL_1;
            pl.TERMS_OF_DELIVERY = AppState.porder.TERMS_OF_DELIVERY;
            pl.DELIVERY_MODE = AppState.porder.DELIVERY_MODE;
            pl.SHIPPING_ADDRESS = AppState.porder.SHIPPING_ADDRESS;
            pl.PAYMENT_TERM = AppState.porder.PAYMENT_TERM;
            pl.PAYMENT_MODE = AppState.porder.PAYMENT_MODE;
            //pl.INWORDS = Inwords;
            //pl.TOTAL_AMOUNT = total;
            plList.Add(pl);

            dt = lsttodt.ToDataTable(plList);
            

            
            //dt3 = lsttodt.ToDataTable(plList);
            //dt.Rows.Add(row);
            //DS = lsttodt.ToDataTable(AppState.termsConditionList);
            //dt3 = dt;
            //DS.Tables.Add(dt);
            //DS.Tables.Add(dt1);
            //DS.Tables.Add(dt2);
            //dt3 = DS.Tables[0];
            //dt3 = DS.Tables[1];
            //dt3 = DS.Tables[2];

            //for (int i=0;i<DS.Tables.Count;i++)
            //{
            //    dt3 += DS.Tables[i];
            //}


            string mimetype = "";
            int extention = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\PurchaseInvoiceL.rdlc";
            //if (rptType=="1")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesDeliveryNote.rdlc"; }
            //else if(rptType=="2")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesInvoice.rdlc"; }


            Dictionary<string, string>  parameters = new Dictionary<string, string>();
            //string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));





            //parameters.Add("poNumber", AppState.porder.PO_NUMBER_LONG_CODE);
            //parameters.Add("supplierName", AppState.porder.VENDOR_NAME);
            //parameters.Add("corporateAddress", AppState.porder.ADDRESS);
            //parameters.Add("contactPerson", AppState.porder.CONTACT_PERSON_NAME_1);
            //parameters.Add("contactPhone", AppState.porder.CONTACT_PERSON_CONTACT_NO_1);

            //parameters.Add("podate", AppState.porder.PO_DATE);
            //parameters.Add("consignee", AppState.porder.CONSIGNEE_NAME);
            //parameters.Add("consigneeAddress", AppState.porder.ADDRESS);
            //parameters.Add("contactPersonEmail", AppState.porder.CONATACT_PERSON_EMAIL_1);
            //parameters.Add("termsOfDelivery", AppState.porder.TERMS_OF_DELIVERY);
            //parameters.Add("deliveryMode", AppState.porder.DELIVERY_MODE);
            //parameters.Add("shippingAddress", AppState.porder.SHIPPING_ADDRESS);
            //parameters.Add("paymentTerm", AppState.porder.PAYMENT_TERM);
            //parameters.Add("paymentMode", AppState.porder.PAYMENT_MODE);
            //parameters.Add("quotRefNo", AppState.porder.QUOTATION_REFERANCE_NO);
            //parameters.Add("quotRefDate", AppState.porder.QUOTATION_REFERANCE_DATE);


            //parameters.Add("vendorContactPerson", AppState.porder.CONTACT_PERSON_NAME);
            //parameters.Add("vendorContactNo", AppState.porder.CONTACT_NO);
            //parameters.Add("vendorContactEmail", AppState.porder.VENDOR_CONTACT_EMAIL);



            //parameters.Add("A", AppState.porder.PAYMENT_MODE);
            //parameters.Add("B", AppState.porder.PAYMENT_MODE);
            //parameters.Add("C", AppState.porder.PAYMENT_MODE);
            //parameters.Add("D", AppState.porder.PAYMENT_MODE);






            //parameters.Add("inWord", Inwords);
            //parameters.Add("grandTotal", total);

            //21







            //parameters.Add("contactPhone", AppState.porder.CONSIGNEE_NAME);

            //parameters.Add("dateTo", SessionData.To_date);
            //parameters.Add("profitLoss", totalprofitloss);



            LocalReport localReport4 = new LocalReport(path);

            localReport4.AddDataSource("DataSet1", dt);
            localReport4.AddDataSource("DataSet2", dt1);
            localReport4.AddDataSource("DataSet3", dt2);
            localReport4.AddDataSource("DataSet4", dt3);

            //localReport.AddDataSource("dsTermsAndConditions", dt1);

            int ext = (int)(DateTime.Now.Ticks >> 10);
            var result = localReport4.Execute(RenderType.Pdf, ext, parameters);

            //var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }


        [HttpGet]
        [Route("GetPurchaseOrderInvoiceInt")]
        public IActionResult GetPurchaseOrderInvoiceInt()
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            var dt2 = new DataTable();
            var dt3 = new DataTable();
            var dt4 = new DataTable();
            var DS = new DataSet();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            List<PurchaseOrderViewModel> pOrderList = new List<PurchaseOrderViewModel>();
            PurchaseInvoiceLocal pl = new PurchaseInvoiceLocal();
            List<PurchaseInvoiceLocal> plList = new List<PurchaseInvoiceLocal>();
            pOrderList.Add(AppState.porder);

            pl.PO_NUMBER_LONG_CODE = AppState.porder.PO_NUMBER_LONG_CODE;
            pl.PO_DATE = AppState.porder.PO_DATE;
            plList.Add(pl);
            pOrderList.Add(AppState.porder);
            dt = lsttodt.ToDataTable(plList);
            dt3 = lsttodt.ToDataTable(AppState.porderDetails);
            dt2 = lsttodt.ToDataTable(AppState.packagingList);
            dt4 = lsttodt.ToDataTable(AppState.termsConditionList);
            //dt.Rows.Add(row);
            //DS = lsttodt.ToDataTable(AppState.termsConditionList);
            //dt3 = dt;
            //DS.Tables.Add(dt);
            //DS.Tables.Add(dt1);
            //DS.Tables.Add(dt2);
            //dt3 = DS.Tables[0];
            //dt3 = DS.Tables[1];
            //dt3 = DS.Tables[2];

            //for (int i=0;i<DS.Tables.Count;i++)
            //{
            //    dt3 += DS.Tables[i];
            //}


            string mimetype = "";
            int extention = 2;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\PurchaseInvoiceInt.rdlc";
            //if (rptType=="1")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesDeliveryNote.rdlc"; }
            //else if(rptType=="2")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesInvoice.rdlc"; }


            Dictionary<string, string>  parameters1 = new Dictionary<string, string>();
            //string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));
            double voucher_total_value = 0;
            for (int k = 0; k < dt3.Rows.Count; k++)
            { voucher_total_value += Convert.ToDouble(dt3.Rows[k].ItemArray[8].ToString()); }
            Inwords = NumberToWords.ConvertAmount(voucher_total_value);
            string total = String.Format("{0:#,###,###.##}", voucher_total_value);
            double grandTotal = voucher_total_value + AppState.porder.CARRING_WAY_COST;
            string Gtotal= String.Format("{0:#,###,###.##}", grandTotal);


            parameters1.Add("poNumber", AppState.porder.PO_NUMBER_LONG_CODE);
            parameters1.Add("podate", AppState.porder.PO_DATE);
            parameters1.Add("supplierName", AppState.porder.VENDOR_NAME);
            parameters1.Add("corporateAddress", AppState.porder.ADDRESS);
            parameters1.Add("consignee", AppState.porder.CONSIGNEE_NAME);
            parameters1.Add("consigneeAddress", AppState.porder.ADDRESS);
            parameters1.Add("quotRefNo", AppState.porder.QUOTATION_REFERANCE_NO);
            parameters1.Add("quotRefDate", AppState.porder.QUOTATION_REFERANCE_DATE);
            parameters1.Add("contactPerson", AppState.porder.CONTACT_PERSON_NAME_1);
            parameters1.Add("contactPhone", AppState.porder.CONTACT_PERSON_CONTACT_NO_1);
            parameters1.Add("contactPersonEmail", AppState.porder.CONATACT_PERSON_EMAIL_1);
            parameters1.Add("vendorContactPerson", AppState.porder.CONTACT_PERSON_NAME);
            parameters1.Add("vendorContactNo", AppState.porder.CONTACT_NO);
            parameters1.Add("vendorContactEmail", AppState.porder.VENDOR_CONTACT_EMAIL);
            parameters1.Add("ContainerSize", AppState.porder.CONTAINER_SIZE);
            parameters1.Add("deliveryTime", AppState.porder.DELIVERY_TIME);
            parameters1.Add("shippingAddress", AppState.porder.SHIPPING_ADDRESS);
            parameters1.Add("paymentTerm", AppState.porder.INCOTERM);
            parameters1.Add("shipVia", AppState.porder.SHIP_VIA);
            parameters1.Add("countryOfOrigin", AppState.porder.COUNTRY_OF_ORIGIN);
            parameters1.Add("portofLoading", AppState.porder.PORT_OF_LOADING);
            parameters1.Add("portofDischarge", AppState.porder.PORT_OF_DISCHARGE);
            parameters1.Add("Currency", AppState.porder.CURRENCY);
            parameters1.Add("bin", AppState.porder.BIN);
            parameters1.Add("tin", AppState.porder.TIN);
            parameters1.Add("carringWayCost", Convert.ToString(AppState.porder.CARRING_WAY_COST));
            parameters1.Add("GRANDT", Gtotal);


            parameters1.Add("inWord", Inwords);
            parameters1.Add("grandTotal", total);

            //25



            //parameters.Add("contactPhone", AppState.porder.CONSIGNEE_NAME);

            //parameters.Add("dateTo", SessionData.To_date);
            //parameters.Add("profitLoss", totalprofitloss);



            LocalReport localReport5 = new LocalReport(path);

            localReport5.AddDataSource("DataSet1", dt);
            localReport5.AddDataSource("DataSet2", dt);
            localReport5.AddDataSource("DataSet3", dt3);
            localReport5.AddDataSource("DataSet4", dt2);
            localReport5.AddDataSource("DataSet5", dt4);

            //localReport.AddDataSource("dsTermsAndConditions", dt1);
            int ext = (int)(DateTime.Now.Ticks >> 10);
            var result = localReport5.Execute(RenderType.Pdf, ext, parameters1);
            //var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }
        //------------Sales Quotation
        [HttpGet]
        [Route("GetSalesQuotation")]
        public IActionResult GetSalesQuotation()
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            var dt2 = new DataTable();
            var dt3 = new DataTable();
            var dt4 = new DataTable();
            var DS = new DataSet();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            List<SalesQuotationView> pOrderList = new List<SalesQuotationView>();
            PurchaseInvoiceLocal pl = new PurchaseInvoiceLocal();
            List<PurchaseInvoiceLocal> plList = new List<PurchaseInvoiceLocal>();
            //pOrderList.Add(AppState.salesQuotation);

            //pl.PO_NUMBER_LONG_CODE = AppState.porder.PO_NUMBER_LONG_CODE;
            //pl.PO_DATE = AppState.porder.PO_DATE;
            //plList.Add(pl);
            pOrderList.Add(AppState.salesQuotation);
            dt = lsttodt.ToDataTable(pOrderList);
            dt1 = lsttodt.ToDataTable(AppState.salesQuotationitemList);
            dt2 = lsttodt.ToDataTable(AppState.SalestermsConditionList);
            //dt4 = lsttodt.ToDataTable(AppState.termsConditionList);
            //dt.Rows.Add(row);
            //DS = lsttodt.ToDataTable(AppState.termsConditionList);
            //dt3 = dt;
            //DS.Tables.Add(dt);
            //DS.Tables.Add(dt1);
            //DS.Tables.Add(dt2);
            //dt3 = DS.Tables[0];
            //dt3 = DS.Tables[1];
            //dt3 = DS.Tables[2];

            //for (int i=0;i<DS.Tables.Count;i++)
            //{
            //    dt3 += DS.Tables[i];
            //}


            string mimetype = "";
            int extention = 2;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesQuotation.rdlc";
            //if (rptType=="1")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesDeliveryNote.rdlc"; }
            //else if(rptType=="2")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesInvoice.rdlc"; }


            Dictionary<string, string> parameters1 = new Dictionary<string, string>();
            //string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));
            //double voucher_total_value = 0;
            //for (int k = 0; k < dt3.Rows.Count; k++)
            //{ voucher_total_value += Convert.ToDouble(dt3.Rows[k].ItemArray[8].ToString()); }
            //Inwords = NumberToWords.ConvertAmount(voucher_total_value);
            //string total = String.Format("{0:#,###,###.##}", voucher_total_value);
            //double grandTotal = voucher_total_value + AppState.porder.CARRING_WAY_COST;
            //string Gtotal = String.Format("{0:#,###,###.##}", grandTotal);


            //parameters1.Add("poNumber", AppState.porder.PO_NUMBER_LONG_CODE);
            //parameters1.Add("podate", AppState.porder.PO_DATE);
            //parameters1.Add("supplierName", AppState.porder.VENDOR_NAME);
            //parameters1.Add("corporateAddress", AppState.porder.ADDRESS);
            //parameters1.Add("consignee", AppState.porder.CONSIGNEE_NAME);
            //parameters1.Add("consigneeAddress", AppState.porder.ADDRESS);
            //parameters1.Add("quotRefNo", AppState.porder.QUOTATION_REFERANCE_NO);
            //parameters1.Add("quotRefDate", AppState.porder.QUOTATION_REFERANCE_DATE);
            //parameters1.Add("contactPerson", AppState.porder.CONTACT_PERSON_NAME_1);
            //parameters1.Add("contactPhone", AppState.porder.CONTACT_PERSON_CONTACT_NO_1);
            //parameters1.Add("contactPersonEmail", AppState.porder.CONATACT_PERSON_EMAIL_1);
            //parameters1.Add("vendorContactPerson", AppState.porder.CONTACT_PERSON_NAME);
            //parameters1.Add("vendorContactNo", AppState.porder.CONTACT_NO);
            //parameters1.Add("vendorContactEmail", AppState.porder.VENDOR_CONTACT_EMAIL);
            //parameters1.Add("ContainerSize", AppState.porder.CONTAINER_SIZE);
            //parameters1.Add("deliveryTime", AppState.porder.DELIVERY_TIME);
            //parameters1.Add("shippingAddress", AppState.porder.SHIPPING_ADDRESS);
            //parameters1.Add("paymentTerm", AppState.porder.INCOTERM);
            //parameters1.Add("shipVia", AppState.porder.SHIP_VIA);
            //parameters1.Add("countryOfOrigin", AppState.porder.COUNTRY_OF_ORIGIN);
            //parameters1.Add("portofLoading", AppState.porder.PORT_OF_LOADING);
            //parameters1.Add("portofDischarge", AppState.porder.PORT_OF_DISCHARGE);
            //parameters1.Add("Currency", AppState.porder.CURRENCY);
            //parameters1.Add("bin", AppState.porder.BIN);
            //parameters1.Add("tin", AppState.porder.TIN);
            //parameters1.Add("carringWayCost", Convert.ToString(AppState.porder.CARRING_WAY_COST));
            //parameters1.Add("GRANDT", Gtotal);


            //parameters1.Add("inWord", Inwords);
            //parameters1.Add("grandTotal", total);

            //25



            //parameters.Add("contactPhone", AppState.porder.CONSIGNEE_NAME);

            //parameters.Add("dateTo", SessionData.To_date);
            //parameters.Add("profitLoss", totalprofitloss);



            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("DataSet1", dt);
            localReport.AddDataSource("DataSet2", dt1);
            localReport.AddDataSource("DataSet3", "");
            localReport.AddDataSource("DataSet4", dt2);
            localReport.AddDataSource("DataSet5", "");

            //localReport.AddDataSource("dsTermsAndConditions", dt1);
            int ext = (int)(DateTime.Now.Ticks >> 10);
            var result = localReport.Execute(RenderType.Pdf, ext, parameters1);
            //var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }
        public class ListtoDataTable
        {
            public System.Data.DataTable ToDataTable<T>(List<T> items)
            {
                System.Data.DataTable dataTable = new System.Data.DataTable(typeof(T).Name);

                //Get all the properties by using reflection
                PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo prop in Props)
                {
                    //Setting column names as Property names
                    dataTable.Columns.Add(prop.Name);
                }
                foreach (T item in items)
                {
                    var values = new object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {

                        values[i] = Props[i].GetValue(item, null);
                    }
                    dataTable.Rows.Add(values);
                }

                return dataTable;
            }
        }
        public class ListtoDataTable1
        {
            public List<System.Data.DataTable> ToDataTable<T>(List<T> items)
            {
                System.Data.DataTable dataTable = new System.Data.DataTable(typeof(T).Name);
                List<System.Data.DataTable> dataTable1 = new List<DataTable>();
                //Get all the properties by using reflection
                PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo prop in Props)
                {
                    //Setting column names as Property names
                    dataTable.Columns.Add(prop.Name);
                }
                foreach (T item in items)
                {
                    var values = new object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {

                        values[i] = Props[i].GetValue(item, null);
                    }
                    dataTable.Rows.Add(values);
                }
                dataTable1.Add(dataTable);
                return dataTable1;
            }
        }

    }
}
