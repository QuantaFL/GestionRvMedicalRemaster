namespace WindowsFormsApp1
{
    partial class FrmConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.btnConnexion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMotDePasse);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.txtIdentifiant);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(282, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 367);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.White;
            this.btnConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnexion.Location = new System.Drawing.Point(185, 266);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(103, 34);
            this.btnConnexion.TabIndex = 7;
            this.btnConnexion.Text = "&Se Connecter";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(76, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mot de Passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(76, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Identifiant";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(80, 228);
            this.txtMotDePasse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(282, 20);
            this.txtMotDePasse.TabIndex = 4;
            this.txtMotDePasse.UseSystemPasswordChar = true;
            this.txtMotDePasse.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources._lock;
            this.pictureBox4.Location = new System.Drawing.Point(347, 222);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(80, 144);
            this.txtIdentifiant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(282, 20);
            this.txtIdentifiant.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(347, 138);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.login__1_;
            this.pictureBox2.Location = new System.Drawing.Point(3, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(454, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.lgcr;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 367);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 365);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnexion;
    }
}

