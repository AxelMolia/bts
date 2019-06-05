namespace WindowsFormsApp4
{
    partial class Technicien
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
            this.tabControlTech = new System.Windows.Forms.TabControl();
            this.tabPageMat = new System.Windows.Forms.TabPage();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMemoire = new System.Windows.Forms.TextBox();
            this.buttonRefreshM = new System.Windows.Forms.Button();
            this.dataGridViewM = new System.Windows.Forms.DataGridView();
            this.buttonSpprM = new System.Windows.Forms.Button();
            this.textBoxGarantie = new System.Windows.Forms.TextBox();
            this.textBoxDisque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProcesseur = new System.Windows.Forms.TextBox();
            this.textBoxIdM = new System.Windows.Forms.TextBox();
            this.buttonAjtM = new System.Windows.Forms.Button();
            this.tabPageD = new System.Windows.Forms.TabPage();
            this.textBoxIdD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxTE = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonFinD = new System.Windows.Forms.Button();
            this.textBoxAffectTech = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAffectT = new System.Windows.Forms.Button();
            this.buttonRefreshT = new System.Windows.Forms.Button();
            this.dataGridViewT = new System.Windows.Forms.DataGridView();
            this.buttonRefreshD = new System.Windows.Forms.Button();
            this.dataGridViewD = new System.Windows.Forms.DataGridView();
            this.tabControlTech.SuspendLayout();
            this.tabPageMat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewM)).BeginInit();
            this.tabPageD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlTech
            // 
            this.tabControlTech.Controls.Add(this.tabPageMat);
            this.tabControlTech.Controls.Add(this.tabPageD);
            this.tabControlTech.Location = new System.Drawing.Point(24, 24);
            this.tabControlTech.Name = "tabControlTech";
            this.tabControlTech.SelectedIndex = 0;
            this.tabControlTech.Size = new System.Drawing.Size(760, 401);
            this.tabControlTech.TabIndex = 0;
            // 
            // tabPageMat
            // 
            this.tabPageMat.Controls.Add(this.dateTimePicker);
            this.tabPageMat.Controls.Add(this.label8);
            this.tabPageMat.Controls.Add(this.textBoxPrix);
            this.tabPageMat.Controls.Add(this.label5);
            this.tabPageMat.Controls.Add(this.label7);
            this.tabPageMat.Controls.Add(this.textBoxMemoire);
            this.tabPageMat.Controls.Add(this.buttonRefreshM);
            this.tabPageMat.Controls.Add(this.dataGridViewM);
            this.tabPageMat.Controls.Add(this.buttonSpprM);
            this.tabPageMat.Controls.Add(this.textBoxGarantie);
            this.tabPageMat.Controls.Add(this.textBoxDisque);
            this.tabPageMat.Controls.Add(this.label4);
            this.tabPageMat.Controls.Add(this.label3);
            this.tabPageMat.Controls.Add(this.label2);
            this.tabPageMat.Controls.Add(this.label1);
            this.tabPageMat.Controls.Add(this.textBoxProcesseur);
            this.tabPageMat.Controls.Add(this.textBoxIdM);
            this.tabPageMat.Controls.Add(this.buttonAjtM);
            this.tabPageMat.Location = new System.Drawing.Point(4, 22);
            this.tabPageMat.Name = "tabPageMat";
            this.tabPageMat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMat.Size = new System.Drawing.Size(752, 375);
            this.tabPageMat.TabIndex = 0;
            this.tabPageMat.Text = "MATERIEL";
            this.tabPageMat.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(91, 171);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Garantie";
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Location = new System.Drawing.Point(125, 223);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrix.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Prix";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Disque";
            // 
            // textBoxMemoire
            // 
            this.textBoxMemoire.Location = new System.Drawing.Point(125, 145);
            this.textBoxMemoire.Name = "textBoxMemoire";
            this.textBoxMemoire.Size = new System.Drawing.Size(100, 20);
            this.textBoxMemoire.TabIndex = 23;
            // 
            // buttonRefreshM
            // 
            this.buttonRefreshM.Location = new System.Drawing.Point(485, 33);
            this.buttonRefreshM.Name = "buttonRefreshM";
            this.buttonRefreshM.Size = new System.Drawing.Size(82, 28);
            this.buttonRefreshM.TabIndex = 22;
            this.buttonRefreshM.Text = "REFRESH";
            this.buttonRefreshM.UseVisualStyleBackColor = true;
            this.buttonRefreshM.Click += new System.EventHandler(this.buttonRefreshM_Click);
            // 
            // dataGridViewM
            // 
            this.dataGridViewM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewM.Location = new System.Drawing.Point(287, 67);
            this.dataGridViewM.Name = "dataGridViewM";
            this.dataGridViewM.Size = new System.Drawing.Size(443, 248);
            this.dataGridViewM.TabIndex = 21;
            // 
            // buttonSpprM
            // 
            this.buttonSpprM.Location = new System.Drawing.Point(125, 321);
            this.buttonSpprM.Name = "buttonSpprM";
            this.buttonSpprM.Size = new System.Drawing.Size(100, 23);
            this.buttonSpprM.TabIndex = 20;
            this.buttonSpprM.Text = "SUPPRIMER";
            this.buttonSpprM.UseVisualStyleBackColor = true;
            this.buttonSpprM.Click += new System.EventHandler(this.buttonSpprM_Click);
            // 
            // textBoxGarantie
            // 
            this.textBoxGarantie.Location = new System.Drawing.Point(125, 197);
            this.textBoxGarantie.Name = "textBoxGarantie";
            this.textBoxGarantie.Size = new System.Drawing.Size(100, 20);
            this.textBoxGarantie.TabIndex = 19;
            // 
            // textBoxDisque
            // 
            this.textBoxDisque.Location = new System.Drawing.Point(125, 119);
            this.textBoxDisque.Name = "textBoxDisque";
            this.textBoxDisque.Size = new System.Drawing.Size(100, 20);
            this.textBoxDisque.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date Achat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Memoire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Processeur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id";
            // 
            // textBoxProcesseur
            // 
            this.textBoxProcesseur.Location = new System.Drawing.Point(125, 93);
            this.textBoxProcesseur.Name = "textBoxProcesseur";
            this.textBoxProcesseur.Size = new System.Drawing.Size(100, 20);
            this.textBoxProcesseur.TabIndex = 13;
            // 
            // textBoxIdM
            // 
            this.textBoxIdM.Location = new System.Drawing.Point(125, 67);
            this.textBoxIdM.Name = "textBoxIdM";
            this.textBoxIdM.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdM.TabIndex = 12;
            // 
            // buttonAjtM
            // 
            this.buttonAjtM.Location = new System.Drawing.Point(125, 292);
            this.buttonAjtM.Name = "buttonAjtM";
            this.buttonAjtM.Size = new System.Drawing.Size(100, 23);
            this.buttonAjtM.TabIndex = 11;
            this.buttonAjtM.Text = "AJOUTER";
            this.buttonAjtM.UseVisualStyleBackColor = true;
            this.buttonAjtM.Click += new System.EventHandler(this.buttonAjtM_Click);
            // 
            // tabPageD
            // 
            this.tabPageD.Controls.Add(this.textBoxIdD);
            this.tabPageD.Controls.Add(this.label10);
            this.tabPageD.Controls.Add(this.textBoxTE);
            this.tabPageD.Controls.Add(this.label11);
            this.tabPageD.Controls.Add(this.buttonFinD);
            this.tabPageD.Controls.Add(this.textBoxAffectTech);
            this.tabPageD.Controls.Add(this.label9);
            this.tabPageD.Controls.Add(this.buttonAffectT);
            this.tabPageD.Controls.Add(this.buttonRefreshT);
            this.tabPageD.Controls.Add(this.dataGridViewT);
            this.tabPageD.Controls.Add(this.buttonRefreshD);
            this.tabPageD.Controls.Add(this.dataGridViewD);
            this.tabPageD.Location = new System.Drawing.Point(4, 22);
            this.tabPageD.Name = "tabPageD";
            this.tabPageD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageD.Size = new System.Drawing.Size(752, 375);
            this.tabPageD.TabIndex = 1;
            this.tabPageD.Text = "DEMANDE";
            this.tabPageD.UseVisualStyleBackColor = true;
            // 
            // textBoxIdD
            // 
            this.textBoxIdD.Location = new System.Drawing.Point(127, 50);
            this.textBoxIdD.Name = "textBoxIdD";
            this.textBoxIdD.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdD.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Id";
            // 
            // textBoxTE
            // 
            this.textBoxTE.Location = new System.Drawing.Point(109, 302);
            this.textBoxTE.Name = "textBoxTE";
            this.textBoxTE.Size = new System.Drawing.Size(100, 20);
            this.textBoxTE.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Travail effectuer";
            // 
            // buttonFinD
            // 
            this.buttonFinD.Location = new System.Drawing.Point(109, 328);
            this.buttonFinD.Name = "buttonFinD";
            this.buttonFinD.Size = new System.Drawing.Size(100, 23);
            this.buttonFinD.TabIndex = 38;
            this.buttonFinD.Text = "FIN Demande";
            this.buttonFinD.UseVisualStyleBackColor = true;
            this.buttonFinD.Click += new System.EventHandler(this.buttonFinD_Click);
            // 
            // textBoxAffectTech
            // 
            this.textBoxAffectTech.Location = new System.Drawing.Point(109, 214);
            this.textBoxAffectTech.Name = "textBoxAffectTech";
            this.textBoxAffectTech.Size = new System.Drawing.Size(100, 20);
            this.textBoxAffectTech.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Technicien:";
            // 
            // buttonAffectT
            // 
            this.buttonAffectT.Location = new System.Drawing.Point(109, 240);
            this.buttonAffectT.Name = "buttonAffectT";
            this.buttonAffectT.Size = new System.Drawing.Size(100, 23);
            this.buttonAffectT.TabIndex = 35;
            this.buttonAffectT.Text = "AFFECTER";
            this.buttonAffectT.UseVisualStyleBackColor = true;
            this.buttonAffectT.Click += new System.EventHandler(this.buttonAffectT_Click);
            // 
            // buttonRefreshT
            // 
            this.buttonRefreshT.Location = new System.Drawing.Point(464, 214);
            this.buttonRefreshT.Name = "buttonRefreshT";
            this.buttonRefreshT.Size = new System.Drawing.Size(82, 26);
            this.buttonRefreshT.TabIndex = 34;
            this.buttonRefreshT.Text = "REFRESH";
            this.buttonRefreshT.UseVisualStyleBackColor = true;
            this.buttonRefreshT.Click += new System.EventHandler(this.buttonRefreshT_Click);
            // 
            // dataGridViewT
            // 
            this.dataGridViewT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewT.Location = new System.Drawing.Point(275, 246);
            this.dataGridViewT.Name = "dataGridViewT";
            this.dataGridViewT.Size = new System.Drawing.Size(443, 123);
            this.dataGridViewT.TabIndex = 33;
            // 
            // buttonRefreshD
            // 
            this.buttonRefreshD.Location = new System.Drawing.Point(467, 8);
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
            this.dataGridViewD.Location = new System.Drawing.Point(275, 40);
            this.dataGridViewD.Name = "dataGridViewD";
            this.dataGridViewD.Size = new System.Drawing.Size(443, 131);
            this.dataGridViewD.TabIndex = 16;
            // 
            // Technicien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 477);
            this.Controls.Add(this.tabControlTech);
            this.Name = "Technicien";
            this.Text = "Technicien";
            this.Load += new System.EventHandler(this.Technicien_Load);
            this.tabControlTech.ResumeLayout(false);
            this.tabPageMat.ResumeLayout(false);
            this.tabPageMat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewM)).EndInit();
            this.tabPageD.ResumeLayout(false);
            this.tabPageD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTech;
        private System.Windows.Forms.TabPage tabPageMat;
        private System.Windows.Forms.TabPage tabPageD;
        private System.Windows.Forms.Button buttonRefreshD;
        private System.Windows.Forms.DataGridView dataGridViewD;
        private System.Windows.Forms.TextBox textBoxTE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonFinD;
        private System.Windows.Forms.TextBox textBoxAffectTech;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAffectT;
        private System.Windows.Forms.Button buttonRefreshT;
        private System.Windows.Forms.DataGridView dataGridViewT;
        private System.Windows.Forms.TextBox textBoxIdD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSpprM;
        private System.Windows.Forms.TextBox textBoxGarantie;
        private System.Windows.Forms.TextBox textBoxDisque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProcesseur;
        private System.Windows.Forms.TextBox textBoxIdM;
        private System.Windows.Forms.Button buttonAjtM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMemoire;
        private System.Windows.Forms.Button buttonRefreshM;
        private System.Windows.Forms.DataGridView dataGridViewM;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}