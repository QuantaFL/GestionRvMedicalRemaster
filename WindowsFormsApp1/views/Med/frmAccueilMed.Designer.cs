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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueilMed));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgAgendaMedecin = new System.Windows.Forms.DataGridView();
            this.txtDateChercher = new System.Windows.Forms.DateTimePicker();
            this.btnRechercherAgenda = new System.Windows.Forms.Button();
            this.btnModifierAgenda = new System.Windows.Forms.Button();
            this.btnVoirRdv = new System.Windows.Forms.Button();
            this.btnAjouterAgenda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgendaMedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.dgAgendaMedecin);
            this.panel1.Controls.Add(this.txtDateChercher);
            this.panel1.Controls.Add(this.btnRechercherAgenda);
            this.panel1.Controls.Add(this.btnModifierAgenda);
            this.panel1.Controls.Add(this.btnVoirRdv);
            this.panel1.Controls.Add(this.btnAjouterAgenda);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1281, 810);
            this.panel1.TabIndex = 0;
            // 
            // dgAgendaMedecin
            // 
            this.dgAgendaMedecin.BackgroundColor = System.Drawing.Color.Gray;
            this.dgAgendaMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgendaMedecin.Location = new System.Drawing.Point(14, 124);
            this.dgAgendaMedecin.Name = "dgAgendaMedecin";
            this.dgAgendaMedecin.RowHeadersWidth = 51;
            this.dgAgendaMedecin.RowTemplate.Height = 24;
            this.dgAgendaMedecin.Size = new System.Drawing.Size(1189, 552);
            this.dgAgendaMedecin.TabIndex = 11;
            // 
            // txtDateChercher
            // 
            this.txtDateChercher.Location = new System.Drawing.Point(658, 36);
            this.txtDateChercher.Name = "txtDateChercher";
            this.txtDateChercher.Size = new System.Drawing.Size(320, 22);
            this.txtDateChercher.TabIndex = 10;
            // 
            // btnRechercherAgenda
            // 
            this.btnRechercherAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercherAgenda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnRechercherAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRechercherAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercherAgenda.ForeColor = System.Drawing.Color.White;
            this.btnRechercherAgenda.Location = new System.Drawing.Point(1007, 32);
            this.btnRechercherAgenda.Name = "btnRechercherAgenda";
            this.btnRechercherAgenda.Size = new System.Drawing.Size(196, 32);
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
            this.btnModifierAgenda.Location = new System.Drawing.Point(14, 77);
            this.btnModifierAgenda.Name = "btnModifierAgenda";
            this.btnModifierAgenda.Size = new System.Drawing.Size(217, 31);
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
            this.btnVoirRdv.Location = new System.Drawing.Point(272, 26);
            this.btnVoirRdv.Name = "btnVoirRdv";
            this.btnVoirRdv.Size = new System.Drawing.Size(220, 31);
            this.btnVoirRdv.TabIndex = 7;
            this.btnVoirRdv.Text = "&Voir mes rendez-vous";
            this.btnVoirRdv.UseVisualStyleBackColor = true;
            // 
            // btnAjouterAgenda
            // 
            this.btnAjouterAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterAgenda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnAjouterAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouterAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterAgenda.ForeColor = System.Drawing.Color.White;
            this.btnAjouterAgenda.Location = new System.Drawing.Point(14, 26);
            this.btnAjouterAgenda.Name = "btnAjouterAgenda";
            this.btnAjouterAgenda.Size = new System.Drawing.Size(217, 31);
            this.btnAjouterAgenda.TabIndex = 6;
            this.btnAjouterAgenda.Text = "Ajouter un Ag&enda";
            this.btnAjouterAgenda.UseVisualStyleBackColor = true;
            this.btnAjouterAgenda.Click += new System.EventHandler(this.btnAjouterAgenda_Click);
            // 
            // frmAccueilMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 700);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccueilMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccueilMed";
            this.panel1.ResumeLayout(false);
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
    }
}