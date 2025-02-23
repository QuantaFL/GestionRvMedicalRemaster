namespace WindowsFormsApp1.views.Med
{
    partial class frmMedAgenda
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDateAgenda = new System.Windows.Forms.DateTimePicker();
            this.txtTitreAgenda = new System.Windows.Forms.TextBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnValiderAjoutUtilisateur = new System.Windows.Forms.Button();
            this.txtCrenneau = new System.Windows.Forms.TextBox();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeureDebut = new System.Windows.Forms.MaskedTextBox();
            this.txtHeureFin = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 725);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(144)))));
            this.panel2.Controls.Add(this.txtHeureFin);
            this.panel2.Controls.Add(this.txtHeureDebut);
            this.panel2.Controls.Add(this.txtDateAgenda);
            this.panel2.Controls.Add(this.txtTitreAgenda);
            this.panel2.Controls.Add(this.btnFermer);
            this.panel2.Controls.Add(this.btnValiderAjoutUtilisateur);
            this.panel2.Controls.Add(this.txtCrenneau);
            this.panel2.Controls.Add(this.txtLieu);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(97, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 681);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtDateAgenda
            // 
            this.txtDateAgenda.Location = new System.Drawing.Point(114, 469);
            this.txtDateAgenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDateAgenda.Name = "txtDateAgenda";
            this.txtDateAgenda.Size = new System.Drawing.Size(373, 26);
            this.txtDateAgenda.TabIndex = 16;
            // 
            // txtTitreAgenda
            // 
            this.txtTitreAgenda.Location = new System.Drawing.Point(114, 94);
            this.txtTitreAgenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitreAgenda.Name = "txtTitreAgenda";
            this.txtTitreAgenda.Size = new System.Drawing.Size(373, 26);
            this.txtTitreAgenda.TabIndex = 14;
            // 
            // btnFermer
            // 
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermer.Location = new System.Drawing.Point(332, 569);
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
            this.btnValiderAjoutUtilisateur.Location = new System.Drawing.Point(114, 569);
            this.btnValiderAjoutUtilisateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnValiderAjoutUtilisateur.Name = "btnValiderAjoutUtilisateur";
            this.btnValiderAjoutUtilisateur.Size = new System.Drawing.Size(155, 54);
            this.btnValiderAjoutUtilisateur.TabIndex = 12;
            this.btnValiderAjoutUtilisateur.Text = "Valider l\'Ajout";
            this.btnValiderAjoutUtilisateur.UseVisualStyleBackColor = true;
            this.btnValiderAjoutUtilisateur.Click += new System.EventHandler(this.btnValiderAjoutUtilisateur_Click);
            // 
            // txtCrenneau
            // 
            this.txtCrenneau.Location = new System.Drawing.Point(114, 248);
            this.txtCrenneau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCrenneau.Name = "txtCrenneau";
            this.txtCrenneau.Size = new System.Drawing.Size(373, 26);
            this.txtCrenneau.TabIndex = 9;
            // 
            // txtLieu
            // 
            this.txtLieu.Location = new System.Drawing.Point(114, 174);
            this.txtLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(373, 26);
            this.txtLieu.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(110, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Titre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(110, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(110, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Heure Fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Creneau";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lieu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(110, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Heure Debut";
            // 
            // txtHeureDebut
            // 
            this.txtHeureDebut.Location = new System.Drawing.Point(114, 320);
            this.txtHeureDebut.Name = "txtHeureDebut";
            this.txtHeureDebut.Size = new System.Drawing.Size(373, 26);
            this.txtHeureDebut.TabIndex = 17;
            this.txtHeureDebut.TextChanged += new System.EventHandler(this.heureDebutChanged);
            // 
            // txtHeureFin
            // 
            this.txtHeureFin.Location = new System.Drawing.Point(114, 399);
            this.txtHeureFin.Name = "txtHeureFin";
            this.txtHeureFin.Size = new System.Drawing.Size(373, 26);
            this.txtHeureFin.TabIndex = 18;
            this.txtHeureFin.TextChanged += new System.EventHandler(this.heureFinChanged);
            // 
            // frmMedAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 755);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMedAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mes Agenda";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnValiderAjoutUtilisateur;
        private System.Windows.Forms.TextBox txtCrenneau;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitreAgenda;
        private System.Windows.Forms.DateTimePicker txtDateAgenda;
        private System.Windows.Forms.MaskedTextBox txtHeureFin;
        private System.Windows.Forms.MaskedTextBox txtHeureDebut;
        private System.Windows.Forms.Label label3;
    }
}