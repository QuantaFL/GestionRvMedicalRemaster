namespace WindowsFormsApp1.views.Med
{
    partial class frmAccueilMed
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgAgendaMedecin = new System.Windows.Forms.DataGridView();
            this.txtDateChercher = new System.Windows.Forms.DateTimePicker();
            this.btnRechercherAgenda = new System.Windows.Forms.Button();
            this.btnModifierAgenda = new System.Windows.Forms.Button();
            this.btnVoirRdv = new System.Windows.Forms.Button();
            this.btnAjouterAgenda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgendaMedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtDateChercher);
            this.panel1.Controls.Add(this.btnRechercherAgenda);
            this.panel1.Controls.Add(this.btnModifierAgenda);
            this.panel1.Controls.Add(this.btnVoirRdv);
            this.panel1.Controls.Add(this.btnAjouterAgenda);
            this.panel1.Controls.Add(this.dgAgendaMedecin);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1479, 895);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.rdv1;
            this.pictureBox1.Location = new System.Drawing.Point(607, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(879, 963);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // dgAgendaMedecin
            // 
            this.dgAgendaMedecin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(234)))));
            this.dgAgendaMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgendaMedecin.Location = new System.Drawing.Point(0, 93);
            this.dgAgendaMedecin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgAgendaMedecin.Name = "dgAgendaMedecin";
            this.dgAgendaMedecin.RowHeadersWidth = 51;
            this.dgAgendaMedecin.RowTemplate.Height = 24;
            this.dgAgendaMedecin.Size = new System.Drawing.Size(407, 626);
            this.dgAgendaMedecin.TabIndex = 11;
            this.dgAgendaMedecin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAgendaMedecin_CellContentClick);
            // 
            // txtDateChercher
            // 
            this.txtDateChercher.Location = new System.Drawing.Point(493, 29);
            this.txtDateChercher.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDateChercher.Name = "txtDateChercher";
            this.txtDateChercher.Size = new System.Drawing.Size(241, 20);
            this.txtDateChercher.TabIndex = 10;
            // 
            // btnRechercherAgenda
            // 
            this.btnRechercherAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercherAgenda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnRechercherAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRechercherAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercherAgenda.ForeColor = System.Drawing.Color.White;
            this.btnRechercherAgenda.Location = new System.Drawing.Point(755, 26);
            this.btnRechercherAgenda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRechercherAgenda.Name = "btnRechercherAgenda";
            this.btnRechercherAgenda.Size = new System.Drawing.Size(147, 26);
            this.btnRechercherAgenda.TabIndex = 9;
            this.btnRechercherAgenda.Text = "&Rechercher un agenda";
            this.btnRechercherAgenda.UseVisualStyleBackColor = true;
            // 
            // btnModifierAgenda
            // 
            this.btnModifierAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifierAgenda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnModifierAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifierAgenda.ForeColor = System.Drawing.Color.White;
            this.btnModifierAgenda.Location = new System.Drawing.Point(11, 62);
            this.btnModifierAgenda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnModifierAgenda.Name = "btnModifierAgenda";
            this.btnModifierAgenda.Size = new System.Drawing.Size(163, 25);
            this.btnModifierAgenda.TabIndex = 8;
            this.btnModifierAgenda.Text = "&Modifier un Agenda";
            this.btnModifierAgenda.UseVisualStyleBackColor = true;
            // 
            // btnVoirRdv
            // 
            this.btnVoirRdv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoirRdv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnVoirRdv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoirRdv.ForeColor = System.Drawing.Color.White;
            this.btnVoirRdv.Location = new System.Drawing.Point(204, 21);
            this.btnVoirRdv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoirRdv.Name = "btnVoirRdv";
            this.btnVoirRdv.Size = new System.Drawing.Size(165, 25);
            this.btnVoirRdv.TabIndex = 7;
            this.btnVoirRdv.Text = "&Voir mes rendez-vous";
            this.btnVoirRdv.UseVisualStyleBackColor = true;
            this.btnVoirRdv.Click += new System.EventHandler(this.btnVoirRdv_Click);
            // 
            // btnAjouterAgenda
            // 
            this.btnAjouterAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterAgenda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnAjouterAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouterAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterAgenda.ForeColor = System.Drawing.Color.White;
            this.btnAjouterAgenda.Location = new System.Drawing.Point(11, 21);
            this.btnAjouterAgenda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAjouterAgenda.Name = "btnAjouterAgenda";
            this.btnAjouterAgenda.Size = new System.Drawing.Size(163, 25);
            this.btnAjouterAgenda.TabIndex = 6;
            this.btnAjouterAgenda.Text = "Ajouter un Ag&enda";
            this.btnAjouterAgenda.UseVisualStyleBackColor = true;
            this.btnAjouterAgenda.Click += new System.EventHandler(this.btnAjouterAgenda_Click);
            // 
            // frmAccueilMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 512);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmAccueilMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "i";
            this.Load += new System.EventHandler(this.frmAccueilMed_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgendaMedecin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoirRdv;
        private System.Windows.Forms.Button btnAjouterAgenda;
        private System.Windows.Forms.Button btnModifierAgenda;
        private System.Windows.Forms.Button btnRechercherAgenda;
        private System.Windows.Forms.DataGridView dgAgendaMedecin;
        private System.Windows.Forms.DateTimePicker txtDateChercher;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}