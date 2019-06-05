namespace WindowsFormsApp4
{
    partial class Visiteur
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
            this.tabControlV = new System.Windows.Forms.TabControl();
            this.tabPageD = new System.Windows.Forms.TabPage();
            this.buttonAjt = new System.Windows.Forms.Button();
            this.textBoxIdD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMatConsern = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDemande = new System.Windows.Forms.DateTimePicker();
            this.buttonSuppr = new System.Windows.Forms.Button();
            this.textBoxNiv = new System.Windows.Forms.TextBox();
            this.textBoxObjet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPageC = new System.Windows.Forms.TabPage();
            this.buttonRefreshD = new System.Windows.Forms.Button();
            this.dataGridViewD = new System.Windows.Forms.DataGridView();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerD = new System.Windows.Forms.DateTimePicker();
            this.buttonSupprD = new System.Windows.Forms.Button();
            this.buttonAjD = new System.Windows.Forms.Button();
            this.textBoxNivUrg = new System.Windows.Forms.TextBox();
            this.textBoxObj = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControlV.SuspendLayout();
            this.tabPageD.SuspendLayout();
            this.tabPageC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlV
            // 
            this.tabControlV.Controls.Add(this.tabPageD);
            this.tabControlV.Controls.Add(this.tabPageC);
            this.tabControlV.Location = new System.Drawing.Point(31, 40);
            this.tabControlV.Name = "tabControlV";
            this.tabControlV.SelectedIndex = 0;
            this.tabControlV.Size = new System.Drawing.Size(768, 398);
            this.tabControlV.TabIndex = 0;
            // 
            // tabPageD
            // 
            this.tabPageD.BackColor = System.Drawing.Color.White;
            this.tabPageD.Controls.Add(this.buttonAjt);
            this.tabPageD.Controls.Add(this.textBoxIdD);
            this.tabPageD.Controls.Add(this.label1);
            this.tabPageD.Controls.Add(this.textBoxMatConsern);
            this.tabPageD.Controls.Add(this.label2);
            this.tabPageD.Controls.Add(this.dateTimePickerDemande);
            this.tabPageD.Controls.Add(this.buttonSuppr);
            this.tabPageD.Controls.Add(this.textBoxNiv);
            this.tabPageD.Controls.Add(this.textBoxObjet);
            this.tabPageD.Controls.Add(this.label3);
            this.tabPageD.Controls.Add(this.label4);
            this.tabPageD.Controls.Add(this.label9);
            this.tabPageD.Location = new System.Drawing.Point(4, 22);
            this.tabPageD.Name = "tabPageD";
            this.tabPageD.Size = new System.Drawing.Size(728, 337);
            this.tabPageD.TabIndex = 0;
            this.tabPageD.Text = "Déclaration";
            // 
            // buttonAjt
            // 
            this.buttonAjt.Location = new System.Drawing.Point(259, 230);
            this.buttonAjt.Name = "buttonAjt";
            this.buttonAjt.Size = new System.Drawing.Size(75, 23);
            this.buttonAjt.TabIndex = 37;
            this.buttonAjt.Text = "AJOUTER";
            this.buttonAjt.UseVisualStyleBackColor = true;
            this.buttonAjt.Click += new System.EventHandler(this.buttonAjt_Click);
            // 
            // textBoxIdD
            // 
            this.textBoxIdD.Location = new System.Drawing.Point(326, 94);
            this.textBoxIdD.Name = "textBoxIdD";
            this.textBoxIdD.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdD.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Id";
            // 
            // textBoxMatConsern
            // 
            this.textBoxMatConsern.Location = new System.Drawing.Point(326, 122);
            this.textBoxMatConsern.Name = "textBoxMatConsern";
            this.textBoxMatConsern.Size = new System.Drawing.Size(100, 20);
            this.textBoxMatConsern.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Materiel";
            // 
            // dateTimePickerDemande
            // 
            this.dateTimePickerDemande.Location = new System.Drawing.Point(271, 178);
            this.dateTimePickerDemande.Name = "dateTimePickerDemande";
            this.dateTimePickerDemande.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDemande.TabIndex = 32;
            // 
            // buttonSuppr
            // 
            this.buttonSuppr.Location = new System.Drawing.Point(377, 230);
            this.buttonSuppr.Name = "buttonSuppr";
            this.buttonSuppr.Size = new System.Drawing.Size(100, 23);
            this.buttonSuppr.TabIndex = 31;
            this.buttonSuppr.Text = "SUPPRIMER";
            this.buttonSuppr.UseVisualStyleBackColor = true;
            this.buttonSuppr.Click += new System.EventHandler(this.buttonSuppr_Click);
            // 
            // textBoxNiv
            // 
            this.textBoxNiv.Location = new System.Drawing.Point(326, 204);
            this.textBoxNiv.Name = "textBoxNiv";
            this.textBoxNiv.Size = new System.Drawing.Size(100, 20);
            this.textBoxNiv.TabIndex = 29;
            // 
            // textBoxObjet
            // 
            this.textBoxObjet.Location = new System.Drawing.Point(326, 152);
            this.textBoxObjet.Name = "textBoxObjet";
            this.textBoxObjet.Size = new System.Drawing.Size(100, 20);
            this.textBoxObjet.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Niveau Urgence";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Objet";
            // 
            // tabPageC
            // 
            this.tabPageC.Controls.Add(this.buttonRefreshD);
            this.tabPageC.Controls.Add(this.dataGridViewD);
            this.tabPageC.Location = new System.Drawing.Point(4, 22);
            this.tabPageC.Name = "tabPageC";
            this.tabPageC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageC.Size = new System.Drawing.Size(760, 372);
            this.tabPageC.TabIndex = 1;
            this.tabPageC.Text = "Consultation";
            this.tabPageC.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshD
            // 
            this.buttonRefreshD.Location = new System.Drawing.Point(324, 24);
            this.buttonRefreshD.Name = "buttonRefreshD";
            this.buttonRefreshD.Size = new System.Drawing.Size(82, 26);
            this.buttonRefreshD.TabIndex = 17;
            this.buttonRefreshD.Text = "REFRESH";
            this.buttonRefreshD.UseVisualStyleBackColor = true;
            this.buttonRefreshD.Click += new System.EventHandler(this.buttonRefreshD_Click);
            // 
            // dataGridViewD
            // 
            this.dataGridViewD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewD.Location = new System.Drawing.Point(6, 56);
            this.dataGridViewD.Name = "dataGridViewD";
            this.dataGridViewD.Size = new System.Drawing.Size(748, 258);
            this.dataGridViewD.TabIndex = 16;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(334, 89);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Id";
            // 
            // textBoxMat
            // 
            this.textBoxMat.Location = new System.Drawing.Point(334, 117);
            this.textBoxMat.Name = "textBoxMat";
            this.textBoxMat.Size = new System.Drawing.Size(100, 20);
            this.textBoxMat.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Materiel";
            // 
            // dateTimePickerD
            // 
            this.dateTimePickerD.Location = new System.Drawing.Point(279, 173);
            this.dateTimePickerD.Name = "dateTimePickerD";
            this.dateTimePickerD.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerD.TabIndex = 32;
            // 
            // buttonSupprD
            // 
            this.buttonSupprD.Location = new System.Drawing.Point(385, 225);
            this.buttonSupprD.Name = "buttonSupprD";
            this.buttonSupprD.Size = new System.Drawing.Size(100, 23);
            this.buttonSupprD.TabIndex = 31;
            this.buttonSupprD.Text = "SUPPRIMER";
            this.buttonSupprD.UseVisualStyleBackColor = true;
            // 
            // buttonAjD
            // 
            this.buttonAjD.Location = new System.Drawing.Point(279, 225);
            this.buttonAjD.Name = "buttonAjD";
            this.buttonAjD.Size = new System.Drawing.Size(100, 23);
            this.buttonAjD.TabIndex = 30;
            this.buttonAjD.Text = "AJOUTER";
            this.buttonAjD.UseVisualStyleBackColor = true;
            // 
            // textBoxNivUrg
            // 
            this.textBoxNivUrg.Location = new System.Drawing.Point(334, 199);
            this.textBoxNivUrg.Name = "textBoxNivUrg";
            this.textBoxNivUrg.Size = new System.Drawing.Size(100, 20);
            this.textBoxNivUrg.TabIndex = 29;
            // 
            // textBoxObj
            // 
            this.textBoxObj.Location = new System.Drawing.Point(334, 147);
            this.textBoxObj.Name = "textBoxObj";
            this.textBoxObj.Size = new System.Drawing.Size(100, 20);
            this.textBoxObj.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Niveau Urgence";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Objet";
            // 
            // Visiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 459);
            this.Controls.Add(this.tabControlV);
            this.Name = "Visiteur";
            this.Text = "Visiteur";
            this.Load += new System.EventHandler(this.Visiteur_Load_1);
            this.tabControlV.ResumeLayout(false);
            this.tabPageD.ResumeLayout(false);
            this.tabPageD.PerformLayout();
            this.tabPageC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlV;
        private System.Windows.Forms.TabPage tabPageD;
        private System.Windows.Forms.TabPage tabPageC;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxMat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerD;
        private System.Windows.Forms.Button buttonSupprD;
        private System.Windows.Forms.Button buttonAjD;
        private System.Windows.Forms.TextBox textBoxNivUrg;
        private System.Windows.Forms.TextBox textBoxObj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIdD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMatConsern;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDemande;
        private System.Windows.Forms.Button buttonSuppr;
        private System.Windows.Forms.TextBox textBoxNiv;
        private System.Windows.Forms.TextBox textBoxObjet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonRefreshD;
        private System.Windows.Forms.DataGridView dataGridViewD;
        private System.Windows.Forms.Button buttonAjt;
    }
}