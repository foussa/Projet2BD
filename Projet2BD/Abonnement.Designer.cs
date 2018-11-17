namespace Projet2BD
{
    partial class Abonnement
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
            System.Windows.Forms.Label lblPrenom;
            System.Windows.Forms.Label lblNom;
            System.Windows.Forms.Label lblDateNaissance;
            System.Windows.Forms.Label lblSexe;
            System.Windows.Forms.Label lblNoCivique;
            System.Windows.Forms.Label lblRue;
            System.Windows.Forms.Label lblVille;
            System.Windows.Forms.Label lblCodePostal;
            System.Windows.Forms.Label lblProvince;
            System.Windows.Forms.Label lblCellulaire;
            System.Windows.Forms.Label lblCourriel;
            System.Windows.Forms.Label lblTelephone;
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbNom = new System.Windows.Forms.TextBox();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.ddlProvinces = new System.Windows.Forms.ComboBox();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtbCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.ddlSexes = new System.Windows.Forms.ComboBox();
            this.ddlTypesAbonnement = new System.Windows.Forms.ComboBox();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAbonnePrincipal = new System.Windows.Forms.Label();
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCellulaire = new System.Windows.Forms.MaskedTextBox();
            this.numNoCivique = new System.Windows.Forms.NumericUpDown();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.lblTypeAbonnement = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblRemarque = new System.Windows.Forms.Label();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.sexeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            lblPrenom = new System.Windows.Forms.Label();
            lblNom = new System.Windows.Forms.Label();
            lblDateNaissance = new System.Windows.Forms.Label();
            lblSexe = new System.Windows.Forms.Label();
            lblNoCivique = new System.Windows.Forms.Label();
            lblRue = new System.Windows.Forms.Label();
            lblVille = new System.Windows.Forms.Label();
            lblCodePostal = new System.Windows.Forms.Label();
            lblProvince = new System.Windows.Forms.Label();
            lblCellulaire = new System.Windows.Forms.Label();
            lblCourriel = new System.Windows.Forms.Label();
            lblTelephone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoCivique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new System.Drawing.Point(102, 65);
            lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new System.Drawing.Size(61, 17);
            lblPrenom.TabIndex = 1;
            lblPrenom.Text = "Prénom:";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new System.Drawing.Point(116, 95);
            lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new System.Drawing.Size(45, 17);
            lblNom.TabIndex = 2;
            lblNom.Text = "Nom :";
            // 
            // lblDateNaissance
            // 
            lblDateNaissance.AutoSize = true;
            lblDateNaissance.Location = new System.Drawing.Point(32, 156);
            lblDateNaissance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDateNaissance.Name = "lblDateNaissance";
            lblDateNaissance.Size = new System.Drawing.Size(134, 17);
            lblDateNaissance.TabIndex = 4;
            lblDateNaissance.Text = "Date de naissance :";
            // 
            // lblSexe
            // 
            lblSexe.AutoSize = true;
            lblSexe.Location = new System.Drawing.Point(114, 125);
            lblSexe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSexe.Name = "lblSexe";
            lblSexe.Size = new System.Drawing.Size(47, 17);
            lblSexe.TabIndex = 6;
            lblSexe.Text = "Sexe :";
            // 
            // lblNoCivique
            // 
            lblNoCivique.AutoSize = true;
            lblNoCivique.Location = new System.Drawing.Point(81, 188);
            lblNoCivique.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNoCivique.Name = "lblNoCivique";
            lblNoCivique.Size = new System.Drawing.Size(80, 17);
            lblNoCivique.TabIndex = 8;
            lblNoCivique.Text = "N° civique :";
            // 
            // lblRue
            // 
            lblRue.AutoSize = true;
            lblRue.Location = new System.Drawing.Point(244, 189);
            lblRue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblRue.Name = "lblRue";
            lblRue.Size = new System.Drawing.Size(42, 17);
            lblRue.TabIndex = 10;
            lblRue.Text = "Rue :";
            // 
            // lblVille
            // 
            lblVille.AutoSize = true;
            lblVille.Location = new System.Drawing.Point(120, 219);
            lblVille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblVille.Name = "lblVille";
            lblVille.Size = new System.Drawing.Size(42, 17);
            lblVille.TabIndex = 12;
            lblVille.Text = "Ville :";
            // 
            // lblCodePostal
            // 
            lblCodePostal.AutoSize = true;
            lblCodePostal.Location = new System.Drawing.Point(74, 280);
            lblCodePostal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblCodePostal.Name = "lblCodePostal";
            lblCodePostal.Size = new System.Drawing.Size(91, 17);
            lblCodePostal.TabIndex = 15;
            lblCodePostal.Text = "Code postal :";
            // 
            // lblProvince
            // 
            lblProvince.AutoSize = true;
            lblProvince.Location = new System.Drawing.Point(91, 249);
            lblProvince.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblProvince.Name = "lblProvince";
            lblProvince.Size = new System.Drawing.Size(71, 17);
            lblProvince.TabIndex = 19;
            lblProvince.Text = "Province :";
            // 
            // lblCellulaire
            // 
            lblCellulaire.AutoSize = true;
            lblCellulaire.Location = new System.Drawing.Point(89, 344);
            lblCellulaire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCellulaire.Name = "lblCellulaire";
            lblCellulaire.Size = new System.Drawing.Size(74, 17);
            lblCellulaire.TabIndex = 21;
            lblCellulaire.Text = "Cellulaire :";
            // 
            // lblCourriel
            // 
            lblCourriel.AutoSize = true;
            lblCourriel.Location = new System.Drawing.Point(98, 376);
            lblCourriel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCourriel.Name = "lblCourriel";
            lblCourriel.Size = new System.Drawing.Size(65, 17);
            lblCourriel.TabIndex = 22;
            lblCourriel.Text = "Courriel :";
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new System.Drawing.Point(78, 311);
            lblTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new System.Drawing.Size(84, 17);
            lblTelephone.TabIndex = 24;
            lblTelephone.Text = "Téléphone :";
            // 
            // tbPrenom
            // 
            this.tbPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Prenom", true));
            this.tbPrenom.Location = new System.Drawing.Point(165, 61);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrenom.MaxLength = 50;
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(124, 22);
            this.tbPrenom.TabIndex = 0;
            this.tbPrenom.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenom_Validating);
            this.tbPrenom.Validated += new System.EventHandler(this.tbPrenom_Validated);
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataSource = typeof(Projet2BD.Abonnements);
            // 
            // tbNom
            // 
            this.tbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Nom", true));
            this.tbNom.Location = new System.Drawing.Point(165, 91);
            this.tbNom.Margin = new System.Windows.Forms.Padding(2);
            this.tbNom.MaxLength = 50;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(124, 22);
            this.tbNom.TabIndex = 1;
            this.tbNom.Validating += new System.ComponentModel.CancelEventHandler(this.tbNom_Validating);
            this.tbNom.Validated += new System.EventHandler(this.tbNom_Validated);
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.abonnementsBindingSource, "DateNaissance", true));
            this.dtpDateNaissance.Location = new System.Drawing.Point(165, 152);
            this.dtpDateNaissance.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(186, 22);
            this.dtpDateNaissance.TabIndex = 3;
            this.dtpDateNaissance.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDateNaissance_Validating);
            this.dtpDateNaissance.Validated += new System.EventHandler(this.dtpDateNaissance_Validated);
            // 
            // tbRue
            // 
            this.tbRue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Rue", true));
            this.tbRue.Location = new System.Drawing.Point(290, 184);
            this.tbRue.Margin = new System.Windows.Forms.Padding(2);
            this.tbRue.MaxLength = 50;
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(124, 22);
            this.tbRue.TabIndex = 5;
            this.tbRue.Validating += new System.ComponentModel.CancelEventHandler(this.tbRue_Validating);
            this.tbRue.Validated += new System.EventHandler(this.tbRue_Validated);
            // 
            // tbVille
            // 
            this.tbVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Ville", true));
            this.tbVille.Location = new System.Drawing.Point(165, 215);
            this.tbVille.Margin = new System.Windows.Forms.Padding(2);
            this.tbVille.MaxLength = 50;
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(249, 22);
            this.tbVille.TabIndex = 6;
            this.tbVille.Validating += new System.ComponentModel.CancelEventHandler(this.tbVille_Validating);
            this.tbVille.Validated += new System.EventHandler(this.tbVille_Validated);
            // 
            // ddlProvinces
            // 
            this.ddlProvinces.DataSource = this.provincesBindingSource;
            this.ddlProvinces.DisplayMember = "Nom";
            this.ddlProvinces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlProvinces.FormattingEnabled = true;
            this.ddlProvinces.Location = new System.Drawing.Point(165, 245);
            this.ddlProvinces.Margin = new System.Windows.Forms.Padding(2);
            this.ddlProvinces.Name = "ddlProvinces";
            this.ddlProvinces.Size = new System.Drawing.Size(186, 24);
            this.ddlProvinces.TabIndex = 7;
            this.ddlProvinces.ValueMember = "Id";
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataSource = typeof(Projet2BD.Provinces);
            // 
            // mtbCodePostal
            // 
            this.mtbCodePostal.Location = new System.Drawing.Point(165, 276);
            this.mtbCodePostal.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCodePostal.Mask = "L0L 0L0";
            this.mtbCodePostal.Name = "mtbCodePostal";
            this.mtbCodePostal.Size = new System.Drawing.Size(62, 22);
            this.mtbCodePostal.TabIndex = 8;
            this.mtbCodePostal.Validating += new System.ComponentModel.CancelEventHandler(this.mtbCodePostal_Validating);
            this.mtbCodePostal.Validated += new System.EventHandler(this.mtbCodePostal_Validated);
            // 
            // ddlSexes
            // 
            this.ddlSexes.DataSource = this.sexeBindingSource;
            this.ddlSexes.DisplayMember = "Nom";
            this.ddlSexes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSexes.FormattingEnabled = true;
            this.ddlSexes.Location = new System.Drawing.Point(165, 121);
            this.ddlSexes.Margin = new System.Windows.Forms.Padding(2);
            this.ddlSexes.Name = "ddlSexes";
            this.ddlSexes.Size = new System.Drawing.Size(124, 24);
            this.ddlSexes.TabIndex = 2;
            this.ddlSexes.ValueMember = "Id";
            // 
            // ddlTypesAbonnement
            // 
            this.ddlTypesAbonnement.DataSource = this.typesAbonnementBindingSource;
            this.ddlTypesAbonnement.DisplayMember = "Description";
            this.ddlTypesAbonnement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTypesAbonnement.FormattingEnabled = true;
            this.ddlTypesAbonnement.Location = new System.Drawing.Point(165, 404);
            this.ddlTypesAbonnement.Margin = new System.Windows.Forms.Padding(2);
            this.ddlTypesAbonnement.Name = "ddlTypesAbonnement";
            this.ddlTypesAbonnement.Size = new System.Drawing.Size(249, 24);
            this.ddlTypesAbonnement.TabIndex = 12;
            this.ddlTypesAbonnement.ValueMember = "No";
            this.ddlTypesAbonnement.SelectedIndexChanged += new System.EventHandler(this.ddlTypesAbonnement_SelectedIndexChanged);
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(Projet2BD.TypesAbonnement);
            // 
            // lblAbonnePrincipal
            // 
            this.lblAbonnePrincipal.AutoSize = true;
            this.lblAbonnePrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbonnePrincipal.Location = new System.Drawing.Point(25, 25);
            this.lblAbonnePrincipal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbonnePrincipal.Name = "lblAbonnePrincipal";
            this.lblAbonnePrincipal.Size = new System.Drawing.Size(149, 20);
            this.lblAbonnePrincipal.TabIndex = 21;
            this.lblAbonnePrincipal.Text = "Abonné principal";
            // 
            // tbCourriel
            // 
            this.tbCourriel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Courriel", true));
            this.tbCourriel.Location = new System.Drawing.Point(165, 372);
            this.tbCourriel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(249, 22);
            this.tbCourriel.TabIndex = 11;
            this.tbCourriel.Validating += new System.ComponentModel.CancelEventHandler(this.tbCourriel_Validating);
            this.tbCourriel.Validated += new System.EventHandler(this.tbCourriel_Validated);
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Location = new System.Drawing.Point(165, 308);
            this.mtbTelephone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbTelephone.Mask = "(000) 000-0000";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(124, 22);
            this.mtbTelephone.TabIndex = 9;
            this.mtbTelephone.Validating += new System.ComponentModel.CancelEventHandler(this.mtbTelephone_Validating);
            this.mtbTelephone.Validated += new System.EventHandler(this.mtbTelephone_Validated);
            // 
            // mtbCellulaire
            // 
            this.mtbCellulaire.Location = new System.Drawing.Point(165, 340);
            this.mtbCellulaire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbCellulaire.Mask = "(000) 000-0000";
            this.mtbCellulaire.Name = "mtbCellulaire";
            this.mtbCellulaire.Size = new System.Drawing.Size(124, 22);
            this.mtbCellulaire.TabIndex = 10;
            this.mtbCellulaire.Validating += new System.ComponentModel.CancelEventHandler(this.mtbCellulaire_Validating);
            this.mtbCellulaire.Validated += new System.EventHandler(this.mtbCellulaire_Validated);
            // 
            // numNoCivique
            // 
            this.numNoCivique.Location = new System.Drawing.Point(165, 184);
            this.numNoCivique.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numNoCivique.Name = "numNoCivique";
            this.numNoCivique.Size = new System.Drawing.Size(62, 22);
            this.numNoCivique.TabIndex = 4;
            this.numNoCivique.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbRemarque
            // 
            this.tbRemarque.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Remarque", true));
            this.tbRemarque.Location = new System.Drawing.Point(165, 436);
            this.tbRemarque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRemarque.MaxLength = 500;
            this.tbRemarque.Multiline = true;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRemarque.Size = new System.Drawing.Size(249, 62);
            this.tbRemarque.TabIndex = 13;
            // 
            // lblTypeAbonnement
            // 
            this.lblTypeAbonnement.AutoSize = true;
            this.lblTypeAbonnement.Location = new System.Drawing.Point(25, 408);
            this.lblTypeAbonnement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeAbonnement.Name = "lblTypeAbonnement";
            this.lblTypeAbonnement.Size = new System.Drawing.Size(142, 17);
            this.lblTypeAbonnement.TabIndex = 30;
            this.lblTypeAbonnement.Text = "Type d\'abonnement :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(141, 518);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(176, 42);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "Ajouter l\'abonnement";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblRemarque
            // 
            this.lblRemarque.AutoSize = true;
            this.lblRemarque.Location = new System.Drawing.Point(80, 440);
            this.lblRemarque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemarque.Name = "lblRemarque";
            this.lblRemarque.Size = new System.Drawing.Size(82, 17);
            this.lblRemarque.TabIndex = 34;
            this.lblRemarque.Text = "Remarque :";
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // sexeBindingSource
            // 
            this.sexeBindingSource.DataSource = typeof(Projet2BD.Sexe);
            // 
            // Abonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(456, 582);
            this.Controls.Add(this.lblRemarque);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblTypeAbonnement);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.numNoCivique);
            this.Controls.Add(this.mtbCellulaire);
            this.Controls.Add(this.mtbTelephone);
            this.Controls.Add(lblTelephone);
            this.Controls.Add(lblCourriel);
            this.Controls.Add(this.tbCourriel);
            this.Controls.Add(lblCellulaire);
            this.Controls.Add(this.lblAbonnePrincipal);
            this.Controls.Add(this.ddlTypesAbonnement);
            this.Controls.Add(lblProvince);
            this.Controls.Add(this.ddlSexes);
            this.Controls.Add(this.mtbCodePostal);
            this.Controls.Add(lblCodePostal);
            this.Controls.Add(this.ddlProvinces);
            this.Controls.Add(lblVille);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(lblRue);
            this.Controls.Add(this.tbRue);
            this.Controls.Add(lblNoCivique);
            this.Controls.Add(lblSexe);
            this.Controls.Add(lblDateNaissance);
            this.Controls.Add(this.dtpDateNaissance);
            this.Controls.Add(lblNom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(lblPrenom);
            this.Controls.Add(this.tbPrenom);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Abonnement";
            this.Text = "Abonnement";
            this.Load += new System.EventHandler(this.Abonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoCivique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.ComboBox ddlProvinces;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private System.Windows.Forms.MaskedTextBox mtbCodePostal;
        private System.Windows.Forms.ComboBox ddlSexes;
        private System.Windows.Forms.ComboBox ddlTypesAbonnement;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.Label lblAbonnePrincipal;
        private System.Windows.Forms.TextBox tbCourriel;
        private System.Windows.Forms.MaskedTextBox mtbTelephone;
        private System.Windows.Forms.MaskedTextBox mtbCellulaire;
        private System.Windows.Forms.NumericUpDown numNoCivique;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.Label lblTypeAbonnement;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblRemarque;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.BindingSource sexeBindingSource;
    }
}