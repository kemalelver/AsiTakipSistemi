namespace AşıTakipSistemi
{
    partial class Doktor
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
            this.hastaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastalarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aşıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aşıYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aşısıYaklaşanlarıGörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaİşlemleriToolStripMenuItem,
            this.aşıİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaİşlemleriToolStripMenuItem
            // 
            this.hastaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaEkleToolStripMenuItem,
            this.hastaSilToolStripMenuItem,
            this.hastalarıListeleToolStripMenuItem});
            this.hastaİşlemleriToolStripMenuItem.Name = "hastaİşlemleriToolStripMenuItem";
            this.hastaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.hastaİşlemleriToolStripMenuItem.Text = "Hasta İşlemleri";
            // 
            // hastaEkleToolStripMenuItem
            // 
            this.hastaEkleToolStripMenuItem.Name = "hastaEkleToolStripMenuItem";
            this.hastaEkleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.hastaEkleToolStripMenuItem.Text = "Hasta Ekle";
            this.hastaEkleToolStripMenuItem.Click += new System.EventHandler(this.hastaEkleToolStripMenuItem_Click);
            // 
            // hastaSilToolStripMenuItem
            // 
            this.hastaSilToolStripMenuItem.Name = "hastaSilToolStripMenuItem";
            this.hastaSilToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.hastaSilToolStripMenuItem.Text = "Hasta Sil";
            this.hastaSilToolStripMenuItem.Click += new System.EventHandler(this.hastaSilToolStripMenuItem_Click);
            // 
            // hastalarıListeleToolStripMenuItem
            // 
            this.hastalarıListeleToolStripMenuItem.Name = "hastalarıListeleToolStripMenuItem";
            this.hastalarıListeleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.hastalarıListeleToolStripMenuItem.Text = "Hastaları Listele";
            this.hastalarıListeleToolStripMenuItem.Click += new System.EventHandler(this.hastalarıListeleToolStripMenuItem_Click);
            // 
            // aşıİşlemleriToolStripMenuItem
            // 
            this.aşıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aşıYapToolStripMenuItem,
            this.aşısıYaklaşanlarıGörToolStripMenuItem});
            this.aşıİşlemleriToolStripMenuItem.Name = "aşıİşlemleriToolStripMenuItem";
            this.aşıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.aşıİşlemleriToolStripMenuItem.Text = "Aşı İşlemleri";
            // 
            // aşıYapToolStripMenuItem
            // 
            this.aşıYapToolStripMenuItem.Name = "aşıYapToolStripMenuItem";
            this.aşıYapToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.aşıYapToolStripMenuItem.Text = "Aşı Yap";
            this.aşıYapToolStripMenuItem.Click += new System.EventHandler(this.aşıYapToolStripMenuItem_Click);
            // 
            // aşısıYaklaşanlarıGörToolStripMenuItem
            // 
            this.aşısıYaklaşanlarıGörToolStripMenuItem.Name = "aşısıYaklaşanlarıGörToolStripMenuItem";
            this.aşısıYaklaşanlarıGörToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.aşısıYaklaşanlarıGörToolStripMenuItem.Text = "Aşısı Yaklaşanları Gör";
            this.aşısıYaklaşanlarıGörToolStripMenuItem.Click += new System.EventHandler(this.aşısıYaklaşanlarıGörToolStripMenuItem_Click);
            // 
            // Doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 438);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Doktor";
            this.Text = "Doktor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastalarıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aşıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aşıYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aşısıYaklaşanlarıGörToolStripMenuItem;
    }
}