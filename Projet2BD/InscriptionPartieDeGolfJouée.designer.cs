namespace Projet2BD
{
    partial class InscriptionPartieDeGolfJouée
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
            System.Windows.Forms.Label nomTerrainsLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbNomEtPrenomAbonne = new System.Windows.Forms.ComboBox();
            this.noNomEtPrenomAbonneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.lblRemarque = new System.Windows.Forms.Label();
            this.lblPointage = new System.Windows.Forms.Label();
            this.btnInscription = new System.Windows.Forms.Button();
            this.noEtNomTerrainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTerrains = new System.Windows.Forms.ComboBox();
            this.nupPointage = new System.Windows.Forms.NumericUpDown();
            this.lblTitre = new System.Windows.Forms.Label();
            this.partieDeGolfJoueeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partieDeGolfJoueeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblAbonne = new System.Windows.Forms.Label();
            nomTerrainsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.noNomEtPrenomAbonneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomTerrainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPointage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partieDeGolfJoueeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partieDeGolfJoueeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAbonne
            // 
            lblAbonne.AutoSize = true;
            lblAbonne.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAbonne.Location = new System.Drawing.Point(12, 73);
            lblAbonne.Name = "lblAbonne";
            lblAbonne.Size = new System.Drawing.Size(60, 16);
            lblAbonne.TabIndex = 7;
            lblAbonne.Text = "Abonné:";
            // 
            // nomTerrainsLabel
            // 
            nomTerrainsLabel.AutoSize = true;
            nomTerrainsLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomTerrainsLabel.Location = new System.Drawing.Point(12, 215);
            nomTerrainsLabel.Name = "nomTerrainsLabel";
            nomTerrainsLabel.Size = new System.Drawing.Size(94, 16);
            nomTerrainsLabel.TabIndex = 14;
            nomTerrainsLabel.Text = "nom Terrains:";
            // 
            // cbNomEtPrenomAbonne
            // 
            this.cbNomEtPrenomAbonne.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.noNomEtPrenomAbonneBindingSource, "noAbonne", true));
            this.cbNomEtPrenomAbonne.DataSource = this.noNomEtPrenomAbonneBindingSource;
            this.cbNomEtPrenomAbonne.DisplayMember = "nomEtPrenomAbonne";
            this.cbNomEtPrenomAbonne.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNomEtPrenomAbonne.FormattingEnabled = true;
            this.cbNomEtPrenomAbonne.Location = new System.Drawing.Point(110, 70);
            this.cbNomEtPrenomAbonne.Name = "cbNomEtPrenomAbonne";
            this.cbNomEtPrenomAbonne.Size = new System.Drawing.Size(122, 24);
            this.cbNomEtPrenomAbonne.TabIndex = 8;
            this.cbNomEtPrenomAbonne.ValueMember = "noAbonne";
            // 
            // noNomEtPrenomAbonneBindingSource
            // 
            this.noNomEtPrenomAbonneBindingSource.DataSource = typeof(Projet2BD.noNomEtPrenomAbonne);
            // 
            // tbRemarque
            // 
            this.tbRemarque.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemarque.Location = new System.Drawing.Point(110, 119);
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(122, 24);
            this.tbRemarque.TabIndex = 11;
            // 
            // lblRemarque
            // 
            this.lblRemarque.AutoSize = true;
            this.lblRemarque.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarque.Location = new System.Drawing.Point(12, 122);
            this.lblRemarque.Name = "lblRemarque";
            this.lblRemarque.Size = new System.Drawing.Size(74, 16);
            this.lblRemarque.TabIndex = 10;
            this.lblRemarque.Text = "Remarque:";
            // 
            // lblPointage
            // 
            this.lblPointage.AutoSize = true;
            this.lblPointage.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointage.Location = new System.Drawing.Point(12, 168);
            this.lblPointage.Name = "lblPointage";
            this.lblPointage.Size = new System.Drawing.Size(67, 16);
            this.lblPointage.TabIndex = 12;
            this.lblPointage.Text = "Pointage:";
            // 
            // btnInscription
            // 
            this.btnInscription.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscription.Location = new System.Drawing.Point(12, 252);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(87, 23);
            this.btnInscription.TabIndex = 14;
            this.btnInscription.Text = "Inscription";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // noEtNomTerrainsBindingSource
            // 
            this.noEtNomTerrainsBindingSource.DataSource = typeof(Projet2BD.noEtNomTerrains);
            // 
            // cbTerrains
            // 
            this.cbTerrains.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.noEtNomTerrainsBindingSource, "nomTerrains", true));
            this.cbTerrains.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.noEtNomTerrainsBindingSource, "noTerrains", true));
            this.cbTerrains.DataSource = this.noEtNomTerrainsBindingSource;
            this.cbTerrains.DisplayMember = "nomTerrains";
            this.cbTerrains.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTerrains.FormattingEnabled = true;
            this.cbTerrains.Location = new System.Drawing.Point(108, 212);
            this.cbTerrains.Name = "cbTerrains";
            this.cbTerrains.Size = new System.Drawing.Size(121, 24);
            this.cbTerrains.TabIndex = 15;
            this.cbTerrains.ValueMember = "noTerrains";
            // 
            // nupPointage
            // 
            this.nupPointage.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupPointage.Location = new System.Drawing.Point(109, 166);
            this.nupPointage.Name = "nupPointage";
            this.nupPointage.Size = new System.Drawing.Size(120, 24);
            this.nupPointage.TabIndex = 16;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(6, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(557, 34);
            this.lblTitre.TabIndex = 17;
            this.lblTitre.Text = "Veuillez entrer les informations ci-dessous";
            // 
            // partieDeGolfJoueeBindingSource
            // 
            this.partieDeGolfJoueeBindingSource.DataSource = typeof(Projet2BD.partieDeGolfJouee);
            // 
            // partieDeGolfJoueeDataGridView
            // 
            this.partieDeGolfJoueeDataGridView.AutoGenerateColumns = false;
            this.partieDeGolfJoueeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partieDeGolfJoueeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.partieDeGolfJoueeDataGridView.DataSource = this.partieDeGolfJoueeBindingSource;
            this.partieDeGolfJoueeDataGridView.Location = new System.Drawing.Point(251, 55);
            this.partieDeGolfJoueeDataGridView.Name = "partieDeGolfJoueeDataGridView";
            this.partieDeGolfJoueeDataGridView.Size = new System.Drawing.Size(540, 220);
            this.partieDeGolfJoueeDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "strIdAbonnement";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Abonné(e)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "intNoTerrains";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "No Terrains";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "strDatePartie";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Date de la Partie";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dblPointage";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn4.HeaderText = "Pointage";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "strRemarque";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn5.HeaderText = "Remarque";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // InscriptionPartieDeGolfJouée
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 343);
            this.Controls.Add(this.partieDeGolfJoueeDataGridView);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.nupPointage);
            this.Controls.Add(nomTerrainsLabel);
            this.Controls.Add(this.cbTerrains);
            this.Controls.Add(this.btnInscription);
            this.Controls.Add(this.lblPointage);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.lblRemarque);
            this.Controls.Add(lblAbonne);
            this.Controls.Add(this.cbNomEtPrenomAbonne);
            this.Name = "InscriptionPartieDeGolfJouée";
            this.Text = "Inscription d\'une partie de golf jouée";
            this.Load += new System.EventHandler(this.InscriptionPartieDeGolfJouée_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noNomEtPrenomAbonneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomTerrainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPointage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partieDeGolfJoueeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partieDeGolfJoueeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNomEtPrenomAbonne;
        private System.Windows.Forms.BindingSource noNomEtPrenomAbonneBindingSource;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.Label lblRemarque;
        private System.Windows.Forms.Label lblPointage;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.BindingSource noEtNomTerrainsBindingSource;
        private System.Windows.Forms.ComboBox cbTerrains;
        private System.Windows.Forms.NumericUpDown nupPointage;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.BindingSource partieDeGolfJoueeBindingSource;
        private System.Windows.Forms.DataGridView partieDeGolfJoueeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}