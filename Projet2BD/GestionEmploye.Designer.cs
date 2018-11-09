namespace Projet2BD
{
    partial class GestionEmploye
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
            this.components = new System.ComponentModel.Container();
            this.bD5B6TP2_BrodeurKoumaDataSet = new Projet2BD.BD5B6TP2_BrodeurKoumaDataSet();
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employesTableAdapter = new Projet2BD.BD5B6TP2_BrodeurKoumaDataSetTableAdapters.EmployesTableAdapter();
            this.tableAdapterManager = new Projet2BD.BD5B6TP2_BrodeurKoumaDataSetTableAdapters.TableAdapterManager();
            this.employesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewtbNoEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewtbMDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewtbNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewtbPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewtbSexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewtbAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewtbNoCivique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewtbRue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewtbVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewtbProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewtbCodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewtbTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewtbCel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewtbCourriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewtbSalaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewtbTypeEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewtbRemarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP2_BrodeurKoumaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bD5B6TP2_BrodeurKoumaDataSet
            // 
            this.bD5B6TP2_BrodeurKoumaDataSet.DataSetName = "BD5B6TP2_BrodeurKoumaDataSet";
            this.bD5B6TP2_BrodeurKoumaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employesBindingSource
            // 
            this.employesBindingSource.DataMember = "Employes";
            this.employesBindingSource.DataSource = this.bD5B6TP2_BrodeurKoumaDataSet;
            // 
            // employesTableAdapter
            // 
            this.employesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbonnementsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DependantsTableAdapter = null;
            this.tableAdapterManager.DepensesTableAdapter = null;
            this.tableAdapterManager.EmployesTableAdapter = this.employesTableAdapter;
            this.tableAdapterManager.PartiesJoueesTableAdapter = null;
            this.tableAdapterManager.PrixDepensesAbonnementsTableAdapter = null;
            this.tableAdapterManager.ProvincesTableAdapter = null;
            this.tableAdapterManager.ReabonnementsTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TerrainsTableAdapter = null;
            this.tableAdapterManager.TypesAbonnementTableAdapter = null;
            this.tableAdapterManager.TypesEmployeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet2BD.BD5B6TP2_BrodeurKoumaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employesDataGridView
            // 
            this.employesDataGridView.AutoGenerateColumns = false;
            this.employesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewtbNoEmp,
            this.dataGridViewtbMDP,
            this.dataGridViewtbNom,
            this.dataGridViewtbPrenom,
            this.dataGridViewtbSexe,
            this.dataGridViewtbAge,
            this.dataGridViewtbNoCivique,
            this.dataGridViewtbRue,
            this.dataGridViewtbVille,
            this.dataGridViewtbProvince,
            this.dataGridViewtbCodePostal,
            this.dataGridViewtbTel,
            this.dataGridViewtbCel,
            this.dataGridViewtbCourriel,
            this.dataGridViewtbSalaire,
            this.dataGridViewtbTypeEmp,
            this.dataGridViewtbRemarque});
            this.employesDataGridView.DataSource = this.employesBindingSource;
            this.employesDataGridView.Location = new System.Drawing.Point(3, 2);
            this.employesDataGridView.Name = "employesDataGridView";
            this.employesDataGridView.Size = new System.Drawing.Size(1061, 220);
            this.employesDataGridView.TabIndex = 1;
            // 
            // dataGridViewtbNoEmp
            // 
            this.dataGridViewtbNoEmp.DataPropertyName = "No";
            this.dataGridViewtbNoEmp.HeaderText = "No d\'employé";
            this.dataGridViewtbNoEmp.Name = "dataGridViewtbNoEmp";
            // 
            // dataGridViewtbMDP
            // 
            this.dataGridViewtbMDP.DataPropertyName = "MotDePasse";
            this.dataGridViewtbMDP.HeaderText = "Mot De Passe";
            this.dataGridViewtbMDP.Name = "dataGridViewtbMDP";
            // 
            // dataGridViewtbNom
            // 
            this.dataGridViewtbNom.DataPropertyName = "Nom";
            this.dataGridViewtbNom.HeaderText = "Nom";
            this.dataGridViewtbNom.Name = "dataGridViewtbNom";
            // 
            // dataGridViewtbPrenom
            // 
            this.dataGridViewtbPrenom.DataPropertyName = "Prenom";
            this.dataGridViewtbPrenom.HeaderText = "Prenom";
            this.dataGridViewtbPrenom.Name = "dataGridViewtbPrenom";
            // 
            // dataGridViewtbSexe
            // 
            this.dataGridViewtbSexe.DataPropertyName = "Sexe";
            this.dataGridViewtbSexe.HeaderText = "Sexe";
            this.dataGridViewtbSexe.Name = "dataGridViewtbSexe";
            // 
            // dataGridViewtbAge
            // 
            this.dataGridViewtbAge.DataPropertyName = "Age";
            this.dataGridViewtbAge.HeaderText = "Age";
            this.dataGridViewtbAge.Name = "dataGridViewtbAge";
            // 
            // dataGridViewtbNoCivique
            // 
            this.dataGridViewtbNoCivique.DataPropertyName = "NoCivique";
            this.dataGridViewtbNoCivique.HeaderText = "No Civique";
            this.dataGridViewtbNoCivique.Name = "dataGridViewtbNoCivique";
            // 
            // dataGridViewtbRue
            // 
            this.dataGridViewtbRue.DataPropertyName = "Rue";
            this.dataGridViewtbRue.HeaderText = "Rue";
            this.dataGridViewtbRue.Name = "dataGridViewtbRue";
            // 
            // dataGridViewtbVille
            // 
            this.dataGridViewtbVille.DataPropertyName = "Ville";
            this.dataGridViewtbVille.HeaderText = "Ville";
            this.dataGridViewtbVille.Name = "dataGridViewtbVille";
            // 
            // dataGridViewtbProvince
            // 
            this.dataGridViewtbProvince.DataPropertyName = "IdProvince";
            this.dataGridViewtbProvince.HeaderText = "Province";
            this.dataGridViewtbProvince.Name = "dataGridViewtbProvince";
            // 
            // dataGridViewtbCodePostal
            // 
            this.dataGridViewtbCodePostal.DataPropertyName = "CodePostal";
            this.dataGridViewtbCodePostal.HeaderText = "Code Postal";
            this.dataGridViewtbCodePostal.Name = "dataGridViewtbCodePostal";
            // 
            // dataGridViewtbTel
            // 
            this.dataGridViewtbTel.DataPropertyName = "Telephone";
            this.dataGridViewtbTel.HeaderText = "Telephone";
            this.dataGridViewtbTel.Name = "dataGridViewtbTel";
            // 
            // dataGridViewtbCel
            // 
            this.dataGridViewtbCel.DataPropertyName = "Cellulaire";
            this.dataGridViewtbCel.HeaderText = "Cellulaire";
            this.dataGridViewtbCel.Name = "dataGridViewtbCel";
            // 
            // dataGridViewtbCourriel
            // 
            this.dataGridViewtbCourriel.DataPropertyName = "Courriel";
            this.dataGridViewtbCourriel.HeaderText = "Courriel";
            this.dataGridViewtbCourriel.Name = "dataGridViewtbCourriel";
            // 
            // dataGridViewtbSalaire
            // 
            this.dataGridViewtbSalaire.DataPropertyName = "SalaireHoraire";
            this.dataGridViewtbSalaire.HeaderText = "Taux Horaire";
            this.dataGridViewtbSalaire.Name = "dataGridViewtbSalaire";
            // 
            // dataGridViewtbTypeEmp
            // 
            this.dataGridViewtbTypeEmp.DataPropertyName = "NoTypeEmploye";
            this.dataGridViewtbTypeEmp.HeaderText = "No du Type d\'Employe";
            this.dataGridViewtbTypeEmp.Name = "dataGridViewtbTypeEmp";
            // 
            // dataGridViewtbRemarque
            // 
            this.dataGridViewtbRemarque.DataPropertyName = "Remarque";
            this.dataGridViewtbRemarque.HeaderText = "Remarque";
            this.dataGridViewtbRemarque.Name = "dataGridViewtbRemarque";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(21, 238);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(85, 31);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // GestionEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 450);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.employesDataGridView);
            this.Name = "GestionEmploye";
            this.Text = "Gestion des employés";
            this.Load += new System.EventHandler(this.GestionEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP2_BrodeurKoumaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BD5B6TP2_BrodeurKoumaDataSet bD5B6TP2_BrodeurKoumaDataSet;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private BD5B6TP2_BrodeurKoumaDataSetTableAdapters.EmployesTableAdapter employesTableAdapter;
        private BD5B6TP2_BrodeurKoumaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewtbNoEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewtbMDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewtbNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewtbPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewtbSexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewtbAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewtbNoCivique;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewtbRue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewtbVille;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewtbProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewtbCodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewtbTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewtbCel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewtbCourriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewtbSalaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewtbTypeEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewtbRemarque;
        private System.Windows.Forms.Button btnAjouter;
    }
}

