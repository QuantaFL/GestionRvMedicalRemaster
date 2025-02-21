namespace WindowsFormsApp1.views
{
    partial class frmMedecin
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
            this.dgMedecin = new System.Windows.Forms.DataGridView();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtNumeroOrdreMedecin = new System.Windows.Forms.TextBox();
            this.lblPoids = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.cbbSpecialite = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMedecin
            // 
            this.dgMedecin.AllowUserToAddRows = false;
            this.dgMedecin.AllowUserToDeleteRows = false;
            this.dgMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedecin.Location = new System.Drawing.Point(623, 76);
            this.dgMedecin.Name = "dgMedecin";
            this.dgMedecin.ReadOnly = true;
            this.dgMedecin.RowHeadersWidth = 51;
            this.dgMedecin.RowTemplate.Height = 24;
            this.dgMedecin.Size = new System.Drawing.Size(1131, 594);
            this.dgMedecin.TabIndex = 32;
            // 
            // btnChoisir
            // 
            this.btnChoisir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoisir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChoisir.Location = new System.Drawing.Point(623, 23);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(129, 27);
            this.btnChoisir.TabIndex = 27;
            this.btnChoisir.Text = "&Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupprimer.Location = new System.Drawing.Point(451, 509);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(129, 27);
            this.btnSupprimer.TabIndex = 30;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifier.Location = new System.Drawing.Point(304, 509);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(129, 27);
            this.btnModifier.TabIndex = 29;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.Location = new System.Drawing.Point(158, 509);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(129, 27);
            this.btnAjouter.TabIndex = 26;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtNumeroOrdreMedecin
            // 
            this.txtNumeroOrdreMedecin.Location = new System.Drawing.Point(176, 441);
            this.txtNumeroOrdreMedecin.Name = "txtNumeroOrdreMedecin";
            this.txtNumeroOrdreMedecin.Size = new System.Drawing.Size(298, 22);
            this.txtNumeroOrdreMedecin.TabIndex = 24;
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.Location = new System.Drawing.Point(176, 422);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(147, 16);
            this.lblPoids.TabIndex = 31;
            this.lblPoids.Text = "Numero Ordre Medecin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Specialite";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(176, 320);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(298, 22);
            this.txtIdentifiant.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Identifiant";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(176, 262);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(298, 22);
            this.txtTelephone.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Telephone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(176, 202);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(298, 22);
            this.txtEmail.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(176, 149);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(298, 22);
            this.txtAdresse.TabIndex = 17;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(176, 130);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(58, 16);
            this.lblAdresse.TabIndex = 16;
            this.lblAdresse.Text = "Adresse";
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(176, 95);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(298, 22);
            this.txtNomPrenom.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "NomPrenom";
            // 
            // btnAgenda
            // 
            this.btnAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgenda.Location = new System.Drawing.Point(824, 23);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(129, 27);
            this.btnAgenda.TabIndex = 33;
            this.btnAgenda.Text = "Ag&enda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // cbbSpecialite
            // 
            this.cbbSpecialite.FormattingEnabled = true;
            this.cbbSpecialite.Location = new System.Drawing.Point(179, 386);
            this.cbbSpecialite.Name = "cbbSpecialite";
            this.cbbSpecialite.Size = new System.Drawing.Size(295, 24);
            this.cbbSpecialite.TabIndex = 35;
            // 
            // frmMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.cbbSpecialite);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.dgMedecin);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtNumeroOrdreMedecin);
            this.Controls.Add(this.lblPoids);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.label1);
            this.Name = "frmMedecin";
            this.Text = "Medecin";
            this.Load += new System.EventHandler(this.frmMedecin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMedecin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMedecin;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtNumeroOrdreMedecin;
        private System.Windows.Forms.Label lblPoids;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.ComboBox cbbSpecialite;
    }
}