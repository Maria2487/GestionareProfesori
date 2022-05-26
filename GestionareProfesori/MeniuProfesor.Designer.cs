namespace GestionareProfesori
{
    partial class MeniuProfesor
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
            this.comboBoxOras = new System.Windows.Forms.ComboBox();
            this.comboBoxLiceu = new System.Windows.Forms.ComboBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.comboBoxMaterie = new System.Windows.Forms.ComboBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblOras = new System.Windows.Forms.Label();
            this.lblLiceu = new System.Windows.Forms.Label();
            this.buttonSalvare = new System.Windows.Forms.Button();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxOras
            // 
            this.comboBoxOras.FormattingEnabled = true;
            this.comboBoxOras.Location = new System.Drawing.Point(91, 41);
            this.comboBoxOras.Name = "comboBoxOras";
            this.comboBoxOras.Size = new System.Drawing.Size(154, 21);
            this.comboBoxOras.TabIndex = 0;
            // 
            // comboBoxLiceu
            // 
            this.comboBoxLiceu.FormattingEnabled = true;
            this.comboBoxLiceu.Location = new System.Drawing.Point(335, 41);
            this.comboBoxLiceu.Name = "comboBoxLiceu";
            this.comboBoxLiceu.Size = new System.Drawing.Size(387, 21);
            this.comboBoxLiceu.TabIndex = 1;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(263, 135);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(176, 20);
            this.txtNume.TabIndex = 2;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(260, 193);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(176, 20);
            this.txtPrenume.TabIndex = 3;
            // 
            // comboBoxMaterie
            // 
            this.comboBoxMaterie.FormattingEnabled = true;
            this.comboBoxMaterie.Location = new System.Drawing.Point(263, 261);
            this.comboBoxMaterie.Name = "comboBoxMaterie";
            this.comboBoxMaterie.Size = new System.Drawing.Size(176, 21);
            this.comboBoxMaterie.TabIndex = 4;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(178, 135);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 5;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(178, 196);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 6;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblOras
            // 
            this.lblOras.AutoSize = true;
            this.lblOras.Location = new System.Drawing.Point(27, 49);
            this.lblOras.Name = "lblOras";
            this.lblOras.Size = new System.Drawing.Size(29, 13);
            this.lblOras.TabIndex = 8;
            this.lblOras.Text = "Oras";
            // 
            // lblLiceu
            // 
            this.lblLiceu.AutoSize = true;
            this.lblLiceu.Location = new System.Drawing.Point(296, 49);
            this.lblLiceu.Name = "lblLiceu";
            this.lblLiceu.Size = new System.Drawing.Size(33, 13);
            this.lblLiceu.TabIndex = 16;
            this.lblLiceu.Text = "Liceu";
            // 
            // buttonSalvare
            // 
            this.buttonSalvare.Location = new System.Drawing.Point(496, 393);
            this.buttonSalvare.Name = "buttonSalvare";
            this.buttonSalvare.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvare.TabIndex = 17;
            this.buttonSalvare.Text = "Salveaza";
            this.buttonSalvare.UseVisualStyleBackColor = true;
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(595, 393);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(75, 23);
            this.buttonSterge.TabIndex = 18;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.UseVisualStyleBackColor = true;
            // 
            // MeniuProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.buttonSalvare);
            this.Controls.Add(this.lblLiceu);
            this.Controls.Add(this.lblOras);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.comboBoxMaterie);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.comboBoxLiceu);
            this.Controls.Add(this.comboBoxOras);
            this.Name = "MeniuProfesor";
            this.Text = "MeniuPersoana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOras;
        private System.Windows.Forms.ComboBox comboBoxLiceu;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.ComboBox comboBoxMaterie;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblOras;
        private System.Windows.Forms.Label lblLiceu;
        private System.Windows.Forms.Button buttonSalvare;
        private System.Windows.Forms.Button buttonSterge;
    }
}