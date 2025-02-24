namespace WindowsFormsApp1.views.Secret
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDateChercher = new System.Windows.Forms.DateTimePicker();
            this.cbbSpecialite = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRechercherAgenda = new System.Windows.Forms.Button();
            this.btnAjouterAgenda = new System.Windows.Forms.Button();
            this.dgAgendaMedecin = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgendaMedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 681);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(144)))));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnRechercherAgenda);
            this.panel2.Controls.Add(this.btnAjouterAgenda);
            this.panel2.Controls.Add(this.dgAgendaMedecin);
            this.panel2.Location = new System.Drawing.Point(-8, -20);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1298, 720);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDateChercher);
            this.groupBox1.Controls.Add(this.cbbSpecialite);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(83, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(620, 106);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher";
            // 
            // txtDateChercher
            // 
            this.txtDateChercher.Location = new System.Drawing.Point(18, 77);
            this.txtDateChercher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDateChercher.Name = "txtDateChercher";
            this.txtDateChercher.Size = new System.Drawing.Size(470, 20);
            this.txtDateChercher.TabIndex = 24;
            // 
            // cbbSpecialite
            // 
            this.cbbSpecialite.FormattingEnabled = true;
            this.cbbSpecialite.Location = new System.Drawing.Point(18, 35);
            this.cbbSpecialite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbSpecialite.Name = "cbbSpecialite";
            this.cbbSpecialite.Size = new System.Drawing.Size(470, 21);
            this.cbbSpecialite.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Specialite";
            // 
            // btnRechercherAgenda
            // 
            this.btnRechercherAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercherAgenda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnRechercherAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRechercherAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercherAgenda.ForeColor = System.Drawing.Color.White;
            this.btnRechercherAgenda.Location = new System.Drawing.Point(707, 46);
            this.btnRechercherAgenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRechercherAgenda.Name = "btnRechercherAgenda";
            this.btnRechercherAgenda.Size = new System.Drawing.Size(147, 26);
            this.btnRechercherAgenda.TabIndex = 14;
            this.btnRechercherAgenda.Text = "&Voir Disponibilites";
            this.btnRechercherAgenda.UseVisualStyleBackColor = true;
            // 
            // btnAjouterAgenda
            // 
            this.btnAjouterAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterAgenda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnAjouterAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouterAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterAgenda.ForeColor = System.Drawing.Color.White;
            this.btnAjouterAgenda.Location = new System.Drawing.Point(707, 94);
            this.btnAjouterAgenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouterAgenda.Name = "btnAjouterAgenda";
            this.btnAjouterAgenda.Size = new System.Drawing.Size(155, 25);
            this.btnAjouterAgenda.TabIndex = 11;
            this.btnAjouterAgenda.Text = "Prendre &Rendez-Vous";
            this.btnAjouterAgenda.UseVisualStyleBackColor = true;
            // 
            // dgAgendaMedecin
            // 
            this.dgAgendaMedecin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgAgendaMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgendaMedecin.Location = new System.Drawing.Point(12, 135);
            this.dgAgendaMedecin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgAgendaMedecin.Name = "dgAgendaMedecin";
            this.dgAgendaMedecin.RowHeadersWidth = 62;
            this.dgAgendaMedecin.RowTemplate.Height = 28;
            this.dgAgendaMedecin.Size = new System.Drawing.Size(1371, 629);
            this.dgAgendaMedecin.TabIndex = 0;
            // 
            // frmRdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRdv";
            this.Text = "Rendez vous";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgendaMedecin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRechercherAgenda;
        private System.Windows.Forms.Button btnAjouterAgenda;
        private System.Windows.Forms.DataGridView dgAgendaMedecin;
        private System.Windows.Forms.ComboBox cbbSpecialite;
        private System.Windows.Forms.DateTimePicker txtDateChercher;
    }
}