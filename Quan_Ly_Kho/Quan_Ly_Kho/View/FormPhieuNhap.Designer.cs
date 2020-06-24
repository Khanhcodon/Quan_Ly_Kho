namespace Quan_Ly_Kho.View.ManhQuan
{
    partial class FormPhieuNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewPhieuNhap = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btChiTietPN = new System.Windows.Forms.Button();
            this.XoaPN = new System.Windows.Forms.Button();
            this.SuaPN = new System.Windows.Forms.Button();
            this.ThemPN = new System.Windows.Forms.Button();
            this.dtNgayViet = new System.Windows.Forms.DateTimePicker();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 61);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(743, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu Nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewPhieuNhap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 253);
            this.panel2.TabIndex = 2;
            // 
            // listViewPhieuNhap
            // 
            this.listViewPhieuNhap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPhieuNhap.FullRowSelect = true;
            this.listViewPhieuNhap.GridLines = true;
            this.listViewPhieuNhap.HideSelection = false;
            this.listViewPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.listViewPhieuNhap.Name = "listViewPhieuNhap";
            this.listViewPhieuNhap.Size = new System.Drawing.Size(743, 253);
            this.listViewPhieuNhap.TabIndex = 0;
            this.listViewPhieuNhap.UseCompatibleStateImageBehavior = false;
            this.listViewPhieuNhap.View = System.Windows.Forms.View.Details;
            this.listViewPhieuNhap.SelectedIndexChanged += new System.EventHandler(this.listViewPhieuNhap_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phiếu nhập";
            this.columnHeader1.Width = 245;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày viết phiếu";
            this.columnHeader2.Width = 249;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thành Tiền";
            this.columnHeader3.Width = 238;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 314);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(743, 277);
            this.panel3.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btChiTietPN);
            this.splitContainer1.Panel1.Controls.Add(this.XoaPN);
            this.splitContainer1.Panel1.Controls.Add(this.SuaPN);
            this.splitContainer1.Panel1.Controls.Add(this.ThemPN);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtNgayViet);
            this.splitContainer1.Panel2.Controls.Add(this.lbThanhTien);
            this.splitContainer1.Panel2.Controls.Add(this.txtMaPN);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(743, 277);
            this.splitContainer1.SplitterDistance = 82;
            this.splitContainer1.TabIndex = 0;
            // 
            // btChiTietPN
            // 
            this.btChiTietPN.Location = new System.Drawing.Point(474, 21);
            this.btChiTietPN.Name = "btChiTietPN";
            this.btChiTietPN.Size = new System.Drawing.Size(150, 35);
            this.btChiTietPN.TabIndex = 3;
            this.btChiTietPN.Text = "Cập nhập";
            this.btChiTietPN.UseVisualStyleBackColor = true;
            this.btChiTietPN.Click += new System.EventHandler(this.btChiTietPN_Click);
            // 
            // XoaPN
            // 
            this.XoaPN.Location = new System.Drawing.Point(330, 21);
            this.XoaPN.Name = "XoaPN";
            this.XoaPN.Size = new System.Drawing.Size(110, 35);
            this.XoaPN.TabIndex = 2;
            this.XoaPN.Text = "Xóa";
            this.XoaPN.UseVisualStyleBackColor = true;
            this.XoaPN.Click += new System.EventHandler(this.XoaPN_Click);
            // 
            // SuaPN
            // 
            this.SuaPN.Location = new System.Drawing.Point(184, 21);
            this.SuaPN.Name = "SuaPN";
            this.SuaPN.Size = new System.Drawing.Size(110, 35);
            this.SuaPN.TabIndex = 1;
            this.SuaPN.Text = "Sửa";
            this.SuaPN.UseVisualStyleBackColor = true;
            this.SuaPN.Click += new System.EventHandler(this.SuaPN_Click);
            // 
            // ThemPN
            // 
            this.ThemPN.Location = new System.Drawing.Point(39, 21);
            this.ThemPN.Name = "ThemPN";
            this.ThemPN.Size = new System.Drawing.Size(110, 35);
            this.ThemPN.TabIndex = 0;
            this.ThemPN.Text = "Thêm";
            this.ThemPN.UseVisualStyleBackColor = true;
            this.ThemPN.Click += new System.EventHandler(this.ThemPN_Click);
            // 
            // dtNgayViet
            // 
            this.dtNgayViet.CustomFormat = "yyyy/MM/dd";
            this.dtNgayViet.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayViet.Location = new System.Drawing.Point(146, 106);
            this.dtNgayViet.Name = "dtNgayViet";
            this.dtNgayViet.Size = new System.Drawing.Size(200, 36);
            this.dtNgayViet.TabIndex = 5;
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Location = new System.Drawing.Point(549, 32);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(132, 29);
            this.lbThanhTien.TabIndex = 4;
            this.lbThanhTien.Text = ".................";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(146, 29);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(201, 36);
            this.txtMaPN.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thành tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày viết:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã PN:";
            // 
            // FormPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 591);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormPhieuNhap";
            this.Text = "FormPhieuNhap";
            this.Load += new System.EventHandler(this.FormPhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listViewPhieuNhap;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btChiTietPN;
        private System.Windows.Forms.Button XoaPN;
        private System.Windows.Forms.Button SuaPN;
        private System.Windows.Forms.Button ThemPN;
        private System.Windows.Forms.DateTimePicker dtNgayViet;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}