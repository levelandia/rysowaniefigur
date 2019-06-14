namespace WindowsFormsApp9
{
    partial class Form2
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
            this.czysc_cz = new System.Windows.Forms.Button();
            this.Obszar_rysowania_cz = new System.Windows.Forms.Label();
            this.obwod_cz = new System.Windows.Forms.Label();
            this.pole_cz = new System.Windows.Forms.Label();
            this.obwod_czt = new System.Windows.Forms.Label();
            this.pole_czt = new System.Windows.Forms.Label();
            this.Tytul_t = new System.Windows.Forms.Label();
            this.panel_trojkat = new System.Windows.Forms.Panel();
            this.rysuj_cz = new System.Windows.Forms.Button();
            this.bokb_cz = new System.Windows.Forms.TextBox();
            this.boka_cz = new System.Windows.Forms.TextBox();
            this.cz_bok_b_label = new System.Windows.Forms.Label();
            this.t_bok_a_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // czysc_cz
            // 
            this.czysc_cz.Location = new System.Drawing.Point(135, 121);
            this.czysc_cz.Name = "czysc_cz";
            this.czysc_cz.Size = new System.Drawing.Size(63, 23);
            this.czysc_cz.TabIndex = 25;
            this.czysc_cz.Text = "Wyczyść";
            this.czysc_cz.UseVisualStyleBackColor = true;
            // 
            // Obszar_rysowania_cz
            // 
            this.Obszar_rysowania_cz.AutoSize = true;
            this.Obszar_rysowania_cz.Location = new System.Drawing.Point(13, 166);
            this.Obszar_rysowania_cz.Name = "Obszar_rysowania_cz";
            this.Obszar_rysowania_cz.Size = new System.Drawing.Size(90, 13);
            this.Obszar_rysowania_cz.TabIndex = 24;
            this.Obszar_rysowania_cz.Text = "Obszar rysowania";
            // 
            // obwod_cz
            // 
            this.obwod_cz.AutoSize = true;
            this.obwod_cz.Location = new System.Drawing.Point(184, 406);
            this.obwod_cz.Name = "obwod_cz";
            this.obwod_cz.Size = new System.Drawing.Size(35, 13);
            this.obwod_cz.TabIndex = 23;
            this.obwod_cz.Text = "label1";
            this.obwod_cz.Visible = false;
            // 
            // pole_cz
            // 
            this.pole_cz.AutoSize = true;
            this.pole_cz.Location = new System.Drawing.Point(168, 384);
            this.pole_cz.Name = "pole_cz";
            this.pole_cz.Size = new System.Drawing.Size(35, 13);
            this.pole_cz.TabIndex = 22;
            this.pole_cz.Text = "label1";
            this.pole_cz.Visible = false;
            // 
            // obwod_czt
            // 
            this.obwod_czt.AutoSize = true;
            this.obwod_czt.Location = new System.Drawing.Point(22, 406);
            this.obwod_czt.Name = "obwod_czt";
            this.obwod_czt.Size = new System.Drawing.Size(161, 13);
            this.obwod_czt.TabIndex = 21;
            this.obwod_czt.Text = "Obwód tego czworokątu wynosi:";
            // 
            // pole_czt
            // 
            this.pole_czt.AutoSize = true;
            this.pole_czt.Location = new System.Drawing.Point(22, 384);
            this.pole_czt.Name = "pole_czt";
            this.pole_czt.Size = new System.Drawing.Size(151, 13);
            this.pole_czt.TabIndex = 20;
            this.pole_czt.Text = "Pole tego czworokątu wynosi: ";
            // 
            // Tytul_t
            // 
            this.Tytul_t.AutoSize = true;
            this.Tytul_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tytul_t.Location = new System.Drawing.Point(68, 27);
            this.Tytul_t.Name = "Tytul_t";
            this.Tytul_t.Size = new System.Drawing.Size(105, 33);
            this.Tytul_t.TabIndex = 19;
            this.Tytul_t.Text = "Trójkąt";
            // 
            // panel_trojkat
            // 
            this.panel_trojkat.BackColor = System.Drawing.Color.White;
            this.panel_trojkat.Location = new System.Drawing.Point(13, 182);
            this.panel_trojkat.Name = "panel_trojkat";
            this.panel_trojkat.Size = new System.Drawing.Size(230, 188);
            this.panel_trojkat.TabIndex = 18;
            // 
            // rysuj_cz
            // 
            this.rysuj_cz.Location = new System.Drawing.Point(54, 121);
            this.rysuj_cz.Name = "rysuj_cz";
            this.rysuj_cz.Size = new System.Drawing.Size(66, 23);
            this.rysuj_cz.TabIndex = 17;
            this.rysuj_cz.Text = "Rysuj";
            this.rysuj_cz.UseVisualStyleBackColor = true;
            this.rysuj_cz.Click += new System.EventHandler(this.rysuj_cz_Click);
            // 
            // bokb_cz
            // 
            this.bokb_cz.Location = new System.Drawing.Point(135, 95);
            this.bokb_cz.Name = "bokb_cz";
            this.bokb_cz.Size = new System.Drawing.Size(68, 20);
            this.bokb_cz.TabIndex = 16;
            // 
            // boka_cz
            // 
            this.boka_cz.Location = new System.Drawing.Point(135, 69);
            this.boka_cz.Name = "boka_cz";
            this.boka_cz.Size = new System.Drawing.Size(68, 20);
            this.boka_cz.TabIndex = 15;
            // 
            // cz_bok_b_label
            // 
            this.cz_bok_b_label.AutoSize = true;
            this.cz_bok_b_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cz_bok_b_label.Location = new System.Drawing.Point(45, 99);
            this.cz_bok_b_label.Name = "cz_bok_b_label";
            this.cz_bok_b_label.Size = new System.Drawing.Size(84, 16);
            this.cz_bok_b_label.TabIndex = 14;
            this.cz_bok_b_label.Text = "Podaj bok b:";
            // 
            // t_bok_a_label
            // 
            this.t_bok_a_label.AutoSize = true;
            this.t_bok_a_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.t_bok_a_label.Location = new System.Drawing.Point(45, 71);
            this.t_bok_a_label.Name = "t_bok_a_label";
            this.t_bok_a_label.Size = new System.Drawing.Size(84, 16);
            this.t_bok_a_label.TabIndex = 13;
            this.t_bok_a_label.Text = "Podaj bok a:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 450);
            this.Controls.Add(this.czysc_cz);
            this.Controls.Add(this.Obszar_rysowania_cz);
            this.Controls.Add(this.obwod_cz);
            this.Controls.Add(this.pole_cz);
            this.Controls.Add(this.obwod_czt);
            this.Controls.Add(this.pole_czt);
            this.Controls.Add(this.Tytul_t);
            this.Controls.Add(this.panel_trojkat);
            this.Controls.Add(this.rysuj_cz);
            this.Controls.Add(this.bokb_cz);
            this.Controls.Add(this.boka_cz);
            this.Controls.Add(this.cz_bok_b_label);
            this.Controls.Add(this.t_bok_a_label);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button czysc_cz;
        private System.Windows.Forms.Label Obszar_rysowania_cz;
        private System.Windows.Forms.Label obwod_cz;
        private System.Windows.Forms.Label pole_cz;
        private System.Windows.Forms.Label obwod_czt;
        private System.Windows.Forms.Label pole_czt;
        private System.Windows.Forms.Label Tytul_t;
        private System.Windows.Forms.Panel panel_trojkat;
        private System.Windows.Forms.Button rysuj_cz;
        private System.Windows.Forms.TextBox bokb_cz;
        private System.Windows.Forms.TextBox boka_cz;
        private System.Windows.Forms.Label cz_bok_b_label;
        private System.Windows.Forms.Label t_bok_a_label;
    }
}