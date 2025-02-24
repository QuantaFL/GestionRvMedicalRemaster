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
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbSpecialite = new System.Windows.Forms.ComboBox();
            this.lblSpecialite = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnValiderAjoutUtilisateur = new System.Windows.Forms.Button();
            this.txtNumeroOrdre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumeroTelephone = new System.Windows.Forms.TextBox();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.txtDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.lblNumeroOrdre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 617);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(144)))));
            this.panel2.Controls.Add(this.label8);
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
            this.panel2.Controls.Add(this.txtDateNaissance);
            this.panel2.Controls.Add(this.lblNumeroOrdre);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(9, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 604);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(172, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "AJOUTER UN MEDECIN";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(163, 115);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(250, 20);
            this.txtAdresse.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(160, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Addresse";
            // 
            // cbbSpecialite
            // 
            this.cbbSpecialite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbSpecialite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbSpecialite.FormattingEnabled = true;
            this.cbbSpecialite.Location = new System.Drawing.Point(163, 401);
            this.cbbSpecialite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbSpecialite.Name = "cbbSpecialite";
            this.cbbSpecialite.Size = new System.Drawing.Size(250, 21);
            this.cbbSpecialite.TabIndex = 15;
            // 
            // lblSpecialite
            // 
            this.lblSpecialite.AutoSize = true;
            this.lblSpecialite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialite.ForeColor = System.Drawing.Color.White;
            this.lblSpecialite.Location = new System.Drawing.Point(160, 384);
            this.lblSpecialite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecialite.Name = "lblSpecialite";
            this.lblSpecialite.Size = new System.Drawing.Size(61, 15);
            this.lblSpecialite.TabIndex = 14;
            this.lblSpecialite.Text = "Specialite";
            // 
            // btnFermer
            // 
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermer.Location = new System.Drawing.Point(308, 463);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(104, 35);
            this.btnFermer.TabIndex = 13;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click_1);
            // 
            // btnValiderAjoutUtilisateur
            // 
            this.btnValiderAjoutUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValiderAjoutUtilisateur.Location = new System.Drawing.Point(163, 463);
            this.btnValiderAjoutUtilisateur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValiderAjoutUtilisateur.Name = "btnValiderAjoutUtilisateur";
            this.btnValiderAjoutUtilisateur.Size = new System.Drawing.Size(104, 35);
            this.btnValiderAjoutUtilisateur.TabIndex = 12;
            this.btnValiderAjoutUtilisateur.Text = "Valider l\'Ajout";
            this.btnValiderAjoutUtilisateur.UseVisualStyleBackColor = true;
            this.btnValiderAjoutUtilisateur.Click += new System.EventHandler(this.btnValiderAjoutUtilisateur_Click_1);
            // 
            // txtNumeroOrdre
            // 
            this.txtNumeroOrdre.Location = new System.Drawing.Point(163, 353);
            this.txtNumeroOrdre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeroOrdre.Name = "txtNumeroOrdre";
            this.txtNumeroOrdre.Size = new System.Drawing.Size(250, 20);
            this.txtNumeroOrdre.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(163, 257);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtNumeroTelephone
            // 
            this.txtNumeroTelephone.Location = new System.Drawing.Point(163, 210);
            this.txtNumeroTelephone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeroTelephone.Name = "txtNumeroTelephone";
            this.txtNumeroTelephone.Size = new System.Drawing.Size(250, 20);
            this.txtNumeroTelephone.TabIndex = 9;
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(163, 162);
            this.txtNomPrenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(250, 20);
            this.txtNomPrenom.TabIndex = 8;
            // 
            // txtDateNaissance
            // 
            this.txtDateNaissance.Location = new System.Drawing.Point(160, 301);
            this.txtDateNaissance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDateNaissance.Name = "txtDateNaissance";
            this.txtDateNaissance.Size = new System.Drawing.Size(250, 20);
            this.txtDateNaissance.TabIndex = 6;
            // 
            // lblNumeroOrdre
            // 
            this.lblNumeroOrdre.AutoSize = true;
            this.lblNumeroOrdre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroOrdre.ForeColor = System.Drawing.Color.White;
            this.lblNumeroOrdre.Location = new System.Drawing.Point(160, 336);
            this.lblNumeroOrdre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroOrdre.Name = "lblNumeroOrdre";
            this.lblNumeroOrdre.Size = new System.Drawing.Size(86, 15);
            this.lblNumeroOrdre.TabIndex = 4;
            this.lblNumeroOrdre.Text = "Numero Ordre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(160, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(160, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(160, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Telephone ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Prenom ";
            // 
            // frmAdminAjouterUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 626);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.DateTimePicker txtDateNaissance;
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
        private System.Windows.Forms.Label label8;
    }
}