namespace Gest_Cultures
{
    partial class Parcellee
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
            this.txt_type = new System.Windows.Forms.TextBox();
            this.txt_surface = new System.Windows.Forms.TextBox();
            this.txt_nomp = new System.Windows.Forms.TextBox();
            this.txt_nump = new System.Windows.Forms.TextBox();
            this.txt_adresse = new System.Windows.Forms.TextBox();
            this.txt_profondeur = new System.Windows.Forms.TextBox();
            this.btn_ajo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(92, 131);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(140, 20);
            this.txt_type.TabIndex = 24;
            // 
            // txt_surface
            // 
            this.txt_surface.Location = new System.Drawing.Point(92, 94);
            this.txt_surface.Name = "txt_surface";
            this.txt_surface.Size = new System.Drawing.Size(140, 20);
            this.txt_surface.TabIndex = 23;
            // 
            // txt_nomp
            // 
            this.txt_nomp.Location = new System.Drawing.Point(92, 56);
            this.txt_nomp.Name = "txt_nomp";
            this.txt_nomp.Size = new System.Drawing.Size(140, 20);
            this.txt_nomp.TabIndex = 22;
            // 
            // txt_nump
            // 
            this.txt_nump.Location = new System.Drawing.Point(92, 19);
            this.txt_nump.Name = "txt_nump";
            this.txt_nump.Size = new System.Drawing.Size(140, 20);
            this.txt_nump.TabIndex = 21;
            // 
            // txt_adresse
            // 
            this.txt_adresse.Location = new System.Drawing.Point(92, 206);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.Size = new System.Drawing.Size(140, 20);
            this.txt_adresse.TabIndex = 26;
            // 
            // txt_profondeur
            // 
            this.txt_profondeur.Location = new System.Drawing.Point(92, 169);
            this.txt_profondeur.Name = "txt_profondeur";
            this.txt_profondeur.Size = new System.Drawing.Size(140, 20);
            this.txt_profondeur.TabIndex = 25;
            // 
            // btn_ajo
            // 
            this.btn_ajo.Location = new System.Drawing.Point(245, 23);
            this.btn_ajo.Name = "btn_ajo";
            this.btn_ajo.Size = new System.Drawing.Size(75, 23);
            this.btn_ajo.TabIndex = 30;
            this.btn_ajo.Text = "Ajouter";
            this.btn_ajo.UseVisualStyleBackColor = true;
            this.btn_ajo.Click += new System.EventHandler(this.btn_ajo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Surface";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Profondeur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Adresse";
            // 
            // Parcelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 249);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ajo);
            this.Controls.Add(this.txt_adresse);
            this.Controls.Add(this.txt_profondeur);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.txt_surface);
            this.Controls.Add(this.txt_nomp);
            this.Controls.Add(this.txt_nump);
            this.Name = "Parcelle";
            this.Text = "Parcelle";
            this.Load += new System.EventHandler(this.Parcelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.TextBox txt_surface;
        private System.Windows.Forms.TextBox txt_nomp;
        private System.Windows.Forms.TextBox txt_nump;
        private System.Windows.Forms.TextBox txt_adresse;
        private System.Windows.Forms.TextBox txt_profondeur;
        private System.Windows.Forms.Button btn_ajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}