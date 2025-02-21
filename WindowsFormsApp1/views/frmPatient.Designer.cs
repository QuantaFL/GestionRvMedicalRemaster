namespace WindowsFormsApp1.views
{
    partial class frmPatient
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGroupeSanguin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.lblPoids = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.dgPatient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NomPrenom";
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(311, 82);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(298, 22);
            this.txtNomPrenom.TabIndex = 1;
            this.txtNomPrenom.TextChanged += new System.EventHandler(this.txtNomPrenom_TextChanged);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(311, 136);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(298, 22);
            this.txtAdresse.TabIndex = 2;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(311, 117);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(58, 16);
            this.lblAdresse.TabIndex = 2;
            this.lblAdresse.Text = "Adresse";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(311, 189);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(298, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(311, 249);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(298, 22);
            this.txtTelephone.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telephone";
            // 
            // txtGroupeSanguin
            // 
            this.txtGroupeSanguin.Location = new System.Drawing.Point(311, 307);
            this.txtGroupeSanguin.Name = "txtGroupeSanguin";
            this.txtGroupeSanguin.Size = new System.Drawing.Size(298, 22);
            this.txtGroupeSanguin.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Groupe Sanguin";
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(311, 372);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(298, 22);
            this.txtTaille.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Taille";
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(311, 428);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(298, 22);
            this.txtPoids.TabIndex = 7;
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.Location = new System.Drawing.Point(311, 409);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(42, 16);
            this.lblPoids.TabIndex = 12;
            this.lblPoids.Text = "Poids";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.Location = new System.Drawing.Point(293, 496);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(129, 27);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifier.Location = new System.Drawing.Point(439, 496);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(129, 27);
            this.btnModifier.TabIndex = 10;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupprimer.Location = new System.Drawing.Point(586, 496);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(129, 27);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnChoisir
            // 
            this.btnChoisir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoisir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChoisir.Location = new System.Drawing.Point(950, 9);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(129, 27);
            this.btnChoisir.TabIndex = 9;
            this.btnChoisir.Text = "&Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // dgPatient
            // 
            this.dgPatient.AllowUserToAddRows = false;
            this.dgPatient.AllowUserToDeleteRows = false;
            this.dgPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatient.Location = new System.Drawing.Point(758, 63);
            this.dgPatient.Name = "dgPatient";
            this.dgPatient.ReadOnly = true;
            this.dgPatient.RowHeadersWidth = 51;
            this.dgPatient.RowTemplate.Height = 24;
            this.dgPatient.Size = new System.Drawing.Size(1131, 594);
            this.dgPatient.TabIndex = 13;
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.dgPatient);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtPoids);
            this.Controls.Add(this.lblPoids);
            this.Controls.Add(this.txtTaille);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGroupeSanguin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.label1);
            this.Name = "frmPatient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.frmPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGroupeSanguin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.Label lblPoids;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.DataGridView dgPatient;
    }
}