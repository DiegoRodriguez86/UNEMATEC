using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNEMATEC.Models.ViewModels
{
    public class mHistorialPagos
    {
        public List<transaccion> transactions { get; set; }
    }

    public class transaccion
    {
        public string id { get; set; }
        public string status { get; set; }
        public string payer_email { get; set; }
        public nombre payer_name { get; set; }
        public amount_wb amount_with_breakdown { get; set; }
        public string time { get; set; }

    }

    public class nombre
    {
        public string given_name { get; set; }
        public string surname { get; set; }
    }

    public class amount_wb
    {
        public grooss_a gross_amount { get; set; }
        public fee fee_amount { get; set; }
        public net net_amount { get; set; }
    }

    public class grooss_a
    {
        public string currency_code { get; set; }
        public string vcalue { get; set; }
    }

    public class fee
    {
        public string currency_code { get; set; }
        public string value { get; set; }
    }

    public class net
    {
        public string currency_code { get; set; }
        public string value { get; set; }
    }
}