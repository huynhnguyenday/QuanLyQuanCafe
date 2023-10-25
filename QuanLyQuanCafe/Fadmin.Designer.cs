namespace QuanLyQuanCafe
{
    partial class Fadmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcBill = new System.Windows.Forms.TabControl();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtpkToDay = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDay = new System.Windows.Forms.DateTimePicker();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbSearchFoodName = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.panel20 = new System.Windows.Forms.Panel();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.panel21 = new System.Windows.Forms.Panel();
            this.nmUpDownType = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.tcBill.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel2.SuspendLayout();
            this.tpFood.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.tpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDownType)).BeginInit();
            this.panel22.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcBill
            // 
            this.tcBill.Controls.Add(this.tpBill);
            this.tcBill.Controls.Add(this.tpFood);
            this.tcBill.Controls.Add(this.tpAccount);
            this.tcBill.Location = new System.Drawing.Point(10, 10);
            this.tcBill.Margin = new System.Windows.Forms.Padding(2);
            this.tcBill.Name = "tcBill";
            this.tcBill.SelectedIndex = 0;
            this.tcBill.Size = new System.Drawing.Size(767, 436);
            this.tcBill.TabIndex = 0;
            this.tcBill.SelectedIndexChanged += new System.EventHandler(this.tcBill_SelectedIndexChanged);
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.flowLayoutPanel1);
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpBill.Location = new System.Drawing.Point(4, 22);
            this.tpBill.Margin = new System.Windows.Forms.Padding(2);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(2);
            this.tpBill.Size = new System.Drawing.Size(759, 410);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dtgvBill);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 55);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(743, 353);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(2, 2);
            this.dtgvBill.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(741, 350);
            this.dtgvBill.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnViewBill);
            this.panel2.Controls.Add(this.dtpkToDay);
            this.panel2.Controls.Add(this.dtpkFromDay);
            this.panel2.Location = new System.Drawing.Point(8, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 46);
            this.panel2.TabIndex = 2;
            // 
            // btnViewBill
            // 
            this.btnViewBill.BackColor = System.Drawing.Color.Transparent;
            this.btnViewBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBill.Location = new System.Drawing.Point(326, 2);
            this.btnViewBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(105, 41);
            this.btnViewBill.TabIndex = 2;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = false;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dtpkToDay
            // 
            this.dtpkToDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkToDay.Location = new System.Drawing.Point(480, 14);
            this.dtpkToDay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpkToDay.Name = "dtpkToDay";
            this.dtpkToDay.Size = new System.Drawing.Size(226, 20);
            this.dtpkToDay.TabIndex = 1;
            // 
            // dtpkFromDay
            // 
            this.dtpkFromDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFromDay.Location = new System.Drawing.Point(44, 14);
            this.dtpkFromDay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpkFromDay.Name = "dtpkFromDay";
            this.dtpkFromDay.Size = new System.Drawing.Size(226, 20);
            this.dtpkFromDay.TabIndex = 0;
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.panel5);
            this.tpFood.Controls.Add(this.panel4);
            this.tpFood.Controls.Add(this.panel3);
            this.tpFood.Controls.Add(this.panel1);
            this.tpFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpFood.Location = new System.Drawing.Point(4, 22);
            this.tpFood.Margin = new System.Windows.Forms.Padding(2);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(2);
            this.tpFood.Size = new System.Drawing.Size(759, 410);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Thức ăn";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbSearchFoodName);
            this.panel5.Controls.Add(this.btnSearchFood);
            this.panel5.Location = new System.Drawing.Point(441, 5);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(285, 81);
            this.panel5.TabIndex = 3;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // txbSearchFoodName
            // 
            this.txbSearchFoodName.Location = new System.Drawing.Point(7, 33);
            this.txbSearchFoodName.Margin = new System.Windows.Forms.Padding(2);
            this.txbSearchFoodName.Name = "txbSearchFoodName";
            this.txbSearchFoodName.Size = new System.Drawing.Size(193, 20);
            this.txbSearchFoodName.TabIndex = 5;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFood.Location = new System.Drawing.Point(200, 13);
            this.btnSearchFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(74, 54);
            this.btnSearchFood.TabIndex = 4;
            this.btnSearchFood.Text = "Tìm";
            this.btnSearchFood.UseVisualStyleBackColor = false;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(441, 91);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 317);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.nmFoodPrice);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Location = new System.Drawing.Point(4, 149);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(270, 44);
            this.panel9.TabIndex = 3;
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(100, 11);
            this.nmFoodPrice.Margin = new System.Windows.Forms.Padding(2);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(168, 20);
            this.nmFoodPrice.TabIndex = 1;
            this.nmFoodPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbFoodCategory);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(4, 100);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(270, 44);
            this.panel8.TabIndex = 3;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(100, 14);
            this.cbFoodCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(169, 21);
            this.cbFoodCategory.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbFoodName);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(2, 51);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 44);
            this.panel7.TabIndex = 2;
            // 
            // txbFoodName
            // 
            this.txbFoodName.Location = new System.Drawing.Point(101, 11);
            this.txbFoodName.Margin = new System.Windows.Forms.Padding(2);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(168, 20);
            this.txbFoodName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbFoodID);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(2, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 44);
            this.panel6.TabIndex = 1;
            // 
            // txbFoodID
            // 
            this.txbFoodID.Location = new System.Drawing.Point(101, 11);
            this.txbFoodID.Margin = new System.Windows.Forms.Padding(2);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.ReadOnly = true;
            this.txbFoodID.Size = new System.Drawing.Size(168, 20);
            this.txbFoodID.TabIndex = 1;
            this.txbFoodID.TextChanged += new System.EventHandler(this.txbFoodID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEditFood);
            this.panel3.Controls.Add(this.btnDeleteFood);
            this.panel3.Controls.Add(this.btnAddFood);
            this.panel3.Location = new System.Drawing.Point(4, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 81);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnEditFood
            // 
            this.btnEditFood.BackColor = System.Drawing.Color.Transparent;
            this.btnEditFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFood.Location = new System.Drawing.Point(293, 13);
            this.btnEditFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(115, 54);
            this.btnEditFood.TabIndex = 2;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = false;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFood.Location = new System.Drawing.Point(153, 13);
            this.btnDeleteFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(122, 54);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = false;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(7, 13);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(125, 54);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvFood);
            this.panel1.Location = new System.Drawing.Point(4, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 317);
            this.panel1.TabIndex = 0;
            // 
            // dtgvFood
            // 
            this.dtgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(2, 2);
            this.dtgvFood.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.RowTemplate.Height = 24;
            this.dtgvFood.Size = new System.Drawing.Size(420, 312);
            this.dtgvFood.TabIndex = 0;
            this.dtgvFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFood_CellContentClick);
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.dtgvAccount);
            this.tpAccount.Controls.Add(this.panel20);
            this.tpAccount.Controls.Add(this.panel24);
            this.tpAccount.Location = new System.Drawing.Point(4, 22);
            this.tpAccount.Margin = new System.Windows.Forms.Padding(2);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(2);
            this.tpAccount.Size = new System.Drawing.Size(759, 410);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(8, 91);
            this.dtgvAccount.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.RowTemplate.Height = 24;
            this.dtgvAccount.Size = new System.Drawing.Size(434, 314);
            this.dtgvAccount.TabIndex = 11;
            this.dtgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAccount_CellContentClick);
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.btnResetPassword);
            this.panel20.Controls.Add(this.panel21);
            this.panel20.Controls.Add(this.panel22);
            this.panel20.Controls.Add(this.panel23);
            this.panel20.Location = new System.Drawing.Point(458, 91);
            this.panel20.Margin = new System.Windows.Forms.Padding(2);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(284, 314);
            this.panel20.TabIndex = 10;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.Location = new System.Drawing.Point(148, 149);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(124, 62);
            this.btnResetPassword.TabIndex = 4;
            this.btnResetPassword.Text = "Đặt lại mật khẩu";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.nmUpDownType);
            this.panel21.Controls.Add(this.label10);
            this.panel21.Location = new System.Drawing.Point(4, 100);
            this.panel21.Margin = new System.Windows.Forms.Padding(2);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(270, 44);
            this.panel21.TabIndex = 3;
            // 
            // nmUpDownType
            // 
            this.nmUpDownType.Location = new System.Drawing.Point(110, 10);
            this.nmUpDownType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmUpDownType.Name = "nmUpDownType";
            this.nmUpDownType.Size = new System.Drawing.Size(120, 20);
            this.nmUpDownType.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Loại tài khoản:";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.txbDisplayName);
            this.panel22.Controls.Add(this.label11);
            this.panel22.Location = new System.Drawing.Point(2, 51);
            this.panel22.Margin = new System.Windows.Forms.Padding(2);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(270, 44);
            this.panel22.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(101, 11);
            this.txbDisplayName.Margin = new System.Windows.Forms.Padding(2);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(168, 20);
            this.txbDisplayName.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên hiển thị:";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.txbUserName);
            this.panel23.Controls.Add(this.label12);
            this.panel23.Location = new System.Drawing.Point(2, 2);
            this.panel23.Margin = new System.Windows.Forms.Padding(2);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(270, 44);
            this.panel23.TabIndex = 1;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(101, 11);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(168, 20);
            this.txbUserName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên tài khoản:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.btnEditAccount);
            this.panel24.Controls.Add(this.btnDeleteAccount);
            this.panel24.Controls.Add(this.btnAddAccount);
            this.panel24.Location = new System.Drawing.Point(4, 5);
            this.panel24.Margin = new System.Windows.Forms.Padding(2);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(438, 81);
            this.panel24.TabIndex = 9;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnEditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAccount.Location = new System.Drawing.Point(298, 13);
            this.btnEditAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(124, 54);
            this.btnEditAccount.TabIndex = 2;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = false;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(154, 13);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(125, 54);
            this.btnDeleteAccount.TabIndex = 1;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.Location = new System.Drawing.Point(7, 13);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(130, 54);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // Fadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 458);
            this.Controls.Add(this.tcBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Fadmin_Load);
            this.tcBill.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tpFood.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.tpAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.panel20.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDownType)).EndInit();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcBill;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.DateTimePicker dtpkToDay;
        private System.Windows.Forms.DateTimePicker dtpkFromDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.TextBox txbSearchFoodName;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbFoodID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.NumericUpDown nmUpDownType;
    }
}