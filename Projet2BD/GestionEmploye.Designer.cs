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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgEmployes = new System.Windows.Forms.DataGridView();
            this.employeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motDePasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noCiviqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProvinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellulaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courrielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaireHoraireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTypeEmployeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typesEmployeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(352, 215);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(85, 31);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dgEmployes
            // 
            this.dgEmployes.AllowUserToAddRows = false;
            this.dgEmployes.AutoGenerateColumns = false;
            this.dgEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.motDePasseDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.sexeDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.noCiviqueDataGridViewTextBoxColumn,
            this.rueDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.idProvinceDataGridViewTextBoxColumn,
            this.codePostalDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.cellulaireDataGridViewTextBoxColumn,
            this.courrielDataGridViewTextBoxColumn,
            this.salaireHoraireDataGridViewTextBoxColumn,
            this.noTypeEmployeDataGridViewTextBoxColumn,
            this.remarqueDataGridViewTextBoxColumn,
            this.provinceDataGridViewTextBoxColumn,
            this.typesEmployeDataGridViewTextBoxColumn});
            this.dgEmployes.DataSource = this.employeBindingSource;
            this.dgEmployes.Location = new System.Drawing.Point(12, 3);
            this.dgEmployes.MultiSelect = false;
            this.dgEmployes.Name = "dgEmployes";
            this.dgEmployes.Size = new System.Drawing.Size(1052, 196);
            this.dgEmployes.TabIndex = 3;
            // 
            // employeBindingSource
            // 
            this.employeBindingSource.DataSource = typeof(Projet2BD.Employes);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(470, 215);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(85, 31);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(579, 215);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(85, 31);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            // 
            // motDePasseDataGridViewTextBoxColumn
            // 
            this.motDePasseDataGridViewTextBoxColumn.DataPropertyName = "MotDePasse";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motDePasseDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.motDePasseDataGridViewTextBoxColumn.HeaderText = "MotDePasse";
            this.motDePasseDataGridViewTextBoxColumn.Name = "motDePasseDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // sexeDataGridViewTextBoxColumn
            // 
            this.sexeDataGridViewTextBoxColumn.DataPropertyName = "Sexe";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.sexeDataGridViewTextBoxColumn.HeaderText = "Sexe";
            this.sexeDataGridViewTextBoxColumn.Name = "sexeDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // noCiviqueDataGridViewTextBoxColumn
            // 
            this.noCiviqueDataGridViewTextBoxColumn.DataPropertyName = "NoCivique";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noCiviqueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.noCiviqueDataGridViewTextBoxColumn.HeaderText = "NoCivique";
            this.noCiviqueDataGridViewTextBoxColumn.Name = "noCiviqueDataGridViewTextBoxColumn";
            // 
            // rueDataGridViewTextBoxColumn
            // 
            this.rueDataGridViewTextBoxColumn.DataPropertyName = "Rue";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.rueDataGridViewTextBoxColumn.HeaderText = "Rue";
            this.rueDataGridViewTextBoxColumn.Name = "rueDataGridViewTextBoxColumn";
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "Ville";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            // 
            // idProvinceDataGridViewTextBoxColumn
            // 
            this.idProvinceDataGridViewTextBoxColumn.DataPropertyName = "IdProvince";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProvinceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.idProvinceDataGridViewTextBoxColumn.HeaderText = "IdProvince";
            this.idProvinceDataGridViewTextBoxColumn.Name = "idProvinceDataGridViewTextBoxColumn";
            // 
            // codePostalDataGridViewTextBoxColumn
            // 
            this.codePostalDataGridViewTextBoxColumn.DataPropertyName = "CodePostal";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codePostalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.codePostalDataGridViewTextBoxColumn.HeaderText = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn.Name = "codePostalDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // cellulaireDataGridViewTextBoxColumn
            // 
            this.cellulaireDataGridViewTextBoxColumn.DataPropertyName = "Cellulaire";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellulaireDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.cellulaireDataGridViewTextBoxColumn.HeaderText = "Cellulaire";
            this.cellulaireDataGridViewTextBoxColumn.Name = "cellulaireDataGridViewTextBoxColumn";
            // 
            // courrielDataGridViewTextBoxColumn
            // 
            this.courrielDataGridViewTextBoxColumn.DataPropertyName = "Courriel";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courrielDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.courrielDataGridViewTextBoxColumn.HeaderText = "Courriel";
            this.courrielDataGridViewTextBoxColumn.Name = "courrielDataGridViewTextBoxColumn";
            // 
            // salaireHoraireDataGridViewTextBoxColumn
            // 
            this.salaireHoraireDataGridViewTextBoxColumn.DataPropertyName = "SalaireHoraire";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaireHoraireDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.salaireHoraireDataGridViewTextBoxColumn.HeaderText = "SalaireHoraire";
            this.salaireHoraireDataGridViewTextBoxColumn.Name = "salaireHoraireDataGridViewTextBoxColumn";
            // 
            // noTypeEmployeDataGridViewTextBoxColumn
            // 
            this.noTypeEmployeDataGridViewTextBoxColumn.DataPropertyName = "NoTypeEmploye";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTypeEmployeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.noTypeEmployeDataGridViewTextBoxColumn.HeaderText = "NoTypeEmploye";
            this.noTypeEmployeDataGridViewTextBoxColumn.Name = "noTypeEmployeDataGridViewTextBoxColumn";
            this.noTypeEmployeDataGridViewTextBoxColumn.Visible = false;
            // 
            // remarqueDataGridViewTextBoxColumn
            // 
            this.remarqueDataGridViewTextBoxColumn.DataPropertyName = "Remarque";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarqueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.remarqueDataGridViewTextBoxColumn.HeaderText = "Remarque";
            this.remarqueDataGridViewTextBoxColumn.Name = "remarqueDataGridViewTextBoxColumn";
            // 
            // provinceDataGridViewTextBoxColumn
            // 
            this.provinceDataGridViewTextBoxColumn.DataPropertyName = "Province";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.provinceDataGridViewTextBoxColumn.HeaderText = "Province";
            this.provinceDataGridViewTextBoxColumn.Name = "provinceDataGridViewTextBoxColumn";
            this.provinceDataGridViewTextBoxColumn.Visible = false;
            // 
            // typesEmployeDataGridViewTextBoxColumn
            // 
            this.typesEmployeDataGridViewTextBoxColumn.DataPropertyName = "TypesEmploye";
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typesEmployeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle19;
            this.typesEmployeDataGridViewTextBoxColumn.HeaderText = "TypesEmploye";
            this.typesEmployeDataGridViewTextBoxColumn.Name = "typesEmployeDataGridViewTextBoxColumn";
            // 
            // GestionEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 258);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.dgEmployes);
            this.Controls.Add(this.btnAjouter);
            this.Name = "GestionEmploye";
            this.Text = "Gestion des employés";
            this.Load += new System.EventHandler(this.GestionEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.BindingSource employeBindingSource;
        private System.Windows.Forms.DataGridView dgEmployes;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motDePasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCiviqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProvinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellulaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courrielDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaireHoraireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTypeEmployeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typesEmployeDataGridViewTextBoxColumn;
    }
}

