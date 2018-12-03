namespace Projet2BD
{
    partial class MettreAJourAbonnes
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
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgAbonnes = new System.Windows.Forms.DataGridView();
            this.tbId_dgAbonnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDateAbonnement_dgAbonnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNom_dgAbonnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPrenom_dgAbonnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddlSexes_dgAbonnes = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sexeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDateNaissance_dgAbonnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNoCivique_dgAbonnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbRue_dgAbonnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbVille_dgAbonnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddlProvinces_dgAbonnes = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCodePostal_dgAbonnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTelephone_dgAbonnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCellulaire_dgAbonnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCourriel_dgAbonnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddlTypesAbonnement_dgAbonnes = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbRemarque_dgAbonnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAbonnes = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDependants = new System.Windows.Forms.Label();
            this.dependantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgDependants = new System.Windows.Forms.DataGridView();
            this.tbId_dgDependants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNom_dgDependants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPrenom_dgDependants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddlSexes_dgDependants = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tbDateNaissance_dgDependants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbIdAbonnement_dgDependants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbRemarque_dgDependants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMettreAJourAbonnes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDependants)).BeginInit();
            this.SuspendLayout();
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataSource = typeof(Projet2BD.Abonnements);
            // 
            // dgAbonnes
            // 
            this.dgAbonnes.AllowUserToAddRows = false;
            this.dgAbonnes.AllowUserToDeleteRows = false;
            this.dgAbonnes.AutoGenerateColumns = false;
            this.dgAbonnes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAbonnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAbonnes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbId_dgAbonnes,
            this.tbDateAbonnement_dgAbonnes,
            this.tbNom_dgAbonnes,
            this.tbPrenom_dgAbonnes,
            this.ddlSexes_dgAbonnes,
            this.tbDateNaissance_dgAbonnes,
            this.tbNoCivique_dgAbonnes,
            this.tbRue_dgAbonnes,
            this.tbVille_dgAbonnes,
            this.ddlProvinces_dgAbonnes,
            this.tbCodePostal_dgAbonnes,
            this.tbTelephone_dgAbonnes,
            this.tbCellulaire_dgAbonnes,
            this.tbCourriel_dgAbonnes,
            this.ddlTypesAbonnement_dgAbonnes,
            this.tbRemarque_dgAbonnes});
            this.dgAbonnes.DataSource = this.abonnementsBindingSource;
            this.dgAbonnes.Location = new System.Drawing.Point(20, 52);
            this.dgAbonnes.MultiSelect = false;
            this.dgAbonnes.Name = "dgAbonnes";
            this.dgAbonnes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAbonnes.Size = new System.Drawing.Size(1800, 300);
            this.dgAbonnes.TabIndex = 1;
            this.dgAbonnes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAbonnes_CellEndEdit);
            this.dgAbonnes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgAbonnes_CellFormatting);
            this.dgAbonnes.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dgAbonnes_CellParsing);
            this.dgAbonnes.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgAbonnes_CellValidating);
            this.dgAbonnes.SelectionChanged += new System.EventHandler(this.dgAbonnes_SelectionChanged);
            // 
            // tbId_dgAbonnes
            // 
            this.tbId_dgAbonnes.DataPropertyName = "Id";
            this.tbId_dgAbonnes.FillWeight = 75F;
            this.tbId_dgAbonnes.HeaderText = "Id";
            this.tbId_dgAbonnes.Name = "tbId_dgAbonnes";
            this.tbId_dgAbonnes.ReadOnly = true;
            // 
            // tbDateAbonnement_dgAbonnes
            // 
            this.tbDateAbonnement_dgAbonnes.DataPropertyName = "DateAbonnement";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.tbDateAbonnement_dgAbonnes.DefaultCellStyle = dataGridViewCellStyle1;
            this.tbDateAbonnement_dgAbonnes.FillWeight = 125F;
            this.tbDateAbonnement_dgAbonnes.HeaderText = "Date d\'abonnement";
            this.tbDateAbonnement_dgAbonnes.Name = "tbDateAbonnement_dgAbonnes";
            this.tbDateAbonnement_dgAbonnes.ReadOnly = true;
            // 
            // tbNom_dgAbonnes
            // 
            this.tbNom_dgAbonnes.DataPropertyName = "Nom";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.tbNom_dgAbonnes.DefaultCellStyle = dataGridViewCellStyle2;
            this.tbNom_dgAbonnes.FillWeight = 75F;
            this.tbNom_dgAbonnes.HeaderText = "Nom";
            this.tbNom_dgAbonnes.Name = "tbNom_dgAbonnes";
            this.tbNom_dgAbonnes.ReadOnly = true;
            // 
            // tbPrenom_dgAbonnes
            // 
            this.tbPrenom_dgAbonnes.DataPropertyName = "Prenom";
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.tbPrenom_dgAbonnes.DefaultCellStyle = dataGridViewCellStyle3;
            this.tbPrenom_dgAbonnes.FillWeight = 75F;
            this.tbPrenom_dgAbonnes.HeaderText = "Prénom";
            this.tbPrenom_dgAbonnes.MaxInputLength = 50;
            this.tbPrenom_dgAbonnes.Name = "tbPrenom_dgAbonnes";
            // 
            // ddlSexes_dgAbonnes
            // 
            this.ddlSexes_dgAbonnes.DataPropertyName = "Sexe";
            this.ddlSexes_dgAbonnes.DataSource = this.sexeBindingSource;
            this.ddlSexes_dgAbonnes.DisplayMember = "Nom";
            this.ddlSexes_dgAbonnes.FillWeight = 75F;
            this.ddlSexes_dgAbonnes.HeaderText = "Sexe";
            this.ddlSexes_dgAbonnes.Name = "ddlSexes_dgAbonnes";
            this.ddlSexes_dgAbonnes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ddlSexes_dgAbonnes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ddlSexes_dgAbonnes.ValueMember = "Id";
            // 
            // sexeBindingSource
            // 
            this.sexeBindingSource.DataSource = typeof(Projet2BD.Sexe);
            // 
            // tbDateNaissance_dgAbonnes
            // 
            this.tbDateNaissance_dgAbonnes.DataPropertyName = "DateNaissance";
            dataGridViewCellStyle4.Format = "D";
            dataGridViewCellStyle4.NullValue = null;
            this.tbDateNaissance_dgAbonnes.DefaultCellStyle = dataGridViewCellStyle4;
            this.tbDateNaissance_dgAbonnes.FillWeight = 125F;
            this.tbDateNaissance_dgAbonnes.HeaderText = "Date de naissance";
            this.tbDateNaissance_dgAbonnes.Name = "tbDateNaissance_dgAbonnes";
            this.tbDateNaissance_dgAbonnes.ReadOnly = true;
            this.tbDateNaissance_dgAbonnes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tbNoCivique_dgAbonnes
            // 
            this.tbNoCivique_dgAbonnes.DataPropertyName = "NoCivique";
            dataGridViewCellStyle5.Format = "D";
            dataGridViewCellStyle5.NullValue = null;
            this.tbNoCivique_dgAbonnes.DefaultCellStyle = dataGridViewCellStyle5;
            this.tbNoCivique_dgAbonnes.FillWeight = 50F;
            this.tbNoCivique_dgAbonnes.HeaderText = "N° civique";
            this.tbNoCivique_dgAbonnes.MaxInputLength = 4;
            this.tbNoCivique_dgAbonnes.Name = "tbNoCivique_dgAbonnes";
            // 
            // tbRue_dgAbonnes
            // 
            this.tbRue_dgAbonnes.DataPropertyName = "Rue";
            dataGridViewCellStyle6.Format = "D";
            dataGridViewCellStyle6.NullValue = null;
            this.tbRue_dgAbonnes.DefaultCellStyle = dataGridViewCellStyle6;
            this.tbRue_dgAbonnes.HeaderText = "Rue";
            this.tbRue_dgAbonnes.MaxInputLength = 50;
            this.tbRue_dgAbonnes.Name = "tbRue_dgAbonnes";
            // 
            // tbVille_dgAbonnes
            // 
            this.tbVille_dgAbonnes.DataPropertyName = "Ville";
            dataGridViewCellStyle7.Format = "D";
            dataGridViewCellStyle7.NullValue = null;
            this.tbVille_dgAbonnes.DefaultCellStyle = dataGridViewCellStyle7;
            this.tbVille_dgAbonnes.FillWeight = 150F;
            this.tbVille_dgAbonnes.HeaderText = "Ville";
            this.tbVille_dgAbonnes.MaxInputLength = 50;
            this.tbVille_dgAbonnes.Name = "tbVille_dgAbonnes";
            // 
            // ddlProvinces_dgAbonnes
            // 
            this.ddlProvinces_dgAbonnes.DataPropertyName = "IdProvince";
            this.ddlProvinces_dgAbonnes.DataSource = this.provincesBindingSource;
            this.ddlProvinces_dgAbonnes.DisplayMember = "Nom";
            this.ddlProvinces_dgAbonnes.FillWeight = 150F;
            this.ddlProvinces_dgAbonnes.HeaderText = "Province";
            this.ddlProvinces_dgAbonnes.Name = "ddlProvinces_dgAbonnes";
            this.ddlProvinces_dgAbonnes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ddlProvinces_dgAbonnes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ddlProvinces_dgAbonnes.ValueMember = "Id";
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataSource = typeof(Projet2BD.Provinces);
            // 
            // tbCodePostal_dgAbonnes
            // 
            this.tbCodePostal_dgAbonnes.DataPropertyName = "CodePostal";
            this.tbCodePostal_dgAbonnes.FillWeight = 60F;
            this.tbCodePostal_dgAbonnes.HeaderText = "Code postal";
            this.tbCodePostal_dgAbonnes.MaxInputLength = 7;
            this.tbCodePostal_dgAbonnes.Name = "tbCodePostal_dgAbonnes";
            // 
            // tbTelephone_dgAbonnes
            // 
            this.tbTelephone_dgAbonnes.DataPropertyName = "Telephone";
            dataGridViewCellStyle8.Format = "\"(###) ###-####\"";
            this.tbTelephone_dgAbonnes.DefaultCellStyle = dataGridViewCellStyle8;
            this.tbTelephone_dgAbonnes.HeaderText = "Téléphone";
            this.tbTelephone_dgAbonnes.MaxInputLength = 14;
            this.tbTelephone_dgAbonnes.Name = "tbTelephone_dgAbonnes";
            this.tbTelephone_dgAbonnes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tbCellulaire_dgAbonnes
            // 
            this.tbCellulaire_dgAbonnes.DataPropertyName = "Cellulaire";
            dataGridViewCellStyle9.Format = "\"(###) ###-####\"";
            this.tbCellulaire_dgAbonnes.DefaultCellStyle = dataGridViewCellStyle9;
            this.tbCellulaire_dgAbonnes.HeaderText = "Cellulaire";
            this.tbCellulaire_dgAbonnes.MaxInputLength = 14;
            this.tbCellulaire_dgAbonnes.Name = "tbCellulaire_dgAbonnes";
            this.tbCellulaire_dgAbonnes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tbCourriel_dgAbonnes
            // 
            this.tbCourriel_dgAbonnes.DataPropertyName = "Courriel";
            dataGridViewCellStyle10.Format = "\"(###) ###-####\"";
            this.tbCourriel_dgAbonnes.DefaultCellStyle = dataGridViewCellStyle10;
            this.tbCourriel_dgAbonnes.FillWeight = 150F;
            this.tbCourriel_dgAbonnes.HeaderText = "Courriel";
            this.tbCourriel_dgAbonnes.MaxInputLength = 100;
            this.tbCourriel_dgAbonnes.Name = "tbCourriel_dgAbonnes";
            this.tbCourriel_dgAbonnes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ddlTypesAbonnement_dgAbonnes
            // 
            this.ddlTypesAbonnement_dgAbonnes.DataPropertyName = "NoTypeAbonnement";
            this.ddlTypesAbonnement_dgAbonnes.DataSource = this.typesAbonnementBindingSource;
            this.ddlTypesAbonnement_dgAbonnes.DisplayMember = "Description";
            this.ddlTypesAbonnement_dgAbonnes.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ddlTypesAbonnement_dgAbonnes.FillWeight = 150F;
            this.ddlTypesAbonnement_dgAbonnes.HeaderText = "Type d\'abonnement";
            this.ddlTypesAbonnement_dgAbonnes.Name = "ddlTypesAbonnement_dgAbonnes";
            this.ddlTypesAbonnement_dgAbonnes.ReadOnly = true;
            this.ddlTypesAbonnement_dgAbonnes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ddlTypesAbonnement_dgAbonnes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ddlTypesAbonnement_dgAbonnes.ValueMember = "No";
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(Projet2BD.TypesAbonnement);
            // 
            // tbRemarque_dgAbonnes
            // 
            this.tbRemarque_dgAbonnes.DataPropertyName = "Remarque";
            this.tbRemarque_dgAbonnes.FillWeight = 200F;
            this.tbRemarque_dgAbonnes.HeaderText = "Remarque";
            this.tbRemarque_dgAbonnes.MaxInputLength = 500;
            this.tbRemarque_dgAbonnes.Name = "tbRemarque_dgAbonnes";
            // 
            // lblAbonnes
            // 
            this.lblAbonnes.AutoSize = true;
            this.lblAbonnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbonnes.Location = new System.Drawing.Point(20, 20);
            this.lblAbonnes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbonnes.Name = "lblAbonnes";
            this.lblAbonnes.Size = new System.Drawing.Size(71, 17);
            this.lblAbonnes.TabIndex = 22;
            this.lblAbonnes.Text = "Abonnés";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Telephone";
            dataGridViewCellStyle11.Format = "\"(###) ###-####\"";
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn11.HeaderText = "Telephone";
            this.dataGridViewTextBoxColumn11.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Cellulaire";
            dataGridViewCellStyle12.Format = "\"(###) ###-####\"";
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn12.HeaderText = "Cellulaire";
            this.dataGridViewTextBoxColumn12.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lblDependants
            // 
            this.lblDependants.AutoSize = true;
            this.lblDependants.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDependants.Location = new System.Drawing.Point(20, 382);
            this.lblDependants.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDependants.Name = "lblDependants";
            this.lblDependants.Size = new System.Drawing.Size(95, 17);
            this.lblDependants.TabIndex = 23;
            this.lblDependants.Text = "Dépendants";
            // 
            // dependantsBindingSource
            // 
            this.dependantsBindingSource.DataSource = typeof(Projet2BD.Dependants);
            // 
            // dgDependants
            // 
            this.dgDependants.AllowUserToAddRows = false;
            this.dgDependants.AllowUserToDeleteRows = false;
            this.dgDependants.AutoGenerateColumns = false;
            this.dgDependants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDependants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDependants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbId_dgDependants,
            this.tbNom_dgDependants,
            this.tbPrenom_dgDependants,
            this.ddlSexes_dgDependants,
            this.tbDateNaissance_dgDependants,
            this.tbIdAbonnement_dgDependants,
            this.tbRemarque_dgDependants});
            this.dgDependants.DataSource = this.dependantsBindingSource;
            this.dgDependants.Location = new System.Drawing.Point(20, 414);
            this.dgDependants.MultiSelect = false;
            this.dgDependants.Name = "dgDependants";
            this.dgDependants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDependants.Size = new System.Drawing.Size(750, 300);
            this.dgDependants.TabIndex = 23;
            this.dgDependants.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDependants_CellEndEdit);
            this.dgDependants.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgDependants_CellValidating);
            // 
            // tbId_dgDependants
            // 
            this.tbId_dgDependants.DataPropertyName = "Id";
            this.tbId_dgDependants.FillWeight = 75F;
            this.tbId_dgDependants.HeaderText = "Id";
            this.tbId_dgDependants.Name = "tbId_dgDependants";
            this.tbId_dgDependants.ReadOnly = true;
            // 
            // tbNom_dgDependants
            // 
            this.tbNom_dgDependants.DataPropertyName = "Nom";
            this.tbNom_dgDependants.FillWeight = 75F;
            this.tbNom_dgDependants.HeaderText = "Nom";
            this.tbNom_dgDependants.MaxInputLength = 50;
            this.tbNom_dgDependants.Name = "tbNom_dgDependants";
            // 
            // tbPrenom_dgDependants
            // 
            this.tbPrenom_dgDependants.DataPropertyName = "Prenom";
            this.tbPrenom_dgDependants.FillWeight = 75F;
            this.tbPrenom_dgDependants.HeaderText = "Prénom";
            this.tbPrenom_dgDependants.MaxInputLength = 50;
            this.tbPrenom_dgDependants.Name = "tbPrenom_dgDependants";
            // 
            // ddlSexes_dgDependants
            // 
            this.ddlSexes_dgDependants.DataPropertyName = "Sexe";
            this.ddlSexes_dgDependants.DataSource = this.sexeBindingSource;
            this.ddlSexes_dgDependants.DisplayMember = "Nom";
            this.ddlSexes_dgDependants.FillWeight = 75F;
            this.ddlSexes_dgDependants.HeaderText = "Sexe";
            this.ddlSexes_dgDependants.Name = "ddlSexes_dgDependants";
            this.ddlSexes_dgDependants.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ddlSexes_dgDependants.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ddlSexes_dgDependants.ValueMember = "Id";
            // 
            // tbDateNaissance_dgDependants
            // 
            this.tbDateNaissance_dgDependants.DataPropertyName = "DateNaissance";
            dataGridViewCellStyle13.Format = "D";
            dataGridViewCellStyle13.NullValue = null;
            this.tbDateNaissance_dgDependants.DefaultCellStyle = dataGridViewCellStyle13;
            this.tbDateNaissance_dgDependants.FillWeight = 125F;
            this.tbDateNaissance_dgDependants.HeaderText = "Date de naissance";
            this.tbDateNaissance_dgDependants.Name = "tbDateNaissance_dgDependants";
            this.tbDateNaissance_dgDependants.ReadOnly = true;
            // 
            // tbIdAbonnement_dgDependants
            // 
            this.tbIdAbonnement_dgDependants.DataPropertyName = "IdAbonnement";
            this.tbIdAbonnement_dgDependants.FillWeight = 75F;
            this.tbIdAbonnement_dgDependants.HeaderText = "Id de l\'abonnement";
            this.tbIdAbonnement_dgDependants.Name = "tbIdAbonnement_dgDependants";
            this.tbIdAbonnement_dgDependants.ReadOnly = true;
            // 
            // tbRemarque_dgDependants
            // 
            this.tbRemarque_dgDependants.DataPropertyName = "Remarque";
            this.tbRemarque_dgDependants.FillWeight = 200F;
            this.tbRemarque_dgDependants.HeaderText = "Remarque";
            this.tbRemarque_dgDependants.MaxInputLength = 500;
            this.tbRemarque_dgDependants.Name = "tbRemarque_dgDependants";
            // 
            // btnMettreAJourAbonnes
            // 
            this.btnMettreAJourAbonnes.Location = new System.Drawing.Point(834, 729);
            this.btnMettreAJourAbonnes.Name = "btnMettreAJourAbonnes";
            this.btnMettreAJourAbonnes.Size = new System.Drawing.Size(172, 34);
            this.btnMettreAJourAbonnes.TabIndex = 24;
            this.btnMettreAJourAbonnes.Text = "Enregistrer les modifications";
            this.btnMettreAJourAbonnes.UseVisualStyleBackColor = true;
            this.btnMettreAJourAbonnes.Click += new System.EventHandler(this.btnMettreAJourAbonnes_Click);
            // 
            // MettreAJourAbonnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 783);
            this.Controls.Add(this.btnMettreAJourAbonnes);
            this.Controls.Add(this.dgDependants);
            this.Controls.Add(this.lblDependants);
            this.Controls.Add(this.lblAbonnes);
            this.Controls.Add(this.dgAbonnes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MettreAJourAbonnes";
            this.ShowIcon = false;
            this.Text = "Mettre à jour les abonnés";
            this.Load += new System.EventHandler(this.MettreAJourAbonnes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDependants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private System.Windows.Forms.DataGridView dgAbonnes;
        private System.Windows.Forms.Label lblAbonnes;
        private System.Windows.Forms.BindingSource sexeBindingSource;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label lblDependants;
        private System.Windows.Forms.BindingSource dependantsBindingSource;
        private System.Windows.Forms.DataGridView dgDependants;
        private System.Windows.Forms.Button btnMettreAJourAbonnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbId_dgDependants;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbNom_dgDependants;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbPrenom_dgDependants;
        private System.Windows.Forms.DataGridViewComboBoxColumn ddlSexes_dgDependants;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbDateNaissance_dgDependants;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbIdAbonnement_dgDependants;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbRemarque_dgDependants;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbId_dgAbonnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbDateAbonnement_dgAbonnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbNom_dgAbonnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbPrenom_dgAbonnes;
        private System.Windows.Forms.DataGridViewComboBoxColumn ddlSexes_dgAbonnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbDateNaissance_dgAbonnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbNoCivique_dgAbonnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbRue_dgAbonnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbVille_dgAbonnes;
        private System.Windows.Forms.DataGridViewComboBoxColumn ddlProvinces_dgAbonnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbCodePostal_dgAbonnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbTelephone_dgAbonnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbCellulaire_dgAbonnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbCourriel_dgAbonnes;
        private System.Windows.Forms.DataGridViewComboBoxColumn ddlTypesAbonnement_dgAbonnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbRemarque_dgAbonnes;
    }
}