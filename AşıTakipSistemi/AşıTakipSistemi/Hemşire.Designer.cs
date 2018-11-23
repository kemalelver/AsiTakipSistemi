namespace AşıTakipSistemi
{
    partial class Hemşire
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
            this.hastaİşleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastalarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aşıYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aşısıYaklaşanlarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaİşleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaİşleriToolStripMenuItem
            // 
            this.hastaİşleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastalarıListeleToolStripMenuItem,
            this.aşıYapToolStripMenuItem,
            this.aşısıYaklaşanlarıListeleToolStripMenuItem});
            this.hastaİşleriToolStripMenuItem.Name = "hastaİşleriToolStripMenuItem";
            this.hastaİşleriToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.hastaİşleriToolStripMenuItem.Text = "Hasta İşleri";
            // 
            // hastalarıListeleToolStripMenuItem
            // 
            this.hastalarıListeleToolStripMenuItem.Name = "hastalarıListeleToolStripMenuItem";
            this.hastalarıListeleToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.hastalarıListeleToolStripMenuItem.Text = "Hastaları Listele";
            this.hastalarıListeleToolStripMenuItem.Click += new System.EventHandler(this.hastalarıListeleToolStripMenuItem_Click);
            // 
            // aşıYapToolStripMenuItem
            // 
            this.aşıYapToolStripMenuItem.Name = "aşıYapToolStripMenuItem";
            this.aşıYapToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.aşıYapToolStripMenuItem.Text = "Aşı Yap";
            this.aşıYapToolStripMenuItem.Click += new System.EventHandler(this.aşıYapToolStripMenuItem_Click);
            // 
            // aşısıYaklaşanlarıListeleToolStripMenuItem
            // 
            this.aşısıYaklaşanlarıListeleToolStripMenuItem.Name = "aşısıYaklaşanlarıListeleToolStripMenuItem";
            this.aşısıYaklaşanlarıListeleToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.aşısıYaklaşanlarıListeleToolStripMenuItem.Text = "Aşısı Yaklaşanları Listele";
            this.aşısıYaklaşanlarıListeleToolStripMenuItem.Click += new System.EventHandler(this.aşısıYaklaşanlarıListeleToolStripMenuItem_Click);
            // 
            // Hemşire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 296);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Hemşire";
            this.Text = "Hemşire";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaİşleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastalarıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aşıYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aşısıYaklaşanlarıListeleToolStripMenuItem;
    }
}