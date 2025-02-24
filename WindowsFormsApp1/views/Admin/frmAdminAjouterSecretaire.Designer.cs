namespace WindowsFormsApp1.views.Admin
{
    partial class frmAdminAjouterSecretaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminAjouterSecretaire));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textMatricule = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelephoneFixe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnValiderAjoutUtilisateur = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumeroTelephone = new System.Windows.Forms.TextBox();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.txtDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(8, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 860);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(144)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textMatricule);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtTelephoneFixe);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtAdresse);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnFermer);
            this.panel2.Controls.Add(this.btnValiderAjoutUtilisateur);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtNumeroTelephone);
            this.panel2.Controls.Add(this.txtNomPrenom);
            this.panel2.Controls.Add(this.txtDateNaissance);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 875);
            this.panel2.TabIndex = 1;
            // 
            // textMatricule
            // 
            this.textMatricule.Enabled = false;
            this.textMatricule.Location = new System.Drawing.Point(244, 639);
            this.textMatricule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textMatricule.Name = "textMatricule";
            this.textMatricule.Size = new System.Drawing.Size(373, 26);
            this.textMatricule.TabIndex = 21;
            this.textMatricule.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(241, 612);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Matricule";
            // 
            // txtTelephoneFixe
            // 
            this.txtTelephoneFixe.Location = new System.Drawing.Point(249, 205);
            this.txtTelephoneFixe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelephoneFixe.Name = "txtTelephoneFixe";
            this.txtTelephoneFixe.Size = new System.Drawing.Size(373, 26);
            this.txtTelephoneFixe.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(245, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Telephone Fixe";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(248, 275);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(373, 26);
            this.txtAdresse.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(244, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Addresse";
            // 
            // btnFermer
            // 
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermer.Location = new System.Drawing.Point(462, 710);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(155, 54);
            this.btnFermer.TabIndex = 13;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnValiderAjoutUtilisateur
            // 
            this.btnValiderAjoutUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValiderAjoutUtilisateur.Location = new System.Drawing.Point(244, 710);
            this.btnValiderAjoutUtilisateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnValiderAjoutUtilisateur.Name = "btnValiderAjoutUtilisateur";
            this.btnValiderAjoutUtilisateur.Size = new System.Drawing.Size(155, 54);
            this.btnValiderAjoutUtilisateur.TabIndex = 12;
            this.btnValiderAjoutUtilisateur.Text = "Valider l\'Ajout";
            this.btnValiderAjoutUtilisateur.UseVisualStyleBackColor = true;
            this.btnValiderAjoutUtilisateur.Click += new System.EventHandler(this.btnValiderAjoutUtilisateur_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(248, 492);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(373, 26);
            this.txtEmail.TabIndex = 10;
            // 
            // txtNumeroTelephone
            // 
            this.txtNumeroTelephone.Location = new System.Drawing.Point(248, 420);
            this.txtNumeroTelephone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroTelephone.Name = "txtNumeroTelephone";
            this.txtNumeroTelephone.Size = new System.Drawing.Size(373, 26);
            this.txtNumeroTelephone.TabIndex = 9;
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(248, 346);
            this.txtNomPrenom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(373, 26);
            this.txtNomPrenom.TabIndex = 8;
            // 
            // txtDateNaissance
            // 
            this.txtDateNaissance.Location = new System.Drawing.Point(244, 561);
            this.txtDateNaissance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDateNaissance.Name = "txtDateNaissance";
            this.txtDateNaissance.Size = new System.Drawing.Size(373, 26);
            this.txtDateNaissance.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(244, 535);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(244, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(244, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Telephone ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Prenom ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(238, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(419, 32);
            this.label8.TabIndex = 22;
            this.label8.Text = "AJOUTER UNE SECRETAIRE";
            // 
            // frmAdminAjouterSecretaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 905);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdminAjouterSecretaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterSecretaire";
            this.Load += new System.EventHandler(this.frmAdminAjouterSecretaire_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnValiderAjoutUtilisateur;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumeroTelephone;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.DateTimePicker txtDateNaissance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelephoneFixe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textMatricule;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}