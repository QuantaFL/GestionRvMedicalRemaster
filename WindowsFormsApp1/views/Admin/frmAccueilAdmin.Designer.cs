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
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.btnBloquerUtilisateur = new System.Windows.Forms.Button();
            this.btnRechercherUtilisateur = new System.Windows.Forms.Button();
            this.btnAjouterUtilisateur = new System.Windows.Forms.Button();
            this.dgUtilisateur = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.btnCorbeille);
            this.panel1.Controls.Add(this.txtRechercher);
            this.panel1.Controls.Add(this.btnBloquerUtilisateur);
            this.panel1.Controls.Add(this.btnRechercherUtilisateur);
            this.panel1.Controls.Add(this.btnAjouterUtilisateur);
            this.panel1.Controls.Add(this.dgUtilisateur);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2158, 1348);
            this.panel1.TabIndex = 0;
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
            // txtRechercher
            // 
            this.txtRechercher.Location = new System.Drawing.Point(962, 36);
            this.txtRechercher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(289, 26);
            this.txtRechercher.TabIndex = 4;
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
            // 
            // btnRechercherUtilisateur
            // 
            this.btnRechercherUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercherUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRechercherUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercherUtilisateur.ForeColor = System.Drawing.Color.White;
            this.btnRechercherUtilisateur.Location = new System.Drawing.Point(1274, 30);
            this.btnRechercherUtilisateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRechercherUtilisateur.Name = "btnRechercherUtilisateur";
            this.btnRechercherUtilisateur.Size = new System.Drawing.Size(237, 40);
            this.btnRechercherUtilisateur.TabIndex = 2;
            this.btnRechercherUtilisateur.Text = "&Rechercher un utilisateur";
            this.btnRechercherUtilisateur.UseVisualStyleBackColor = true;
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
            this.btnAjouterUtilisateur.Text = "&Ajouter un utilisateur";
            this.btnAjouterUtilisateur.UseVisualStyleBackColor = true;
            this.btnAjouterUtilisateur.Click += new System.EventHandler(this.btnAjouterUtilisateur_Click);
            // 
            // dgUtilisateur
            // 
            this.dgUtilisateur.AllowUserToAddRows = false;
            this.dgUtilisateur.AllowUserToDeleteRows = false;
            this.dgUtilisateur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUtilisateur.Location = new System.Drawing.Point(68, 186);
            this.dgUtilisateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgUtilisateur.Name = "dgUtilisateur";
            this.dgUtilisateur.ReadOnly = true;
            this.dgUtilisateur.RowHeadersWidth = 51;
            this.dgUtilisateur.RowTemplate.Height = 24;
            this.dgUtilisateur.Size = new System.Drawing.Size(2090, 1162);
            this.dgUtilisateur.TabIndex = 0;
            // 
            // frmAccueilAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button btnRechercherUtilisateur;
        private System.Windows.Forms.Button btnBloquerUtilisateur;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Button btnCorbeille;
    }
}