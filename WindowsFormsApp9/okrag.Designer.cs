namespace WindowsFormsApp9
{
    partial class okrag
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
            this.czysc_o = new System.Windows.Forms.Button();
            this.Obszar_rysowania_o = new System.Windows.Forms.Label();
            this.obwod_cz = new System.Windows.Forms.Label();
            this.pole_o = new System.Windows.Forms.Label();
            this.obwod_o = new System.Windows.Forms.Label();
            this.pole_ot = new System.Windows.Forms.Label();
            this.Tytul_o = new System.Windows.Forms.Label();
            this.panel_okrag = new System.Windows.Forms.Panel();
            this.rysuj_o = new System.Windows.Forms.Button();
            this.promien = new System.Windows.Forms.TextBox();
            this.promien_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // czysc_o
            // 
            this.czysc_o.Location = new System.Drawing.Point(128, 95);
            this.czysc_o.Name = "czysc_o";
            this.czysc_o.Size = new System.Drawing.Size(63, 23);
            this.czysc_o.TabIndex = 25;
            this.czysc_o.Text = "Wyczyść";
            this.czysc_o.UseVisualStyleBackColor = true;
            this.czysc_o.Click += new System.EventHandler(this.czysc_o_Click);
            // 
            // Obszar_rysowania_o
            // 
            this.Obszar_rysowania_o.AutoSize = true;
            this.Obszar_rysowania_o.Location = new System.Drawing.Point(17, 165);
            this.Obszar_rysowania_o.Name = "Obszar_rysowania_o";
            this.Obszar_rysowania_o.Size = new System.Drawing.Size(90, 13);
            this.Obszar_rysowania_o.TabIndex = 24;
            this.Obszar_rysowania_o.Text = "Obszar rysowania";
            // 
            // obwod_cz
            // 
            this.obwod_cz.AutoSize = true;
            this.obwod_cz.Location = new System.Drawing.Point(164, 405);
            this.obwod_cz.Name = "obwod_cz";
            this.obwod_cz.Size = new System.Drawing.Size(35, 13);
            this.obwod_cz.TabIndex = 23;
            this.obwod_cz.Text = "label1";
            this.obwod_cz.Visible = false;
            // 
            // pole_o
            // 
            this.pole_o.AutoSize = true;
            this.pole_o.Location = new System.Drawing.Point(149, 383);
            this.pole_o.Name = "pole_o";
            this.pole_o.Size = new System.Drawing.Size(35, 13);
            this.pole_o.TabIndex = 22;
            this.pole_o.Text = "label1";
            this.pole_o.Visible = false;
            // 
            // obwod_o
            // 
            this.obwod_o.AutoSize = true;
            this.obwod_o.Location = new System.Drawing.Point(26, 405);
            this.obwod_o.Name = "obwod_o";
            this.obwod_o.Size = new System.Drawing.Size(139, 13);
            this.obwod_o.TabIndex = 21;
            this.obwod_o.Text = "Obwód tego okręgu wynosi:";
            // 
            // pole_ot
            // 
            this.pole_ot.AutoSize = true;
            this.pole_ot.Location = new System.Drawing.Point(26, 383);
            this.pole_ot.Name = "pole_ot";
            this.pole_ot.Size = new System.Drawing.Size(129, 13);
            this.pole_ot.TabIndex = 20;
            this.pole_ot.Text = "Pole tego okręgu wynosi: ";
            // 
            // Tytul_o
            // 
            this.Tytul_o.AutoSize = true;
            this.Tytul_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tytul_o.Location = new System.Drawing.Point(82, 25);
            this.Tytul_o.Name = "Tytul_o";
            this.Tytul_o.Size = new System.Drawing.Size(95, 33);
            this.Tytul_o.TabIndex = 19;
            this.Tytul_o.Text = "Okrąg";
            // 
            // panel_okrag
            // 
            this.panel_okrag.BackColor = System.Drawing.Color.White;
            this.panel_okrag.Location = new System.Drawing.Point(17, 181);
            this.panel_okrag.Name = "panel_okrag";
            this.panel_okrag.Size = new System.Drawing.Size(230, 188);
            this.panel_okrag.TabIndex = 18;
            // 
            // rysuj_o
            // 
            this.rysuj_o.Location = new System.Drawing.Point(56, 95);
            this.rysuj_o.Name = "rysuj_o";
            this.rysuj_o.Size = new System.Drawing.Size(66, 23);
            this.rysuj_o.TabIndex = 17;
            this.rysuj_o.Text = "Rysuj";
            this.rysuj_o.UseVisualStyleBackColor = true;
            this.rysuj_o.Click += new System.EventHandler(this.rysuj_o_Click);
            // 
            // promien
            // 
            this.promien.Location = new System.Drawing.Point(152, 69);
            this.promien.Name = "promien";
            this.promien.Size = new System.Drawing.Size(68, 20);
            this.promien.TabIndex = 15;
            this.promien.TextChanged += new System.EventHandler(this.promien_TextChanged);
            // 
            // promien_label
            // 
            this.promien_label.AutoSize = true;
            this.promien_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.promien_label.Location = new System.Drawing.Point(49, 70);
            this.promien_label.Name = "promien_label";
            this.promien_label.Size = new System.Drawing.Size(99, 16);
            this.promien_label.TabIndex = 13;
            this.promien_label.Text = "Podaj promień:";
            // 
            // okrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 450);
            this.Controls.Add(this.czysc_o);
            this.Controls.Add(this.Obszar_rysowania_o);
            this.Controls.Add(this.obwod_cz);
            this.Controls.Add(this.pole_o);
            this.Controls.Add(this.obwod_o);
            this.Controls.Add(this.pole_ot);
            this.Controls.Add(this.Tytul_o);
            this.Controls.Add(this.panel_okrag);
            this.Controls.Add(this.rysuj_o);
            this.Controls.Add(this.promien);
            this.Controls.Add(this.promien_label);
            this.Name = "okrag";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button czysc_o;
        private System.Windows.Forms.Label Obszar_rysowania_o;
        private System.Windows.Forms.Label obwod_cz;
        private System.Windows.Forms.Label pole_o;
        private System.Windows.Forms.Label obwod_o;
        private System.Windows.Forms.Label pole_ot;
        private System.Windows.Forms.Label Tytul_o;
        private System.Windows.Forms.Panel panel_okrag;
        private System.Windows.Forms.Button rysuj_o;
        private System.Windows.Forms.TextBox promien;
        private System.Windows.Forms.Label promien_label;
    }
}