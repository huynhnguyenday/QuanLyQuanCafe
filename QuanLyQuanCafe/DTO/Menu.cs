using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Menu
    {
        public Menu(string foodName, int count, float price, float totalPrice = 0)
        {
            this.foodName = foodName;
            this.count = count;
            this.price = price;
            this.TotalPrice = totalPrice;
        }

        public Menu(DataRow rows) //hiển thị ra cột
        {
            this.foodName =(string)rows["name"];
            this.count = (int)rows["count"];
            this.price = (float)Convert.ToDouble(rows["price"].ToString()); //do sql không chịu đổi sang dạng float ????
            this.TotalPrice = (float)Convert.ToDouble(rows["totalPrice"].ToString());
        }

        private string foodName;
        private int count;
        private float price;
        private float totalPrice;

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
