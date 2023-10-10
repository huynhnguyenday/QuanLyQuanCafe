using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Table
    {
        public Table(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        public Table(DataRow row) //Chuyển từng row thành list
        {
            this.ID = (int)row["ID"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }
        private string Status;
        private string name;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Status1 { get => Status; set => Status = value; }
    }
}
