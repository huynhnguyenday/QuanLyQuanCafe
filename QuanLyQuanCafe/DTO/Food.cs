using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Food
    {
        public Food(int id, int categoryID, string name, float price)
        {
            this.ID = id;
            this.Name = name;
            this.CategoryID = categoryID;
            this.Price = price;
        }

        public Food(DataRow rows)
        {
            this.ID = (int)rows["id"];
            this.Name = rows["name"].ToString();
            this.CategoryID = (int)rows["idcategory"];
            this.Price = (float)Convert.ToDouble(rows["price"].ToString());
        }

        private int iD;
        private string name;
        private int categoryID;
        private float price;

        public int ID { get => iD; set => iD = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public float Price { get => price; set => price = value; }
        public string Name { get => name; set => name = value; }
    }
}
