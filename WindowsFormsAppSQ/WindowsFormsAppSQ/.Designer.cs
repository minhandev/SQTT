namespace WindowsFormsAppSQ
{
    partial class fQuanly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanly));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Ma_QL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Hoan_Thanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_TB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_Nguoi_Phu_Trach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_NV_KT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghi_Chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTacVu = new System.Windows.Forms.BindingNavigator(this.components);
            this.btlThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
            this.btlXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripSeparator();
            this.btlSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripSeparator();
            this.btlXemLai = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btlThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaql = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbxnvkt = new System.Windows.Forms.ComboBox();
            this.cbbtb = new System.Windows.Forms.ComboBox();
            this.cbbnpt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbdv = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btlLuu = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThanhTacVu)).BeginInit();
            this.ThanhTacVu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_QL,
            this.Ngay_Hoan_Thanh,
            this.Ma_DV,
            this.Ma_TB,
            this.Ma_Nguoi_Phu_Trach,
            this.Ma_NV_KT,
            this.Ghi_Chu});
            this.dataGridView.Location = new System.Drawing.Point(0, 151);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(830, 296);
            this.dataGridView.TabIndex = 16;
            // 
            // Ma_QL
            // 
            this.Ma_QL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ma_QL.DataPropertyName = "Ma_QL";
            this.Ma_QL.HeaderText = "Mã quản lý";
            this.Ma_QL.Name = "Ma_QL";
            this.Ma_QL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Ngay_Hoan_Thanh
            // 
            this.Ngay_Hoan_Thanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ngay_Hoan_Thanh.DataPropertyName = "Ngay_Hoan_Thanh";
            this.Ngay_Hoan_Thanh.HeaderText = "Ngày hoàn thành";
            this.Ngay_Hoan_Thanh.Name = "Ngay_Hoan_Thanh";
            // 
            // Ma_DV
            // 
            this.Ma_DV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ma_DV.DataPropertyName = "Ma_DV";
            this.Ma_DV.HeaderText = "Đơn vị";
            this.Ma_DV.Name = "Ma_DV";
            // 
            // Ma_TB
            // 
            this.Ma_TB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ma_TB.DataPropertyName = "Ma_TB";
            this.Ma_TB.HeaderText = "Thiết bị";
            this.Ma_TB.Name = "Ma_TB";
            // 
            // Ma_Nguoi_Phu_Trach
            // 
            this.Ma_Nguoi_Phu_Trach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ma_Nguoi_Phu_Trach.DataPropertyName = "Ma_Nguoi_Phu_Trach";
            this.Ma_Nguoi_Phu_Trach.HeaderText = "Người phụ trách";
            this.Ma_Nguoi_Phu_Trach.Name = "Ma_Nguoi_Phu_Trach";
            // 
            // Ma_NV_KT
            // 
            this.Ma_NV_KT.DataPropertyName = "Ma_NV_KT";
            this.Ma_NV_KT.HeaderText = "Nhân viên kỹ thuật";
            this.Ma_NV_KT.Name = "Ma_NV_KT";
            // 
            // Ghi_Chu
            // 
            this.Ghi_Chu.DataPropertyName = "Ghi_Chu";
            this.Ghi_Chu.HeaderText = "Ghi chú";
            this.Ghi_Chu.Name = "Ghi_Chu";
            // 
            // ThanhTacVu
            // 
            this.ThanhTacVu.AddNewItem = null;
            this.ThanhTacVu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ThanhTacVu.CountItem = null;
            this.ThanhTacVu.DeleteItem = null;
            this.ThanhTacVu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btlThem,
            this.toolStripButton4,
            this.btlXoa,
            this.toolStripButton5,
            this.btlSua,
            this.toolStripButton8,
            this.btlXemLai,
            this.toolStripSeparator3,
            this.btlThoat,
            this.toolStripSeparator2,
            this.btlLuu});
            this.ThanhTacVu.Location = new System.Drawing.Point(0, 101);
            this.ThanhTacVu.MoveFirstItem = null;
            this.ThanhTacVu.MoveLastItem = null;
            this.ThanhTacVu.MoveNextItem = null;
            this.ThanhTacVu.MovePreviousItem = null;
            this.ThanhTacVu.Name = "ThanhTacVu";
            this.ThanhTacVu.PositionItem = null;
            this.ThanhTacVu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ThanhTacVu.Size = new System.Drawing.Size(830, 47);
            this.ThanhTacVu.TabIndex = 18;
            this.ThanhTacVu.Text = "bindingNavigator1";
            // 
            // btlThem
            // 
            this.btlThem.Image = ((System.Drawing.Image)(resources.GetObject("btlThem.Image")));
            this.btlThem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btlThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btlThem.Name = "btlThem";
            this.btlThem.Size = new System.Drawing.Size(41, 44);
            this.btlThem.Text = "Thêm";
            this.btlThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btlThem.Click += new System.EventHandler(this.btlThem_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(6, 47);
            // 
            // btlXoa
            // 
            this.btlXoa.Image = ((System.Drawing.Image)(resources.GetObject("btlXoa.Image")));
            this.btlXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btlXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btlXoa.Name = "btlXoa";
            this.btlXoa.Size = new System.Drawing.Size(31, 44);
            this.btlXoa.Text = "Xóa";
            this.btlXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btlXoa.Click += new System.EventHandler(this.btlXoa_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(6, 47);
            // 
            // btlSua
            // 
            this.btlSua.Image = ((System.Drawing.Image)(resources.GetObject("btlSua.Image")));
            this.btlSua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btlSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btlSua.Name = "btlSua";
            this.btlSua.Size = new System.Drawing.Size(30, 44);
            this.btlSua.Text = "Sửa";
            this.btlSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btlSua.Click += new System.EventHandler(this.btlSua_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(6, 47);
            // 
            // btlXemLai
            // 
            this.btlXemLai.Image = global::WindowsFormsAppSQ.Properties.Resources.Ok;
            this.btlXemLai.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btlXemLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btlXemLai.Name = "btlXemLai";
            this.btlXemLai.Size = new System.Drawing.Size(53, 44);
            this.btlXemLai.Text = "Xem Lại";
            this.btlXemLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btlXemLai.Click += new System.EventHandler(this.btlXemLai_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 47);
            // 
            // btlThoat
            // 
            this.btlThoat.Image = global::WindowsFormsAppSQ.Properties.Resources.Shutdown1;
            this.btlThoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btlThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btlThoat.Name = "btlThoat";
            this.btlThoat.Size = new System.Drawing.Size(41, 44);
            this.btlThoat.Text = "Thoát";
            this.btlThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btlThoat.Click += new System.EventHandler(this.btlThoat_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã quản lý :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tìm kiếm :";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(367, 12);
            this.txtTimKiem.MaxLength = 10;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(140, 20);
            this.txtTimKiem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ngày hoàn thành :";
            // 
            // txtmaql
            // 
            this.txtmaql.Location = new System.Drawing.Point(109, 45);
            this.txtmaql.MaxLength = 10;
            this.txtmaql.Name = "txtmaql";
            this.txtmaql.Size = new System.Drawing.Size(123, 20);
            this.txtmaql.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.cbxnvkt);
            this.groupBox1.Controls.Add(this.cbbtb);
            this.groupBox1.Controls.Add(this.cbbnpt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbbdv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtghichu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtmaql);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 101);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn vị";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(109, 67);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker.TabIndex = 77;
            // 
            // cbxnvkt
            // 
            this.cbxnvkt.FormattingEnabled = true;
            this.cbxnvkt.Location = new System.Drawing.Point(489, 69);
            this.cbxnvkt.Name = "cbxnvkt";
            this.cbxnvkt.Size = new System.Drawing.Size(124, 21);
            this.cbxnvkt.TabIndex = 19;
            // 
            // cbbtb
            // 
            this.cbbtb.FormattingEnabled = true;
            this.cbbtb.Location = new System.Drawing.Point(279, 71);
            this.cbbtb.Name = "cbbtb";
            this.cbbtb.Size = new System.Drawing.Size(124, 21);
            this.cbbtb.TabIndex = 19;
            // 
            // cbbnpt
            // 
            this.cbbnpt.FormattingEnabled = true;
            this.cbbnpt.Location = new System.Drawing.Point(489, 45);
            this.cbbnpt.Name = "cbbnpt";
            this.cbbnpt.Size = new System.Drawing.Size(124, 21);
            this.cbbnpt.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nhân viên kt :";
            // 
            // cbbdv
            // 
            this.cbbdv.FormattingEnabled = true;
            this.cbbdv.Location = new System.Drawing.Point(279, 47);
            this.cbbdv.Name = "cbbdv";
            this.cbbdv.Size = new System.Drawing.Size(124, 21);
            this.cbbdv.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Thiết bị :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Người phụ trách :";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(678, 63);
            this.txtghichu.MaxLength = 10;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(140, 20);
            this.txtghichu.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Đơn vị :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(622, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ghi chú :";
            // 
            // btlLuu
            // 
            this.btlLuu.Image = global::WindowsFormsAppSQ.Properties.Resources.Luu1;
            this.btlLuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btlLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btlLuu.Name = "btlLuu";
            this.btlLuu.Size = new System.Drawing.Size(31, 44);
            this.btlLuu.Text = "Lưu";
            this.btlLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btlLuu.Click += new System.EventHandler(this.btlLuu_Click);
            // 
            // fQuanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.ThanhTacVu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Name = "fQuanly";
            this.Text = "fQuanly";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThanhTacVu)).EndInit();
            this.ThanhTacVu.ResumeLayout(false);
            this.ThanhTacVu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingNavigator ThanhTacVu;
        private System.Windows.Forms.ToolStripButton btlThem;
        private System.Windows.Forms.ToolStripSeparator toolStripButton4;
        private System.Windows.Forms.ToolStripButton btlXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripButton5;
        private System.Windows.Forms.ToolStripButton btlSua;
        private System.Windows.Forms.ToolStripSeparator toolStripButton8;
        private System.Windows.Forms.ToolStripButton btlXemLai;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btlThoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_QL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Hoan_Thanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_TB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Nguoi_Phu_Trach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NV_KT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghi_Chu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaql;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxnvkt;
        private System.Windows.Forms.ComboBox cbbtb;
        private System.Windows.Forms.ComboBox cbbnpt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbdv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ToolStripButton btlLuu;
    }
}