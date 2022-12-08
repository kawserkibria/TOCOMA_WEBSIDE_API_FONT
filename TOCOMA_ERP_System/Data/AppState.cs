﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_ERP_ClassLibrary.Models;

namespace TOCOMA_ERP_System.Data
{
    public class AppState
    {
        public static List<PlanandOperationViewModel> GetPlanList { get; set; }
        public static PurchaseOrderViewModel porder { get; set; }
        public static List<PurchaseOrderDetailsEntity> porderDetails { get; set; }
        public static List<PurchaseOrderViewModel> purchaseOrderList { get; set; }
        public static SalesOrderViewModel salesOrderView { get; set; }
        public static List<SalesItemDetailsModel> salesItemDetails { get; set; }
        
        public static List<PurchaseTermsConditionsModel> SalestermsConditionList { get; set; }
        public static SalesQuotationView salesQuotation { get; set; }
        public static List<SalesQuotationItemView> salesQuotationitemList { get; set; }
        public static List<PurchaseTermsConditionsModel> termsConditionList { get; set; }
        public static List<PackagingInstructionModel> packagingList { get; set; }
    }
}
