﻿namespace WindowsFormsAppSQ
{
    partial class flinhkien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flinhkien));
            this.ThanhTacVu = new System.Windows.Forms.BindingNavigator(this.components);
            this.btlThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
            this.btlXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripSeparator();
            this.btlSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripSeparator();
            this.btlLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btlXemLai = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btlThoat = new System.Windows.Forms.ToolStripButton();
            this.txtd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ThanhTacVu)).BeginInit();
            this.ThanhTacVu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.btlLuu,
            this.toolStripSeparator3,
            this.btlXemLai,
            this.toolStripSeparator2,
            this.btlThoat});
            this.ThanhTacVu.Location = new System.Drawing.Point(0, 98);
            this.ThanhTacVu.MoveFirstItem = null;
            this.ThanhTacVu.MoveLastItem = null;
            this.ThanhTacVu.MoveNextItem = null;
            this.ThanhTacVu.MovePreviousItem = null;
            this.ThanhTacVu.Name = "ThanhTacVu";
            this.ThanhTacVu.PositionItem = null;
            this.ThanhTacVu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ThanhTacVu.Size = new System.Drawing.Size(800, 47);
            this.ThanhTacVu.TabIndex = 28;
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 47);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
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
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(461, 30);
            this.txtd.MaxLength = 10;
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(138, 20);
            this.txtd.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Năm SX  :";
            // 
            // txtt
            // 
            this.txtt.Location = new System.Drawing.Point(223, 57);
            this.txtt.MaxLength = 30;
            this.txtt.Name = "txtt";
            this.txtt.Size = new System.Drawing.Size(138, 20);
            this.txtt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên  :";
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(223, 31);
            this.txtm.MaxLength = 30;
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(138, 20);
            this.txtm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã  :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.comboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 98);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(461, 56);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(138, 21);
            this.comboBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Đơn vị :";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 161);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(800, 300);
            this.dataGridView.TabIndex = 26;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // flinhkien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ThanhTacVu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Name = "flinhkien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LINH KIỆN";
            ((System.ComponentModel.ISupportInitialize)(this.ThanhTacVu)).EndInit();
            this.ThanhTacVu.ResumeLayout(false);
            this.ThanhTacVu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator ThanhTacVu;
        private System.Windows.Forms.ToolStripButton btlThem;
        private System.Windows.Forms.ToolStripSeparator toolStripButton4;
        private System.Windows.Forms.ToolStripButton btlXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripButton5;
        private System.Windows.Forms.ToolStripButton btlSua;
        private System.Windows.Forms.ToolStripSeparator toolStripButton8;
        private System.Windows.Forms.ToolStripButton btlLuu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btlXemLai;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btlThoat;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label5;
    }
}