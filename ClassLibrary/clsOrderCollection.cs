using System.Collections.Generic;
using System;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsOrderCollection
    {

        List<clsOrder> mOrderList = new List<clsOrder>();

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                //worry about this later////////////////
            }
        }
        public clsOrder ThisOrder { get; set; }

        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.DateOfPurchase = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfPurchase"]);
                AnOrder.ShippingCompany = Convert.ToString(DB.DataTable.Rows[Index]["ShippingCompany"]);
                AnOrder.Over18 = Convert.ToBoolean(DB.DataTable.Rows[Index]["Over18"]);
                AnOrder.TotalPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalPrice"]);
                mOrderList.Add(AnOrder);

                Index++;
            }
        }
    }
    
}