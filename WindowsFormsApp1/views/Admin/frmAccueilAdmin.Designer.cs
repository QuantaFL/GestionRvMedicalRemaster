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
            this.btnRechercherSecretaire = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRerchercherSecretaire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouterSecretaire = new System.Windows.Forms.Button();
            this.btnCorbeille = new System.Windows.Forms.Button();
            this.txtRechercherMedecin = new System.Windows.Forms.TextBox();
            this.btnBloquerUtilisateur = new System.Windows.Forms.Button();
            this.btnRechercherMedecin = new System.Windows.Forms.Button();
            this.btnAjouterUtilisateur = new System.Windows.Forms.Button();
            this.dgUtilisateur = new System.Windows.Forms.DataGridView();
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
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2158, 1348);
            this.panel1.TabIndex = 0;
            // 
            // btnRechercherSecretaire
            // 
            this.btnRechercherSecretaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercherSecretaire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRechercherSecretaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercherSecretaire.ForeColor = System.Drawing.Color.White;
            this.btnRechercherSecretaire.Location = new System.Drawing.Point(1274, 101);
            this.btnRechercherSecretaire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRechercherSecretaire.Name = "btnRechercherSecretaire";
            this.btnRechercherSecretaire.Size = new System.Drawing.Size(296, 40);
            this.btnRechercherSecretaire.TabIndex = 10;
            this.btnRechercherSecretaire.Text = "Rechercher une s&ecretaire";
            this.btnRechercherSecretaire.UseVisualStyleBackColor = true;
            this.btnRechercherSecretaire.Click += new System.EventHandler(this.btnRechercherSecretaire_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(958, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Matricule";
            // 
            // txtRerchercherSecretaire
            // 
            this.txtRerchercherSecretaire.Location = new System.Drawing.Point(962, 109);
            this.txtRerchercherSecretaire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRerchercherSecretaire.Name = "txtRerchercherSecretaire";
            this.txtRerchercherSecretaire.Size = new System.Drawing.Size(289, 26);
            this.txtRerchercherSecretaire.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(958, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero Ordre";
            // 
            // btnAjouterSecretaire
            // 
            this.btnAjouterSecretaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterSecretaire.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnAjouterSecretaire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouterSecretaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterSecretaire.ForeColor = System.Drawing.Color.White;
            this.btnAjouterSecretaire.Location = new System.Drawing.Point(296, 82);
            this.btnAjouterSecretaire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjouterSecretaire.Name = "btnAjouterSecretaire";
            this.btnAjouterSecretaire.Size = new System.Drawing.Size(254, 54);
            this.btnAjouterSecretaire.TabIndex = 6;
            this.btnAjouterSecretaire.Text = "Ajouter une &secretaire";
            this.btnAjouterSecretaire.UseVisualStyleBackColor = true;
            this.btnAjouterSecretaire.Click += new System.EventHandler(this.btnAjouterSecretaire_Click_1);
            // 
            // btnCorbeille
            // 
            this.btnCorbeille.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorbeille.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnCorbeille.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCorbeille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorbeille.ForeColor = System.Drawing.Color.White;
            this.btnCorbeille.Location = new System.Drawing.Point(7, 82);
            this.btnCorbeille.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCorbeille.Name = "btnCorbeille";
            this.btnCorbeille.Size = new System.Drawing.Size(245, 54);
            this.btnCorbeille.TabIndex = 5;
            this.btnCorbeille.Text = "&Voir la corbeille";
            this.btnCorbeille.UseVisualStyleBackColor = true;
            // 
            // txtRechercherMedecin
            // 
            this.txtRechercherMedecin.Location = new System.Drawing.Point(962, 51);
            this.txtRechercherMedecin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRechercherMedecin.Name = "txtRechercherMedecin";
            this.txtRechercherMedecin.Size = new System.Drawing.Size(289, 26);
            this.txtRechercherMedecin.TabIndex = 4;
            // 
            // btnBloquerUtilisateur
            // 
            this.btnBloquerUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBloquerUtilisateur.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnBloquerUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBloquerUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloquerUtilisateur.ForeColor = System.Drawing.Color.White;
            this.btnBloquerUtilisateur.Location = new System.Drawing.Point(296, 10);
            this.btnBloquerUtilisateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBloquerUtilisateur.Name = "btnBloquerUtilisateur";
            this.btnBloquerUtilisateur.Size = new System.Drawing.Size(254, 54);
            this.btnBloquerUtilisateur.TabIndex = 3;
            this.btnBloquerUtilisateur.Text = "&Bloquer un utilisateur";
            this.btnBloquerUtilisateur.UseVisualStyleBackColor = true;
            this.btnBloquerUtilisateur.Click += new System.EventHandler(this.btnBloquerUtilisateur_Click);
            // 
            // btnRechercherMedecin
            // 
            this.btnRechercherMedecin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercherMedecin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRechercherMedecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercherMedecin.ForeColor = System.Drawing.Color.White;
            this.btnRechercherMedecin.Location = new System.Drawing.Point(1274, 48);
            this.btnRechercherMedecin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRechercherMedecin.Name = "btnRechercherMedecin";
            this.btnRechercherMedecin.Size = new System.Drawing.Size(296, 40);
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
            this.btnAjouterUtilisateur.Location = new System.Drawing.Point(7, 10);
            this.btnAjouterUtilisateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjouterUtilisateur.Name = "btnAjouterUtilisateur";
            this.btnAjouterUtilisateur.Size = new System.Drawing.Size(245, 54);
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
            this.dgUtilisateur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUtilisateur.Location = new System.Drawing.Point(0, 164);
            this.dgUtilisateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgUtilisateur.MinimumSize = new System.Drawing.Size(1350, 375);
            this.dgUtilisateur.Name = "dgUtilisateur";
            this.dgUtilisateur.ReadOnly = true;
            this.dgUtilisateur.RowHeadersWidth = 51;
            this.dgUtilisateur.RowTemplate.Height = 24;
            this.dgUtilisateur.Size = new System.Drawing.Size(2090, 2500);
            this.dgUtilisateur.TabIndex = 0;
            // 
            // frmAccueilAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAccueilAdmin";
            this.ShowIcon = false;
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
       // private CustomControls.CtrlBox ctrlBox1;
    }
}