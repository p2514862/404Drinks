using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool isOver18OK { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public int TotalPriceOK { get; set; }
        public string ShippingCompany { get; set; }
        public int OrderIDOK { get; set; }
    }
}