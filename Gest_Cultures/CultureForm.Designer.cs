namespace Gest_Cultures
{
    partial class CultureForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_grain = new System.Windows.Forms.TextBox();
            this.CB = new System.Windows.Forms.ComboBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_pailles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ajo = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_sup = new System.Windows.Forms.Button();
            this.check_phyto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(178, 80);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(140, 20);
            this.txt_num.TabIndex = 0;
            // 
            // txt_grain
            // 
            this.txt_grain.Location = new System.Drawing.Point(178, 158);
            this.txt_grain.Name = "txt_grain";
            this.txt_grain.Size = new System.Drawing.Size(140, 20);
            this.txt_grain.TabIndex = 6;
            // 
            // CB
            // 
            this.CB.FormattingEnabled = true;
            this.CB.Location = new System.Drawing.Point(178, 39);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(140, 21);
            this.CB.TabIndex = 18;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(178, 120);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(140, 20);
            this.txt_nom.TabIndex = 20;
            // 
            // txt_pailles
            // 
            this.txt_pailles.Location = new System.Drawing.Point(178, 196);
            this.txt_pailles.Name = "txt_pailles";
            this.txt_pailles.Size = new System.Drawing.Size(140, 20);
            this.txt_pailles.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nom Culture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Num Culture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Coefficient d\'exportation grain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Coefficient d\'exportation Pailles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Phyto-sanitaire";
            // 
            // btn_ajo
            // 
            this.btn_ajo.Location = new System.Drawing.Point(417, 39);
            this.btn_ajo.Name = "btn_ajo";
            this.btn_ajo.Size = new System.Drawing.Size(75, 23);
            this.btn_ajo.TabIndex = 26;
            this.btn_ajo.Text = "Ajouter";
            this.btn_ajo.UseVisualStyleBackColor = true;
            this.btn_ajo.Click += new System.EventHandler(this.btn_ajo_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Location = new System.Drawing.Point(417, 80);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(75, 23);
            this.btn_mod.TabIndex = 27;
            this.btn_mod.Text = "Modifier";
            this.btn_mod.UseVisualStyleBackColor = true;
            // 
            // btn_sup
            // 
            this.btn_sup.Location = new System.Drawing.Point(417, 120);
            this.btn_sup.Name = "btn_sup";
            this.btn_sup.Size = new System.Drawing.Size(75, 23);
            this.btn_sup.TabIndex = 28;
            this.btn_sup.Text = "Supprimer";
            this.btn_sup.UseVisualStyleBackColor = true;
            // 
            // check_phyto
            // 
            this.check_phyto.AutoSize = true;
            this.check_phyto.Location = new System.Drawing.Point(199, 234);
            this.check_phyto.Name = "check_phyto";
            this.check_phyto.Size = new System.Drawing.Size(80, 17);
            this.check_phyto.TabIndex = 29;
            this.check_phyto.Text = "checkBox1";
            this.check_phyto.UseVisualStyleBackColor = true;
            // 
            // Culture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 288);
            this.Controls.Add(this.check_phyto);
            this.Controls.Add(this.btn_sup);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_ajo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_pailles);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.txt_grain);
            this.Controls.Add(this.txt_num);
            this.Name = "Culture";
            this.Text = "Culture";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_grain;
        private System.Windows.Forms.ComboBox CB;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_pailles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ajo;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_sup;
        private System.Windows.Forms.CheckBox check_phyto;
    }
}

