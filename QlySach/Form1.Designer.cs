﻿namespace QlySach
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhậpDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpBảngChủĐềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpBảngNhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpBảngSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpDữLiệuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhậpDữLiệuToolStripMenuItem
            // 
            this.nhậpDữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpBảngChủĐềToolStripMenuItem,
            this.nhậpBảngNhàXuấtBảnToolStripMenuItem,
            this.nhậpBảngSáchToolStripMenuItem});
            this.nhậpDữLiệuToolStripMenuItem.Name = "nhậpDữLiệuToolStripMenuItem";
            this.nhậpDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.nhậpDữLiệuToolStripMenuItem.Text = "Nhập Dữ Liệu";
            // 
            // nhậpBảngChủĐềToolStripMenuItem
            // 
            this.nhậpBảngChủĐềToolStripMenuItem.Name = "nhậpBảngChủĐềToolStripMenuItem";
            this.nhậpBảngChủĐềToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.nhậpBảngChủĐềToolStripMenuItem.Text = "Nhập bảng Chủ Đề";
            this.nhậpBảngChủĐềToolStripMenuItem.Click += new System.EventHandler(this.nhậpBảngChủĐềToolStripMenuItem_Click);
            // 
            // nhậpBảngNhàXuấtBảnToolStripMenuItem
            // 
            this.nhậpBảngNhàXuấtBảnToolStripMenuItem.Name = "nhậpBảngNhàXuấtBảnToolStripMenuItem";
            this.nhậpBảngNhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.nhậpBảngNhàXuấtBảnToolStripMenuItem.Text = "Nhập bảng Nhà Xuất Bản";
            this.nhậpBảngNhàXuấtBảnToolStripMenuItem.Click += new System.EventHandler(this.nhậpBảngNhàXuấtBảnToolStripMenuItem_Click);
            // 
            // nhậpBảngSáchToolStripMenuItem
            // 
            this.nhậpBảngSáchToolStripMenuItem.Name = "nhậpBảngSáchToolStripMenuItem";
            this.nhậpBảngSáchToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.nhậpBảngSáchToolStripMenuItem.Text = "Nhập bảng Sách";
            this.nhậpBảngSáchToolStripMenuItem.Click += new System.EventHandler(this.nhậpBảngSáchToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 458);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhậpDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpBảngChủĐềToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpBảngNhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpBảngSáchToolStripMenuItem;
    }
}

