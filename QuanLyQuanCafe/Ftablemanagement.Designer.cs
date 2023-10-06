namespace QuanLyQuanCafe
{
    partial class Ftablemanagement
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnDisCount = new System.Windows.Forms.Button();
            this.nmDisCount = new System.Windows.Forms.NumericUpDown();
            this.cbSwtichTable = new System.Windows.Forms.ComboBox();
            this.btnSwtichTable = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDisCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1130, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.toolStripMenuItem2});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem2.Text = "Đăng Xuất";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(592, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 326);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSwtichTable);
            this.panel3.Controls.Add(this.cbSwtichTable);
            this.panel3.Controls.Add(this.nmDisCount);
            this.panel3.Controls.Add(this.btnDisCount);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Location = new System.Drawing.Point(592, 482);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 111);
            this.panel3.TabIndex = 4;
            // 
            // lsvBill
            // 
            this.lsvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(0, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(526, 326);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmFoodCount);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(592, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(526, 103);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 21);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(284, 24);
            this.cbCategory.TabIndex = 0;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(3, 65);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(287, 24);
            this.cbFood.TabIndex = 1;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.cbFood_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(405, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 100);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm Món";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(305, 42);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(94, 22);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmFoodCount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(12, 34);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(574, 559);
            this.flpTable.TabIndex = 6;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(405, 13);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(118, 84);
            this.btnCheckOut.TabIndex = 0;
            this.btnCheckOut.Text = "Thanh Toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnDisCount
            // 
            this.btnDisCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisCount.Location = new System.Drawing.Point(234, 43);
            this.btnDisCount.Name = "btnDisCount";
            this.btnDisCount.Size = new System.Drawing.Size(150, 54);
            this.btnDisCount.TabIndex = 1;
            this.btnDisCount.Text = "Giảm giá";
            this.btnDisCount.UseVisualStyleBackColor = true;
            // 
            // nmDisCount
            // 
            this.nmDisCount.Location = new System.Drawing.Point(234, 14);
            this.nmDisCount.Name = "nmDisCount";
            this.nmDisCount.Size = new System.Drawing.Size(150, 22);
            this.nmDisCount.TabIndex = 4;
            this.nmDisCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmDisCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmDisCount.ValueChanged += new System.EventHandler(this.nmDisCount_ValueChanged);
            // 
            // cbSwtichTable
            // 
            this.cbSwtichTable.FormattingEnabled = true;
            this.cbSwtichTable.Location = new System.Drawing.Point(3, 14);
            this.cbSwtichTable.Name = "cbSwtichTable";
            this.cbSwtichTable.Size = new System.Drawing.Size(211, 24);
            this.cbSwtichTable.TabIndex = 4;
            // 
            // btnSwtichTable
            // 
            this.btnSwtichTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwtichTable.Location = new System.Drawing.Point(3, 43);
            this.btnSwtichTable.Name = "btnSwtichTable";
            this.btnSwtichTable.Size = new System.Drawing.Size(211, 54);
            this.btnSwtichTable.TabIndex = 5;
            this.btnSwtichTable.Text = "Chuyển Bàn";
            this.btnSwtichTable.UseVisualStyleBackColor = true;
            // 
            // Ftablemanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 600);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ftablemanagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán Cafe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDisCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnDisCount;
        private System.Windows.Forms.NumericUpDown nmDisCount;
        private System.Windows.Forms.Button btnSwtichTable;
        private System.Windows.Forms.ComboBox cbSwtichTable;
    }
}