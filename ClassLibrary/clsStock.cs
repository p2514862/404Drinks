using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public int ProductID { get; set; }
        public string DrinkType { get; set; }
        public int Quantity { get; set; }
        public Decimal Price { get; set; }
        public DateTime DateRecieved { get; set; }
        public bool Availability { get; set; }
    }
}