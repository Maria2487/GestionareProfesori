namespace GestionareProfesori
{
    partial class MeniuRepartizare
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
            this.lblMaterie = new System.Windows.Forms.Label();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.buttonSalvare = new System.Windows.Forms.Button();
            this.lblLiceu = new System.Windows.Forms.Label();
            this.lblOras = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.comboBoxLiceu = new System.Windows.Forms.ComboBox();
            this.txtMaterie = new System.Windows.Forms.TextBox();
            this.txtOras = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMaterie
            // 
            this.lblMaterie.AutoSize = true;
            this.lblMaterie.Location = new System.Drawing.Point(16, 235);
            this.lblMaterie.Name = "lblMaterie";
            this.lblMaterie.Size = new System.Drawing.Size(42, 13);
            this.lblMaterie.TabIndex = 31;
            this.lblMaterie.Text = "Materie";
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(669, 357);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(75, 23);
            this.buttonSterge.TabIndex = 30;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // buttonSalvare
            // 
            this.buttonSalvare.Location = new System.Drawing.Point(545, 357);
            this.buttonSalvare.Name = "buttonSalvare";
            this.buttonSalvare.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvare.TabIndex = 29;
            this.buttonSalvare.Text = "Salveaza";
            this.buttonSalvare.UseVisualStyleBackColor = true;
            // 
            // lblLiceu
            // 
            this.lblLiceu.AutoSize = true;
            this.lblLiceu.Location = new System.Drawing.Point(322, 46);
            this.lblLiceu.Name = "lblLiceu";
            this.lblLiceu.Size = new System.Drawing.Size(33, 13);
            this.lblLiceu.TabIndex = 28;
            this.lblLiceu.Text = "Liceu";
            // 
            // lblOras
            // 
            this.lblOras.AutoSize = true;
            this.lblOras.Location = new System.Drawing.Point(16, 43);
            this.lblOras.Name = "lblOras";
            this.lblOras.Size = new System.Drawing.Size(29, 13);
            this.lblOras.TabIndex = 27;
            this.lblOras.Text = "Oras";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(13, 163);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 26;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(16, 102);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 25;
            this.lblNume.Text = "Nume";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(95, 160);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.ReadOnly = true;
            this.txtPrenume.Size = new System.Drawing.Size(176, 20);
            this.txtPrenume.TabIndex = 23;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(98, 102);
            this.txtNume.Name = "txtNume";
            this.txtNume.ReadOnly = true;
            this.txtNume.Size = new System.Drawing.Size(176, 20);
            this.txtNume.TabIndex = 22;
            // 
            // comboBoxLiceu
            // 
            this.comboBoxLiceu.FormattingEnabled = true;
            this.comboBoxLiceu.Location = new System.Drawing.Point(361, 38);
            this.comboBoxLiceu.Name = "comboBoxLiceu";
            this.comboBoxLiceu.Size = new System.Drawing.Size(387, 21);
            this.comboBoxLiceu.TabIndex = 21;
            // 
            // txtMaterie
            // 
            this.txtMaterie.Location = new System.Drawing.Point(95, 232);
            this.txtMaterie.Name = "txtMaterie";
            this.txtMaterie.ReadOnly = true;
            this.txtMaterie.Size = new System.Drawing.Size(176, 20);
            this.txtMaterie.TabIndex = 32;
            // 
            // txtOras
            // 
            this.txtOras.Location = new System.Drawing.Point(98, 43);
            this.txtOras.Name = "txtOras";
            this.txtOras.ReadOnly = true;
            this.txtOras.Size = new System.Drawing.Size(176, 20);
            this.txtOras.TabIndex = 33;
            // 
            // MeniuRepartizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 392);
            this.Controls.Add(this.txtOras);
            this.Controls.Add(this.txtMaterie);
            this.Controls.Add(this.lblMaterie);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.buttonSalvare);
            this.Controls.Add(this.lblLiceu);
            this.Controls.Add(this.lblOras);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.comboBoxLiceu);
            this.Name = "MeniuRepartizare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuRepartizare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaterie;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.Button buttonSalvare;
        private System.Windows.Forms.Label lblLiceu;
        private System.Windows.Forms.Label lblOras;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.ComboBox comboBoxLiceu;
        private System.Windows.Forms.TextBox txtMaterie;
        private System.Windows.Forms.TextBox txtOras;
    }
}