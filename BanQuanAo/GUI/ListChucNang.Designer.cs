namespace BanQuanAo.GUI
{
    partial class frmList
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
            this.btn_PageBanHang = new System.Windows.Forms.Button();
            this.btn_PageCapNhat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_PageBanHang
            // 
            this.btn_PageBanHang.Location = new System.Drawing.Point(318, 205);
            this.btn_PageBanHang.Name = "btn_PageBanHang";
            this.btn_PageBanHang.Size = new System.Drawing.Size(171, 44);
            this.btn_PageBanHang.TabIndex = 0;
            this.btn_PageBanHang.Text = "Bán hàng";
            this.btn_PageBanHang.UseVisualStyleBackColor = true;
            this.btn_PageBanHang.Click += new System.EventHandler(this.btn_PageBanHang_Click);
            // 
            // btn_PageCapNhat
            // 
            this.btn_PageCapNhat.Location = new System.Drawing.Point(318, 273);
            this.btn_PageCapNhat.Name = "btn_PageCapNhat";
            this.btn_PageCapNhat.Size = new System.Drawing.Size(171, 40);
            this.btn_PageCapNhat.TabIndex = 1;
            this.btn_PageCapNhat.Text = "Cập nhật hàng";
            this.btn_PageCapNhat.UseVisualStyleBackColor = true;
            this.btn_PageCapNhat.Click += new System.EventHandler(this.btn_PageCapNhat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bánHàngToolStripMenuItem,
            this.cậpNhậtHàngToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(58, 24);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.bánHàngToolStripMenuItem.Text = "Bán hàng";
            this.bánHàngToolStripMenuItem.Click += new System.EventHandler(this.bánHàngToolStripMenuItem_Click);
            // 
            // cậpNhậtHàngToolStripMenuItem
            // 
            this.cậpNhậtHàngToolStripMenuItem.Name = "cậpNhậtHàngToolStripMenuItem";
            this.cậpNhậtHàngToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.cậpNhậtHàngToolStripMenuItem.Text = "Cập nhật hàng";
            this.cậpNhậtHàngToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtHàngToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(204, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách chức năng";
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_PageCapNhat);
            this.Controls.Add(this.btn_PageBanHang);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmList";
            this.Text = "ListChucNang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmList_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PageBanHang;
        private System.Windows.Forms.Button btn_PageCapNhat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtHàngToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}