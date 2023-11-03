
namespace _21110701
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_MaThuoc = new System.Windows.Forms.TextBox();
            this.txt_TenThuoc = new System.Windows.Forms.TextBox();
            this.txt_NhaSanXuat = new System.Windows.Forms.TextBox();
            this.txt_HSD = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.time_SanXuat = new System.Windows.Forms.DateTimePicker();
            this.MATHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHASX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HANSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thuốc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên thuốc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhà sản xuất:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sản suất:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hạn sử dụng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn giá:";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(60, 216);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(218, 216);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(354, 216);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 9;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(499, 216);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATHUOC,
            this.TENTHUOC,
            this.NHASX,
            this.NGAYSX,
            this.HANSD,
            this.SOLUONG,
            this.DONGIA,
            this.THANHTIEN});
            this.dataGridView1.Location = new System.Drawing.Point(25, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 206);
            this.dataGridView1.TabIndex = 11;
            // 
            // txt_MaThuoc
            // 
            this.txt_MaThuoc.Location = new System.Drawing.Point(133, 20);
            this.txt_MaThuoc.Name = "txt_MaThuoc";
            this.txt_MaThuoc.Size = new System.Drawing.Size(100, 22);
            this.txt_MaThuoc.TabIndex = 12;
            // 
            // txt_TenThuoc
            // 
            this.txt_TenThuoc.Location = new System.Drawing.Point(133, 68);
            this.txt_TenThuoc.Name = "txt_TenThuoc";
            this.txt_TenThuoc.Size = new System.Drawing.Size(100, 22);
            this.txt_TenThuoc.TabIndex = 13;
            // 
            // txt_NhaSanXuat
            // 
            this.txt_NhaSanXuat.Location = new System.Drawing.Point(133, 116);
            this.txt_NhaSanXuat.Name = "txt_NhaSanXuat";
            this.txt_NhaSanXuat.Size = new System.Drawing.Size(100, 22);
            this.txt_NhaSanXuat.TabIndex = 14;
            // 
            // txt_HSD
            // 
            this.txt_HSD.Location = new System.Drawing.Point(474, 20);
            this.txt_HSD.Name = "txt_HSD";
            this.txt_HSD.Size = new System.Drawing.Size(100, 22);
            this.txt_HSD.TabIndex = 15;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(474, 78);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(100, 22);
            this.txt_SoLuong.TabIndex = 16;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(474, 135);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(100, 22);
            this.txt_DonGia.TabIndex = 17;
            // 
            // time_SanXuat
            // 
            this.time_SanXuat.CustomFormat = "dd/mm/yyyy";
            this.time_SanXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_SanXuat.Location = new System.Drawing.Point(131, 162);
            this.time_SanXuat.Name = "time_SanXuat";
            this.time_SanXuat.Size = new System.Drawing.Size(132, 22);
            this.time_SanXuat.TabIndex = 18;
            // 
            // MATHUOC
            // 
            this.MATHUOC.DataPropertyName = "MATHUOC";
            this.MATHUOC.HeaderText = "Mã Thuốc";
            this.MATHUOC.MinimumWidth = 6;
            this.MATHUOC.Name = "MATHUOC";
            this.MATHUOC.Width = 125;
            // 
            // TENTHUOC
            // 
            this.TENTHUOC.DataPropertyName = "TENTHUOC";
            this.TENTHUOC.HeaderText = "Tên Thuốc";
            this.TENTHUOC.MinimumWidth = 6;
            this.TENTHUOC.Name = "TENTHUOC";
            this.TENTHUOC.Width = 125;
            // 
            // NHASX
            // 
            this.NHASX.DataPropertyName = "NHASX";
            this.NHASX.HeaderText = "Nhà sản xuất";
            this.NHASX.MinimumWidth = 6;
            this.NHASX.Name = "NHASX";
            this.NHASX.Width = 125;
            // 
            // NGAYSX
            // 
            this.NGAYSX.DataPropertyName = "NGAYSX";
            this.NGAYSX.HeaderText = "Ngày sản xuất";
            this.NGAYSX.MinimumWidth = 6;
            this.NGAYSX.Name = "NGAYSX";
            this.NGAYSX.Width = 125;
            // 
            // HANSD
            // 
            this.HANSD.DataPropertyName = "HANSD";
            this.HANSD.HeaderText = "Hạn sử dụng";
            this.HANSD.MinimumWidth = 6;
            this.HANSD.Name = "HANSD";
            this.HANSD.Width = 125;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 125;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Width = 125;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.time_SanXuat);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.txt_HSD);
            this.Controls.Add(this.txt_NhaSanXuat);
            this.Controls.Add(this.txt_TenThuoc);
            this.Controls.Add(this.txt_MaThuoc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_MaThuoc;
        private System.Windows.Forms.TextBox txt_TenThuoc;
        private System.Windows.Forms.TextBox txt_NhaSanXuat;
        private System.Windows.Forms.TextBox txt_HSD;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.DateTimePicker time_SanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHASX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HANSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
    }
}

