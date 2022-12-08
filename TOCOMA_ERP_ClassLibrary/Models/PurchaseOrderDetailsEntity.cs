﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class PurchaseOrderDetailsEntity
    {
        public int PO_DETAILS_ID { get; set; }
        public int PO_ID { get; set; }
        public string PO_NUMBER_LONG_CODE { get; set; }
        public int ITEM_ID { get; set; }
        public string ITEM_NAME { get; set; }
        public string UOM { get; set; }
        public int UNIT_ID { get; set; }
        public double QUANTITY { get; set; }
        public double UNIT_PRICE { get; set; }
        public double UNIT_TOTAL { get; set; }
        public double AIT { get; set; }
        public double VAT { get; set; }
        public double ADJ_RETURN_DISCOUNT { get; set; }
        public string PACK_SIZE { get; set; }
        public string INWORDS { get; set; }
        public string TOTAL_AMOUNT { get; set; }
    }
}
