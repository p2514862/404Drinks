using System.Collections.Generic;
using System;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsOrderCollection
    {

        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();

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
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }
    

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

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@ProductID", mThisOrder.ProductID);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@Over18", mThisOrder.Over18);
            DB.AddParameter("@ShippingCompany", mThisOrder.ShippingCompany);
            DB.AddParameter("@DateOfPurchase", mThisOrder.DateOfPurchase);

            return DB.Execute("sproc_tblOrder_Insert");

        }
    }
    
}