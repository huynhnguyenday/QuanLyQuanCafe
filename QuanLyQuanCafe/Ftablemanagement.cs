using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class Ftablemanagement : Form
    {
        public Ftablemanagement()
        {
            InitializeComponent();

            LoadTable();
        }
        #region Method

        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList(); //Lấy danh sách table

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight};
                btn.Text = item.Name + Environment.NewLine + item.Status1; //Hiển thị chữ

                switch (item.Status1)
                {
                    case "Trống":
                        btn.BackColor = Color.Silver;
                        break;
                    default:
                        btn.BackColor = Color.Orange;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }
        #endregion

        #region Events
        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nmDisCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Faccountprofile f = new Faccountprofile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fadmin f = new Fadmin();
            f.ShowDialog();
        }
        #endregion
    }
}
