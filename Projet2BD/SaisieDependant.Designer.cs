namespace Projet2BD
{
    partial class SaisieDependant
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblPrenom;
            System.Windows.Forms.Label lblNom;
            System.Windows.Forms.Label lblSexe;
            System.Windows.Forms.Label lblDateNaissance;
            System.Windows.Forms.Label lblRemarque;
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.ddlSexes = new System.Windows.Forms.ComboBox();
            this.sexeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDependant = new System.Windows.Forms.Label();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            lblPrenom = new System.Windows.Forms.Label();
            lblNom = new System.Windows.Forms.Label();
            lblSexe = new System.Windows.Forms.Label();
            lblDateNaissance = new System.Windows.Forms.Label();
            lblRemarque = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new System.Drawing.Point(0, 32);
            lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new System.Drawing.Size(49, 13);
            lblPrenom.TabIndex = 1;
            lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new System.Drawing.Point(0, 56);
            lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new System.Drawing.Size(35, 13);
            lblNom.TabIndex = 2;
            lblNom.Text = "Nom :";
            // 
            // lblSexe
            // 
            lblSexe.AutoSize = true;
            lblSexe.Location = new System.Drawing.Point(0, 80);
            lblSexe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSexe.Name = "lblSexe";
            lblSexe.Size = new System.Drawing.Size(37, 13);
            lblSexe.TabIndex = 4;
            lblSexe.Text = "Sexe :";
            // 
            // lblDateNaissance
            // 
            lblDateNaissance.AutoSize = true;
            lblDateNaissance.Location = new System.Drawing.Point(0, 105);
            lblDateNaissance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDateNaissance.Name = "lblDateNaissance";
            lblDateNaissance.Size = new System.Drawing.Size(102, 13);
            lblDateNaissance.TabIndex = 6;
            lblDateNaissance.Text = "Date de naissance :";
            // 
            // lblRemarque
            // 
            lblRemarque.AutoSize = true;
            lblRemarque.Location = new System.Drawing.Point(0, 129);
            lblRemarque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblRemarque.Name = "lblRemarque";
            lblRemarque.Size = new System.Drawing.Size(62, 13);
            lblRemarque.TabIndex = 8;
            lblRemarque.Text = "Remarque :";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(106, 29);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrenom.MaxLength = 50;
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(100, 20);
            this.tbPrenom.TabIndex = 2;
            this.tbPrenom.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenom_Validating);
            this.tbPrenom.Validated += new System.EventHandler(this.tbPrenom_Validated);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(106, 53);
            this.tbNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNom.MaxLength = 50;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 3;
            this.tbNom.Validating += new System.ComponentModel.CancelEventHandler(this.tbNom_Validating);
            this.tbNom.Validated += new System.EventHandler(this.tbNom_Validated);
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Location = new System.Drawing.Point(106, 102);
            this.dtpDateNaissance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(150, 20);
            this.dtpDateNaissance.TabIndex = 7;
            this.dtpDateNaissance.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDateNaissance_Validating);
            this.dtpDateNaissance.Validated += new System.EventHandler(this.dtpDateNaissance_Validated);
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(106, 126);
            this.tbRemarque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRemarque.MaxLength = 500;
            this.tbRemarque.Multiline = true;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRemarque.Size = new System.Drawing.Size(200, 50);
            this.tbRemarque.TabIndex = 9;
            // 
            // ddlSexes
            // 
            this.ddlSexes.DataSource = this.sexeBindingSource;
            this.ddlSexes.DisplayMember = "Nom";
            this.ddlSexes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSexes.FormattingEnabled = true;
            this.ddlSexes.Location = new System.Drawing.Point(106, 77);
            this.ddlSexes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ddlSexes.Name = "ddlSexes";
            this.ddlSexes.Size = new System.Drawing.Size(100, 21);
            this.ddlSexes.TabIndex = 19;
            this.ddlSexes.ValueMember = "Id";
            // 
            // sexeBindingSource
            // 
            this.sexeBindingSource.DataSource = typeof(Projet2BD.Sexe);
            // 
            // lblDependant
            // 
            this.lblDependant.AutoSize = true;
            this.lblDependant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDependant.Location = new System.Drawing.Point(0, 0);
            this.lblDependant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDependant.Name = "lblDependant";
            this.lblDependant.Size = new System.Drawing.Size(0, 17);
            this.lblDependant.TabIndex = 20;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // SaisieDependant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDependant);
            this.Controls.Add(this.ddlSexes);
            this.Controls.Add(lblRemarque);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(lblDateNaissance);
            this.Controls.Add(this.dtpDateNaissance);
            this.Controls.Add(lblSexe);
            this.Controls.Add(lblNom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(lblPrenom);
            this.Controls.Add(this.tbPrenom);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SaisieDependant";
            this.Size = new System.Drawing.Size(306, 176);
            this.Load += new System.EventHandler(this.SaisieDependant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.ComboBox ddlSexes;
        private System.Windows.Forms.Label lblDependant;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.BindingSource sexeBindingSource;
    }
}
