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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 684);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
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
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbbCreneaux);
            this.panel2.Location = new System.Drawing.Point(279, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 415);
            this.panel2.TabIndex = 1;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(144)))));
            this.btnValider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnValider.Location = new System.Drawing.Point(121, 370);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(99, 29);
            this.btnValider.TabIndex = 13;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Couts";
            // 
            // txtCout
            // 
            this.txtCout.Enabled = false;
            this.txtCout.Location = new System.Drawing.Point(17, 337);
            this.txtCout.Margin = new System.Windows.Forms.Padding(2);
            this.txtCout.Name = "txtCout";
            this.txtCout.Size = new System.Drawing.Size(87, 20);
            this.txtCout.TabIndex = 11;
            // 
            // cbbSoins
            // 
            this.cbbSoins.FormattingEnabled = true;
            this.cbbSoins.Location = new System.Drawing.Point(17, 285);
            this.cbbSoins.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSoins.Name = "cbbSoins";
            this.cbbSoins.Size = new System.Drawing.Size(171, 21);
            this.cbbSoins.TabIndex = 10;
            this.cbbSoins.SelectedIndexChanged += new System.EventHandler(this.cbbSoins_SelectedIndexChanged);
            // 
            // Soins
            // 
            this.Soins.AutoSize = true;
            this.Soins.Location = new System.Drawing.Point(20, 255);
            this.Soins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Soins.Name = "Soins";
            this.Soins.Size = new System.Drawing.Size(33, 13);
            this.Soins.TabIndex = 9;
            this.Soins.Text = "Soins";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 222);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Reference Paiement";
            // 
            // cbbMoyenPaiement
            // 
            this.cbbMoyenPaiement.FormattingEnabled = true;
            this.cbbMoyenPaiement.Location = new System.Drawing.Point(17, 150);
            this.cbbMoyenPaiement.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMoyenPaiement.Name = "cbbMoyenPaiement";
            this.cbbMoyenPaiement.Size = new System.Drawing.Size(82, 21);
            this.cbbMoyenPaiement.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mode Paiement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rendez-Vous";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Creneaux";
            // 
            // cbbCreneaux
            // 
            this.cbbCreneaux.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbCreneaux.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCreneaux.FormattingEnabled = true;
            this.cbbCreneaux.Location = new System.Drawing.Point(17, 84);
            this.cbbCreneaux.Margin = new System.Windows.Forms.Padding(2);
            this.cbbCreneaux.Name = "cbbCreneaux";
            this.cbbCreneaux.Size = new System.Drawing.Size(82, 21);
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
            // frmValiderRdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmValiderRdv";
            this.Text = "frmValiderRdv";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}