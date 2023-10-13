using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int billID, int foodID, int count)
        {
            this.iD = id;
            this.billID = billID;
            this.foodID = foodID;
            this.count = count;
        }

        public BillInfo(DataRow rows)
        {
            this.iD = (int)rows["id"];
            this.billID = (int)rows["idBill"];
            this.foodID = (int)rows["idFood"];
            this.count = (int)rows["count"];
        }

        private int billID;
        private int foodID;
        private int count;
        private int iD;

        public int BillID { get => billID; set => billID = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public int Count { get => count; set => count = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
