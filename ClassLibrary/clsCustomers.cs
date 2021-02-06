using System;

namespace ClassLibrary
{
    public class clsCustomers
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public bool LivesInUK { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CustomerEmail { get; set; }
        public string Password { get; set; }
        public string CustomerAddress { get; set; }
    }
}