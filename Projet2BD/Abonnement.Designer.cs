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
            this.SuspendLayout();
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new System.Drawing.Point(82, 52);
            lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new System.Drawing.Size(46, 13);
            lblPrenom.TabIndex = 1;
            lblPrenom.Text = "Prénom:";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new System.Drawing.Point(93, 76);
            lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new System.Drawing.Size(35, 13);
            lblNom.TabIndex = 2;
            lblNom.Text = "Nom :";
            // 
            // lblDateNaissance
            // 
            lblDateNaissance.AutoSize = true;
            lblDateNaissance.Location = new System.Drawing.Point(26, 125);
            lblDateNaissance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDateNaissance.Name = "lblDateNaissance";
            lblDateNaissance.Size = new System.Drawing.Size(102, 13);
            lblDateNaissance.TabIndex = 4;
            lblDateNaissance.Text = "Date de naissance :";
            // 
            // lblSexe
            // 
            lblSexe.AutoSize = true;
            lblSexe.Location = new System.Drawing.Point(91, 100);
            lblSexe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSexe.Name = "lblSexe";
            lblSexe.Size = new System.Drawing.Size(37, 13);
            lblSexe.TabIndex = 6;
            lblSexe.Text = "Sexe :";
            // 
            // lblNoCivique
            // 
            lblNoCivique.AutoSize = true;
            lblNoCivique.Location = new System.Drawing.Point(65, 150);
            lblNoCivique.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNoCivique.Name = "lblNoCivique";
            lblNoCivique.Size = new System.Drawing.Size(62, 13);
            lblNoCivique.TabIndex = 8;
            lblNoCivique.Text = "N° civique :";
            // 
            // lblRue
            // 
            lblRue.AutoSize = true;
            lblRue.Location = new System.Drawing.Point(195, 151);
            lblRue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblRue.Name = "lblRue";
            lblRue.Size = new System.Drawing.Size(33, 13);
            lblRue.TabIndex = 10;
            lblRue.Text = "Rue :";
            // 
            // lblVille
            // 
            lblVille.AutoSize = true;
            lblVille.Location = new System.Drawing.Point(96, 175);
            lblVille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblVille.Name = "lblVille";
            lblVille.Size = new System.Drawing.Size(32, 13);
            lblVille.TabIndex = 12;
            lblVille.Text = "Ville :";
            // 
            // lblCodePostal
            // 
            lblCodePostal.AutoSize = true;
            lblCodePostal.Location = new System.Drawing.Point(59, 224);
            lblCodePostal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblCodePostal.Name = "lblCodePostal";
            lblCodePostal.Size = new System.Drawing.Size(69, 13);
            lblCodePostal.TabIndex = 15;
            lblCodePostal.Text = "Code postal :";
            // 
            // lblProvince
            // 
            lblProvince.AutoSize = true;
            lblProvince.Location = new System.Drawing.Point(73, 199);
            lblProvince.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblProvince.Name = "lblProvince";
            lblProvince.Size = new System.Drawing.Size(55, 13);
            lblProvince.TabIndex = 19;
            lblProvince.Text = "Province :";
            // 
            // lblCellulaire
            // 
            lblCellulaire.AutoSize = true;
            lblCellulaire.Location = new System.Drawing.Point(71, 275);
            lblCellulaire.Name = "lblCellulaire";
            lblCellulaire.Size = new System.Drawing.Size(55, 13);
            lblCellulaire.TabIndex = 21;
            lblCellulaire.Text = "Cellulaire :";
            // 
            // lblCourriel
            // 
            lblCourriel.AutoSize = true;
            lblCourriel.Location = new System.Drawing.Point(78, 301);
            lblCourriel.Name = "lblCourriel";
            lblCourriel.Size = new System.Drawing.Size(48, 13);
            lblCourriel.TabIndex = 22;
            lblCourriel.Text = "Courriel :";
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new System.Drawing.Point(62, 249);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new System.Drawing.Size(64, 13);
            lblTelephone.TabIndex = 24;
            lblTelephone.Text = "Téléphone :";
            // 
            // tbPrenom
            // 
            this.tbPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Prenom", true));
            this.tbPrenom.Location = new System.Drawing.Point(132, 49);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrenom.MaxLength = 50;
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(100, 20);
            this.tbPrenom.TabIndex = 2;
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataSource = typeof(Projet2BD.Abonnements);
            // 
            // tbNom
            // 
            this.tbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Nom", true));
            this.tbNom.Location = new System.Drawing.Point(132, 73);
            this.tbNom.Margin = new System.Windows.Forms.Padding(2);
            this.tbNom.MaxLength = 50;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 3;
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.abonnementsBindingSource, "DateNaissance", true));
            this.dtpDateNaissance.Location = new System.Drawing.Point(132, 122);
            this.dtpDateNaissance.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(150, 20);
            this.dtpDateNaissance.TabIndex = 5;
            // 
            // tbRue
            // 
            this.tbRue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Rue", true));
            this.tbRue.Location = new System.Drawing.Point(232, 147);
            this.tbRue.Margin = new System.Windows.Forms.Padding(2);
            this.tbRue.MaxLength = 50;
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(100, 20);
            this.tbRue.TabIndex = 11;
            // 
            // tbVille
            // 
            this.tbVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Ville", true));
            this.tbVille.Location = new System.Drawing.Point(132, 172);
            this.tbVille.Margin = new System.Windows.Forms.Padding(2);
            this.tbVille.MaxLength = 50;
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(200, 20);
            this.tbVille.TabIndex = 13;
            // 
            // ddlProvinces
            // 
            this.ddlProvinces.DataSource = this.provincesBindingSource;
            this.ddlProvinces.DisplayMember = "Nom";
            this.ddlProvinces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlProvinces.FormattingEnabled = true;
            this.ddlProvinces.Location = new System.Drawing.Point(132, 196);
            this.ddlProvinces.Margin = new System.Windows.Forms.Padding(2);
            this.ddlProvinces.Name = "ddlProvinces";
            this.ddlProvinces.Size = new System.Drawing.Size(150, 21);
            this.ddlProvinces.TabIndex = 14;
            this.ddlProvinces.ValueMember = "Id";
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataSource = typeof(Projet2BD.Provinces);
            // 
            // mtbCodePostal
            // 
            this.mtbCodePostal.Location = new System.Drawing.Point(132, 221);
            this.mtbCodePostal.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCodePostal.Mask = "L0L 0L0";
            this.mtbCodePostal.Name = "mtbCodePostal";
            this.mtbCodePostal.Size = new System.Drawing.Size(50, 20);
            this.mtbCodePostal.TabIndex = 17;
            // 
            // ddlSexes
            // 
            this.ddlSexes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSexes.FormattingEnabled = true;
            this.ddlSexes.Location = new System.Drawing.Point(132, 97);
            this.ddlSexes.Margin = new System.Windows.Forms.Padding(2);
            this.ddlSexes.Name = "ddlSexes";
            this.ddlSexes.Size = new System.Drawing.Size(100, 21);
            this.ddlSexes.TabIndex = 18;
            // 
            // ddlTypesAbonnement
            // 
            this.ddlTypesAbonnement.DataSource = this.typesAbonnementBindingSource;
            this.ddlTypesAbonnement.DisplayMember = "Description";
            this.ddlTypesAbonnement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTypesAbonnement.FormattingEnabled = true;
            this.ddlTypesAbonnement.Location = new System.Drawing.Point(132, 323);
            this.ddlTypesAbonnement.Margin = new System.Windows.Forms.Padding(2);
            this.ddlTypesAbonnement.Name = "ddlTypesAbonnement";
            this.ddlTypesAbonnement.Size = new System.Drawing.Size(200, 21);
            this.ddlTypesAbonnement.TabIndex = 20;
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
            this.lblAbonnePrincipal.Location = new System.Drawing.Point(20, 20);
            this.lblAbonnePrincipal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbonnePrincipal.Name = "lblAbonnePrincipal";
            this.lblAbonnePrincipal.Size = new System.Drawing.Size(130, 17);
            this.lblAbonnePrincipal.TabIndex = 21;
            this.lblAbonnePrincipal.Text = "Abonné principal";
            // 
            // tbCourriel
            // 
            this.tbCourriel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Courriel", true));
            this.tbCourriel.Location = new System.Drawing.Point(132, 298);
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(200, 20);
            this.tbCourriel.TabIndex = 23;
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Location = new System.Drawing.Point(132, 246);
            this.mtbTelephone.Mask = "(000) 000-0000";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(100, 20);
            this.mtbTelephone.TabIndex = 26;
            // 
            // mtbCellulaire
            // 
            this.mtbCellulaire.Location = new System.Drawing.Point(132, 272);
            this.mtbCellulaire.Mask = "(000) 000-0000";
            this.mtbCellulaire.Name = "mtbCellulaire";
            this.mtbCellulaire.Size = new System.Drawing.Size(100, 20);
            this.mtbCellulaire.TabIndex = 27;
            // 
            // numNoCivique
            // 
            this.numNoCivique.Location = new System.Drawing.Point(132, 147);
            this.numNoCivique.Name = "numNoCivique";
            this.numNoCivique.Size = new System.Drawing.Size(50, 20);
            this.numNoCivique.TabIndex = 28;
            this.numNoCivique.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbRemarque
            // 
            this.tbRemarque.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Remarque", true));
            this.tbRemarque.Location = new System.Drawing.Point(132, 349);
            this.tbRemarque.MaxLength = 500;
            this.tbRemarque.Multiline = true;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRemarque.Size = new System.Drawing.Size(200, 50);
            this.tbRemarque.TabIndex = 29;
            // 
            // lblTypeAbonnement
            // 
            this.lblTypeAbonnement.AutoSize = true;
            this.lblTypeAbonnement.Location = new System.Drawing.Point(20, 326);
            this.lblTypeAbonnement.Name = "lblTypeAbonnement";
            this.lblTypeAbonnement.Size = new System.Drawing.Size(107, 13);
            this.lblTypeAbonnement.TabIndex = 30;
            this.lblTypeAbonnement.Text = "Type d\'abonnement :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(113, 414);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(141, 34);
            this.btnAjouter.TabIndex = 31;
            this.btnAjouter.Text = "Ajouter l\'abonnement";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // lblRemarque
            // 
            this.lblRemarque.AutoSize = true;
            this.lblRemarque.Location = new System.Drawing.Point(64, 352);
            this.lblRemarque.Name = "lblRemarque";
            this.lblRemarque.Size = new System.Drawing.Size(62, 13);
            this.lblRemarque.TabIndex = 34;
            this.lblRemarque.Text = "Remarque :";
            // 
            // Abonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(365, 466);
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
    }
}