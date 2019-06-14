namespace WindowsFormsApp9
{
    partial class Glowna
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.okragToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trójkatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czworokatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okragToolStripMenuItem,
            this.trójkatToolStripMenuItem,
            this.czworokatToolStripMenuItem,
            this.cosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(231, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // okragToolStripMenuItem
            // 
            this.okragToolStripMenuItem.Name = "okragToolStripMenuItem";
            this.okragToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.okragToolStripMenuItem.Text = "Okrag";
            this.okragToolStripMenuItem.Click += new System.EventHandler(this.okragToolStripMenuItem_Click);
            // 
            // trójkatToolStripMenuItem
            // 
            this.trójkatToolStripMenuItem.Name = "trójkatToolStripMenuItem";
            this.trójkatToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.trójkatToolStripMenuItem.Text = "Trójkat";
            this.trójkatToolStripMenuItem.Click += new System.EventHandler(this.trójkatToolStripMenuItem_Click);
            // 
            // czworokatToolStripMenuItem
            // 
            this.czworokatToolStripMenuItem.Name = "czworokatToolStripMenuItem";
            this.czworokatToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.czworokatToolStripMenuItem.Text = "Czworokat";
            this.czworokatToolStripMenuItem.Click += new System.EventHandler(this.czworokatToolStripMenuItem_Click);
            // 
            // cosToolStripMenuItem
            // 
            this.cosToolStripMenuItem.Name = "cosToolStripMenuItem";
            this.cosToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.cosToolStripMenuItem.Text = "Cos";
            // 
            // Glowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 27);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glowna";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem okragToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trójkatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czworokatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosToolStripMenuItem;
    }
}

