﻿namespace WindowsFormsAppSQ
{
    partial class fdonvi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fdonvi));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txts = new System.Windows.Forms.TextBox();
            this.txtd = new System.Windows.Forms.TextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.btlThoat = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThanhTacVu)).BeginInit();
            this.ThanhTacVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(-1, 148);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(800, 300);
            this.dataGridView.TabIndex = 19;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtd);
            this.groupBox1.Controls.Add(this.txts);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 98);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn vị :";
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(122, 35);
            this.txtm.MaxLength = 30;
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(231, 20);
            this.txtm.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên đơn vị :";
            // 
            // txtt
            // 
            this.txtt.Location = new System.Drawing.Point(122, 61);
            this.txtt.MaxLength = 30;
            this.txtt.Name = "txtt";
            this.txtt.Size = new System.Drawing.Size(231, 20);
            this.txtt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Địa điểm  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Số điện thoại  :";
            // 
            // txts
            // 
            this.txts.Location = new System.Drawing.Point(540, 61);
            this.txts.MaxLength = 10;
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(229, 20);
            this.txts.TabIndex = 15;
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(540, 34);
            this.txtd.MaxLength = 10;
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(229, 20);
            this.txtd.TabIndex = 17;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
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
            this.ThanhTacVu.TabIndex = 22;
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
            // fdonvi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ThanhTacVu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Name = "fdonvi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐƠN VỊ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fdonvi_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThanhTacVu)).EndInit();
            this.ThanhTacVu.ResumeLayout(false);
            this.ThanhTacVu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.TextBox txts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
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
        private System.Windows.Forms.ToolStripButton btlThoat;
    }
}