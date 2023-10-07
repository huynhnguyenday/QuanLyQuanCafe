using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class Fadmin : Form
    {
        public Fadmin()
        {
            InitializeComponent();

            LoadAccountList(); //Kết nối tới sql database
        }

        private void Fadmin_Load(object sender, EventArgs e)
        {
            
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tcBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void LoadFoodList()
        {
            string query = "select * from Food"; //chạy query trong sql

            dtgvFood.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        void LoadAccountList()
        {
            string query = " EXEC dbo.USP_GetAccountByUserName @UserName"; //chạy query trong sql

            dtgvAccount.DataSource = DataProvider.Instance.ExcuteQuery(query, new object[] {"admin"});
        }
    }
}
    