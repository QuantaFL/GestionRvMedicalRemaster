namespace WindowsFormsApp1.views
{
    partial class FrmAgenda
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
            this.dgAgenda = new System.Windows.Forms.DataGridView();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.txtCrenneau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHeureFin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHeureDebut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtDatePlanifier = new System.Windows.Forms.DateTimePicker();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblIdMedecin = new System.Windows.Forms.Label();
            this.btnRendezVous = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAgenda
            // 
            this.dgAgenda.AllowUserToAddRows = false;
            this.dgAgenda.AllowUserToDeleteRows = false;
            this.dgAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgenda.Location = new System.Drawing.Point(609, 120);
            this.dgAgenda.Name = "dgAgenda";
            this.dgAgenda.ReadOnly = true;
            this.dgAgenda.RowHeadersWidth = 51;
            this.dgAgenda.RowTemplate.Height = 24;
            this.dgAgenda.Size = new System.Drawing.Size(788, 442);
            this.dgAgenda.TabIndex = 49;
            // 
            // btnChoisir
            // 
            this.btnChoisir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoisir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChoisir.Location = new System.Drawing.Point(609, 28);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(129, 27);
            this.btnChoisir.TabIndex = 46;
            this.btnChoisir.Text = "&Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // txtCrenneau
            // 
            this.txtCrenneau.Location = new System.Drawing.Point(119, 390);
            this.txtCrenneau.Name = "txtCrenneau";
            this.txtCrenneau.Size = new System.Drawing.Size(298, 22);
            this.txtCrenneau.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Crenneau";
            // 
            // txtLieu
            // 
            this.txtLieu.Location = new System.Drawing.Point(116, 325);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(298, 22);
            this.txtLieu.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Lieu";
            // 
            // txtHeureFin
            // 
            this.txtHeureFin.Location = new System.Drawing.Point(116, 267);
            this.txtHeureFin.Name = "txtHeureFin";
            this.txtHeureFin.Size = new System.Drawing.Size(298, 22);
            this.txtHeureFin.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Heure Fin";
            // 
            // txtHeureDebut
            // 
            this.txtHeureDebut.Location = new System.Drawing.Point(116, 207);
            this.txtHeureDebut.Name = "txtHeureDebut";
            this.txtHeureDebut.Size = new System.Drawing.Size(298, 22);
            this.txtHeureDebut.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Heure Debut";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(116, 135);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(36, 16);
            this.lblAdresse.TabIndex = 36;
            this.lblAdresse.Text = "Date";
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(116, 100);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(298, 22);
            this.txtTitre.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Titre";
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedecin.Location = new System.Drawing.Point(787, 26);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(0, 25);
            this.lblMedecin.TabIndex = 50;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupprimer.Location = new System.Drawing.Point(412, 511);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(129, 27);
            this.btnSupprimer.TabIndex = 53;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifier.Location = new System.Drawing.Point(265, 511);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(129, 27);
            this.btnModifier.TabIndex = 52;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.Location = new System.Drawing.Point(119, 511);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(129, 27);
            this.btnAjouter.TabIndex = 51;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtDatePlanifier
            // 
            this.txtDatePlanifier.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDatePlanifier.Location = new System.Drawing.Point(119, 155);
            this.txtDatePlanifier.Name = "txtDatePlanifier";
            this.txtDatePlanifier.Size = new System.Drawing.Size(295, 22);
            this.txtDatePlanifier.TabIndex = 54;
            // 
            // btnFermer
            // 
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFermer.Location = new System.Drawing.Point(39, 24);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(129, 27);
            this.btnFermer.TabIndex = 55;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lblIdMedecin
            // 
            this.lblIdMedecin.AutoSize = true;
            this.lblIdMedecin.Location = new System.Drawing.Point(113, 445);
            this.lblIdMedecin.Name = "lblIdMedecin";
            this.lblIdMedecin.Size = new System.Drawing.Size(0, 16);
            this.lblIdMedecin.TabIndex = 56;
            // 
            // btnRendezVous
            // 
            this.btnRendezVous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRendezVous.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRendezVous.Location = new System.Drawing.Point(221, 26);
            this.btnRendezVous.Name = "btnRendezVous";
            this.btnRendezVous.Size = new System.Drawing.Size(129, 27);
            this.btnRendezVous.TabIndex = 57;
            this.btnRendezVous.Text = "&Rendez-vous";
            this.btnRendezVous.UseVisualStyleBackColor = true;
            this.btnRendezVous.Click += new System.EventHandler(this.btnRendezVous_Click_1);
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.btnRendezVous);
            this.Controls.Add(this.lblIdMedecin);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.txtDatePlanifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblMedecin);
            this.Controls.Add(this.dgAgenda);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.txtCrenneau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHeureFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHeureDebut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.FrmAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAgenda;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.TextBox txtCrenneau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHeureFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHeureDebut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DateTimePicker txtDatePlanifier;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblIdMedecin;
        private System.Windows.Forms.Button btnRendezVous;
    }
}