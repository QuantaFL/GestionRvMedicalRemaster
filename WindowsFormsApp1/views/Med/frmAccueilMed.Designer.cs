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
            this.btnVoirRdv = new System.Windows.Forms.Button();
            this.btnAjouterAgenda = new System.Windows.Forms.Button();
            this.btnModifierAgenda = new System.Windows.Forms.Button();
            this.btnRechercherAgenda = new System.Windows.Forms.Button();
            this.txtDateChercher = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.txtDateChercher);
            this.panel1.Controls.Add(this.btnRechercherAgenda);
            this.panel1.Controls.Add(this.btnModifierAgenda);
            this.panel1.Controls.Add(this.btnVoirRdv);
            this.panel1.Controls.Add(this.btnAjouterAgenda);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 676);
            this.panel1.TabIndex = 0;
            // 
            // btnVoirRdv
            // 
            this.btnVoirRdv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoirRdv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoirRdv.Location = new System.Drawing.Point(187, 26);
            this.btnVoirRdv.Name = "btnVoirRdv";
            this.btnVoirRdv.Size = new System.Drawing.Size(152, 31);
            this.btnVoirRdv.TabIndex = 7;
            this.btnVoirRdv.Text = "&Voir mes rendez-vous";
            this.btnVoirRdv.UseVisualStyleBackColor = true;
            // 
            // btnAjouterAgenda
            // 
            this.btnAjouterAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouterAgenda.Location = new System.Drawing.Point(14, 26);
            this.btnAjouterAgenda.Name = "btnAjouterAgenda";
            this.btnAjouterAgenda.Size = new System.Drawing.Size(152, 31);
            this.btnAjouterAgenda.TabIndex = 6;
            this.btnAjouterAgenda.Text = "Ajouter un Ag&enda";
            this.btnAjouterAgenda.UseVisualStyleBackColor = true;
            // 
            // btnModifierAgenda
            // 
            this.btnModifierAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifierAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifierAgenda.Location = new System.Drawing.Point(108, 78);
            this.btnModifierAgenda.Name = "btnModifierAgenda";
            this.btnModifierAgenda.Size = new System.Drawing.Size(152, 31);
            this.btnModifierAgenda.TabIndex = 8;
            this.btnModifierAgenda.Text = "&Modifier un Agenda";
            this.btnModifierAgenda.UseVisualStyleBackColor = true;
            // 
            // btnRechercherAgenda
            // 
            this.btnRechercherAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercherAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRechercherAgenda.Location = new System.Drawing.Point(1010, 26);
            this.btnRechercherAgenda.Name = "btnRechercherAgenda";
            this.btnRechercherAgenda.Size = new System.Drawing.Size(170, 32);
            this.btnRechercherAgenda.TabIndex = 9;
            this.btnRechercherAgenda.Text = "&Rechercher un agenda";
            this.btnRechercherAgenda.UseVisualStyleBackColor = true;
            // 
            // txtDateChercher
            // 
            this.txtDateChercher.Location = new System.Drawing.Point(778, 36);
            this.txtDateChercher.Name = "txtDateChercher";
            this.txtDateChercher.Size = new System.Drawing.Size(200, 22);
            this.txtDateChercher.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1166, 526);
            this.dataGridView1.TabIndex = 11;
            // 
            // frmAccueilMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 700);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "frmAccueilMed";
            this.Text = "AccueilMed";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoirRdv;
        private System.Windows.Forms.Button btnAjouterAgenda;
        private System.Windows.Forms.Button btnModifierAgenda;
        private System.Windows.Forms.Button btnRechercherAgenda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker txtDateChercher;
    }
}