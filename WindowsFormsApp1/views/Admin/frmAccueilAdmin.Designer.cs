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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBloquerUtilisateur = new System.Windows.Forms.Button();
            this.btnRechercherUtilisateur = new System.Windows.Forms.Button();
            this.btnAjouterUtilisateur = new System.Windows.Forms.Button();
            this.dgUtilisateur = new System.Windows.Forms.DataGridView();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.btnCorbeille = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.btnCorbeille);
            this.panel1.Controls.Add(this.txtRechercher);
            this.panel1.Controls.Add(this.btnBloquerUtilisateur);
            this.panel1.Controls.Add(this.btnRechercherUtilisateur);
            this.panel1.Controls.Add(this.btnAjouterUtilisateur);
            this.panel1.Controls.Add(this.dgUtilisateur);
            this.panel1.Location = new System.Drawing.Point(6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 747);
            this.panel1.TabIndex = 0;
            // 
            // btnBloquerUtilisateur
            // 
            this.btnBloquerUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBloquerUtilisateur.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnBloquerUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBloquerUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloquerUtilisateur.ForeColor = System.Drawing.Color.White;
            this.btnBloquerUtilisateur.Location = new System.Drawing.Point(179, 8);
            this.btnBloquerUtilisateur.Name = "btnBloquerUtilisateur";
            this.btnBloquerUtilisateur.Size = new System.Drawing.Size(170, 31);
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
            this.btnRechercherUtilisateur.Location = new System.Drawing.Point(1017, 40);
            this.btnRechercherUtilisateur.Name = "btnRechercherUtilisateur";
            this.btnRechercherUtilisateur.Size = new System.Drawing.Size(196, 32);
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
            this.btnAjouterUtilisateur.Location = new System.Drawing.Point(6, 8);
            this.btnAjouterUtilisateur.Name = "btnAjouterUtilisateur";
            this.btnAjouterUtilisateur.Size = new System.Drawing.Size(152, 31);
            this.btnAjouterUtilisateur.TabIndex = 1;
            this.btnAjouterUtilisateur.Text = "&Ajouter un utilisateur";
            this.btnAjouterUtilisateur.UseVisualStyleBackColor = true;
            // 
            // dgUtilisateur
            // 
            this.dgUtilisateur.AllowUserToAddRows = false;
            this.dgUtilisateur.AllowUserToDeleteRows = false;
            this.dgUtilisateur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUtilisateur.Location = new System.Drawing.Point(6, 115);
            this.dgUtilisateur.Name = "dgUtilisateur";
            this.dgUtilisateur.ReadOnly = true;
            this.dgUtilisateur.RowHeadersWidth = 51;
            this.dgUtilisateur.RowTemplate.Height = 24;
            this.dgUtilisateur.Size = new System.Drawing.Size(1236, 629);
            this.dgUtilisateur.TabIndex = 0;
            // 
            // txtRechercher
            // 
            this.txtRechercher.Location = new System.Drawing.Point(740, 45);
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(257, 22);
            this.txtRechercher.TabIndex = 4;
            // 
            // btnCorbeille
            // 
            this.btnCorbeille.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorbeille.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnCorbeille.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCorbeille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorbeille.ForeColor = System.Drawing.Color.White;
            this.btnCorbeille.Location = new System.Drawing.Point(95, 57);
            this.btnCorbeille.Name = "btnCorbeille";
            this.btnCorbeille.Size = new System.Drawing.Size(152, 31);
            this.btnCorbeille.TabIndex = 5;
            this.btnCorbeille.Text = "&Corbeille";
            this.btnCorbeille.UseVisualStyleBackColor = true;
            // 
            // frmAccueilAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 763);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "frmAccueilAdmin";
            this.Text = "Acceuil";
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