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
        public Food(int id, int categoryID, string name, string price)
        {
            this.ID = id;
            this.Name = name;
            this.CategoryID = categoryID;
            this.Price = price;
        }

        public Food(DataRow rows)
        {
            this.Price = (Convert.ToDouble(rows["price"])).ToString("#,0#");
            this.ID = (int)rows["id"];
            this.Name = rows["name"].ToString();
            this.CategoryID = (int)rows["idcategory"];
        }

        private int iD;
        private string name;
        private int categoryID;
        private string price;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }

        public string Price { get => price; set => price = value; }

    }
}
