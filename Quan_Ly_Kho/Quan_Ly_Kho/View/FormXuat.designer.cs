namespace Quan_Ly_Kho.View
{
    partial class FormXuat
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
            this.textBoxMaPX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewPhieuXuat = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonCT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeNX = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 109);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xuat Kho";
            // 
            // textBoxMaPX
            // 
            this.textBoxMaPX.Location = new System.Drawing.Point(190, 129);
            this.textBoxMaPX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMaPX.Multiline = true;
            this.textBoxMaPX.Name = "textBoxMaPX";
            this.textBoxMaPX.Size = new System.Drawing.Size(149, 35);
            this.textBoxMaPX.TabIndex = 2;
            this.textBoxMaPX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ma PX";
            // 
            // listViewPhieuXuat
            // 
            this.listViewPhieuXuat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewPhieuXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPhieuXuat.HideSelection = false;
            this.listViewPhieuXuat.Location = new System.Drawing.Point(5, 294);
            this.listViewPhieuXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewPhieuXuat.Name = "listViewPhieuXuat";
            this.listViewPhieuXuat.Size = new System.Drawing.Size(867, 443);
            this.listViewPhieuXuat.TabIndex = 3;
            this.listViewPhieuXuat.UseCompatibleStateImageBehavior = false;
            this.listViewPhieuXuat.View = System.Windows.Forms.View.Details;
            this.listViewPhieuXuat.SelectedIndexChanged += new System.EventHandler(this.listViewPhieuXuat_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ma Phieu Xuat";
            this.columnHeader1.Width = 248;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngay Xuat";
            this.columnHeader2.Width = 285;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tong Tien";
            this.columnHeader3.Width = 328;
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(461, 215);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(141, 43);
            this.buttonThem.TabIndex = 4;
            this.buttonThem.Text = "Them";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(182, 758);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(102, 43);
            this.buttonSua.TabIndex = 4;
            this.buttonSua.Text = "Sua";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(395, 758);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(102, 43);
            this.buttonXoa.TabIndex = 4;
            this.buttonXoa.Text = "Xoa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonCT
            // 
            this.buttonCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCT.Location = new System.Drawing.Point(583, 758);
            this.buttonCT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCT.Name = "buttonCT";
            this.buttonCT.Size = new System.Drawing.Size(102, 43);
            this.buttonCT.TabIndex = 4;
            this.buttonCT.Text = "Chi Tiet";
            this.buttonCT.UseVisualStyleBackColor = false;
            this.buttonCT.Click += new System.EventHandler(this.buttonCT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngay Xuat";
            // 
            // dateTimeNX
            // 
            this.dateTimeNX.CustomFormat = "yyyy/MM/dd";
            this.dateTimeNX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNX.Location = new System.Drawing.Point(190, 215);
            this.dateTimeNX.Name = "dateTimeNX";
            this.dateTimeNX.Size = new System.Drawing.Size(149, 27);
            this.dateTimeNX.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tong Tien";
            // 
            // textBoxTT
            // 
            this.textBoxTT.Location = new System.Drawing.Point(598, 129);
            this.textBoxTT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTT.Multiline = true;
            this.textBoxTT.Name = "textBoxTT";
            this.textBoxTT.Size = new System.Drawing.Size(149, 35);
            this.textBoxTT.TabIndex = 2;
            this.textBoxTT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(668, 215);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Chi Tiet Xuat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(872, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimeNX);
            this.Controls.Add(this.buttonCT);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.listViewPhieuXuat);
            this.Controls.Add(this.textBoxTT);
            this.Controls.Add(this.textBoxMaPX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormXuat";
            this.Text = "FormXuat";
            this.Load += new System.EventHandler(this.FormXuat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaPX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewPhieuXuat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonCT;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeNX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTT;
        private System.Windows.Forms.Button button1;
    }
}