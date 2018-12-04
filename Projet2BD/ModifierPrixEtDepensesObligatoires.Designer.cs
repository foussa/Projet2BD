namespace Projet2BD
{
    partial class ModifierPrixEtDepensesObligatoires
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.noTypeAbonnementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anneeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depensesObligatoiresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typesAbonnementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDepensesAbonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgPrixDepensesAbonnements = new System.Windows.Forms.DataGridView();
            this.ddlTypesAbonnement_dgPrixDepensesAbonnements = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbPrix_PrixDepensesAbonnements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDepensesObligatoires_PrixDepensesAbonnements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbRemarque_PrixDepensesAbonnements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModifierPrixEtDepensesObligatoires = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrixDepensesAbonnements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noTypeAbonnementDataGridViewTextBoxColumn
            // 
            this.noTypeAbonnementDataGridViewTextBoxColumn.DataPropertyName = "NoTypeAbonnement";
            this.noTypeAbonnementDataGridViewTextBoxColumn.HeaderText = "NoTypeAbonnement";
            this.noTypeAbonnementDataGridViewTextBoxColumn.Name = "noTypeAbonnementDataGridViewTextBoxColumn";
            // 
            // anneeDataGridViewTextBoxColumn
            // 
            this.anneeDataGridViewTextBoxColumn.DataPropertyName = "Annee";
            this.anneeDataGridViewTextBoxColumn.HeaderText = "Annee";
            this.anneeDataGridViewTextBoxColumn.Name = "anneeDataGridViewTextBoxColumn";
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            // 
            // depensesObligatoiresDataGridViewTextBoxColumn
            // 
            this.depensesObligatoiresDataGridViewTextBoxColumn.DataPropertyName = "DepensesObligatoires";
            this.depensesObligatoiresDataGridViewTextBoxColumn.HeaderText = "DepensesObligatoires";
            this.depensesObligatoiresDataGridViewTextBoxColumn.Name = "depensesObligatoiresDataGridViewTextBoxColumn";
            // 
            // remarqueDataGridViewTextBoxColumn
            // 
            this.remarqueDataGridViewTextBoxColumn.DataPropertyName = "Remarque";
            this.remarqueDataGridViewTextBoxColumn.HeaderText = "Remarque";
            this.remarqueDataGridViewTextBoxColumn.Name = "remarqueDataGridViewTextBoxColumn";
            // 
            // typesAbonnementDataGridViewTextBoxColumn
            // 
            this.typesAbonnementDataGridViewTextBoxColumn.DataPropertyName = "TypesAbonnement";
            this.typesAbonnementDataGridViewTextBoxColumn.HeaderText = "TypesAbonnement";
            this.typesAbonnementDataGridViewTextBoxColumn.Name = "typesAbonnementDataGridViewTextBoxColumn";
            // 
            // prixDepensesAbonnementsBindingSource
            // 
            this.prixDepensesAbonnementsBindingSource.DataSource = typeof(System.Data.Linq.EntitySet<Projet2BD.PrixDepensesAbonnements>);
            // 
            // dgPrixDepensesAbonnements
            // 
            this.dgPrixDepensesAbonnements.AllowUserToAddRows = false;
            this.dgPrixDepensesAbonnements.AllowUserToDeleteRows = false;
            this.dgPrixDepensesAbonnements.AutoGenerateColumns = false;
            this.dgPrixDepensesAbonnements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPrixDepensesAbonnements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrixDepensesAbonnements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ddlTypesAbonnement_dgPrixDepensesAbonnements,
            this.tbPrix_PrixDepensesAbonnements,
            this.tbDepensesObligatoires_PrixDepensesAbonnements,
            this.tbRemarque_PrixDepensesAbonnements});
            this.dgPrixDepensesAbonnements.DataSource = this.prixDepensesAbonnementsBindingSource;
            this.dgPrixDepensesAbonnements.Location = new System.Drawing.Point(20, 20);
            this.dgPrixDepensesAbonnements.MultiSelect = false;
            this.dgPrixDepensesAbonnements.Name = "dgPrixDepensesAbonnements";
            this.dgPrixDepensesAbonnements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPrixDepensesAbonnements.Size = new System.Drawing.Size(600, 175);
            this.dgPrixDepensesAbonnements.TabIndex = 1;
            this.dgPrixDepensesAbonnements.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPrixDepensesAbonnements_CellEndEdit);
            this.dgPrixDepensesAbonnements.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgPrixDepensesAbonnements_CellValidating);
            // 
            // ddlTypesAbonnement_dgPrixDepensesAbonnements
            // 
            this.ddlTypesAbonnement_dgPrixDepensesAbonnements.DataPropertyName = "NoTypeAbonnement";
            this.ddlTypesAbonnement_dgPrixDepensesAbonnements.DataSource = this.typesAbonnementBindingSource;
            this.ddlTypesAbonnement_dgPrixDepensesAbonnements.DisplayMember = "Description";
            this.ddlTypesAbonnement_dgPrixDepensesAbonnements.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ddlTypesAbonnement_dgPrixDepensesAbonnements.FillWeight = 150F;
            this.ddlTypesAbonnement_dgPrixDepensesAbonnements.HeaderText = "Type d\'abonnement";
            this.ddlTypesAbonnement_dgPrixDepensesAbonnements.Name = "ddlTypesAbonnement_dgPrixDepensesAbonnements";
            this.ddlTypesAbonnement_dgPrixDepensesAbonnements.ReadOnly = true;
            this.ddlTypesAbonnement_dgPrixDepensesAbonnements.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ddlTypesAbonnement_dgPrixDepensesAbonnements.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ddlTypesAbonnement_dgPrixDepensesAbonnements.ValueMember = "No";
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(Projet2BD.TypesAbonnement);
            // 
            // tbPrix_PrixDepensesAbonnements
            // 
            this.tbPrix_PrixDepensesAbonnements.DataPropertyName = "Prix";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.tbPrix_PrixDepensesAbonnements.DefaultCellStyle = dataGridViewCellStyle5;
            this.tbPrix_PrixDepensesAbonnements.HeaderText = "Prix";
            this.tbPrix_PrixDepensesAbonnements.Name = "tbPrix_PrixDepensesAbonnements";
            // 
            // tbDepensesObligatoires_PrixDepensesAbonnements
            // 
            this.tbDepensesObligatoires_PrixDepensesAbonnements.DataPropertyName = "DepensesObligatoires";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.tbDepensesObligatoires_PrixDepensesAbonnements.DefaultCellStyle = dataGridViewCellStyle6;
            this.tbDepensesObligatoires_PrixDepensesAbonnements.HeaderText = "Dépenses obligatoires";
            this.tbDepensesObligatoires_PrixDepensesAbonnements.Name = "tbDepensesObligatoires_PrixDepensesAbonnements";
            // 
            // tbRemarque_PrixDepensesAbonnements
            // 
            this.tbRemarque_PrixDepensesAbonnements.DataPropertyName = "Remarque";
            this.tbRemarque_PrixDepensesAbonnements.FillWeight = 200F;
            this.tbRemarque_PrixDepensesAbonnements.HeaderText = "Remarque";
            this.tbRemarque_PrixDepensesAbonnements.Name = "tbRemarque_PrixDepensesAbonnements";
            // 
            // btnModifierPrixEtDepensesObligatoires
            // 
            this.btnModifierPrixEtDepensesObligatoires.Location = new System.Drawing.Point(162, 210);
            this.btnModifierPrixEtDepensesObligatoires.Name = "btnModifierPrixEtDepensesObligatoires";
            this.btnModifierPrixEtDepensesObligatoires.Size = new System.Drawing.Size(316, 34);
            this.btnModifierPrixEtDepensesObligatoires.TabIndex = 25;
            this.btnModifierPrixEtDepensesObligatoires.Text = "Modifier les prix et les dépenses obligatoires d\'abonnement";
            this.btnModifierPrixEtDepensesObligatoires.UseVisualStyleBackColor = true;
            this.btnModifierPrixEtDepensesObligatoires.Click += new System.EventHandler(this.btnModifierPrixEtDepensesObligatoires_Click);
            // 
            // ModifierPrixEtDepensesObligatoires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 264);
            this.Controls.Add(this.btnModifierPrixEtDepensesObligatoires);
            this.Controls.Add(this.dgPrixDepensesAbonnements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModifierPrixEtDepensesObligatoires";
            this.ShowIcon = false;
            this.Text = "Modifier un prix et des dépenses obligatoires d’abonnement";
            this.Load += new System.EventHandler(this.ModifierPrixEtDepensesObligatoires_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrixDepensesAbonnements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn noTypeAbonnementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anneeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depensesObligatoiresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typesAbonnementDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource prixDepensesAbonnementsBindingSource;
        private System.Windows.Forms.DataGridView dgPrixDepensesAbonnements;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.Button btnModifierPrixEtDepensesObligatoires;
        private System.Windows.Forms.DataGridViewComboBoxColumn ddlTypesAbonnement_dgPrixDepensesAbonnements;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbPrix_PrixDepensesAbonnements;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbDepensesObligatoires_PrixDepensesAbonnements;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbRemarque_PrixDepensesAbonnements;
    }
}