namespace DataAdapter
{
    partial class MainForm
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
            this.verilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calisanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparislerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verilerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verilerToolStripMenuItem
            // 
            this.verilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musterilerToolStripMenuItem,
            this.calisanlarToolStripMenuItem,
            this.siparislerToolStripMenuItem,
            this.urunlerToolStripMenuItem});
            this.verilerToolStripMenuItem.Name = "verilerToolStripMenuItem";
            this.verilerToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.verilerToolStripMenuItem.Text = "Veriler";
            // 
            // musterilerToolStripMenuItem
            // 
            this.musterilerToolStripMenuItem.Name = "musterilerToolStripMenuItem";
            this.musterilerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.musterilerToolStripMenuItem.Text = "Musteriler";
            this.musterilerToolStripMenuItem.Click += new System.EventHandler(this.musterilerToolStripMenuItem_Click);
            // 
            // calisanlarToolStripMenuItem
            // 
            this.calisanlarToolStripMenuItem.Name = "calisanlarToolStripMenuItem";
            this.calisanlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calisanlarToolStripMenuItem.Text = "Calisanlar";
            // 
            // siparislerToolStripMenuItem
            // 
            this.siparislerToolStripMenuItem.Name = "siparislerToolStripMenuItem";
            this.siparislerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparislerToolStripMenuItem.Text = "Siparisler";
            // 
            // urunlerToolStripMenuItem
            // 
            this.urunlerToolStripMenuItem.Name = "urunlerToolStripMenuItem";
            this.urunlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urunlerToolStripMenuItem.Text = "Urunler";
            this.urunlerToolStripMenuItem.Click += new System.EventHandler(this.urunlerToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calisanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparislerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunlerToolStripMenuItem;
    }
}