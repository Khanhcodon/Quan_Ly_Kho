namespace Quan_Ly_Kho.Controller
{
    partial class DangNhap
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
            this.pBDangKy = new System.Windows.Forms.PictureBox();
            this.pBDangNhap = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Quan_Ly_Kho.Properties.Resources.Đăng_Nhập;
            this.panel1.Controls.Add(this.pBDangKy);
            this.panel1.Controls.Add(this.pBDangNhap);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 297);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pBDangKy
            // 
            this.pBDangKy.Image = global::Quan_Ly_Kho.Properties.Resources.bt_Đăng_ký;
            this.pBDangKy.Location = new System.Drawing.Point(314, 230);
            this.pBDangKy.Name = "pBDangKy";
            this.pBDangKy.Size = new System.Drawing.Size(109, 32);
            this.pBDangKy.TabIndex = 3;
            this.pBDangKy.TabStop = false;
            this.pBDangKy.Click += new System.EventHandler(this.pBDangKy_Click);
            // 
            // pBDangNhap
            // 
            this.pBDangNhap.Image = global::Quan_Ly_Kho.Properties.Resources.bt_Đăng_nhập;
            this.pBDangNhap.Location = new System.Drawing.Point(114, 230);
            this.pBDangNhap.Name = "pBDangNhap";
            this.pBDangNhap.Size = new System.Drawing.Size(109, 32);
            this.pBDangNhap.TabIndex = 2;
            this.pBDangNhap.TabStop = false;
            this.pBDangNhap.Click += new System.EventHandler(this.pBDangNhap_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(178, 165);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(281, 35);
            this.txtPass.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(178, 105);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(281, 35);
            this.txtID.TabIndex = 0;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 297);
            this.Controls.Add(this.panel1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDangNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBDangNhap;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox pBDangKy;
    }
}