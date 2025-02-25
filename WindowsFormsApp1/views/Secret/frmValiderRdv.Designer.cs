namespace WindowsFormsApp1.views.Secret
{
    partial class frmValiderRdv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValiderRdv));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnValider = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCout = new System.Windows.Forms.TextBox();
            this.cbbSoins = new System.Windows.Forms.ComboBox();
            this.Soins = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbMoyenPaiement = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCreneaux = new System.Windows.Forms.ComboBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 738);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.btnValider);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCout);
            this.panel2.Controls.Add(this.cbbSoins);
            this.panel2.Controls.Add(this.Soins);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbbMoyenPaiement);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbbCreneaux);
            this.panel2.Location = new System.Drawing.Point(181, 152);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 461);
            this.panel2.TabIndex = 1;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(144)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnValider.Location = new System.Drawing.Point(101, 345);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(197, 37);
            this.btnValider.TabIndex = 13;
            this.btnValider.Text = "Confirmer ";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Couts";
            // 
            // txtCout
            // 
            this.txtCout.Enabled = false;
            this.txtCout.Location = new System.Drawing.Point(34, 273);
            this.txtCout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCout.Name = "txtCout";
            this.txtCout.Size = new System.Drawing.Size(327, 22);
            this.txtCout.TabIndex = 11;
            // 
            // cbbSoins
            // 
            this.cbbSoins.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbSoins.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbSoins.FormattingEnabled = true;
            this.cbbSoins.Location = new System.Drawing.Point(34, 212);
            this.cbbSoins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbSoins.Name = "cbbSoins";
            this.cbbSoins.Size = new System.Drawing.Size(327, 24);
            this.cbbSoins.TabIndex = 10;
            this.cbbSoins.SelectedIndexChanged += new System.EventHandler(this.cbbSoins_SelectedIndexChanged);
            // 
            // Soins
            // 
            this.Soins.AutoSize = true;
            this.Soins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soins.ForeColor = System.Drawing.Color.White;
            this.Soins.Location = new System.Drawing.Point(31, 192);
            this.Soins.Name = "Soins";
            this.Soins.Size = new System.Drawing.Size(46, 18);
            this.Soins.TabIndex = 9;
            this.Soins.Text = "Soins";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 156);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Reference Paiement";
            // 
            // cbbMoyenPaiement
            // 
            this.cbbMoyenPaiement.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMoyenPaiement.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMoyenPaiement.FormattingEnabled = true;
            this.cbbMoyenPaiement.Location = new System.Drawing.Point(34, 99);
            this.cbbMoyenPaiement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMoyenPaiement.Name = "cbbMoyenPaiement";
            this.cbbMoyenPaiement.Size = new System.Drawing.Size(327, 24);
            this.cbbMoyenPaiement.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mode Paiement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(223, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "PRISE DE RENDEZ-VOUS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Creneaux";
            // 
            // cbbCreneaux
            // 
            this.cbbCreneaux.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbCreneaux.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCreneaux.FormattingEnabled = true;
            this.cbbCreneaux.Location = new System.Drawing.Point(34, 44);
            this.cbbCreneaux.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbCreneaux.Name = "cbbCreneaux";
            this.cbbCreneaux.Size = new System.Drawing.Size(327, 24);
            this.cbbCreneaux.TabIndex = 0;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pnlControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 32);
            this.panel3.TabIndex = 3;
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.pnlControl.Controls.Add(this.pictureBox2);
            this.pnlControl.Location = new System.Drawing.Point(664, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(96, 43);
            this.pnlControl.TabIndex = 1;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "RENDEZ-VOUS";
            // 
            // frmValiderRdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 784);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmValiderRdv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmValiderRdv";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCreneaux;
        private System.Windows.Forms.ComboBox cbbSoins;
        private System.Windows.Forms.Label Soins;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbMoyenPaiement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCout;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
    }
}