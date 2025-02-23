namespace WindowsFormsApp1.views.Admin
{
    partial class frmAdminAjouterUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminAjouterUtilisateur));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnValiderAjoutUtilisateur = new System.Windows.Forms.Button();
            this.txtNumeroOrdre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumeroTelephone = new System.Windows.Forms.TextBox();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.cbbRoleUtilisateur = new System.Windows.Forms.ComboBox();
            this.txtDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumeroOrdre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSpecialite = new System.Windows.Forms.Label();
            this.cbbSpecialite = new System.Windows.Forms.ComboBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 580);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(144)))));
            this.panel2.Controls.Add(this.txtAdresse);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbbSpecialite);
            this.panel2.Controls.Add(this.lblSpecialite);
            this.panel2.Controls.Add(this.btnFermer);
            this.panel2.Controls.Add(this.btnValiderAjoutUtilisateur);
            this.panel2.Controls.Add(this.txtNumeroOrdre);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtNumeroTelephone);
            this.panel2.Controls.Add(this.txtNomPrenom);
            this.panel2.Controls.Add(this.cbbRoleUtilisateur);
            this.panel2.Controls.Add(this.txtDateNaissance);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblNumeroOrdre);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(86, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 545);
            this.panel2.TabIndex = 1;
            // 
            // btnFermer
            // 
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermer.Location = new System.Drawing.Point(292, 476);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(138, 43);
            this.btnFermer.TabIndex = 13;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click_1);
            // 
            // btnValiderAjoutUtilisateur
            // 
            this.btnValiderAjoutUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValiderAjoutUtilisateur.Location = new System.Drawing.Point(98, 476);
            this.btnValiderAjoutUtilisateur.Name = "btnValiderAjoutUtilisateur";
            this.btnValiderAjoutUtilisateur.Size = new System.Drawing.Size(138, 43);
            this.btnValiderAjoutUtilisateur.TabIndex = 12;
            this.btnValiderAjoutUtilisateur.Text = "Valider l\'Ajout";
            this.btnValiderAjoutUtilisateur.UseVisualStyleBackColor = true;
            this.btnValiderAjoutUtilisateur.Click += new System.EventHandler(this.btnValiderAjoutUtilisateur_Click_1);
            // 
            // txtNumeroOrdre
            // 
            this.txtNumeroOrdre.Location = new System.Drawing.Point(101, 375);
            this.txtNumeroOrdre.Name = "txtNumeroOrdre";
            this.txtNumeroOrdre.Size = new System.Drawing.Size(332, 22);
            this.txtNumeroOrdre.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(101, 256);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(332, 22);
            this.txtEmail.TabIndex = 10;
            // 
            // txtNumeroTelephone
            // 
            this.txtNumeroTelephone.Location = new System.Drawing.Point(101, 198);
            this.txtNumeroTelephone.Name = "txtNumeroTelephone";
            this.txtNumeroTelephone.Size = new System.Drawing.Size(332, 22);
            this.txtNumeroTelephone.TabIndex = 9;
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(101, 139);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(332, 22);
            this.txtNomPrenom.TabIndex = 8;
            // 
            // cbbRoleUtilisateur
            // 
            this.cbbRoleUtilisateur.FormattingEnabled = true;
            this.cbbRoleUtilisateur.Location = new System.Drawing.Point(101, 23);
            this.cbbRoleUtilisateur.Name = "cbbRoleUtilisateur";
            this.cbbRoleUtilisateur.Size = new System.Drawing.Size(332, 24);
            this.cbbRoleUtilisateur.TabIndex = 7;
            this.cbbRoleUtilisateur.Leave += new System.EventHandler(this.cbbRoleUtilisateur_Leave);
            // 
            // txtDateNaissance
            // 
            this.txtDateNaissance.Location = new System.Drawing.Point(98, 311);
            this.txtDateNaissance.Name = "txtDateNaissance";
            this.txtDateNaissance.Size = new System.Drawing.Size(332, 22);
            this.txtDateNaissance.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(98, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Role ";
            // 
            // lblNumeroOrdre
            // 
            this.lblNumeroOrdre.AutoSize = true;
            this.lblNumeroOrdre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroOrdre.ForeColor = System.Drawing.Color.White;
            this.lblNumeroOrdre.Location = new System.Drawing.Point(98, 354);
            this.lblNumeroOrdre.Name = "lblNumeroOrdre";
            this.lblNumeroOrdre.Size = new System.Drawing.Size(104, 18);
            this.lblNumeroOrdre.TabIndex = 4;
            this.lblNumeroOrdre.Text = "Numero Ordre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(98, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(98, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Telephone ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Prenom ";
            // 
            // lblSpecialite
            // 
            this.lblSpecialite.AutoSize = true;
            this.lblSpecialite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialite.ForeColor = System.Drawing.Color.White;
            this.lblSpecialite.Location = new System.Drawing.Point(98, 413);
            this.lblSpecialite.Name = "lblSpecialite";
            this.lblSpecialite.Size = new System.Drawing.Size(71, 18);
            this.lblSpecialite.TabIndex = 14;
            this.lblSpecialite.Text = "Specialite";
            // 
            // cbbSpecialite
            // 
            this.cbbSpecialite.FormattingEnabled = true;
            this.cbbSpecialite.Location = new System.Drawing.Point(101, 434);
            this.cbbSpecialite.Name = "cbbSpecialite";
            this.cbbSpecialite.Size = new System.Drawing.Size(332, 24);
            this.cbbSpecialite.TabIndex = 15;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(101, 82);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(332, 22);
            this.txtAdresse.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(98, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Addresse";
            // 
            // frmAdminAjouterUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 604);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminAjouterUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter Un Utilisateur";
            this.Load += new System.EventHandler(this.frmAdminAjouterUtilisateur_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnValiderAjoutUtilisateur;
        private System.Windows.Forms.TextBox txtNumeroOrdre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumeroTelephone;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.ComboBox cbbRoleUtilisateur;
        private System.Windows.Forms.DateTimePicker txtDateNaissance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumeroOrdre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblSpecialite;
        private System.Windows.Forms.ComboBox cbbSpecialite;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label5;
    }
}