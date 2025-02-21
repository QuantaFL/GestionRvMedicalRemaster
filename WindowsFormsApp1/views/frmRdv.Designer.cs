namespace WindowsFormsApp1.views
{
    partial class frmRdv
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
            this.lblMedecinRdv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbSoins = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbPatient = new System.Windows.Forms.ComboBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.txtNombrePersonnes = new System.Windows.Forms.TextBox();
            this.lstCrenneau = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbModePaiement = new System.Windows.Forms.ComboBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lstCreneauPrise = new System.Windows.Forms.ListBox();
            this.lblCreneauPrise = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMedecinRdv
            // 
            this.lblMedecinRdv.AutoSize = true;
            this.lblMedecinRdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedecinRdv.Location = new System.Drawing.Point(497, 26);
            this.lblMedecinRdv.Name = "lblMedecinRdv";
            this.lblMedecinRdv.Size = new System.Drawing.Size(70, 25);
            this.lblMedecinRdv.TabIndex = 0;
            this.lblMedecinRdv.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soins";
            // 
            // cbbSoins
            // 
            this.cbbSoins.FormattingEnabled = true;
            this.cbbSoins.Location = new System.Drawing.Point(43, 135);
            this.cbbSoins.Name = "cbbSoins";
            this.cbbSoins.Size = new System.Drawing.Size(222, 24);
            this.cbbSoins.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de personnes";
            // 
            // cbbPatient
            // 
            this.cbbPatient.FormattingEnabled = true;
            this.cbbPatient.Location = new System.Drawing.Point(46, 286);
            this.cbbPatient.Name = "cbbPatient";
            this.cbbPatient.Size = new System.Drawing.Size(222, 24);
            this.cbbPatient.TabIndex = 4;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.Location = new System.Drawing.Point(46, 258);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(79, 25);
            this.lblPatient.TabIndex = 5;
            this.lblPatient.Text = "Patient";
            // 
            // txtNombrePersonnes
            // 
            this.txtNombrePersonnes.Enabled = false;
            this.txtNombrePersonnes.Location = new System.Drawing.Point(43, 213);
            this.txtNombrePersonnes.Name = "txtNombrePersonnes";
            this.txtNombrePersonnes.Size = new System.Drawing.Size(222, 22);
            this.txtNombrePersonnes.TabIndex = 6;
            // 
            // lstCrenneau
            // 
            this.lstCrenneau.FormattingEnabled = true;
            this.lstCrenneau.ItemHeight = 16;
            this.lstCrenneau.Location = new System.Drawing.Point(502, 73);
            this.lstCrenneau.Name = "lstCrenneau";
            this.lstCrenneau.Size = new System.Drawing.Size(238, 468);
            this.lstCrenneau.TabIndex = 7;
            this.lstCrenneau.SelectedIndexChanged += new System.EventHandler(this.lstCrenneau_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mode de paiement";
            // 
            // cbbModePaiement
            // 
            this.cbbModePaiement.FormattingEnabled = true;
            this.cbbModePaiement.Location = new System.Drawing.Point(45, 370);
            this.cbbModePaiement.Name = "cbbModePaiement";
            this.cbbModePaiement.Size = new System.Drawing.Size(222, 24);
            this.cbbModePaiement.TabIndex = 9;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(48, 30);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(121, 33);
            this.btnFermer.TabIndex = 10;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lstCreneauPrise
            // 
            this.lstCreneauPrise.FormattingEnabled = true;
            this.lstCreneauPrise.ItemHeight = 16;
            this.lstCreneauPrise.Location = new System.Drawing.Point(792, 73);
            this.lstCreneauPrise.Name = "lstCreneauPrise";
            this.lstCreneauPrise.Size = new System.Drawing.Size(238, 468);
            this.lstCreneauPrise.TabIndex = 11;
            this.lstCreneauPrise.SelectedIndexChanged += new System.EventHandler(this.lstCrenneauPrise_SelectedIndexChanged);
            // 
            // lblCreneauPrise
            // 
            this.lblCreneauPrise.AutoSize = true;
            this.lblCreneauPrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreneauPrise.Location = new System.Drawing.Point(787, 26);
            this.lblCreneauPrise.Name = "lblCreneauPrise";
            this.lblCreneauPrise.Size = new System.Drawing.Size(150, 25);
            this.lblCreneauPrise.TabIndex = 12;
            this.lblCreneauPrise.Text = "Creneau Prise";
            // 
            // frmRdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.lblCreneauPrise);
            this.Controls.Add(this.lstCreneauPrise);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.cbbModePaiement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCrenneau);
            this.Controls.Add(this.txtNombrePersonnes);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.cbbPatient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbSoins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMedecinRdv);
            this.Name = "frmRdv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rendez-Vous";
            this.Load += new System.EventHandler(this.frmRdv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedecinRdv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbSoins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbPatient;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.TextBox txtNombrePersonnes;
        private System.Windows.Forms.ListBox lstCrenneau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbModePaiement;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.ListBox lstCreneauPrise;
        private System.Windows.Forms.Label lblCreneauPrise;
    }
}