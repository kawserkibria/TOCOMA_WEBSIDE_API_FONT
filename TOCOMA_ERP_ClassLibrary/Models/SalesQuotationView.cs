using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class SalesQuotationView
    {
        public int SALES_QUOTATION_ID { get; set; }
        public string QUOTATION_NO { get; set; }
        public string QUOTATION_DATE { get; set; }
        public string QUOTATION_TYPE { get; set; }
        public string TYPE { get; set; }
        public string VALID_UP_TO_DATE { get; set; }
        public string INCOTERM { get; set; }
        public string SHIP_VIA { get; set; }
        public string SALES_PERSON { get; set; }
        public string PHONE_NO { get; set; }
        public string PAYMENT_TERMS { get; set; }
        public string EXPECTED_DELIVERY_DATE { get; set; }
        public string TERMS_AND_CONDITION { get; set; }
        public string INQUERY_DATE { get; set; }
        public int CUSTOMER_ID { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string CUSTOMER_NAME_SHORT_FORM { get; set; }
        public double SALES_TOTAL { get; set; }
        public string REG_BY { get; set; }
        public string STATUS { get; set; }
        public int SL { get; set; }

        public string CORPORATE_ADDRESS { get; set; }
        public string ITEM_NAME { get; set; }
        public string SHIPPING_ADDRESS { get; set; }
        public string CONTACT_PERSON_NAME { get; set; }
        public string CONTACT_PERSON_PHONE { get; set; }
        public string CONTACT_PERSON_EMAIL { get; set; }
    }
}
