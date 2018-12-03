namespace Projet2BD
{
    partial class VisualiserStatistiques
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TypeAbonnementAnneeNbAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TypeAbonnementMoisNbAbonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TerrainAnneeNbPartiesJoueesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TerrainMoisNbPartiesJoueesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AbonnementAnneeSumDepensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AbonnementMoisSumDepensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeAbonnementAnneeNbAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeAbonnementMoisNbAbonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerrainAnneeNbPartiesJoueesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerrainMoisNbPartiesJoueesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbonnementAnneeSumDepensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbonnementMoisSumDepensesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1584, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1576, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Abonnements par année et par type d’abonnement";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1576, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abonnements par mois de l’année courante et par type d’abonnement";
            this.tabPage2.UseVisualStyleBackColor = true;            
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1576, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Parties jouées par année et par terrain";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1576, 435);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Parties jouées par mois de l’année courante et par terrain";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1576, 435);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Dépenses par année et par abonnement";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.reportViewer6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1576, 435);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Dépenses par mois de l’année courante et par abonnement";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TypeAbonnementAnneeNbAbonnementBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projet2BD.RapportNbAbonnementsParAnneeEtTypeAbonnement.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1570, 429);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.TypeAbonnementMoisNbAbonnementsBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Projet2BD.RapportNbAbonnementsParMoisEtTypeAbonnement.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1570, 429);
            this.reportViewer2.TabIndex = 0;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.TerrainAnneeNbPartiesJoueesBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Projet2BD.RapportNbPartiesJoueesParAnneeEtTerrain.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1570, 429);
            this.reportViewer3.TabIndex = 0;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.TerrainMoisNbPartiesJoueesBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Projet2BD.RapportNbPartiesJoueesParMoisEtTerrain.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(3, 3);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(1570, 429);
            this.reportViewer4.TabIndex = 0;
            // 
            // reportViewer5
            // 
            this.reportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.AbonnementAnneeSumDepensesBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "Projet2BD.RapportSumDepensesParAnneeEtAbonnement.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(3, 3);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(1570, 429);
            this.reportViewer5.TabIndex = 0;
            // 
            // reportViewer6
            // 
            this.reportViewer6.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.AbonnementMoisSumDepensesBindingSource;
            this.reportViewer6.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "Projet2BD.RapportSumDepensesParMoisEtAbonnement.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(3, 3);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.ServerReport.BearerToken = null;
            this.reportViewer6.Size = new System.Drawing.Size(1570, 429);
            this.reportViewer6.TabIndex = 0;
            // 
            // TypeAbonnementAnneeNbAbonnementBindingSource
            // 
            this.TypeAbonnementAnneeNbAbonnementBindingSource.DataSource = typeof(Projet2BD.TypeAbonnementAnneeNbAbonnements);
            // 
            // TypeAbonnementMoisNbAbonnementsBindingSource
            // 
            this.TypeAbonnementMoisNbAbonnementsBindingSource.DataSource = typeof(Projet2BD.TypeAbonnementMoisNbAbonnements);
            // 
            // TerrainAnneeNbPartiesJoueesBindingSource
            // 
            this.TerrainAnneeNbPartiesJoueesBindingSource.DataSource = typeof(Projet2BD.TerrainAnneeNbPartiesJouees);
            // 
            // TerrainMoisNbPartiesJoueesBindingSource
            // 
            this.TerrainMoisNbPartiesJoueesBindingSource.DataSource = typeof(Projet2BD.TerrainMoisNbPartiesJouees);
            // 
            // AbonnementAnneeSumDepensesBindingSource
            // 
            this.AbonnementAnneeSumDepensesBindingSource.DataSource = typeof(Projet2BD.AbonnementAnneeSumDepenses);
            // 
            // AbonnementMoisSumDepensesBindingSource
            // 
            this.AbonnementMoisSumDepensesBindingSource.DataSource = typeof(Projet2BD.AbonnementMoisSumDepenses);
            // 
            // VisualiserStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 461);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "VisualiserStatistiques";
            this.ShowIcon = false;
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.VisualiserStatistiques_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TypeAbonnementAnneeNbAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeAbonnementMoisNbAbonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerrainAnneeNbPartiesJoueesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerrainMoisNbPartiesJoueesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbonnementAnneeSumDepensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbonnementMoisSumDepensesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TypeAbonnementAnneeNbAbonnementBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource TypeAbonnementMoisNbAbonnementsBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource TerrainAnneeNbPartiesJoueesBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource TerrainMoisNbPartiesJoueesBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private System.Windows.Forms.BindingSource AbonnementAnneeSumDepensesBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
        private System.Windows.Forms.BindingSource AbonnementMoisSumDepensesBindingSource;
    }
}