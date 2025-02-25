namespace WindowsFormsApp1.views.Med
{
    partial class frmRdvMed
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgRdvMedecin = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRdvMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 92);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(233, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "MES RENDEZ VOUS DU JOUR";
            // 
            // dgRdvMedecin
            // 
            this.dgRdvMedecin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(234)))));
            this.dgRdvMedecin.CausesValidation = false;
            this.dgRdvMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRdvMedecin.Location = new System.Drawing.Point(1, 97);
            this.dgRdvMedecin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgRdvMedecin.Name = "dgRdvMedecin";
            this.dgRdvMedecin.RowHeadersWidth = 62;
            this.dgRdvMedecin.RowTemplate.Height = 28;
            this.dgRdvMedecin.Size = new System.Drawing.Size(459, 621);
            this.dgRdvMedecin.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.rdv;
            this.pictureBox2.Location = new System.Drawing.Point(457, 97);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(826, 611);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // frmRdvMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(214)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(913, 502);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgRdvMedecin);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRdvMed";
            this.Load += new System.EventHandler(this.frmRdvMed_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRdvMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgRdvMedecin;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}