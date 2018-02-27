namespace Gest_Cultures
{
    partial class Variete
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
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.btn_sup = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_ajo = new System.Windows.Forms.Button();
            this.CB_num = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(24, 85);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(140, 20);
            this.txt_nom.TabIndex = 22;
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(24, 47);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(140, 20);
            this.txt_num.TabIndex = 21;
            // 
            // btn_sup
            // 
            this.btn_sup.Location = new System.Drawing.Point(189, 122);
            this.btn_sup.Name = "btn_sup";
            this.btn_sup.Size = new System.Drawing.Size(75, 23);
            this.btn_sup.TabIndex = 31;
            this.btn_sup.Text = "Supprimer";
            this.btn_sup.UseVisualStyleBackColor = true;
            this.btn_sup.Click += new System.EventHandler(this.btn_sup_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Location = new System.Drawing.Point(189, 82);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(75, 23);
            this.btn_mod.TabIndex = 30;
            this.btn_mod.Text = "Modifier";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // btn_ajo
            // 
            this.btn_ajo.Location = new System.Drawing.Point(189, 41);
            this.btn_ajo.Name = "btn_ajo";
            this.btn_ajo.Size = new System.Drawing.Size(75, 23);
            this.btn_ajo.TabIndex = 29;
            this.btn_ajo.Text = "Ajouter";
            this.btn_ajo.UseVisualStyleBackColor = true;
            this.btn_ajo.Click += new System.EventHandler(this.btn_ajo_Click);
            // 
            // CB_num
            // 
            this.CB_num.FormattingEnabled = true;
            this.CB_num.Location = new System.Drawing.Point(24, 124);
            this.CB_num.Name = "CB_num";
            this.CB_num.Size = new System.Drawing.Size(140, 21);
            this.CB_num.TabIndex = 32;
            // 
            // Variete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 197);
            this.Controls.Add(this.CB_num);
            this.Controls.Add(this.btn_sup);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_ajo);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_num);
            this.Name = "Variete";
            this.Text = "Variete";
            this.Load += new System.EventHandler(this.Variete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Button btn_sup;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_ajo;
        private System.Windows.Forms.ComboBox CB_num;
    }
}