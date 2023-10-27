using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Menu = QuanLyQuanCafe.DTO.Menu;

namespace QuanLyQuanCafe
{
    public partial class Ftablemanagement : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; } set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        public Ftablemanagement(Account acc)
        {
            InitializeComponent();
            
            LoadTable();

            this.LoginAccount = acc;

            LoadCategory();

            LoadComboboxTable(cbSwitchTable);
        }
        #region Method
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();

            cbCategory.DataSource = listCategory; //load list

            cbCategory.DisplayMember = "Name"; //Hiển thị trường Name
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodCategoryID(id);

            cbFood.DataSource = listFood;

            cbFood.DisplayMember = "Name";
        }

        void LoadTable()
        {
            flpTable.Controls.Clear();

            List<Table> tableList = TableDAO.Instance.LoadTableList(); //Lấy danh sách table

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight};
                btn.Text = item.Name + Environment.NewLine + item.Status1; //Hiển thị chữ
                btn.Click += Btn_Click;
                btn.Tag = item; //lưu trữ dữ liệu item
          
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

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Menu item in listBillInfo) 
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString("#,0#"));
                lsvItem.SubItems.Add(item.TotalPrice.ToString("#,0#"));
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem); //add item vào trong bill
            }
            CultureInfo culture = new CultureInfo("vi-VN"); //Quy đổi thành tiền vnd
            txbTotalPrice.Text = totalPrice.ToString("c", culture); //format thành đồng  
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }
        #endregion

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ") ";
        }

        #region Unused
        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        #endregion
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Faccountprofile f = new Faccountprofile(LoginAccount);

            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }

        void f_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";  
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fadmin f = new Fadmin();
            f.loginAccount = loginAccount;
            f.InsertFood += F_InsertFood;
            f.DeleteFood += F_DeleteFood;
            f.UpdateFood += F_UpdateFood;
            f.ShowDialog();
        }

        private void F_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void F_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
            LoadTable();    
        }
        private void F_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if(lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if (txbTotalPrice.Text == "") //Kiểm tra chọn bàn chưa
            {
                MessageBox.Show("Vui lòng chọn bàn rồi mới chọn món");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, 1);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, 1);
            }

            ShowBill(table.ID);

            LoadTable();
        }

        private void btnCheckOut_Click(object sender, EventArgs e) //hỏi là muốn thanh toán hay không
        {
            Table table = lsvBill.Tag as Table;

            if (txbTotalPrice.Text == "") //Kiểm tra có chọn bàn chưa
            {
                MessageBox.Show("Vui lòng chọn bàn và món ăn rồi thanh toán");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmDisCount.Value;

            Double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0].Replace(".", "")); //lấy mấy số đầu tiên sau dấy phẩy
            Double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            if (lsvBill.Items.Count == 0) // Kiểm tra xem trên listbox có thứ gì không
            {
                MessageBox.Show("Bạn chưa có chọn món ăn");
                return;
            }

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn muốn thanh toán cho bàn {0}?\n => Tổng giá tiền: {1}", table.Name, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) //Nếu nhấn ok, thực hiện điều dưới
                {
                    BillDAO.Instance.Checkout(idBill, discount, (float)finalTotalPrice);
                    ShowBill(table.ID);

                    LoadTable(); //load để đổi từ trống sang có người và ngược lại 
                }
            }
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).ID;

            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(id2);

            if (id1 == id2)
            {
                MessageBox.Show("Không thể chuyển bàn sang bàn của chính mình");
                return;
            }

            if (idBill != -1)
            {
                MessageBox.Show("Bàn đã có người, vui lòng chọn bàn khác");
                return;
            }

            if (MessageBox.Show(string.Format("Bạn có muốn chuyển bàn {0} qua bàn {1}?", (lsvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);
                LoadTable();
            }
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCheckOut_Click(this, new EventArgs());
        }

        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddFood_Click(this, new EventArgs());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (txbTotalPrice.Text == "") //Kiểm tra chọn bàn chưa
            {
                MessageBox.Show("Vui lòng chọn bàn rồi mới chọn món");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            if (lsvBill.Items.Count == 0) // Kiểm tra xem trên listbox có thứ gì không
            {
                MessageBox.Show("Bạn chưa có chọn món ăn");
                return;
            }

            if (idBill == -1)
            {
                MessageBox.Show("Không tồn tại món đó");
                return;
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, -1);
            }

            ShowBill(table.ID);

            LoadTable();
        }
    }
}
