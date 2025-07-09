namespace WindowsFormsApp1.views.Secret
{
    partial class frmListerPatient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.btnRechercherPatient = new System.Windows.Forms.Button();
            this.dgPatients = new System.Windows.Forms.DataGridView();
            this.btnRetour = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTelephone);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(19, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Size = new System.Drawing.Size(900, 134);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Telephone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(24, 86);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(625, 22);
            this.txtEmail.TabIndex = 20;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(24, 43);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(625, 22);
            this.txtTelephone.TabIndex = 19;
            // 
            // btnRechercherPatient
            // 
            this.btnRechercherPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercherPatient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnRechercherPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRechercherPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercherPatient.ForeColor = System.Drawing.Color.White;
            this.btnRechercherPatient.Location = new System.Drawing.Point(933, 25);
            this.btnRechercherPatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRechercherPatient.Name = "btnRechercherPatient";
            this.btnRechercherPatient.Size = new System.Drawing.Size(196, 32);
            this.btnRechercherPatient.TabIndex = 17;
            this.btnRechercherPatient.Text = "&Rechercher un Patient";
            this.btnRechercherPatient.UseVisualStyleBackColor = true;
            this.btnRechercherPatient.Click += new System.EventHandler(this.btnRechercherPatient_Click);
            // 
            // dgPatients
            // 
            this.dgPatients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(234)))));
            this.dgPatients.CausesValidation = false;
            this.dgPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatients.Location = new System.Drawing.Point(102, 216);
            this.dgPatients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgPatients.Name = "dgPatients";
            this.dgPatients.RowHeadersWidth = 62;
            this.dgPatients.RowTemplate.Height = 28;
            this.dgPatients.Size = new System.Drawing.Size(1067, 500);
            this.dgPatients.TabIndex = 19;
            // 
            // btnRetour
            // 
            this.btnRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(933, 79);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(196, 32);
            this.btnRetour.TabIndex = 21;
            this.btnRetour.Text = "R&etour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.rdv;
            this.pictureBox2.Location = new System.Drawing.Point(-8, 150);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2143, 1037);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // frmListerPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1212, 827);
            this.ControlBox = false;
            this.Controls.Add(this.dgPatients);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnRechercherPatient);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmListerPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmListerPatient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Button btnRechercherPatient;
        private System.Windows.Forms.DataGridView dgPatients;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRetour;
    }
}