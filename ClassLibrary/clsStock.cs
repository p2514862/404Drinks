using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public int StockNo { get; set; }
        public string DrinkType { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTime DateRecieved { get; set; }
        public bool Availability { get; set; }
    }
}