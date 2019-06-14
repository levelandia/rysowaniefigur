namespace WindowsFormsApp9
{
    partial class czworokat
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
            this.cz_bok_a_label = new System.Windows.Forms.Label();
            this.cz_bok_b_label = new System.Windows.Forms.Label();
            this.boka_cz = new System.Windows.Forms.TextBox();
            this.bokb_cz = new System.Windows.Forms.TextBox();
            this.rysuj_cz = new System.Windows.Forms.Button();
            this.panel_czworokat = new System.Windows.Forms.Panel();
            this.Tytul_cz = new System.Windows.Forms.Label();
            this.pole_czt = new System.Windows.Forms.Label();
            this.obwod_czt = new System.Windows.Forms.Label();
            this.pole_cz = new System.Windows.Forms.Label();
            this.obwod_cz = new System.Windows.Forms.Label();
            this.Obszar_rysowania_cz = new System.Windows.Forms.Label();
            this.czysc_cz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cz_bok_a_label
            // 
            this.cz_bok_a_label.AutoSize = true;
            this.cz_bok_a_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cz_bok_a_label.Location = new System.Drawing.Point(44, 58);
            this.cz_bok_a_label.Name = "cz_bok_a_label";
            this.cz_bok_a_label.Size = new System.Drawing.Size(84, 16);
            this.cz_bok_a_label.TabIndex = 0;
            this.cz_bok_a_label.Text = "Podaj bok a:";
            // 
            // cz_bok_b_label
            // 
            this.cz_bok_b_label.AutoSize = true;
            this.cz_bok_b_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cz_bok_b_label.Location = new System.Drawing.Point(44, 86);
            this.cz_bok_b_label.Name = "cz_bok_b_label";
            this.cz_bok_b_label.Size = new System.Drawing.Size(84, 16);
            this.cz_bok_b_label.TabIndex = 1;
            this.cz_bok_b_label.Text = "Podaj bok b:";
            // 
            // boka_cz
            // 
            this.boka_cz.Location = new System.Drawing.Point(134, 56);
            this.boka_cz.Name = "boka_cz";
            this.boka_cz.Size = new System.Drawing.Size(68, 20);
            this.boka_cz.TabIndex = 2;
            // 
            // bokb_cz
            // 
            this.bokb_cz.Location = new System.Drawing.Point(134, 82);
            this.bokb_cz.Name = "bokb_cz";
            this.bokb_cz.Size = new System.Drawing.Size(68, 20);
            this.bokb_cz.TabIndex = 3;
            // 
            // rysuj_cz
            // 
            this.rysuj_cz.Location = new System.Drawing.Point(53, 108);
            this.rysuj_cz.Name = "rysuj_cz";
            this.rysuj_cz.Size = new System.Drawing.Size(66, 23);
            this.rysuj_cz.TabIndex = 4;
            this.rysuj_cz.Text = "Rysuj";
            this.rysuj_cz.UseVisualStyleBackColor = true;
            this.rysuj_cz.Click += new System.EventHandler(this.rysuj_cz_Click);
            // 
            // panel_czworokat
            // 
            this.panel_czworokat.BackColor = System.Drawing.Color.White;
            this.panel_czworokat.Location = new System.Drawing.Point(12, 169);
            this.panel_czworokat.Name = "panel_czworokat";
            this.panel_czworokat.Size = new System.Drawing.Size(230, 188);
            this.panel_czworokat.TabIndex = 5;
            // 
            // Tytul_cz
            // 
            this.Tytul_cz.AutoSize = true;
            this.Tytul_cz.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tytul_cz.Location = new System.Drawing.Point(47, 15);
            this.Tytul_cz.Name = "Tytul_cz";
            this.Tytul_cz.Size = new System.Drawing.Size(153, 33);
            this.Tytul_cz.TabIndex = 6;
            this.Tytul_cz.Text = "Czworokąt";
            // 
            // pole_czt
            // 
            this.pole_czt.AutoSize = true;
            this.pole_czt.Location = new System.Drawing.Point(21, 371);
            this.pole_czt.Name = "pole_czt";
            this.pole_czt.Size = new System.Drawing.Size(151, 13);
            this.pole_czt.TabIndex = 7;
            this.pole_czt.Text = "Pole tego czworokątu wynosi: ";
            // 
            // obwod_czt
            // 
            this.obwod_czt.AutoSize = true;
            this.obwod_czt.Location = new System.Drawing.Point(21, 393);
            this.obwod_czt.Name = "obwod_czt";
            this.obwod_czt.Size = new System.Drawing.Size(161, 13);
            this.obwod_czt.TabIndex = 8;
            this.obwod_czt.Text = "Obwód tego czworokątu wynosi:";
            // 
            // pole_cz
            // 
            this.pole_cz.AutoSize = true;
            this.pole_cz.Location = new System.Drawing.Point(167, 371);
            this.pole_cz.Name = "pole_cz";
            this.pole_cz.Size = new System.Drawing.Size(35, 13);
            this.pole_cz.TabIndex = 9;
            this.pole_cz.Text = "label1";
            this.pole_cz.Visible = false;
            // 
            // obwod_cz
            // 
            this.obwod_cz.AutoSize = true;
            this.obwod_cz.Location = new System.Drawing.Point(183, 393);
            this.obwod_cz.Name = "obwod_cz";
            this.obwod_cz.Size = new System.Drawing.Size(35, 13);
            this.obwod_cz.TabIndex = 10;
            this.obwod_cz.Text = "label1";
            this.obwod_cz.Visible = false;
            // 
            // Obszar_rysowania_cz
            // 
            this.Obszar_rysowania_cz.AutoSize = true;
            this.Obszar_rysowania_cz.Location = new System.Drawing.Point(12, 153);
            this.Obszar_rysowania_cz.Name = "Obszar_rysowania_cz";
            this.Obszar_rysowania_cz.Size = new System.Drawing.Size(90, 13);
            this.Obszar_rysowania_cz.TabIndex = 11;
            this.Obszar_rysowania_cz.Text = "Obszar rysowania";
            // 
            // czysc_cz
            // 
            this.czysc_cz.Location = new System.Drawing.Point(134, 108);
            this.czysc_cz.Name = "czysc_cz";
            this.czysc_cz.Size = new System.Drawing.Size(63, 23);
            this.czysc_cz.TabIndex = 12;
            this.czysc_cz.Text = "Wyczyść";
            this.czysc_cz.UseVisualStyleBackColor = true;
            this.czysc_cz.Click += new System.EventHandler(this.czysc_cz_Click);
            // 
            // czworokat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(254, 450);
            this.Controls.Add(this.czysc_cz);
            this.Controls.Add(this.Obszar_rysowania_cz);
            this.Controls.Add(this.obwod_cz);
            this.Controls.Add(this.pole_cz);
            this.Controls.Add(this.obwod_czt);
            this.Controls.Add(this.pole_czt);
            this.Controls.Add(this.Tytul_cz);
            this.Controls.Add(this.panel_czworokat);
            this.Controls.Add(this.rysuj_cz);
            this.Controls.Add(this.bokb_cz);
            this.Controls.Add(this.boka_cz);
            this.Controls.Add(this.cz_bok_b_label);
            this.Controls.Add(this.cz_bok_a_label);
            this.Name = "czworokat";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.czworokat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cz_bok_a_label;
        private System.Windows.Forms.Label cz_bok_b_label;
        private System.Windows.Forms.TextBox boka_cz;
        private System.Windows.Forms.TextBox bokb_cz;
        private System.Windows.Forms.Button rysuj_cz;
        private System.Windows.Forms.Panel panel_czworokat;
        private System.Windows.Forms.Label Tytul_cz;
        private System.Windows.Forms.Label pole_czt;
        private System.Windows.Forms.Label obwod_czt;
        private System.Windows.Forms.Label pole_cz;
        private System.Windows.Forms.Label obwod_cz;
        private System.Windows.Forms.Label Obszar_rysowania_cz;
        private System.Windows.Forms.Button czysc_cz;
    }
}