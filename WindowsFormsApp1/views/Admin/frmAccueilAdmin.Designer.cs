namespace WindowsFormsApp1.views
{
    partial class frmAccueilAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueilAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCorbeille = new System.Windows.Forms.Button();
            this.txtRechercherMedecin = new System.Windows.Forms.TextBox();
            this.btnBloquerUtilisateur = new System.Windows.Forms.Button();
            this.btnRechercherMedecin = new System.Windows.Forms.Button();
            this.btnAjouterUtilisateur = new System.Windows.Forms.Button();
            this.dgUtilisateur = new System.Windows.Forms.DataGridView();
            this.btnAjouterSecretaire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRerchercherSecretaire = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRechercherSecretaire = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.btnRechercherSecretaire);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRerchercherSecretaire);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAjouterSecretaire);
            this.panel1.Controls.Add(this.btnCorbeille);
            this.panel1.Controls.Add(this.txtRechercherMedecin);
            this.panel1.Controls.Add(this.btnBloquerUtilisateur);
            this.panel1.Controls.Add(this.btnRechercherMedecin);
            this.panel1.Controls.Add(this.btnAjouterUtilisateur);
            this.panel1.Controls.Add(this.dgUtilisateur);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1918, 1078);
            this.panel1.TabIndex = 0;
            // 
            // btnCorbeille
            // 
            this.btnCorbeille.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorbeille.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnCorbeille.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCorbeille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorbeille.ForeColor = System.Drawing.Color.White;
            this.btnCorbeille.Location = new System.Drawing.Point(6, 66);
            this.btnCorbeille.Name = "btnCorbeille";
            this.btnCorbeille.Size = new System.Drawing.Size(218, 43);
            this.btnCorbeille.TabIndex = 5;
            this.btnCorbeille.Text = "&Voir la corbeille";
            this.btnCorbeille.UseVisualStyleBackColor = true;
            // 
            // txtRechercherMedecin
            // 
            this.txtRechercherMedecin.Location = new System.Drawing.Point(855, 41);
            this.txtRechercherMedecin.Name = "txtRechercherMedecin";
            this.txtRechercherMedecin.Size = new System.Drawing.Size(257, 22);
            this.txtRechercherMedecin.TabIndex = 4;
            // 
            // btnBloquerUtilisateur
            // 
            this.btnBloquerUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBloquerUtilisateur.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnBloquerUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBloquerUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloquerUtilisateur.ForeColor = System.Drawing.Color.White;
            this.btnBloquerUtilisateur.Location = new System.Drawing.Point(263, 8);
            this.btnBloquerUtilisateur.Name = "btnBloquerUtilisateur";
            this.btnBloquerUtilisateur.Size = new System.Drawing.Size(226, 43);
            this.btnBloquerUtilisateur.TabIndex = 3;
            this.btnBloquerUtilisateur.Text = "&Bloquer un utilisateur";
            this.btnBloquerUtilisateur.UseVisualStyleBackColor = true;
            // 
            // btnRechercherMedecin
            // 
            this.btnRechercherMedecin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercherMedecin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRechercherMedecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercherMedecin.ForeColor = System.Drawing.Color.White;
            this.btnRechercherMedecin.Location = new System.Drawing.Point(1132, 38);
            this.btnRechercherMedecin.Name = "btnRechercherMedecin";
            this.btnRechercherMedecin.Size = new System.Drawing.Size(211, 32);
            this.btnRechercherMedecin.TabIndex = 2;
            this.btnRechercherMedecin.Text = "&Rechercher un medecin";
            this.btnRechercherMedecin.UseVisualStyleBackColor = true;
            this.btnRechercherMedecin.Click += new System.EventHandler(this.btnRechercherMedecin_Click);
            // 
            // btnAjouterUtilisateur
            // 
            this.btnAjouterUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterUtilisateur.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnAjouterUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouterUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterUtilisateur.ForeColor = System.Drawing.Color.White;
            this.btnAjouterUtilisateur.Location = new System.Drawing.Point(6, 8);
            this.btnAjouterUtilisateur.Name = "btnAjouterUtilisateur";
            this.btnAjouterUtilisateur.Size = new System.Drawing.Size(218, 43);
            this.btnAjouterUtilisateur.TabIndex = 1;
            this.btnAjouterUtilisateur.Text = "Ajouter un &medecin";
            this.btnAjouterUtilisateur.UseVisualStyleBackColor = true;
            this.btnAjouterUtilisateur.Click += new System.EventHandler(this.btnAjouterUtilisateur_Click);
            // 
            // dgUtilisateur
            // 
            this.dgUtilisateur.AllowUserToAddRows = false;
            this.dgUtilisateur.AllowUserToDeleteRows = false;
            this.dgUtilisateur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgUtilisateur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUtilisateur.Location = new System.Drawing.Point(0, 131);
            this.dgUtilisateur.MinimumSize = new System.Drawing.Size(1200, 300);
            this.dgUtilisateur.Name = "dgUtilisateur";
            this.dgUtilisateur.ReadOnly = true;
            this.dgUtilisateur.RowHeadersWidth = 51;
            this.dgUtilisateur.RowTemplate.Height = 24;
            this.dgUtilisateur.Size = new System.Drawing.Size(1858, 930);
            this.dgUtilisateur.TabIndex = 0;
            // 
            // btnAjouterSecretaire
            // 
            this.btnAjouterSecretaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterSecretaire.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnAjouterSecretaire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouterSecretaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterSecretaire.ForeColor = System.Drawing.Color.White;
            this.btnAjouterSecretaire.Location = new System.Drawing.Point(263, 66);
            this.btnAjouterSecretaire.Name = "btnAjouterSecretaire";
            this.btnAjouterSecretaire.Size = new System.Drawing.Size(226, 43);
            this.btnAjouterSecretaire.TabIndex = 6;
            this.btnAjouterSecretaire.Text = "Ajouter une &secretaire";
            this.btnAjouterSecretaire.UseVisualStyleBackColor = true;
            this.btnAjouterSecretaire.Click += new System.EventHandler(this.btnAjouterSecretaire_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(852, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero Ordre";
            // 
            // txtRerchercherSecretaire
            // 
            this.txtRerchercherSecretaire.Location = new System.Drawing.Point(855, 87);
            this.txtRerchercherSecretaire.Name = "txtRerchercherSecretaire";
            this.txtRerchercherSecretaire.Size = new System.Drawing.Size(257, 22);
            this.txtRerchercherSecretaire.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(852, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Matricule";
            // 
            // btnRechercherSecretaire
            // 
            this.btnRechercherSecretaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercherSecretaire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRechercherSecretaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercherSecretaire.ForeColor = System.Drawing.Color.White;
            this.btnRechercherSecretaire.Location = new System.Drawing.Point(1132, 81);
            this.btnRechercherSecretaire.Name = "btnRechercherSecretaire";
            this.btnRechercherSecretaire.Size = new System.Drawing.Size(211, 32);
            this.btnRechercherSecretaire.TabIndex = 10;
            this.btnRechercherSecretaire.Text = "&Rechercher une secretaire";
            this.btnRechercherSecretaire.UseVisualStyleBackColor = true;
            // 
            // frmAccueilAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 882);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccueilAdmin";
            this.ShowIcon = false;
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.frmAccueilAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAjouterUtilisateur;
        private System.Windows.Forms.DataGridView dgUtilisateur;
        private System.Windows.Forms.Button btnRechercherMedecin;
        private System.Windows.Forms.Button btnBloquerUtilisateur;
        private System.Windows.Forms.TextBox txtRechercherMedecin;
        private System.Windows.Forms.Button btnCorbeille;
        private System.Windows.Forms.Button btnAjouterSecretaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRerchercherSecretaire;
        private System.Windows.Forms.Button btnRechercherSecretaire;
    }
}