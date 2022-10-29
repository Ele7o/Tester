namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.soThuNhat = new System.Windows.Forms.TextBox();
            this.soThuHai = new System.Windows.Forms.TextBox();
            this.ketQua = new System.Windows.Forms.TextBox();
            this.lastCal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCong
            // 
            this.btnCong.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCong.Location = new System.Drawing.Point(32, 166);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(149, 121);
            this.btnCong.TabIndex = 0;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTru.Location = new System.Drawing.Point(269, 166);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(149, 121);
            this.btnTru.TabIndex = 1;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNhan.Location = new System.Drawing.Point(506, 166);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(149, 121);
            this.btnNhan.TabIndex = 2;
            this.btnNhan.Text = "x";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChia.Location = new System.Drawing.Point(743, 166);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(149, 121);
            this.btnChia.TabIndex = 3;
            this.btnChia.Text = "÷";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // soThuNhat
            // 
            this.soThuNhat.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soThuNhat.Location = new System.Drawing.Point(32, 61);
            this.soThuNhat.Name = "soThuNhat";
            this.soThuNhat.PlaceholderText = "Nhap So Thu Nhat";
            this.soThuNhat.Size = new System.Drawing.Size(861, 31);
            this.soThuNhat.TabIndex = 4;
            // 
            // soThuHai
            // 
            this.soThuHai.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soThuHai.Location = new System.Drawing.Point(32, 104);
            this.soThuHai.Name = "soThuHai";
            this.soThuHai.PlaceholderText = "Nhap So Thu Hai";
            this.soThuHai.Size = new System.Drawing.Size(861, 31);
            this.soThuHai.TabIndex = 5;
            // 
            // ketQua
            // 
            this.ketQua.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ketQua.Location = new System.Drawing.Point(32, 336);
            this.ketQua.Name = "ketQua";
            this.ketQua.PlaceholderText = "Ket Qua";
            this.ketQua.Size = new System.Drawing.Size(861, 43);
            this.ketQua.TabIndex = 6;
            // 
            // lastCal
            // 
            this.lastCal.AutoSize = true;
            this.lastCal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastCal.Location = new System.Drawing.Point(32, 24);
            this.lastCal.Name = "lastCal";
            this.lastCal.Size = new System.Drawing.Size(0, 25);
            this.lastCal.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 449);
            this.Controls.Add(this.lastCal);
            this.Controls.Add(this.ketQua);
            this.Controls.Add(this.soThuHai);
            this.Controls.Add(this.soThuNhat);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Name = "Form1";
            this.Text = "PhepToan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private TextBox soThuNhat;
        private TextBox soThuHai;
        private TextBox ketQua;
        private Label lastCal;
    }
}