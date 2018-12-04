namespace Projet2BD
{
    partial class frmModificationEmploye
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
            this.nupSalaire = new System.Windows.Forms.NumericUpDown();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.idEtNomProvinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nupNoCivique = new System.Windows.Forms.NumericUpDown();
            this.nupAge = new System.Windows.Forms.NumericUpDown();
            this.cbSexe = new System.Windows.Forms.ComboBox();
            this.lblCourriel = new System.Windows.Forms.Label();
            this.lblSalaire = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblNoCivique = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblRemarque = new System.Windows.Forms.Label();
            this.lblMDP = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.tbCodePostal = new System.Windows.Forms.TextBox();
            this.tbCel = new System.Windows.Forms.TextBox();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbMDP = new System.Windows.Forms.TextBox();
            this.btnModification = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupSalaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idEtNomProvinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNoCivique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // nupSalaire
            // 
            this.nupSalaire.DecimalPlaces = 2;
            this.nupSalaire.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupSalaire.Location = new System.Drawing.Point(682, 100);
            this.nupSalaire.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nupSalaire.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupSalaire.Name = "nupSalaire";
            this.nupSalaire.Size = new System.Drawing.Size(100, 24);
            this.nupSalaire.TabIndex = 70;
            this.nupSalaire.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbProvince
            // 
            this.cbProvince.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.idEtNomProvinceBindingSource, "idProvince", true));
            this.cbProvince.DataSource = this.idEtNomProvinceBindingSource;
            this.cbProvince.DisplayMember = "nomProvince";
            this.cbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvince.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(495, 61);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(100, 24);
            this.cbProvince.TabIndex = 69;
            this.cbProvince.ValueMember = "idProvince";
            // 
            // idEtNomProvinceBindingSource
            // 
            this.idEtNomProvinceBindingSource.DataSource = typeof(Projet2BD.IdEtNomProvince);
            // 
            // nupNoCivique
            // 
            this.nupNoCivique.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupNoCivique.Location = new System.Drawing.Point(299, 101);
            this.nupNoCivique.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupNoCivique.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNoCivique.Name = "nupNoCivique";
            this.nupNoCivique.Size = new System.Drawing.Size(100, 24);
            this.nupNoCivique.TabIndex = 68;
            this.nupNoCivique.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupAge
            // 
            this.nupAge.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupAge.Location = new System.Drawing.Point(299, 62);
            this.nupAge.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.nupAge.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nupAge.Name = "nupAge";
            this.nupAge.Size = new System.Drawing.Size(100, 24);
            this.nupAge.TabIndex = 67;
            this.nupAge.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // cbSexe
            // 
            this.cbSexe.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexe.FormattingEnabled = true;
            this.cbSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cbSexe.Location = new System.Drawing.Point(108, 184);
            this.cbSexe.Name = "cbSexe";
            this.cbSexe.Size = new System.Drawing.Size(100, 24);
            this.cbSexe.TabIndex = 66;
            // 
            // lblCourriel
            // 
            this.lblCourriel.AutoSize = true;
            this.lblCourriel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourriel.Location = new System.Drawing.Point(601, 64);
            this.lblCourriel.Name = "lblCourriel";
            this.lblCourriel.Size = new System.Drawing.Size(56, 16);
            this.lblCourriel.TabIndex = 65;
            this.lblCourriel.Text = "Couriel:";
            // 
            // lblSalaire
            // 
            this.lblSalaire.AutoSize = true;
            this.lblSalaire.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaire.Location = new System.Drawing.Point(601, 103);
            this.lblSalaire.Name = "lblSalaire";
            this.lblSalaire.Size = new System.Drawing.Size(53, 16);
            this.lblSalaire.TabIndex = 64;
            this.lblSalaire.Text = "Salaire:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(12, 103);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 16);
            this.lblNom.TabIndex = 62;
            this.lblNom.Text = "Nom:";
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodePostal.Location = new System.Drawing.Point(405, 103);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(85, 16);
            this.lblCodePostal.TabIndex = 61;
            this.lblCodePostal.Text = "Code postal:";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(12, 142);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(60, 16);
            this.lblPrenom.TabIndex = 60;
            this.lblPrenom.Text = "Prenom:";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexe.Location = new System.Drawing.Point(12, 184);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(40, 16);
            this.lblSexe.TabIndex = 59;
            this.lblSexe.Text = "Sexe:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(214, 64);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 16);
            this.lblAge.TabIndex = 58;
            this.lblAge.Text = "Age:";
            // 
            // lblNoCivique
            // 
            this.lblNoCivique.AutoSize = true;
            this.lblNoCivique.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCivique.Location = new System.Drawing.Point(214, 103);
            this.lblNoCivique.Name = "lblNoCivique";
            this.lblNoCivique.Size = new System.Drawing.Size(80, 16);
            this.lblNoCivique.TabIndex = 57;
            this.lblNoCivique.Text = "No Civique:";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRue.Location = new System.Drawing.Point(214, 142);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(35, 16);
            this.lblRue.TabIndex = 56;
            this.lblRue.Text = "Rue:";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.Location = new System.Drawing.Point(214, 184);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(40, 16);
            this.lblVille.TabIndex = 55;
            this.lblVille.Text = "Ville:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(405, 64);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(65, 16);
            this.lblProvince.TabIndex = 54;
            this.lblProvince.Text = "Province:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(405, 142);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(77, 16);
            this.lblTel.TabIndex = 53;
            this.lblTel.Text = "Telephone:";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCel.Location = new System.Drawing.Point(405, 184);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(70, 16);
            this.lblCel.TabIndex = 52;
            this.lblCel.Text = "Cellulaire:";
            // 
            // lblRemarque
            // 
            this.lblRemarque.AutoSize = true;
            this.lblRemarque.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarque.Location = new System.Drawing.Point(601, 145);
            this.lblRemarque.Name = "lblRemarque";
            this.lblRemarque.Size = new System.Drawing.Size(74, 16);
            this.lblRemarque.TabIndex = 51;
            this.lblRemarque.Text = "Remarque:";
            // 
            // lblMDP
            // 
            this.lblMDP.AutoSize = true;
            this.lblMDP.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDP.Location = new System.Drawing.Point(12, 64);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(94, 16);
            this.lblMDP.TabIndex = 50;
            this.lblMDP.Text = "Mot de passe:";
            // 
            // tbTel
            // 
            this.tbTel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTel.Location = new System.Drawing.Point(495, 136);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(100, 24);
            this.tbTel.TabIndex = 49;
            // 
            // tbCourriel
            // 
            this.tbCourriel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCourriel.Location = new System.Drawing.Point(682, 61);
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(100, 24);
            this.tbCourriel.TabIndex = 48;
            // 
            // tbVille
            // 
            this.tbVille.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVille.Location = new System.Drawing.Point(299, 181);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(100, 24);
            this.tbVille.TabIndex = 47;
            // 
            // tbRue
            // 
            this.tbRue.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRue.Location = new System.Drawing.Point(299, 139);
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(100, 24);
            this.tbRue.TabIndex = 46;
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodePostal.Location = new System.Drawing.Point(495, 97);
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.Size = new System.Drawing.Size(100, 24);
            this.tbCodePostal.TabIndex = 45;
            // 
            // tbCel
            // 
            this.tbCel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCel.Location = new System.Drawing.Point(495, 178);
            this.tbCel.Name = "tbCel";
            this.tbCel.Size = new System.Drawing.Size(100, 24);
            this.tbCel.TabIndex = 44;
            // 
            // tbRemarque
            // 
            this.tbRemarque.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemarque.Location = new System.Drawing.Point(682, 142);
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(100, 24);
            this.tbRemarque.TabIndex = 43;
            this.tbRemarque.TextChanged += new System.EventHandler(this.tbRemarque_TextChanged);
            // 
            // tbPrenom
            // 
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenom.Location = new System.Drawing.Point(108, 142);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(100, 24);
            this.tbPrenom.TabIndex = 42;
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(108, 103);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 24);
            this.tbNom.TabIndex = 41;
            // 
            // tbMDP
            // 
            this.tbMDP.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMDP.Location = new System.Drawing.Point(108, 64);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.PasswordChar = '*';
            this.tbMDP.Size = new System.Drawing.Size(100, 24);
            this.tbMDP.TabIndex = 40;
            // 
            // btnModification
            // 
            this.btnModification.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModification.Location = new System.Drawing.Point(646, 175);
            this.btnModification.Name = "btnModification";
            this.btnModification.Size = new System.Drawing.Size(136, 44);
            this.btnModification.TabIndex = 72;
            this.btnModification.Text = "Modifier employé";
            this.btnModification.UseVisualStyleBackColor = true;
            this.btnModification.Click += new System.EventHandler(this.btnModification_Click);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(212, 18);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(417, 27);
            this.lblTitre.TabIndex = 73;
            this.lblTitre.Text = "Veuillez entrer les informations ci-desous";
            // 
            // frmModificationEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 231);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnModification);
            this.Controls.Add(this.nupSalaire);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(this.nupNoCivique);
            this.Controls.Add(this.nupAge);
            this.Controls.Add(this.cbSexe);
            this.Controls.Add(this.lblCourriel);
            this.Controls.Add(this.lblSalaire);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblCodePostal);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblSexe);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblNoCivique);
            this.Controls.Add(this.lblRue);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblRemarque);
            this.Controls.Add(this.lblMDP);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbCourriel);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(this.tbRue);
            this.Controls.Add(this.tbCodePostal);
            this.Controls.Add(this.tbCel);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbMDP);
            this.Name = "frmModificationEmploye";
            this.Text = "Modification Employé";
            this.Load += new System.EventHandler(this.frmModificationEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupSalaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idEtNomProvinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNoCivique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nupSalaire;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.NumericUpDown nupNoCivique;
        private System.Windows.Forms.NumericUpDown nupAge;
        private System.Windows.Forms.ComboBox cbSexe;
        private System.Windows.Forms.Label lblCourriel;
        private System.Windows.Forms.Label lblSalaire;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblNoCivique;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblRemarque;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbCourriel;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.TextBox tbCodePostal;
        private System.Windows.Forms.TextBox tbCel;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbMDP;
        private System.Windows.Forms.Button btnModification;
        private System.Windows.Forms.BindingSource idEtNomProvinceBindingSource;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.Label lblTitre;
    }
}