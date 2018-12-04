namespace Projet2BD
{
    partial class frmInscriptionDepense
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
            System.Windows.Forms.Label lblAbonne;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRemarque = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.noNomEtPrenomAbonneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbNomEtPrenomAbonne = new System.Windows.Forms.ComboBox();
            this.nupMontant = new System.Windows.Forms.NumericUpDown();
            this.tbService = new System.Windows.Forms.TextBox();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.btnInscriptionDepense = new System.Windows.Forms.Button();
            this.depenseEtTouteSesInformationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depenseEtTouteSesInformationsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitre = new System.Windows.Forms.Label();
            lblAbonne = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.noNomEtPrenomAbonneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMontant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depenseEtTouteSesInformationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depenseEtTouteSesInformationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAbonne
            // 
            lblAbonne.AutoSize = true;
            lblAbonne.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAbonne.Location = new System.Drawing.Point(15, 59);
            lblAbonne.Name = "lblAbonne";
            lblAbonne.Size = new System.Drawing.Size(60, 16);
            lblAbonne.TabIndex = 5;
            lblAbonne.Text = "Abonné:";
            // 
            // lblRemarque
            // 
            this.lblRemarque.AutoSize = true;
            this.lblRemarque.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarque.Location = new System.Drawing.Point(14, 135);
            this.lblRemarque.Name = "lblRemarque";
            this.lblRemarque.Size = new System.Drawing.Size(74, 16);
            this.lblRemarque.TabIndex = 2;
            this.lblRemarque.Text = "Remarque:";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(15, 180);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(55, 16);
            this.lblService.TabIndex = 3;
            this.lblService.Text = "Service:";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.Location = new System.Drawing.Point(14, 98);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(65, 16);
            this.lblMontant.TabIndex = 4;
            this.lblMontant.Text = "Montant:";
            // 
            // noNomEtPrenomAbonneBindingSource
            // 
            this.noNomEtPrenomAbonneBindingSource.DataSource = typeof(Projet2BD.noNomEtPrenomAbonne);
            // 
            // cbNomEtPrenomAbonne
            // 
            this.cbNomEtPrenomAbonne.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.noNomEtPrenomAbonneBindingSource, "nomEtPrenomAbonne", true));
            this.cbNomEtPrenomAbonne.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.noNomEtPrenomAbonneBindingSource, "noAbonne", true));
            this.cbNomEtPrenomAbonne.DataSource = this.noNomEtPrenomAbonneBindingSource;
            this.cbNomEtPrenomAbonne.DisplayMember = "nomEtPrenomAbonne";
            this.cbNomEtPrenomAbonne.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNomEtPrenomAbonne.FormattingEnabled = true;
            this.cbNomEtPrenomAbonne.Location = new System.Drawing.Point(94, 56);
            this.cbNomEtPrenomAbonne.Name = "cbNomEtPrenomAbonne";
            this.cbNomEtPrenomAbonne.Size = new System.Drawing.Size(121, 24);
            this.cbNomEtPrenomAbonne.TabIndex = 6;
            this.cbNomEtPrenomAbonne.ValueMember = "noAbonne";
            // 
            // nupMontant
            // 
            this.nupMontant.DecimalPlaces = 2;
            this.nupMontant.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupMontant.Location = new System.Drawing.Point(94, 98);
            this.nupMontant.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupMontant.Name = "nupMontant";
            this.nupMontant.Size = new System.Drawing.Size(120, 24);
            this.nupMontant.TabIndex = 7;
            this.nupMontant.ThousandsSeparator = true;
            // 
            // tbService
            // 
            this.tbService.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbService.Location = new System.Drawing.Point(94, 177);
            this.tbService.Name = "tbService";
            this.tbService.Size = new System.Drawing.Size(121, 24);
            this.tbService.TabIndex = 8;
            // 
            // tbRemarque
            // 
            this.tbRemarque.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemarque.Location = new System.Drawing.Point(93, 132);
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(122, 24);
            this.tbRemarque.TabIndex = 9;
            // 
            // btnInscriptionDepense
            // 
            this.btnInscriptionDepense.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscriptionDepense.Location = new System.Drawing.Point(17, 231);
            this.btnInscriptionDepense.Name = "btnInscriptionDepense";
            this.btnInscriptionDepense.Size = new System.Drawing.Size(177, 35);
            this.btnInscriptionDepense.TabIndex = 10;
            this.btnInscriptionDepense.Text = "Inscription de dépense";
            this.btnInscriptionDepense.UseVisualStyleBackColor = true;
            this.btnInscriptionDepense.Click += new System.EventHandler(this.btnInscriptionDepense_Click);
            // 
            // depenseEtTouteSesInformationsBindingSource
            // 
            this.depenseEtTouteSesInformationsBindingSource.DataSource = typeof(Projet2BD.DepenseEtTouteSesInformations);
            // 
            // depenseEtTouteSesInformationsDataGridView
            // 
            this.depenseEtTouteSesInformationsDataGridView.AllowUserToAddRows = false;
            this.depenseEtTouteSesInformationsDataGridView.AllowUserToDeleteRows = false;
            this.depenseEtTouteSesInformationsDataGridView.AutoGenerateColumns = false;
            this.depenseEtTouteSesInformationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depenseEtTouteSesInformationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.depenseEtTouteSesInformationsDataGridView.DataSource = this.depenseEtTouteSesInformationsBindingSource;
            this.depenseEtTouteSesInformationsDataGridView.Location = new System.Drawing.Point(248, 46);
            this.depenseEtTouteSesInformationsDataGridView.Name = "depenseEtTouteSesInformationsDataGridView";
            this.depenseEtTouteSesInformationsDataGridView.Size = new System.Drawing.Size(645, 220);
            this.depenseEtTouteSesInformationsDataGridView.TabIndex = 10;
            this.depenseEtTouteSesInformationsDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "strNomCompletAbonne";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn1.HeaderText = "strNomCompletAbonne";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dcmMontant";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn3.HeaderText = "dcmMontant";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "strTypeService";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn4.HeaderText = "strTypeService";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "strNomCompletEmploye";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn5.HeaderText = "strNomCompletEmploye";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dcmMontantDesDepenses";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn6.HeaderText = "dcmMontantDesDepenses";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "dcmMontantObligatoire";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn7.HeaderText = "dcmMontantObligatoire";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(197, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(557, 34);
            this.lblTitre.TabIndex = 11;
            this.lblTitre.Text = "Veuillez entrer les informations ci-dessous";
            // 
            // frmInscriptionDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 270);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.depenseEtTouteSesInformationsDataGridView);
            this.Controls.Add(this.btnInscriptionDepense);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.tbService);
            this.Controls.Add(this.nupMontant);
            this.Controls.Add(lblAbonne);
            this.Controls.Add(this.cbNomEtPrenomAbonne);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblRemarque);
            this.Name = "frmInscriptionDepense";
            this.Text = "Inscription Dépense";
            this.Load += new System.EventHandler(this.frmInscriptionDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noNomEtPrenomAbonneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMontant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depenseEtTouteSesInformationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depenseEtTouteSesInformationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRemarque;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.BindingSource noNomEtPrenomAbonneBindingSource;
        private System.Windows.Forms.ComboBox cbNomEtPrenomAbonne;
        private System.Windows.Forms.NumericUpDown nupMontant;
        private System.Windows.Forms.TextBox tbService;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.Button btnInscriptionDepense;
        private System.Windows.Forms.BindingSource depenseEtTouteSesInformationsBindingSource;
        private System.Windows.Forms.DataGridView depenseEtTouteSesInformationsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label lblTitre;
    }
}