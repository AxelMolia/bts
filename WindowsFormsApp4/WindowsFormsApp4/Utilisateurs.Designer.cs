namespace WindowsFormsApp4
{
    partial class Utilisateurs
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
            this.buttonSeCo = new System.Windows.Forms.Button();
            this.labelIdU = new System.Windows.Forms.Label();
            this.labelMdpU = new System.Windows.Forms.Label();
            this.textBoxIdU = new System.Windows.Forms.TextBox();
            this.textBoxMdpU = new System.Windows.Forms.TextBox();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSeCo
            // 
            this.buttonSeCo.Location = new System.Drawing.Point(316, 304);
            this.buttonSeCo.Name = "buttonSeCo";
            this.buttonSeCo.Size = new System.Drawing.Size(98, 23);
            this.buttonSeCo.TabIndex = 1;
            this.buttonSeCo.Text = "Se Connecter";
            this.buttonSeCo.UseVisualStyleBackColor = true;
            this.buttonSeCo.Click += new System.EventHandler(this.buttonSeCo_Click);
            // 
            // labelIdU
            // 
            this.labelIdU.AutoSize = true;
            this.labelIdU.Location = new System.Drawing.Point(222, 155);
            this.labelIdU.Name = "labelIdU";
            this.labelIdU.Size = new System.Drawing.Size(59, 13);
            this.labelIdU.TabIndex = 2;
            this.labelIdU.Text = "Identifiant :";
            // 
            // labelMdpU
            // 
            this.labelMdpU.AutoSize = true;
            this.labelMdpU.Location = new System.Drawing.Point(222, 202);
            this.labelMdpU.Name = "labelMdpU";
            this.labelMdpU.Size = new System.Drawing.Size(78, 13);
            this.labelMdpU.TabIndex = 3;
            this.labelMdpU.Text = "Mot de Passe :";
            // 
            // textBoxIdU
            // 
            this.textBoxIdU.Location = new System.Drawing.Point(416, 152);
            this.textBoxIdU.Name = "textBoxIdU";
            this.textBoxIdU.Size = new System.Drawing.Size(121, 20);
            this.textBoxIdU.TabIndex = 4;
            // 
            // textBoxMdpU
            // 
            this.textBoxMdpU.Location = new System.Drawing.Point(416, 199);
            this.textBoxMdpU.Name = "textBoxMdpU";
            this.textBoxMdpU.Size = new System.Drawing.Size(121, 20);
            this.textBoxMdpU.TabIndex = 5;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(677, 390);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitter.TabIndex = 6;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(222, 247);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(37, 13);
            this.labelType.TabIndex = 9;
            this.labelType.Text = "Type :";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Responsable",
            "Salarie",
            "Technicien"});
            this.comboBoxType.Location = new System.Drawing.Point(416, 244);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 10;
            // 
            // Utilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.textBoxMdpU);
            this.Controls.Add(this.textBoxIdU);
            this.Controls.Add(this.labelMdpU);
            this.Controls.Add(this.labelIdU);
            this.Controls.Add(this.buttonSeCo);
            this.Name = "Utilisateurs";
            this.Text = "Utilisateurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSeCo;
        private System.Windows.Forms.Label labelIdU;
        private System.Windows.Forms.Label labelMdpU;
        private System.Windows.Forms.TextBox textBoxIdU;
        private System.Windows.Forms.TextBox textBoxMdpU;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
    }
}