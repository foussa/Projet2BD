namespace Projet2BD
{
    partial class frmAjouterEmploye
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
            this.tbMDP = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.tbCel = new System.Windows.Forms.TextBox();
            this.tbCodePostal = new System.Windows.Forms.TextBox();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.lblMDP = new System.Windows.Forms.Label();
            this.lblRemarque = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblNoCivique = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTypeEmp = new System.Windows.Forms.Label();
            this.lblSalaire = new System.Windows.Forms.Label();
            this.lblCourriel = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbSexe = new System.Windows.Forms.ComboBox();
            this.nupAge = new System.Windows.Forms.NumericUpDown();
            this.nupNoCivique = new System.Windows.Forms.NumericUpDown();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.idEtNomProvinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nupSalaire = new System.Windows.Forms.NumericUpDown();
            this.cbTypeEmp = new System.Windows.Forms.ComboBox();
            this.noEtTypeEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNoCivique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idEtNomProvinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSalaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtTypeEmployeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMDP
            // 
            this.tbMDP.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMDP.Location = new System.Drawing.Point(119, 80);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.PasswordChar = '*';
            this.tbMDP.Size = new System.Drawing.Size(100, 24);
            this.tbMDP.TabIndex = 0;
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(119, 119);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 24);
            this.tbNom.TabIndex = 1;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenom.Location = new System.Drawing.Point(119, 158);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(100, 24);
            this.tbPrenom.TabIndex = 2;
            // 
            // tbRemarque
            // 
            this.tbRemarque.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemarque.Location = new System.Drawing.Point(724, 199);
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(100, 24);
            this.tbRemarque.TabIndex = 4;
            // 
            // tbCel
            // 
            this.tbCel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCel.Location = new System.Drawing.Point(506, 196);
            this.tbCel.Name = "tbCel";
            this.tbCel.Size = new System.Drawing.Size(100, 24);
            this.tbCel.TabIndex = 5;
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodePostal.Location = new System.Drawing.Point(506, 115);
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.Size = new System.Drawing.Size(100, 24);
            this.tbCodePostal.TabIndex = 6;
            // 
            // tbRue
            // 
            this.tbRue.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRue.Location = new System.Drawing.Point(300, 157);
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(100, 24);
            this.tbRue.TabIndex = 9;
            // 
            // tbVille
            // 
            this.tbVille.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVille.Location = new System.Drawing.Point(300, 199);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(100, 24);
            this.tbVille.TabIndex = 10;
            // 
            // tbCourriel
            // 
            this.tbCourriel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCourriel.Location = new System.Drawing.Point(724, 79);
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(100, 24);
            this.tbCourriel.TabIndex = 13;
            // 
            // tbTel
            // 
            this.tbTel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTel.Location = new System.Drawing.Point(506, 154);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(100, 24);
            this.tbTel.TabIndex = 14;
            // 
            // lblMDP
            // 
            this.lblMDP.AutoSize = true;
            this.lblMDP.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDP.Location = new System.Drawing.Point(23, 82);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(94, 16);
            this.lblMDP.TabIndex = 16;
            this.lblMDP.Text = "Mot de passe:";
            // 
            // lblRemarque
            // 
            this.lblRemarque.AutoSize = true;
            this.lblRemarque.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarque.Location = new System.Drawing.Point(612, 202);
            this.lblRemarque.Name = "lblRemarque";
            this.lblRemarque.Size = new System.Drawing.Size(74, 16);
            this.lblRemarque.TabIndex = 17;
            this.lblRemarque.Text = "Remarque:";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCel.Location = new System.Drawing.Point(416, 202);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(70, 16);
            this.lblCel.TabIndex = 18;
            this.lblCel.Text = "Cellulaire:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(416, 160);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(77, 16);
            this.lblTel.TabIndex = 19;
            this.lblTel.Text = "Telephone:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(416, 82);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(65, 16);
            this.lblProvince.TabIndex = 20;
            this.lblProvince.Text = "Province:";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.Location = new System.Drawing.Point(225, 202);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(40, 16);
            this.lblVille.TabIndex = 21;
            this.lblVille.Text = "Ville:";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRue.Location = new System.Drawing.Point(225, 160);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(35, 16);
            this.lblRue.TabIndex = 22;
            this.lblRue.Text = "Rue:";
            // 
            // lblNoCivique
            // 
            this.lblNoCivique.AutoSize = true;
            this.lblNoCivique.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCivique.Location = new System.Drawing.Point(225, 121);
            this.lblNoCivique.Name = "lblNoCivique";
            this.lblNoCivique.Size = new System.Drawing.Size(80, 16);
            this.lblNoCivique.TabIndex = 23;
            this.lblNoCivique.Text = "No Civique:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(225, 82);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 16);
            this.lblAge.TabIndex = 24;
            this.lblAge.Text = "Age:";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexe.Location = new System.Drawing.Point(23, 202);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(40, 16);
            this.lblSexe.TabIndex = 25;
            this.lblSexe.Text = "Sexe:";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(23, 160);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(60, 16);
            this.lblPrenom.TabIndex = 26;
            this.lblPrenom.Text = "Prenom:";
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodePostal.Location = new System.Drawing.Point(416, 121);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(85, 16);
            this.lblCodePostal.TabIndex = 27;
            this.lblCodePostal.Text = "Code postal:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(23, 121);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 16);
            this.lblNom.TabIndex = 28;
            this.lblNom.Text = "Nom:";
            // 
            // lblTypeEmp
            // 
            this.lblTypeEmp.AutoSize = true;
            this.lblTypeEmp.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeEmp.Location = new System.Drawing.Point(612, 160);
            this.lblTypeEmp.Name = "lblTypeEmp";
            this.lblTypeEmp.Size = new System.Drawing.Size(111, 16);
            this.lblTypeEmp.TabIndex = 29;
            this.lblTypeEmp.Text = "Type d\'employé:";
            // 
            // lblSalaire
            // 
            this.lblSalaire.AutoSize = true;
            this.lblSalaire.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaire.Location = new System.Drawing.Point(612, 121);
            this.lblSalaire.Name = "lblSalaire";
            this.lblSalaire.Size = new System.Drawing.Size(53, 16);
            this.lblSalaire.TabIndex = 30;
            this.lblSalaire.Text = "Salaire:";
            // 
            // lblCourriel
            // 
            this.lblCourriel.AutoSize = true;
            this.lblCourriel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourriel.Location = new System.Drawing.Point(612, 82);
            this.lblCourriel.Name = "lblCourriel";
            this.lblCourriel.Size = new System.Drawing.Size(56, 16);
            this.lblCourriel.TabIndex = 31;
            this.lblCourriel.Text = "Couriel:";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(382, 229);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(136, 44);
            this.btnAjouter.TabIndex = 32;
            this.btnAjouter.Text = "Ajouter employé";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // cbSexe
            // 
            this.cbSexe.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexe.FormattingEnabled = true;
            this.cbSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cbSexe.Location = new System.Drawing.Point(119, 200);
            this.cbSexe.Name = "cbSexe";
            this.cbSexe.Size = new System.Drawing.Size(100, 24);
            this.cbSexe.TabIndex = 33;
            // 
            // nupAge
            // 
            this.nupAge.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupAge.Location = new System.Drawing.Point(300, 80);
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
            this.nupAge.TabIndex = 34;
            this.nupAge.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // nupNoCivique
            // 
            this.nupNoCivique.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupNoCivique.Location = new System.Drawing.Point(300, 119);
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
            this.nupNoCivique.TabIndex = 35;
            this.nupNoCivique.Value = new decimal(new int[] {
            1,
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
            this.cbProvince.Location = new System.Drawing.Point(506, 79);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(100, 24);
            this.cbProvince.TabIndex = 37;
            this.cbProvince.ValueMember = "idProvince";
            // 
            // idEtNomProvinceBindingSource
            // 
            this.idEtNomProvinceBindingSource.DataSource = typeof(Projet2BD.IdEtNomProvince);
            // 
            // nupSalaire
            // 
            this.nupSalaire.DecimalPlaces = 2;
            this.nupSalaire.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupSalaire.Location = new System.Drawing.Point(724, 118);
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
            this.nupSalaire.TabIndex = 38;
            this.nupSalaire.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbTypeEmp
            // 
            this.cbTypeEmp.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.noEtTypeEmployeBindingSource, "noTypeEmploye", true));
            this.cbTypeEmp.DataSource = this.noEtTypeEmployeBindingSource;
            this.cbTypeEmp.DisplayMember = "typeEmploye";
            this.cbTypeEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeEmp.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypeEmp.FormattingEnabled = true;
            this.cbTypeEmp.Location = new System.Drawing.Point(724, 157);
            this.cbTypeEmp.Name = "cbTypeEmp";
            this.cbTypeEmp.Size = new System.Drawing.Size(100, 24);
            this.cbTypeEmp.TabIndex = 39;
            this.cbTypeEmp.ValueMember = "noTypeEmploye";
            // 
            // noEtTypeEmployeBindingSource
            // 
            this.noEtTypeEmployeBindingSource.DataSource = typeof(Projet2BD.NoEtTypeEmploye);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(160, 21);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(573, 34);
            this.lblTitre.TabIndex = 40;
            this.lblTitre.Text = "Veuillez remplir les informations ci-dessous";
            // 
            // frmAjouterEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 277);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.cbTypeEmp);
            this.Controls.Add(this.nupSalaire);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(this.nupNoCivique);
            this.Controls.Add(this.nupAge);
            this.Controls.Add(this.cbSexe);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblCourriel);
            this.Controls.Add(this.lblSalaire);
            this.Controls.Add(this.lblTypeEmp);
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
            this.Name = "frmAjouterEmploye";
            this.Text = "Ajouter Employé";
            this.Load += new System.EventHandler(this.frmAjouterEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNoCivique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idEtNomProvinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSalaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtTypeEmployeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMDP;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.TextBox tbCel;
        private System.Windows.Forms.TextBox tbCodePostal;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbCourriel;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.Label lblRemarque;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblNoCivique;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTypeEmp;
        private System.Windows.Forms.Label lblSalaire;
        private System.Windows.Forms.Label lblCourriel;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.NumericUpDown nupNoCivique;
        private System.Windows.Forms.NumericUpDown nupAge;
        private System.Windows.Forms.ComboBox cbSexe;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.NumericUpDown nupSalaire;
        private System.Windows.Forms.ComboBox cbTypeEmp;
        private System.Windows.Forms.BindingSource noEtTypeEmployeBindingSource;
        private System.Windows.Forms.BindingSource idEtNomProvinceBindingSource;
        private System.Windows.Forms.Label lblTitre;
    }
}