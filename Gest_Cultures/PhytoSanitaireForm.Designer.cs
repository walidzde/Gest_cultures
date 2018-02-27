namespace Gest_Cultures
{
    partial class PhytoSanitaireForm
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
            this.components = new System.ComponentModel.Container();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.btn_Enregistrer = new System.Windows.Forms.Button();
            this.gest_CulturesDataSet2 = new Gest_Cultures.Gest_CulturesDataSet2();
            this.parcelleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.parcelleTableAdapter1 = new Gest_Cultures.Gest_CulturesDataSet2TableAdapters.ParcelleTableAdapter();
            this.produitPhytoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gest_CulturesDataSet = new Gest_Cultures.Gest_CulturesDataSet();
            this.produit_PhytoTableAdapter = new Gest_Cultures.Gest_CulturesDataSetTableAdapters.Produit_PhytoTableAdapter();
            this.parcelleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gest_CulturesDataSet1 = new Gest_Cultures.Gest_CulturesDataSet1();
            this.parcelleTableAdapter = new Gest_Cultures.Gest_CulturesDataSet1TableAdapters.ParcelleTableAdapter();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhytoSanitaire = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Parcelle = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CoutHa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoutTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gest_CulturesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitPhytoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gest_CulturesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gest_CulturesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.PhytoSanitaire,
            this.Parcelle,
            this.CoutHa,
            this.CoutTotal});
            this.DGV.Location = new System.Drawing.Point(12, 63);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(553, 213);
            this.DGV.TabIndex = 0;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // btn_Enregistrer
            // 
            this.btn_Enregistrer.Location = new System.Drawing.Point(333, 296);
            this.btn_Enregistrer.Name = "btn_Enregistrer";
            this.btn_Enregistrer.Size = new System.Drawing.Size(75, 23);
            this.btn_Enregistrer.TabIndex = 1;
            this.btn_Enregistrer.Text = "Enregistrer";
            this.btn_Enregistrer.UseVisualStyleBackColor = true;
            this.btn_Enregistrer.Click += new System.EventHandler(this.btn_Enregistrer_Click);
            // 
            // gest_CulturesDataSet2
            // 
            this.gest_CulturesDataSet2.DataSetName = "Gest_CulturesDataSet2";
            this.gest_CulturesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parcelleBindingSource1
            // 
            this.parcelleBindingSource1.DataMember = "Parcelle";
            this.parcelleBindingSource1.DataSource = this.gest_CulturesDataSet2;
            // 
            // parcelleTableAdapter1
            // 
            this.parcelleTableAdapter1.ClearBeforeFill = true;
            // 
            // produitPhytoBindingSource
            // 
            this.produitPhytoBindingSource.DataMember = "Produit_Phyto";
            this.produitPhytoBindingSource.DataSource = this.gest_CulturesDataSet;
            // 
            // gest_CulturesDataSet
            // 
            this.gest_CulturesDataSet.DataSetName = "Gest_CulturesDataSet";
            this.gest_CulturesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produit_PhytoTableAdapter
            // 
            this.produit_PhytoTableAdapter.ClearBeforeFill = true;
            // 
            // parcelleBindingSource
            // 
            this.parcelleBindingSource.DataMember = "Parcelle";
            this.parcelleBindingSource.DataSource = this.gest_CulturesDataSet1;
            // 
            // gest_CulturesDataSet1
            // 
            this.gest_CulturesDataSet1.DataSetName = "Gest_CulturesDataSet1";
            this.gest_CulturesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parcelleTableAdapter
            // 
            this.parcelleTableAdapter.ClearBeforeFill = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // PhytoSanitaire
            // 
            this.PhytoSanitaire.DataSource = this.produitPhytoBindingSource;
            this.PhytoSanitaire.DisplayMember = "RefProduitPhy";
            this.PhytoSanitaire.HeaderText = "Phyto Sanitaire";
            this.PhytoSanitaire.Name = "PhytoSanitaire";
            this.PhytoSanitaire.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PhytoSanitaire.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Parcelle
            // 
            this.Parcelle.DataSource = this.parcelleBindingSource1;
            this.Parcelle.DisplayMember = "NumParcelle";
            this.Parcelle.HeaderText = "Parcelle";
            this.Parcelle.Name = "Parcelle";
            this.Parcelle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Parcelle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CoutHa
            // 
            this.CoutHa.HeaderText = "Cout Ha";
            this.CoutHa.Name = "CoutHa";
            // 
            // CoutTotal
            // 
            this.CoutTotal.HeaderText = "Cout Total";
            this.CoutTotal.Name = "CoutTotal";
            // 
            // PhytoSanitaireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 332);
            this.Controls.Add(this.btn_Enregistrer);
            this.Controls.Add(this.DGV);
            this.Name = "PhytoSanitaireForm";
            this.Text = "PhytoSanitaireForm";
            this.Load += new System.EventHandler(this.PhytoSanitaireForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gest_CulturesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitPhytoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gest_CulturesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gest_CulturesDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button btn_Enregistrer;
        private Gest_CulturesDataSet gest_CulturesDataSet;
        private System.Windows.Forms.BindingSource produitPhytoBindingSource;
        private Gest_CulturesDataSetTableAdapters.Produit_PhytoTableAdapter produit_PhytoTableAdapter;
        private Gest_CulturesDataSet1 gest_CulturesDataSet1;
        private System.Windows.Forms.BindingSource parcelleBindingSource;
        private Gest_CulturesDataSet1TableAdapters.ParcelleTableAdapter parcelleTableAdapter;
        private Gest_CulturesDataSet2 gest_CulturesDataSet2;
        private System.Windows.Forms.BindingSource parcelleBindingSource1;
        private Gest_CulturesDataSet2TableAdapters.ParcelleTableAdapter parcelleTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewComboBoxColumn PhytoSanitaire;
        private System.Windows.Forms.DataGridViewComboBoxColumn Parcelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoutHa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoutTotal;
    }
}