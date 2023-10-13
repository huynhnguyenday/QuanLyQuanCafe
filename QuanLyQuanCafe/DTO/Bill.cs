﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckin, DateTime? dateCheckout, int status)
        {
            this.ID = id;
            this.DateCheckin = dateCheckin;
            this.DateCheckout = dateCheckout;
            this.Status = status;
        }

        public Bill(DataRow row) //hiện thành row ở bảng
        {
            this.ID = (int)row["id"];
            this.DateCheckin = (DateTime?)row["dateCheckin"];
            this.DateCheckout = (DateTime?)row["dateCheckout"];
            this.Status = (int)row["status"];
        }

        private int status;

        private DateTime? dateCheckout;

        private DateTime? dateCheckin; //? -> có thể NULL

        private int iD;

        public int ID { get => iD; set => iD = value; }

        public int Status { get => status; set => status = value; }
        public DateTime? DateCheckout { get => dateCheckout; set => dateCheckout = value; }
        public DateTime? DateCheckin { get => dateCheckin; set => dateCheckin = value; }
    }
}