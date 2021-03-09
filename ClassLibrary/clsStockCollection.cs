using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStock AnStock = new clsStock();
                AnStock.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AnStock.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnStock.DrinkType = Convert.ToString(DB.DataTable.Rows[Index]["DrinkType"]);
                AnStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnStock.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AnStock.DateRecieved = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateRecieved"]);
                mStockList.Add(AnStock);
                Index++;
            }
          }
            
        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsStock ThisStock { get; set; }
    }

     
}