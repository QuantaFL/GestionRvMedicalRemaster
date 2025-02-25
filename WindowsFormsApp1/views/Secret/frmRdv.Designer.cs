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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRdv));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDateChercher = new System.Windows.Forms.DateTimePicker();
            this.cbbSpecialite = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRechercherDispo = new System.Windows.Forms.Button();
            this.btnAjouterAgenda = new System.Windows.Forms.Button();
            this.dgAgendaMedecin = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgendaMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 961);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnRechercherDispo);
            this.panel2.Controls.Add(this.btnAjouterAgenda);
            this.panel2.Controls.Add(this.dgAgendaMedecin);
            this.panel2.Location = new System.Drawing.Point(12, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1161, 933);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDateChercher);
            this.groupBox1.Controls.Add(this.cbbSpecialite);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(17, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(827, 130);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher";
            // 
            // txtDateChercher
            // 
            this.txtDateChercher.Location = new System.Drawing.Point(24, 95);
            this.txtDateChercher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDateChercher.Name = "txtDateChercher";
            this.txtDateChercher.Size = new System.Drawing.Size(625, 22);
            this.txtDateChercher.TabIndex = 24;
            // 
            // cbbSpecialite
            // 
            this.cbbSpecialite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbSpecialite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbSpecialite.FormattingEnabled = true;
            this.cbbSpecialite.Location = new System.Drawing.Point(24, 43);
            this.cbbSpecialite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbSpecialite.Name = "cbbSpecialite";
            this.cbbSpecialite.Size = new System.Drawing.Size(625, 24);
            this.cbbSpecialite.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Specialite";
            // 
            // btnRechercherDispo
            // 
            this.btnRechercherDispo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercherDispo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnRechercherDispo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRechercherDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercherDispo.ForeColor = System.Drawing.Color.White;
            this.btnRechercherDispo.Location = new System.Drawing.Point(889, 42);
            this.btnRechercherDispo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRechercherDispo.Name = "btnRechercherDispo";
            this.btnRechercherDispo.Size = new System.Drawing.Size(207, 32);
            this.btnRechercherDispo.TabIndex = 14;
            this.btnRechercherDispo.Text = "&Voir Disponibilites";
            this.btnRechercherDispo.UseVisualStyleBackColor = true;
            this.btnRechercherDispo.Click += new System.EventHandler(this.btnRechercherDispo_Click);
            // 
            // btnAjouterAgenda
            // 
            this.btnAjouterAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterAgenda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnAjouterAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouterAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterAgenda.ForeColor = System.Drawing.Color.White;
            this.btnAjouterAgenda.Location = new System.Drawing.Point(889, 116);
            this.btnAjouterAgenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouterAgenda.Name = "btnAjouterAgenda";
            this.btnAjouterAgenda.Size = new System.Drawing.Size(207, 31);
            this.btnAjouterAgenda.TabIndex = 11;
            this.btnAjouterAgenda.Text = "Prendre &Rendez-Vous";
            this.btnAjouterAgenda.UseVisualStyleBackColor = true;
            this.btnAjouterAgenda.Click += new System.EventHandler(this.btnAjouterRendezvous_Click);
            // 
            // dgAgendaMedecin
            // 
            this.dgAgendaMedecin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgAgendaMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgendaMedecin.Location = new System.Drawing.Point(17, 170);
            this.dgAgendaMedecin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgAgendaMedecin.Name = "dgAgendaMedecin";
            this.dgAgendaMedecin.RowHeadersWidth = 62;
            this.dgAgendaMedecin.RowTemplate.Height = 28;
            this.dgAgendaMedecin.Size = new System.Drawing.Size(1128, 640);
            this.dgAgendaMedecin.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1520, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 36);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pnlControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 39);
            this.panel3.TabIndex = 16;
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.pnlControl.Controls.Add(this.pictureBox2);
            this.pnlControl.Location = new System.Drawing.Point(1104, 3);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(84, 33);
            this.pnlControl.TabIndex = 0;
            this.pnlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlControl_Paint);
            this.pnlControl.MouseLeave += new System.EventHandler(this.pnlControl_MouseLeave);
            this.pnlControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlControl_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.fermer;
            this.pictureBox2.Location = new System.Drawing.Point(22, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Liste des agendas";
            // 
            // frmRdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1000);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRdv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rendez vous";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgendaMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRechercherDispo;
        private System.Windows.Forms.Button btnAjouterAgenda;
        private System.Windows.Forms.DataGridView dgAgendaMedecin;
        private System.Windows.Forms.ComboBox cbbSpecialite;
        private System.Windows.Forms.DateTimePicker txtDateChercher;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}