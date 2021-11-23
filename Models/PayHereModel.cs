using System;

namespace PayHere_ASP_NET_Core.Models
{
    public class PayHereModel
    {
        public string merchant_id { get; set; }
        public string order_id { get; set; }
        public string payment_id { get; set; }
        public string payhere_amount { get; set; }
        public string payhere_currency { get; set; }
        public string status_code { get; set; }
        public string md5sig { get; set; }
        public string custom_1 { get; set; }
        public string custom_2 { get; set; }
        public string status_message { get; set; }
        public string method { get; set; }
        public string card_holder_name { get; set; }
        public string card_no { get; set; }
        public string card_expiry { get; set; }

    }
}
