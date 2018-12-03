namespace Projet2BD
{
    partial class RenouvellerAbonnement
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
            this.ddlAbonnements = new System.Windows.Forms.ComboBox();
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblRemarque = new System.Windows.Forms.Label();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.btnRenouvellerAbonnement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlAbonnements
            // 
            this.ddlAbonnements.DataSource = this.abonnementsBindingSource;
            this.ddlAbonnements.DisplayMember = "IdEtNomComplet";
            this.ddlAbonnements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAbonnements.FormattingEnabled = true;
            this.ddlAbonnements.Location = new System.Drawing.Point(98, 20);
            this.ddlAbonnements.Margin = new System.Windows.Forms.Padding(2);
            this.ddlAbonnements.Name = "ddlAbonnements";
            this.ddlAbonnements.Size = new System.Drawing.Size(200, 21);
            this.ddlAbonnements.TabIndex = 0;
            this.ddlAbonnements.ValueMember = "Id";
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataSource = typeof(Projet2BD.Abonnements);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Abonnement :";
            // 
            // lblRemarque
            // 
            this.lblRemarque.AutoSize = true;
            this.lblRemarque.Location = new System.Drawing.Point(20, 49);
            this.lblRemarque.Name = "lblRemarque";
            this.lblRemarque.Size = new System.Drawing.Size(62, 13);
            this.lblRemarque.TabIndex = 36;
            this.lblRemarque.Text = "Remarque :";
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(98, 46);
            this.tbRemarque.MaxLength = 500;
            this.tbRemarque.Multiline = true;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRemarque.Size = new System.Drawing.Size(200, 50);
            this.tbRemarque.TabIndex = 35;
            // 
            // btnRenouvellerAbonnement
            // 
            this.btnRenouvellerAbonnement.Location = new System.Drawing.Point(79, 111);
            this.btnRenouvellerAbonnement.Name = "btnRenouvellerAbonnement";
            this.btnRenouvellerAbonnement.Size = new System.Drawing.Size(162, 34);
            this.btnRenouvellerAbonnement.TabIndex = 37;
            this.btnRenouvellerAbonnement.Text = "Renouveller l\'abonnement";
            this.btnRenouvellerAbonnement.UseVisualStyleBackColor = true;
            this.btnRenouvellerAbonnement.Click += new System.EventHandler(this.btnRenouvellerAbonnement_Click);
            // 
            // RenouvellerAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 165);
            this.Controls.Add(this.btnRenouvellerAbonnement);
            this.Controls.Add(this.lblRemarque);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlAbonnements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "RenouvellerAbonnement";
            this.ShowIcon = false;
            this.Text = "Renouveller un abonnement";
            this.Load += new System.EventHandler(this.RenouvellerAbonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlAbonnements;
        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRemarque;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.Button btnRenouvellerAbonnement;
    }
}