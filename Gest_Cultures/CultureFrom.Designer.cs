namespace Gest_Cultures
{
    partial class CultureFrom
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
            this.CB = new System.Windows.Forms.ComboBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_cef = new System.Windows.Forms.TextBox();
            this.txt_ceg = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_sup = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_ajo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB
            // 
            this.CB.FormattingEnabled = true;
            this.CB.Location = new System.Drawing.Point(94, 28);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(140, 21);
            this.CB.TabIndex = 35;
            this.CB.SelectedIndexChanged += new System.EventHandler(this.CB_SelectedIndexChanged);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(94, 106);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(140, 20);
            this.txt_nom.TabIndex = 34;
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(94, 68);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(140, 20);
            this.txt_num.TabIndex = 33;
            // 
            // txt_cef
            // 
            this.txt_cef.Location = new System.Drawing.Point(94, 183);
            this.txt_cef.Name = "txt_cef";
            this.txt_cef.Size = new System.Drawing.Size(140, 20);
            this.txt_cef.TabIndex = 37;
            // 
            // txt_ceg
            // 
            this.txt_ceg.Location = new System.Drawing.Point(94, 145);
            this.txt_ceg.Name = "txt_ceg";
            this.txt_ceg.Size = new System.Drawing.Size(140, 20);
            this.txt_ceg.TabIndex = 36;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(119, 221);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.Text = "Phytosanitaire";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_sup
            // 
            this.btn_sup.Location = new System.Drawing.Point(298, 125);
            this.btn_sup.Name = "btn_sup";
            this.btn_sup.Size = new System.Drawing.Size(75, 23);
            this.btn_sup.TabIndex = 42;
            this.btn_sup.Text = "Supprimer";
            this.btn_sup.UseVisualStyleBackColor = true;
            this.btn_sup.Click += new System.EventHandler(this.btn_sup_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Location = new System.Drawing.Point(298, 85);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(75, 23);
            this.btn_mod.TabIndex = 41;
            this.btn_mod.Text = "Modifier";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // btn_ajo
            // 
            this.btn_ajo.Location = new System.Drawing.Point(298, 44);
            this.btn_ajo.Name = "btn_ajo";
            this.btn_ajo.Size = new System.Drawing.Size(75, 23);
            this.btn_ajo.TabIndex = 40;
            this.btn_ajo.Text = "Ajouter";
            this.btn_ajo.UseVisualStyleBackColor = true;
            this.btn_ajo.Click += new System.EventHandler(this.btn_ajo_Click);
            // 
            // CultureFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 293);
            this.Controls.Add(this.btn_sup);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_ajo);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txt_cef);
            this.Controls.Add(this.txt_ceg);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_num);
            this.Name = "CultureFrom";
            this.Text = "CultureFrom";
            this.Load += new System.EventHandler(this.CultureFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_cef;
        private System.Windows.Forms.TextBox txt_ceg;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_sup;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_ajo;
    }
}